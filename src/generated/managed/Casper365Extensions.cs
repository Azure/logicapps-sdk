//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Casper365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Casper365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<Course[]> CourseGet(Expression<Func<string>> course = null)
        {
            var __workflow_course = WorkflowExpression.Compile(course, nameof(course), required: false);
            return new DeferredBodyAction<Course[]>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_course != null)
                    callPayload.Queries["course"] = ExpressionConverter.Convert(__workflow_course);
                return new ApiConnectionAction<Course[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<bool> Course(Expression<Func<string>> courseaudience = null, Expression<Func<string>> coursecourseName = null, Expression<Func<string>> coursedos = null, Expression<Func<string>> courseemail = null)
        {
            var __workflow_courseaudience = WorkflowExpression.Compile(courseaudience, nameof(courseaudience), required: false);
            var __workflow_coursecourseName = WorkflowExpression.Compile(coursecourseName, nameof(coursecourseName), required: false);
            var __workflow_coursedos = WorkflowExpression.Compile(coursedos, nameof(coursedos), required: false);
            var __workflow_courseemail = WorkflowExpression.Compile(courseemail, nameof(courseemail), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var course = new JObject();
                var coursepropCount = 0;
                if (__workflow_courseaudience != null)
                {
                    course["audience"] = ExpressionConverter.ConvertO(__workflow_courseaudience);
                    coursepropCount++;
                }

                if (__workflow_coursecourseName != null)
                {
                    course["courseName"] = ExpressionConverter.ConvertO(__workflow_coursecourseName);
                    coursepropCount++;
                }

                if (__workflow_coursedos != null)
                {
                    course["dos"] = ExpressionConverter.ConvertO(__workflow_coursedos);
                    coursepropCount++;
                }

                if (__workflow_courseemail != null)
                {
                    course["email"] = ExpressionConverter.ConvertO(__workflow_courseemail);
                    coursepropCount++;
                }

                if (coursepropCount > 0)
                {
                    callPayload.Body = course;
                }

                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction LogEnd(Expression<Func<string>> identifier = null)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Log/End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(__workflow_identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction LogStart(Expression<Func<string>> identifier = null)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Log/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(__workflow_identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<Student> StudentGet(Expression<Func<string>> studentId = null)
        {
            var __workflow_studentId = WorkflowExpression.Compile(studentId, nameof(studentId), required: false);
            return new DeferredBodyAction<Student>(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_studentId != null)
                    callPayload.Queries["studentId"] = ExpressionConverter.Convert(__workflow_studentId);
                return new ApiConnectionAction<Student>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction Student(Expression<Func<string>> studentacadCareer = null, Expression<Func<string>> studentacadOrgDescr = null, Expression<Func<string>> studentacadProgram = null, Expression<Func<string>> studentaddress1 = null, Expression<Func<string>> studentaddress2 = null, Expression<Func<string>> studentaddress3 = null, Expression<Func<string>> studentaddress4 = null, Expression<Func<string>> studentbarcode = null, Expression<Func<string>> studentbirthCountryCode = null, Expression<Func<string>> studentcellTel = null, Expression<Func<string>> studentcity = null, Expression<Func<double>> studentcollegeAccountNo = null, Expression<Func<string>> studentcountry = null, Expression<Func<string>> studentcountryCitizen = null, Expression<Func<string>> studentcountryCitizen2 = null, Expression<Func<string>> studentcrsid = null, Expression<Func<string>> studentdegree = null, Expression<Func<string>> studentdob = null, Expression<Func<string>> studentdos = null, Expression<Func<string>> studentdosEmail = null, Expression<Func<string>> studentdosEmployeeId = null, Expression<Func<string>> studentemail = null, Expression<Func<string>> studentemailAddr = null, Expression<Func<string>> studentemailPersonal = null, Expression<Func<string>> studentendDate = null, Expression<Func<string>> studentenqGrp = null, Expression<Func<string>> studentfirstNames = null, Expression<Func<string>> studentgradTutor = null, Expression<Func<string>> studentgradTutorEmail = null, Expression<Func<string>> studentgradTutorEmployeeId = null, Expression<Func<string>> studentgrp = null, Expression<Func<string>> studentgrpId = null, Expression<Func<string>> studenthomeAddress1 = null, Expression<Func<string>> studenthomeAddress2 = null, Expression<Func<string>> studenthomeAddress3 = null, Expression<Func<string>> studenthomeAddress4 = null, Expression<Func<string>> studenthomeAddress5 = null, Expression<Func<string>> studenthomeCountry = null, Expression<Func<string>> studenthomePostal = null, Expression<Func<string>> studenthomeState = null, Expression<Func<string>> studenthomeTel = null, Expression<Func<string>> studentmatriculation = null, Expression<Func<string>> studentmobileTel = null, Expression<Func<string>> studentnationality = null, Expression<Func<string>> studentpostal = null, Expression<Func<string>> studentprinSuper = null, Expression<Func<string>> studentprinSuperEmail = null, Expression<Func<string>> studentprinSuperEmployeeId = null, Expression<Func<string>> studentsex = null, Expression<Func<string>> studentstartDate = null, Expression<Func<string>> studentstudentFeesClass = null, Expression<Func<string>> studentstudyYear = null, Expression<Func<string>> studentsubject = null, Expression<Func<string>> studentsubjectDescr = null, Expression<Func<string>> studentsuperEmail = null, Expression<Func<string>> studentsurname = null, Expression<Func<string>> studenttitle = null, Expression<Func<string>> studenttutor = null, Expression<Func<string>> studenttutorEmail = null, Expression<Func<string>> studenttutorEmployeeId = null)
        {
            var __workflow_studentacadCareer = WorkflowExpression.Compile(studentacadCareer, nameof(studentacadCareer), required: false);
            var __workflow_studentacadOrgDescr = WorkflowExpression.Compile(studentacadOrgDescr, nameof(studentacadOrgDescr), required: false);
            var __workflow_studentacadProgram = WorkflowExpression.Compile(studentacadProgram, nameof(studentacadProgram), required: false);
            var __workflow_studentaddress1 = WorkflowExpression.Compile(studentaddress1, nameof(studentaddress1), required: false);
            var __workflow_studentaddress2 = WorkflowExpression.Compile(studentaddress2, nameof(studentaddress2), required: false);
            var __workflow_studentaddress3 = WorkflowExpression.Compile(studentaddress3, nameof(studentaddress3), required: false);
            var __workflow_studentaddress4 = WorkflowExpression.Compile(studentaddress4, nameof(studentaddress4), required: false);
            var __workflow_studentbarcode = WorkflowExpression.Compile(studentbarcode, nameof(studentbarcode), required: false);
            var __workflow_studentbirthCountryCode = WorkflowExpression.Compile(studentbirthCountryCode, nameof(studentbirthCountryCode), required: false);
            var __workflow_studentcellTel = WorkflowExpression.Compile(studentcellTel, nameof(studentcellTel), required: false);
            var __workflow_studentcity = WorkflowExpression.Compile(studentcity, nameof(studentcity), required: false);
            var __workflow_studentcollegeAccountNo = WorkflowExpression.Compile(studentcollegeAccountNo, nameof(studentcollegeAccountNo), required: false);
            var __workflow_studentcountry = WorkflowExpression.Compile(studentcountry, nameof(studentcountry), required: false);
            var __workflow_studentcountryCitizen = WorkflowExpression.Compile(studentcountryCitizen, nameof(studentcountryCitizen), required: false);
            var __workflow_studentcountryCitizen2 = WorkflowExpression.Compile(studentcountryCitizen2, nameof(studentcountryCitizen2), required: false);
            var __workflow_studentcrsid = WorkflowExpression.Compile(studentcrsid, nameof(studentcrsid), required: false);
            var __workflow_studentdegree = WorkflowExpression.Compile(studentdegree, nameof(studentdegree), required: false);
            var __workflow_studentdob = WorkflowExpression.Compile(studentdob, nameof(studentdob), required: false);
            var __workflow_studentdos = WorkflowExpression.Compile(studentdos, nameof(studentdos), required: false);
            var __workflow_studentdosEmail = WorkflowExpression.Compile(studentdosEmail, nameof(studentdosEmail), required: false);
            var __workflow_studentdosEmployeeId = WorkflowExpression.Compile(studentdosEmployeeId, nameof(studentdosEmployeeId), required: false);
            var __workflow_studentemail = WorkflowExpression.Compile(studentemail, nameof(studentemail), required: false);
            var __workflow_studentemailAddr = WorkflowExpression.Compile(studentemailAddr, nameof(studentemailAddr), required: false);
            var __workflow_studentemailPersonal = WorkflowExpression.Compile(studentemailPersonal, nameof(studentemailPersonal), required: false);
            var __workflow_studentendDate = WorkflowExpression.Compile(studentendDate, nameof(studentendDate), required: false);
            var __workflow_studentenqGrp = WorkflowExpression.Compile(studentenqGrp, nameof(studentenqGrp), required: false);
            var __workflow_studentfirstNames = WorkflowExpression.Compile(studentfirstNames, nameof(studentfirstNames), required: false);
            var __workflow_studentgradTutor = WorkflowExpression.Compile(studentgradTutor, nameof(studentgradTutor), required: false);
            var __workflow_studentgradTutorEmail = WorkflowExpression.Compile(studentgradTutorEmail, nameof(studentgradTutorEmail), required: false);
            var __workflow_studentgradTutorEmployeeId = WorkflowExpression.Compile(studentgradTutorEmployeeId, nameof(studentgradTutorEmployeeId), required: false);
            var __workflow_studentgrp = WorkflowExpression.Compile(studentgrp, nameof(studentgrp), required: false);
            var __workflow_studentgrpId = WorkflowExpression.Compile(studentgrpId, nameof(studentgrpId), required: false);
            var __workflow_studenthomeAddress1 = WorkflowExpression.Compile(studenthomeAddress1, nameof(studenthomeAddress1), required: false);
            var __workflow_studenthomeAddress2 = WorkflowExpression.Compile(studenthomeAddress2, nameof(studenthomeAddress2), required: false);
            var __workflow_studenthomeAddress3 = WorkflowExpression.Compile(studenthomeAddress3, nameof(studenthomeAddress3), required: false);
            var __workflow_studenthomeAddress4 = WorkflowExpression.Compile(studenthomeAddress4, nameof(studenthomeAddress4), required: false);
            var __workflow_studenthomeAddress5 = WorkflowExpression.Compile(studenthomeAddress5, nameof(studenthomeAddress5), required: false);
            var __workflow_studenthomeCountry = WorkflowExpression.Compile(studenthomeCountry, nameof(studenthomeCountry), required: false);
            var __workflow_studenthomePostal = WorkflowExpression.Compile(studenthomePostal, nameof(studenthomePostal), required: false);
            var __workflow_studenthomeState = WorkflowExpression.Compile(studenthomeState, nameof(studenthomeState), required: false);
            var __workflow_studenthomeTel = WorkflowExpression.Compile(studenthomeTel, nameof(studenthomeTel), required: false);
            var __workflow_studentmatriculation = WorkflowExpression.Compile(studentmatriculation, nameof(studentmatriculation), required: false);
            var __workflow_studentmobileTel = WorkflowExpression.Compile(studentmobileTel, nameof(studentmobileTel), required: false);
            var __workflow_studentnationality = WorkflowExpression.Compile(studentnationality, nameof(studentnationality), required: false);
            var __workflow_studentpostal = WorkflowExpression.Compile(studentpostal, nameof(studentpostal), required: false);
            var __workflow_studentprinSuper = WorkflowExpression.Compile(studentprinSuper, nameof(studentprinSuper), required: false);
            var __workflow_studentprinSuperEmail = WorkflowExpression.Compile(studentprinSuperEmail, nameof(studentprinSuperEmail), required: false);
            var __workflow_studentprinSuperEmployeeId = WorkflowExpression.Compile(studentprinSuperEmployeeId, nameof(studentprinSuperEmployeeId), required: false);
            var __workflow_studentsex = WorkflowExpression.Compile(studentsex, nameof(studentsex), required: false);
            var __workflow_studentstartDate = WorkflowExpression.Compile(studentstartDate, nameof(studentstartDate), required: false);
            var __workflow_studentstudentFeesClass = WorkflowExpression.Compile(studentstudentFeesClass, nameof(studentstudentFeesClass), required: false);
            var __workflow_studentstudyYear = WorkflowExpression.Compile(studentstudyYear, nameof(studentstudyYear), required: false);
            var __workflow_studentsubject = WorkflowExpression.Compile(studentsubject, nameof(studentsubject), required: false);
            var __workflow_studentsubjectDescr = WorkflowExpression.Compile(studentsubjectDescr, nameof(studentsubjectDescr), required: false);
            var __workflow_studentsuperEmail = WorkflowExpression.Compile(studentsuperEmail, nameof(studentsuperEmail), required: false);
            var __workflow_studentsurname = WorkflowExpression.Compile(studentsurname, nameof(studentsurname), required: false);
            var __workflow_studenttitle = WorkflowExpression.Compile(studenttitle, nameof(studenttitle), required: false);
            var __workflow_studenttutor = WorkflowExpression.Compile(studenttutor, nameof(studenttutor), required: false);
            var __workflow_studenttutorEmail = WorkflowExpression.Compile(studenttutorEmail, nameof(studenttutorEmail), required: false);
            var __workflow_studenttutorEmployeeId = WorkflowExpression.Compile(studenttutorEmployeeId, nameof(studenttutorEmployeeId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var student = new JObject();
                var studentpropCount = 0;
                if (__workflow_studentacadCareer != null)
                {
                    student["acadCareer"] = ExpressionConverter.ConvertO(__workflow_studentacadCareer);
                    studentpropCount++;
                }

                if (__workflow_studentacadOrgDescr != null)
                {
                    student["acadOrgDescr"] = ExpressionConverter.ConvertO(__workflow_studentacadOrgDescr);
                    studentpropCount++;
                }

                if (__workflow_studentacadProgram != null)
                {
                    student["acadProgram"] = ExpressionConverter.ConvertO(__workflow_studentacadProgram);
                    studentpropCount++;
                }

                if (__workflow_studentaddress1 != null)
                {
                    student["address1"] = ExpressionConverter.ConvertO(__workflow_studentaddress1);
                    studentpropCount++;
                }

                if (__workflow_studentaddress2 != null)
                {
                    student["address2"] = ExpressionConverter.ConvertO(__workflow_studentaddress2);
                    studentpropCount++;
                }

                if (__workflow_studentaddress3 != null)
                {
                    student["address3"] = ExpressionConverter.ConvertO(__workflow_studentaddress3);
                    studentpropCount++;
                }

                if (__workflow_studentaddress4 != null)
                {
                    student["address4"] = ExpressionConverter.ConvertO(__workflow_studentaddress4);
                    studentpropCount++;
                }

                if (__workflow_studentbarcode != null)
                {
                    student["barcode"] = ExpressionConverter.ConvertO(__workflow_studentbarcode);
                    studentpropCount++;
                }

                if (__workflow_studentbirthCountryCode != null)
                {
                    student["birthCountryCode"] = ExpressionConverter.ConvertO(__workflow_studentbirthCountryCode);
                    studentpropCount++;
                }

                if (__workflow_studentcellTel != null)
                {
                    student["cellTel"] = ExpressionConverter.ConvertO(__workflow_studentcellTel);
                    studentpropCount++;
                }

                if (__workflow_studentcity != null)
                {
                    student["city"] = ExpressionConverter.ConvertO(__workflow_studentcity);
                    studentpropCount++;
                }

                if (__workflow_studentcollegeAccountNo != null)
                {
                    student["collegeAccountNo"] = ExpressionConverter.ConvertO(__workflow_studentcollegeAccountNo);
                    studentpropCount++;
                }

                if (__workflow_studentcountry != null)
                {
                    student["country"] = ExpressionConverter.ConvertO(__workflow_studentcountry);
                    studentpropCount++;
                }

                if (__workflow_studentcountryCitizen != null)
                {
                    student["countryCitizen"] = ExpressionConverter.ConvertO(__workflow_studentcountryCitizen);
                    studentpropCount++;
                }

                if (__workflow_studentcountryCitizen2 != null)
                {
                    student["countryCitizen2"] = ExpressionConverter.ConvertO(__workflow_studentcountryCitizen2);
                    studentpropCount++;
                }

                if (__workflow_studentcrsid != null)
                {
                    student["crsid"] = ExpressionConverter.ConvertO(__workflow_studentcrsid);
                    studentpropCount++;
                }

                if (__workflow_studentdegree != null)
                {
                    student["degree"] = ExpressionConverter.ConvertO(__workflow_studentdegree);
                    studentpropCount++;
                }

                if (__workflow_studentdob != null)
                {
                    student["dob"] = ExpressionConverter.ConvertO(__workflow_studentdob);
                    studentpropCount++;
                }

                if (__workflow_studentdos != null)
                {
                    student["dos"] = ExpressionConverter.ConvertO(__workflow_studentdos);
                    studentpropCount++;
                }

                if (__workflow_studentdosEmail != null)
                {
                    student["dosEmail"] = ExpressionConverter.ConvertO(__workflow_studentdosEmail);
                    studentpropCount++;
                }

                if (__workflow_studentdosEmployeeId != null)
                {
                    student["dosEmployeeId"] = ExpressionConverter.ConvertO(__workflow_studentdosEmployeeId);
                    studentpropCount++;
                }

                if (__workflow_studentemail != null)
                {
                    student["email"] = ExpressionConverter.ConvertO(__workflow_studentemail);
                    studentpropCount++;
                }

                if (__workflow_studentemailAddr != null)
                {
                    student["emailAddr"] = ExpressionConverter.ConvertO(__workflow_studentemailAddr);
                    studentpropCount++;
                }

                if (__workflow_studentemailPersonal != null)
                {
                    student["emailPersonal"] = ExpressionConverter.ConvertO(__workflow_studentemailPersonal);
                    studentpropCount++;
                }

                if (__workflow_studentendDate != null)
                {
                    student["endDate"] = ExpressionConverter.ConvertO(__workflow_studentendDate);
                    studentpropCount++;
                }

                if (__workflow_studentenqGrp != null)
                {
                    student["enqGrp"] = ExpressionConverter.ConvertO(__workflow_studentenqGrp);
                    studentpropCount++;
                }

                if (__workflow_studentfirstNames != null)
                {
                    student["firstNames"] = ExpressionConverter.ConvertO(__workflow_studentfirstNames);
                    studentpropCount++;
                }

                if (__workflow_studentgradTutor != null)
                {
                    student["gradTutor"] = ExpressionConverter.ConvertO(__workflow_studentgradTutor);
                    studentpropCount++;
                }

                if (__workflow_studentgradTutorEmail != null)
                {
                    student["gradTutorEmail"] = ExpressionConverter.ConvertO(__workflow_studentgradTutorEmail);
                    studentpropCount++;
                }

                if (__workflow_studentgradTutorEmployeeId != null)
                {
                    student["gradTutorEmployeeId"] = ExpressionConverter.ConvertO(__workflow_studentgradTutorEmployeeId);
                    studentpropCount++;
                }

                if (__workflow_studentgrp != null)
                {
                    student["grp"] = ExpressionConverter.ConvertO(__workflow_studentgrp);
                    studentpropCount++;
                }

                if (__workflow_studentgrpId != null)
                {
                    student["grpId"] = ExpressionConverter.ConvertO(__workflow_studentgrpId);
                    studentpropCount++;
                }

                if (__workflow_studenthomeAddress1 != null)
                {
                    student["homeAddress1"] = ExpressionConverter.ConvertO(__workflow_studenthomeAddress1);
                    studentpropCount++;
                }

                if (__workflow_studenthomeAddress2 != null)
                {
                    student["homeAddress2"] = ExpressionConverter.ConvertO(__workflow_studenthomeAddress2);
                    studentpropCount++;
                }

                if (__workflow_studenthomeAddress3 != null)
                {
                    student["homeAddress3"] = ExpressionConverter.ConvertO(__workflow_studenthomeAddress3);
                    studentpropCount++;
                }

                if (__workflow_studenthomeAddress4 != null)
                {
                    student["homeAddress4"] = ExpressionConverter.ConvertO(__workflow_studenthomeAddress4);
                    studentpropCount++;
                }

                if (__workflow_studenthomeAddress5 != null)
                {
                    student["homeAddress5"] = ExpressionConverter.ConvertO(__workflow_studenthomeAddress5);
                    studentpropCount++;
                }

                if (__workflow_studenthomeCountry != null)
                {
                    student["homeCountry"] = ExpressionConverter.ConvertO(__workflow_studenthomeCountry);
                    studentpropCount++;
                }

                if (__workflow_studenthomePostal != null)
                {
                    student["homePostal"] = ExpressionConverter.ConvertO(__workflow_studenthomePostal);
                    studentpropCount++;
                }

                if (__workflow_studenthomeState != null)
                {
                    student["homeState"] = ExpressionConverter.ConvertO(__workflow_studenthomeState);
                    studentpropCount++;
                }

                if (__workflow_studenthomeTel != null)
                {
                    student["homeTel"] = ExpressionConverter.ConvertO(__workflow_studenthomeTel);
                    studentpropCount++;
                }

                if (__workflow_studentmatriculation != null)
                {
                    student["matriculation"] = ExpressionConverter.ConvertO(__workflow_studentmatriculation);
                    studentpropCount++;
                }

                if (__workflow_studentmobileTel != null)
                {
                    student["mobileTel"] = ExpressionConverter.ConvertO(__workflow_studentmobileTel);
                    studentpropCount++;
                }

                if (__workflow_studentnationality != null)
                {
                    student["nationality"] = ExpressionConverter.ConvertO(__workflow_studentnationality);
                    studentpropCount++;
                }

                if (__workflow_studentpostal != null)
                {
                    student["postal"] = ExpressionConverter.ConvertO(__workflow_studentpostal);
                    studentpropCount++;
                }

                if (__workflow_studentprinSuper != null)
                {
                    student["prinSuper"] = ExpressionConverter.ConvertO(__workflow_studentprinSuper);
                    studentpropCount++;
                }

                if (__workflow_studentprinSuperEmail != null)
                {
                    student["prinSuperEmail"] = ExpressionConverter.ConvertO(__workflow_studentprinSuperEmail);
                    studentpropCount++;
                }

                if (__workflow_studentprinSuperEmployeeId != null)
                {
                    student["prinSuperEmployeeId"] = ExpressionConverter.ConvertO(__workflow_studentprinSuperEmployeeId);
                    studentpropCount++;
                }

                if (__workflow_studentsex != null)
                {
                    student["sex"] = ExpressionConverter.ConvertO(__workflow_studentsex);
                    studentpropCount++;
                }

                if (__workflow_studentstartDate != null)
                {
                    student["startDate"] = ExpressionConverter.ConvertO(__workflow_studentstartDate);
                    studentpropCount++;
                }

                if (__workflow_studentstudentFeesClass != null)
                {
                    student["studentFeesClass"] = ExpressionConverter.ConvertO(__workflow_studentstudentFeesClass);
                    studentpropCount++;
                }

                if (__workflow_studentstudyYear != null)
                {
                    student["studyYear"] = ExpressionConverter.ConvertO(__workflow_studentstudyYear);
                    studentpropCount++;
                }

                if (__workflow_studentsubject != null)
                {
                    student["subject"] = ExpressionConverter.ConvertO(__workflow_studentsubject);
                    studentpropCount++;
                }

                if (__workflow_studentsubjectDescr != null)
                {
                    student["subjectDescr"] = ExpressionConverter.ConvertO(__workflow_studentsubjectDescr);
                    studentpropCount++;
                }

                if (__workflow_studentsuperEmail != null)
                {
                    student["superEmail"] = ExpressionConverter.ConvertO(__workflow_studentsuperEmail);
                    studentpropCount++;
                }

                if (__workflow_studentsurname != null)
                {
                    student["surname"] = ExpressionConverter.ConvertO(__workflow_studentsurname);
                    studentpropCount++;
                }

                if (__workflow_studenttitle != null)
                {
                    student["title"] = ExpressionConverter.ConvertO(__workflow_studenttitle);
                    studentpropCount++;
                }

                if (__workflow_studenttutor != null)
                {
                    student["tutor"] = ExpressionConverter.ConvertO(__workflow_studenttutor);
                    studentpropCount++;
                }

                if (__workflow_studenttutorEmail != null)
                {
                    student["tutorEmail"] = ExpressionConverter.ConvertO(__workflow_studenttutorEmail);
                    studentpropCount++;
                }

                if (__workflow_studenttutorEmployeeId != null)
                {
                    student["tutorEmployeeId"] = ExpressionConverter.ConvertO(__workflow_studenttutorEmployeeId);
                    studentpropCount++;
                }

                if (studentpropCount > 0)
                {
                    callPayload.Body = student;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<bool> StudentIsBrowserAppGet()
        {
            var apiCallPath = "/Student/IsBrowserApp";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<bool>(callPayload);
        }
    }

    public class Casper365Triggers([ConnectionName] string connectionId)
    {
    }

    public class Course
    {
        [JsonProperty("audience")]
        public string Audience { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("dos")]
        public string Dos { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Student
    {
        [JsonProperty("acadCareer")]
        public string AcadCareer { get; set; }

        [JsonProperty("acadOrgDescr")]
        public string AcadOrgDescr { get; set; }

        [JsonProperty("acadProgram")]
        public string AcadProgram { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("address4")]
        public string Address4 { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("birthCountryCode")]
        public string BirthCountryCode { get; set; }

        [JsonProperty("cellTel")]
        public string CellTel { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("collegeAccountNo")]
        public double CollegeAccountNo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCitizen")]
        public string CountryCitizen { get; set; }

        [JsonProperty("countryCitizen2")]
        public string CountryCitizen2 { get; set; }

        [JsonProperty("crsid")]
        public string Crsid { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("dos")]
        public string Dos { get; set; }

        [JsonProperty("dosEmail")]
        public string DosEmail { get; set; }

        [JsonProperty("dosEmployeeId")]
        public string DosEmployeeId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailAddr")]
        public string EmailAddr { get; set; }

        [JsonProperty("emailPersonal")]
        public string EmailPersonal { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("enqGrp")]
        public string EnqGrp { get; set; }

        [JsonProperty("firstNames")]
        public string FirstNames { get; set; }

        [JsonProperty("gradTutor")]
        public string GradTutor { get; set; }

        [JsonProperty("gradTutorEmail")]
        public string GradTutorEmail { get; set; }

        [JsonProperty("gradTutorEmployeeId")]
        public string GradTutorEmployeeId { get; set; }

        [JsonProperty("grp")]
        public string Grp { get; set; }

        [JsonProperty("grpId")]
        public string GrpId { get; set; }

        [JsonProperty("homeAddress1")]
        public string HomeAddress1 { get; set; }

        [JsonProperty("homeAddress2")]
        public string HomeAddress2 { get; set; }

        [JsonProperty("homeAddress3")]
        public string HomeAddress3 { get; set; }

        [JsonProperty("homeAddress4")]
        public string HomeAddress4 { get; set; }

        [JsonProperty("homeAddress5")]
        public string HomeAddress5 { get; set; }

        [JsonProperty("homeCountry")]
        public string HomeCountry { get; set; }

        [JsonProperty("homePostal")]
        public string HomePostal { get; set; }

        [JsonProperty("homeState")]
        public string HomeState { get; set; }

        [JsonProperty("homeTel")]
        public string HomeTel { get; set; }

        [JsonProperty("matriculation")]
        public string Matriculation { get; set; }

        [JsonProperty("mobileTel")]
        public string MobileTel { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("prinSuper")]
        public string PrinSuper { get; set; }

        [JsonProperty("prinSuperEmail")]
        public string PrinSuperEmail { get; set; }

        [JsonProperty("prinSuperEmployeeId")]
        public string PrinSuperEmployeeId { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("studentFeesClass")]
        public string StudentFeesClass { get; set; }

        [JsonProperty("studyYear")]
        public string StudyYear { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("subjectDescr")]
        public string SubjectDescr { get; set; }

        [JsonProperty("superEmail")]
        public string SuperEmail { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tutor")]
        public string Tutor { get; set; }

        [JsonProperty("tutorEmail")]
        public string TutorEmail { get; set; }

        [JsonProperty("tutorEmployeeId")]
        public string TutorEmployeeId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Casper365;

    public partial class WorkflowManagedActions
    {
        public Casper365Actions Casper365(string connectionId) => new Casper365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Casper365Triggers Casper365(string connectionId) => new Casper365Triggers(connectionId);
    }
}
