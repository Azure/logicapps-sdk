//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Casper365
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Casper365Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildCourseGet))]
        public IBodyWorkflowAction<Course[]> CourseGet([WorkflowExpression] Func<string> course = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Course[]> __BuildCourseGet(WorkflowExpression<string> course = null)
        {
            WorkflowExpression.Validate(course, nameof(course), required: false);
            return new DeferredBodyAction<Course[]>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (course != null)
                    callPayload.Queries["course"] = ExpressionConverter.Convert(course);
                return new ApiConnectionAction<Course[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildCourse))]
        public IBodyWorkflowAction<bool> Course([WorkflowExpression] Func<string> courseaudience = null, [WorkflowExpression] Func<string> coursecourseName = null, [WorkflowExpression] Func<string> coursedos = null, [WorkflowExpression] Func<string> courseemail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildCourse(WorkflowExpression<string> courseaudience = null, WorkflowExpression<string> coursecourseName = null, WorkflowExpression<string> coursedos = null, WorkflowExpression<string> courseemail = null)
        {
            WorkflowExpression.Validate(courseaudience, nameof(courseaudience), required: false);
            WorkflowExpression.Validate(coursecourseName, nameof(coursecourseName), required: false);
            WorkflowExpression.Validate(coursedos, nameof(coursedos), required: false);
            WorkflowExpression.Validate(courseemail, nameof(courseemail), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var course = new JObject();
                var coursepropCount = 0;
                if (courseaudience != null)
                {
                    course["audience"] = ExpressionConverter.ConvertO(courseaudience);
                    coursepropCount++;
                }

                if (coursecourseName != null)
                {
                    course["courseName"] = ExpressionConverter.ConvertO(coursecourseName);
                    coursepropCount++;
                }

                if (coursedos != null)
                {
                    course["dos"] = ExpressionConverter.ConvertO(coursedos);
                    coursepropCount++;
                }

                if (courseemail != null)
                {
                    course["email"] = ExpressionConverter.ConvertO(courseemail);
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
        [WorkflowExpressionFactory(nameof(__BuildLogEnd))]
        public IWorkflowAction LogEnd([WorkflowExpression] Func<string> identifier = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLogEnd(WorkflowExpression<string> identifier = null)
        {
            WorkflowExpression.Validate(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Log/End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildLogStart))]
        public IWorkflowAction LogStart([WorkflowExpression] Func<string> identifier = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLogStart(WorkflowExpression<string> identifier = null)
        {
            WorkflowExpression.Validate(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Log/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildStudentGet))]
        public IBodyWorkflowAction<Student> StudentGet([WorkflowExpression] Func<string> studentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Student> __BuildStudentGet(WorkflowExpression<string> studentId = null)
        {
            WorkflowExpression.Validate(studentId, nameof(studentId), required: false);
            return new DeferredBodyAction<Student>(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (studentId != null)
                    callPayload.Queries["studentId"] = ExpressionConverter.Convert(studentId);
                return new ApiConnectionAction<Student>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildStudent))]
        public IWorkflowAction Student([WorkflowExpression] Func<string> studentacadCareer = null, [WorkflowExpression] Func<string> studentacadOrgDescr = null, [WorkflowExpression] Func<string> studentacadProgram = null, [WorkflowExpression] Func<string> studentaddress1 = null, [WorkflowExpression] Func<string> studentaddress2 = null, [WorkflowExpression] Func<string> studentaddress3 = null, [WorkflowExpression] Func<string> studentaddress4 = null, [WorkflowExpression] Func<string> studentbarcode = null, [WorkflowExpression] Func<string> studentbirthCountryCode = null, [WorkflowExpression] Func<string> studentcellTel = null, [WorkflowExpression] Func<string> studentcity = null, [WorkflowExpression] Func<double> studentcollegeAccountNo = null, [WorkflowExpression] Func<string> studentcountry = null, [WorkflowExpression] Func<string> studentcountryCitizen = null, [WorkflowExpression] Func<string> studentcountryCitizen2 = null, [WorkflowExpression] Func<string> studentcrsid = null, [WorkflowExpression] Func<string> studentdegree = null, [WorkflowExpression] Func<string> studentdob = null, [WorkflowExpression] Func<string> studentdos = null, [WorkflowExpression] Func<string> studentdosEmail = null, [WorkflowExpression] Func<string> studentdosEmployeeId = null, [WorkflowExpression] Func<string> studentemail = null, [WorkflowExpression] Func<string> studentemailAddr = null, [WorkflowExpression] Func<string> studentemailPersonal = null, [WorkflowExpression] Func<string> studentendDate = null, [WorkflowExpression] Func<string> studentenqGrp = null, [WorkflowExpression] Func<string> studentfirstNames = null, [WorkflowExpression] Func<string> studentgradTutor = null, [WorkflowExpression] Func<string> studentgradTutorEmail = null, [WorkflowExpression] Func<string> studentgradTutorEmployeeId = null, [WorkflowExpression] Func<string> studentgrp = null, [WorkflowExpression] Func<string> studentgrpId = null, [WorkflowExpression] Func<string> studenthomeAddress1 = null, [WorkflowExpression] Func<string> studenthomeAddress2 = null, [WorkflowExpression] Func<string> studenthomeAddress3 = null, [WorkflowExpression] Func<string> studenthomeAddress4 = null, [WorkflowExpression] Func<string> studenthomeAddress5 = null, [WorkflowExpression] Func<string> studenthomeCountry = null, [WorkflowExpression] Func<string> studenthomePostal = null, [WorkflowExpression] Func<string> studenthomeState = null, [WorkflowExpression] Func<string> studenthomeTel = null, [WorkflowExpression] Func<string> studentmatriculation = null, [WorkflowExpression] Func<string> studentmobileTel = null, [WorkflowExpression] Func<string> studentnationality = null, [WorkflowExpression] Func<string> studentpostal = null, [WorkflowExpression] Func<string> studentprinSuper = null, [WorkflowExpression] Func<string> studentprinSuperEmail = null, [WorkflowExpression] Func<string> studentprinSuperEmployeeId = null, [WorkflowExpression] Func<string> studentsex = null, [WorkflowExpression] Func<string> studentstartDate = null, [WorkflowExpression] Func<string> studentstudentFeesClass = null, [WorkflowExpression] Func<string> studentstudyYear = null, [WorkflowExpression] Func<string> studentsubject = null, [WorkflowExpression] Func<string> studentsubjectDescr = null, [WorkflowExpression] Func<string> studentsuperEmail = null, [WorkflowExpression] Func<string> studentsurname = null, [WorkflowExpression] Func<string> studenttitle = null, [WorkflowExpression] Func<string> studenttutor = null, [WorkflowExpression] Func<string> studenttutorEmail = null, [WorkflowExpression] Func<string> studenttutorEmployeeId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildStudent(WorkflowExpression<string> studentacadCareer = null, WorkflowExpression<string> studentacadOrgDescr = null, WorkflowExpression<string> studentacadProgram = null, WorkflowExpression<string> studentaddress1 = null, WorkflowExpression<string> studentaddress2 = null, WorkflowExpression<string> studentaddress3 = null, WorkflowExpression<string> studentaddress4 = null, WorkflowExpression<string> studentbarcode = null, WorkflowExpression<string> studentbirthCountryCode = null, WorkflowExpression<string> studentcellTel = null, WorkflowExpression<string> studentcity = null, WorkflowExpression<double> studentcollegeAccountNo = null, WorkflowExpression<string> studentcountry = null, WorkflowExpression<string> studentcountryCitizen = null, WorkflowExpression<string> studentcountryCitizen2 = null, WorkflowExpression<string> studentcrsid = null, WorkflowExpression<string> studentdegree = null, WorkflowExpression<string> studentdob = null, WorkflowExpression<string> studentdos = null, WorkflowExpression<string> studentdosEmail = null, WorkflowExpression<string> studentdosEmployeeId = null, WorkflowExpression<string> studentemail = null, WorkflowExpression<string> studentemailAddr = null, WorkflowExpression<string> studentemailPersonal = null, WorkflowExpression<string> studentendDate = null, WorkflowExpression<string> studentenqGrp = null, WorkflowExpression<string> studentfirstNames = null, WorkflowExpression<string> studentgradTutor = null, WorkflowExpression<string> studentgradTutorEmail = null, WorkflowExpression<string> studentgradTutorEmployeeId = null, WorkflowExpression<string> studentgrp = null, WorkflowExpression<string> studentgrpId = null, WorkflowExpression<string> studenthomeAddress1 = null, WorkflowExpression<string> studenthomeAddress2 = null, WorkflowExpression<string> studenthomeAddress3 = null, WorkflowExpression<string> studenthomeAddress4 = null, WorkflowExpression<string> studenthomeAddress5 = null, WorkflowExpression<string> studenthomeCountry = null, WorkflowExpression<string> studenthomePostal = null, WorkflowExpression<string> studenthomeState = null, WorkflowExpression<string> studenthomeTel = null, WorkflowExpression<string> studentmatriculation = null, WorkflowExpression<string> studentmobileTel = null, WorkflowExpression<string> studentnationality = null, WorkflowExpression<string> studentpostal = null, WorkflowExpression<string> studentprinSuper = null, WorkflowExpression<string> studentprinSuperEmail = null, WorkflowExpression<string> studentprinSuperEmployeeId = null, WorkflowExpression<string> studentsex = null, WorkflowExpression<string> studentstartDate = null, WorkflowExpression<string> studentstudentFeesClass = null, WorkflowExpression<string> studentstudyYear = null, WorkflowExpression<string> studentsubject = null, WorkflowExpression<string> studentsubjectDescr = null, WorkflowExpression<string> studentsuperEmail = null, WorkflowExpression<string> studentsurname = null, WorkflowExpression<string> studenttitle = null, WorkflowExpression<string> studenttutor = null, WorkflowExpression<string> studenttutorEmail = null, WorkflowExpression<string> studenttutorEmployeeId = null)
        {
            WorkflowExpression.Validate(studentacadCareer, nameof(studentacadCareer), required: false);
            WorkflowExpression.Validate(studentacadOrgDescr, nameof(studentacadOrgDescr), required: false);
            WorkflowExpression.Validate(studentacadProgram, nameof(studentacadProgram), required: false);
            WorkflowExpression.Validate(studentaddress1, nameof(studentaddress1), required: false);
            WorkflowExpression.Validate(studentaddress2, nameof(studentaddress2), required: false);
            WorkflowExpression.Validate(studentaddress3, nameof(studentaddress3), required: false);
            WorkflowExpression.Validate(studentaddress4, nameof(studentaddress4), required: false);
            WorkflowExpression.Validate(studentbarcode, nameof(studentbarcode), required: false);
            WorkflowExpression.Validate(studentbirthCountryCode, nameof(studentbirthCountryCode), required: false);
            WorkflowExpression.Validate(studentcellTel, nameof(studentcellTel), required: false);
            WorkflowExpression.Validate(studentcity, nameof(studentcity), required: false);
            WorkflowExpression.Validate(studentcollegeAccountNo, nameof(studentcollegeAccountNo), required: false);
            WorkflowExpression.Validate(studentcountry, nameof(studentcountry), required: false);
            WorkflowExpression.Validate(studentcountryCitizen, nameof(studentcountryCitizen), required: false);
            WorkflowExpression.Validate(studentcountryCitizen2, nameof(studentcountryCitizen2), required: false);
            WorkflowExpression.Validate(studentcrsid, nameof(studentcrsid), required: false);
            WorkflowExpression.Validate(studentdegree, nameof(studentdegree), required: false);
            WorkflowExpression.Validate(studentdob, nameof(studentdob), required: false);
            WorkflowExpression.Validate(studentdos, nameof(studentdos), required: false);
            WorkflowExpression.Validate(studentdosEmail, nameof(studentdosEmail), required: false);
            WorkflowExpression.Validate(studentdosEmployeeId, nameof(studentdosEmployeeId), required: false);
            WorkflowExpression.Validate(studentemail, nameof(studentemail), required: false);
            WorkflowExpression.Validate(studentemailAddr, nameof(studentemailAddr), required: false);
            WorkflowExpression.Validate(studentemailPersonal, nameof(studentemailPersonal), required: false);
            WorkflowExpression.Validate(studentendDate, nameof(studentendDate), required: false);
            WorkflowExpression.Validate(studentenqGrp, nameof(studentenqGrp), required: false);
            WorkflowExpression.Validate(studentfirstNames, nameof(studentfirstNames), required: false);
            WorkflowExpression.Validate(studentgradTutor, nameof(studentgradTutor), required: false);
            WorkflowExpression.Validate(studentgradTutorEmail, nameof(studentgradTutorEmail), required: false);
            WorkflowExpression.Validate(studentgradTutorEmployeeId, nameof(studentgradTutorEmployeeId), required: false);
            WorkflowExpression.Validate(studentgrp, nameof(studentgrp), required: false);
            WorkflowExpression.Validate(studentgrpId, nameof(studentgrpId), required: false);
            WorkflowExpression.Validate(studenthomeAddress1, nameof(studenthomeAddress1), required: false);
            WorkflowExpression.Validate(studenthomeAddress2, nameof(studenthomeAddress2), required: false);
            WorkflowExpression.Validate(studenthomeAddress3, nameof(studenthomeAddress3), required: false);
            WorkflowExpression.Validate(studenthomeAddress4, nameof(studenthomeAddress4), required: false);
            WorkflowExpression.Validate(studenthomeAddress5, nameof(studenthomeAddress5), required: false);
            WorkflowExpression.Validate(studenthomeCountry, nameof(studenthomeCountry), required: false);
            WorkflowExpression.Validate(studenthomePostal, nameof(studenthomePostal), required: false);
            WorkflowExpression.Validate(studenthomeState, nameof(studenthomeState), required: false);
            WorkflowExpression.Validate(studenthomeTel, nameof(studenthomeTel), required: false);
            WorkflowExpression.Validate(studentmatriculation, nameof(studentmatriculation), required: false);
            WorkflowExpression.Validate(studentmobileTel, nameof(studentmobileTel), required: false);
            WorkflowExpression.Validate(studentnationality, nameof(studentnationality), required: false);
            WorkflowExpression.Validate(studentpostal, nameof(studentpostal), required: false);
            WorkflowExpression.Validate(studentprinSuper, nameof(studentprinSuper), required: false);
            WorkflowExpression.Validate(studentprinSuperEmail, nameof(studentprinSuperEmail), required: false);
            WorkflowExpression.Validate(studentprinSuperEmployeeId, nameof(studentprinSuperEmployeeId), required: false);
            WorkflowExpression.Validate(studentsex, nameof(studentsex), required: false);
            WorkflowExpression.Validate(studentstartDate, nameof(studentstartDate), required: false);
            WorkflowExpression.Validate(studentstudentFeesClass, nameof(studentstudentFeesClass), required: false);
            WorkflowExpression.Validate(studentstudyYear, nameof(studentstudyYear), required: false);
            WorkflowExpression.Validate(studentsubject, nameof(studentsubject), required: false);
            WorkflowExpression.Validate(studentsubjectDescr, nameof(studentsubjectDescr), required: false);
            WorkflowExpression.Validate(studentsuperEmail, nameof(studentsuperEmail), required: false);
            WorkflowExpression.Validate(studentsurname, nameof(studentsurname), required: false);
            WorkflowExpression.Validate(studenttitle, nameof(studenttitle), required: false);
            WorkflowExpression.Validate(studenttutor, nameof(studenttutor), required: false);
            WorkflowExpression.Validate(studenttutorEmail, nameof(studenttutorEmail), required: false);
            WorkflowExpression.Validate(studenttutorEmployeeId, nameof(studenttutorEmployeeId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var student = new JObject();
                var studentpropCount = 0;
                if (studentacadCareer != null)
                {
                    student["acadCareer"] = ExpressionConverter.ConvertO(studentacadCareer);
                    studentpropCount++;
                }

                if (studentacadOrgDescr != null)
                {
                    student["acadOrgDescr"] = ExpressionConverter.ConvertO(studentacadOrgDescr);
                    studentpropCount++;
                }

                if (studentacadProgram != null)
                {
                    student["acadProgram"] = ExpressionConverter.ConvertO(studentacadProgram);
                    studentpropCount++;
                }

                if (studentaddress1 != null)
                {
                    student["address1"] = ExpressionConverter.ConvertO(studentaddress1);
                    studentpropCount++;
                }

                if (studentaddress2 != null)
                {
                    student["address2"] = ExpressionConverter.ConvertO(studentaddress2);
                    studentpropCount++;
                }

                if (studentaddress3 != null)
                {
                    student["address3"] = ExpressionConverter.ConvertO(studentaddress3);
                    studentpropCount++;
                }

                if (studentaddress4 != null)
                {
                    student["address4"] = ExpressionConverter.ConvertO(studentaddress4);
                    studentpropCount++;
                }

                if (studentbarcode != null)
                {
                    student["barcode"] = ExpressionConverter.ConvertO(studentbarcode);
                    studentpropCount++;
                }

                if (studentbirthCountryCode != null)
                {
                    student["birthCountryCode"] = ExpressionConverter.ConvertO(studentbirthCountryCode);
                    studentpropCount++;
                }

                if (studentcellTel != null)
                {
                    student["cellTel"] = ExpressionConverter.ConvertO(studentcellTel);
                    studentpropCount++;
                }

                if (studentcity != null)
                {
                    student["city"] = ExpressionConverter.ConvertO(studentcity);
                    studentpropCount++;
                }

                if (studentcollegeAccountNo != null)
                {
                    student["collegeAccountNo"] = ExpressionConverter.ConvertO(studentcollegeAccountNo);
                    studentpropCount++;
                }

                if (studentcountry != null)
                {
                    student["country"] = ExpressionConverter.ConvertO(studentcountry);
                    studentpropCount++;
                }

                if (studentcountryCitizen != null)
                {
                    student["countryCitizen"] = ExpressionConverter.ConvertO(studentcountryCitizen);
                    studentpropCount++;
                }

                if (studentcountryCitizen2 != null)
                {
                    student["countryCitizen2"] = ExpressionConverter.ConvertO(studentcountryCitizen2);
                    studentpropCount++;
                }

                if (studentcrsid != null)
                {
                    student["crsid"] = ExpressionConverter.ConvertO(studentcrsid);
                    studentpropCount++;
                }

                if (studentdegree != null)
                {
                    student["degree"] = ExpressionConverter.ConvertO(studentdegree);
                    studentpropCount++;
                }

                if (studentdob != null)
                {
                    student["dob"] = ExpressionConverter.ConvertO(studentdob);
                    studentpropCount++;
                }

                if (studentdos != null)
                {
                    student["dos"] = ExpressionConverter.ConvertO(studentdos);
                    studentpropCount++;
                }

                if (studentdosEmail != null)
                {
                    student["dosEmail"] = ExpressionConverter.ConvertO(studentdosEmail);
                    studentpropCount++;
                }

                if (studentdosEmployeeId != null)
                {
                    student["dosEmployeeId"] = ExpressionConverter.ConvertO(studentdosEmployeeId);
                    studentpropCount++;
                }

                if (studentemail != null)
                {
                    student["email"] = ExpressionConverter.ConvertO(studentemail);
                    studentpropCount++;
                }

                if (studentemailAddr != null)
                {
                    student["emailAddr"] = ExpressionConverter.ConvertO(studentemailAddr);
                    studentpropCount++;
                }

                if (studentemailPersonal != null)
                {
                    student["emailPersonal"] = ExpressionConverter.ConvertO(studentemailPersonal);
                    studentpropCount++;
                }

                if (studentendDate != null)
                {
                    student["endDate"] = ExpressionConverter.ConvertO(studentendDate);
                    studentpropCount++;
                }

                if (studentenqGrp != null)
                {
                    student["enqGrp"] = ExpressionConverter.ConvertO(studentenqGrp);
                    studentpropCount++;
                }

                if (studentfirstNames != null)
                {
                    student["firstNames"] = ExpressionConverter.ConvertO(studentfirstNames);
                    studentpropCount++;
                }

                if (studentgradTutor != null)
                {
                    student["gradTutor"] = ExpressionConverter.ConvertO(studentgradTutor);
                    studentpropCount++;
                }

                if (studentgradTutorEmail != null)
                {
                    student["gradTutorEmail"] = ExpressionConverter.ConvertO(studentgradTutorEmail);
                    studentpropCount++;
                }

                if (studentgradTutorEmployeeId != null)
                {
                    student["gradTutorEmployeeId"] = ExpressionConverter.ConvertO(studentgradTutorEmployeeId);
                    studentpropCount++;
                }

                if (studentgrp != null)
                {
                    student["grp"] = ExpressionConverter.ConvertO(studentgrp);
                    studentpropCount++;
                }

                if (studentgrpId != null)
                {
                    student["grpId"] = ExpressionConverter.ConvertO(studentgrpId);
                    studentpropCount++;
                }

                if (studenthomeAddress1 != null)
                {
                    student["homeAddress1"] = ExpressionConverter.ConvertO(studenthomeAddress1);
                    studentpropCount++;
                }

                if (studenthomeAddress2 != null)
                {
                    student["homeAddress2"] = ExpressionConverter.ConvertO(studenthomeAddress2);
                    studentpropCount++;
                }

                if (studenthomeAddress3 != null)
                {
                    student["homeAddress3"] = ExpressionConverter.ConvertO(studenthomeAddress3);
                    studentpropCount++;
                }

                if (studenthomeAddress4 != null)
                {
                    student["homeAddress4"] = ExpressionConverter.ConvertO(studenthomeAddress4);
                    studentpropCount++;
                }

                if (studenthomeAddress5 != null)
                {
                    student["homeAddress5"] = ExpressionConverter.ConvertO(studenthomeAddress5);
                    studentpropCount++;
                }

                if (studenthomeCountry != null)
                {
                    student["homeCountry"] = ExpressionConverter.ConvertO(studenthomeCountry);
                    studentpropCount++;
                }

                if (studenthomePostal != null)
                {
                    student["homePostal"] = ExpressionConverter.ConvertO(studenthomePostal);
                    studentpropCount++;
                }

                if (studenthomeState != null)
                {
                    student["homeState"] = ExpressionConverter.ConvertO(studenthomeState);
                    studentpropCount++;
                }

                if (studenthomeTel != null)
                {
                    student["homeTel"] = ExpressionConverter.ConvertO(studenthomeTel);
                    studentpropCount++;
                }

                if (studentmatriculation != null)
                {
                    student["matriculation"] = ExpressionConverter.ConvertO(studentmatriculation);
                    studentpropCount++;
                }

                if (studentmobileTel != null)
                {
                    student["mobileTel"] = ExpressionConverter.ConvertO(studentmobileTel);
                    studentpropCount++;
                }

                if (studentnationality != null)
                {
                    student["nationality"] = ExpressionConverter.ConvertO(studentnationality);
                    studentpropCount++;
                }

                if (studentpostal != null)
                {
                    student["postal"] = ExpressionConverter.ConvertO(studentpostal);
                    studentpropCount++;
                }

                if (studentprinSuper != null)
                {
                    student["prinSuper"] = ExpressionConverter.ConvertO(studentprinSuper);
                    studentpropCount++;
                }

                if (studentprinSuperEmail != null)
                {
                    student["prinSuperEmail"] = ExpressionConverter.ConvertO(studentprinSuperEmail);
                    studentpropCount++;
                }

                if (studentprinSuperEmployeeId != null)
                {
                    student["prinSuperEmployeeId"] = ExpressionConverter.ConvertO(studentprinSuperEmployeeId);
                    studentpropCount++;
                }

                if (studentsex != null)
                {
                    student["sex"] = ExpressionConverter.ConvertO(studentsex);
                    studentpropCount++;
                }

                if (studentstartDate != null)
                {
                    student["startDate"] = ExpressionConverter.ConvertO(studentstartDate);
                    studentpropCount++;
                }

                if (studentstudentFeesClass != null)
                {
                    student["studentFeesClass"] = ExpressionConverter.ConvertO(studentstudentFeesClass);
                    studentpropCount++;
                }

                if (studentstudyYear != null)
                {
                    student["studyYear"] = ExpressionConverter.ConvertO(studentstudyYear);
                    studentpropCount++;
                }

                if (studentsubject != null)
                {
                    student["subject"] = ExpressionConverter.ConvertO(studentsubject);
                    studentpropCount++;
                }

                if (studentsubjectDescr != null)
                {
                    student["subjectDescr"] = ExpressionConverter.ConvertO(studentsubjectDescr);
                    studentpropCount++;
                }

                if (studentsuperEmail != null)
                {
                    student["superEmail"] = ExpressionConverter.ConvertO(studentsuperEmail);
                    studentpropCount++;
                }

                if (studentsurname != null)
                {
                    student["surname"] = ExpressionConverter.ConvertO(studentsurname);
                    studentpropCount++;
                }

                if (studenttitle != null)
                {
                    student["title"] = ExpressionConverter.ConvertO(studenttitle);
                    studentpropCount++;
                }

                if (studenttutor != null)
                {
                    student["tutor"] = ExpressionConverter.ConvertO(studenttutor);
                    studentpropCount++;
                }

                if (studenttutorEmail != null)
                {
                    student["tutorEmail"] = ExpressionConverter.ConvertO(studenttutorEmail);
                    studentpropCount++;
                }

                if (studenttutorEmployeeId != null)
                {
                    student["tutorEmployeeId"] = ExpressionConverter.ConvertO(studenttutorEmployeeId);
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