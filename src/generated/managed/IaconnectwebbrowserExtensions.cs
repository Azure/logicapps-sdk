//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectwebbrowserActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetChromeBrowserVersionFromFile))]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> BrowserGetChromeBrowserVersionFromFile([WorkflowExpression] Func<string> browserGetChromeBrowserVersionFromFileworkflow, [WorkflowExpression] Func<string> browserGetChromeBrowserVersionFromFilechromeBrowserEXE = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> __BuildBrowserGetChromeBrowserVersionFromFile(WorkflowExpression<string> browserGetChromeBrowserVersionFromFileworkflow, WorkflowExpression<string> browserGetChromeBrowserVersionFromFilechromeBrowserEXE = null)
        {
            WorkflowExpression.Validate(browserGetChromeBrowserVersionFromFileworkflow, nameof(browserGetChromeBrowserVersionFromFileworkflow), required: true);
            WorkflowExpression.Validate(browserGetChromeBrowserVersionFromFilechromeBrowserEXE, nameof(browserGetChromeBrowserVersionFromFilechromeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromeBrowserVersionFromFileResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromeBrowserVersionFromFile = new JObject();
                var browserGetChromeBrowserVersionFromFilepropCount = 0;
                if (browserGetChromeBrowserVersionFromFilechromeBrowserEXE != null)
                {
                    browserGetChromeBrowserVersionFromFile["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromeBrowserVersionFromFilechromeBrowserEXE);
                    browserGetChromeBrowserVersionFromFilepropCount++;
                }

                browserGetChromeBrowserVersionFromFilepropCount++;
                browserGetChromeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(browserGetChromeBrowserVersionFromFileworkflow);
                if (browserGetChromeBrowserVersionFromFilepropCount > 0)
                {
                    callPayload.Body = browserGetChromeBrowserVersionFromFile;
                }

                return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetChromeDriverFolder))]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> BrowserGetChromeDriverFolder([WorkflowExpression] Func<string> browserGetChromeDriverFolderdirectoryPath, [WorkflowExpression] Func<string> browserGetChromeDriverFolderworkflow, [WorkflowExpression] Func<int> browserGetChromeDriverFolderchromeMajorVersion = null, [WorkflowExpression] Func<string> browserGetChromeDriverFolderchromeBrowserEXE = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> __BuildBrowserGetChromeDriverFolder(WorkflowExpression<string> browserGetChromeDriverFolderdirectoryPath, WorkflowExpression<string> browserGetChromeDriverFolderworkflow, WorkflowExpression<int> browserGetChromeDriverFolderchromeMajorVersion = null, WorkflowExpression<string> browserGetChromeDriverFolderchromeBrowserEXE = null)
        {
            WorkflowExpression.Validate(browserGetChromeDriverFolderdirectoryPath, nameof(browserGetChromeDriverFolderdirectoryPath), required: true);
            WorkflowExpression.Validate(browserGetChromeDriverFolderworkflow, nameof(browserGetChromeDriverFolderworkflow), required: true);
            WorkflowExpression.Validate(browserGetChromeDriverFolderchromeMajorVersion, nameof(browserGetChromeDriverFolderchromeMajorVersion), required: false);
            WorkflowExpression.Validate(browserGetChromeDriverFolderchromeBrowserEXE, nameof(browserGetChromeDriverFolderchromeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromeDriverFolderResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromeDriverFolder = new JObject();
                var browserGetChromeDriverFolderpropCount = 0;
                browserGetChromeDriverFolderpropCount++;
                browserGetChromeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderdirectoryPath);
                if (browserGetChromeDriverFolderchromeMajorVersion != null)
                {
                    browserGetChromeDriverFolder["ChromeMajorVersion"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderchromeMajorVersion);
                    browserGetChromeDriverFolderpropCount++;
                }

                if (browserGetChromeDriverFolderchromeBrowserEXE != null)
                {
                    browserGetChromeDriverFolder["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderchromeBrowserEXE);
                    browserGetChromeDriverFolderpropCount++;
                }

                browserGetChromeDriverFolderpropCount++;
                browserGetChromeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderworkflow);
                if (browserGetChromeDriverFolderpropCount > 0)
                {
                    callPayload.Body = browserGetChromeDriverFolder;
                }

                return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserDownloadSuitableChromeDriverFromInternet))]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> BrowserDownloadSuitableChromeDriverFromInternet([WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetworkflow, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = null, [WorkflowExpression] Func<bool> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = null, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = null, [WorkflowExpression] Func<bool> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = null, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = null, [WorkflowExpression] Func<bool> browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> __BuildBrowserDownloadSuitableChromeDriverFromInternet(WorkflowExpression<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, WorkflowExpression<string> browserDownloadSuitableChromeDriverFromInternetworkflow, WorkflowExpression<string> browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = null, WorkflowExpression<bool> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = null, WorkflowExpression<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = null, WorkflowExpression<bool> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = null, WorkflowExpression<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = null, WorkflowExpression<bool> browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = null)
        {
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder), required: true);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetworkflow, nameof(browserDownloadSuitableChromeDriverFromInternetworkflow), required: true);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE, nameof(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE), required: false);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex, nameof(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex), required: false);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL), required: false);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex, nameof(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex), required: false);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL), required: false);
            WorkflowExpression.Validate(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver, nameof(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver), required: false);
            return new DeferredBodyAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDownloadSuitableChromeDriverFromInternet = new JObject();
                var browserDownloadSuitableChromeDriverFromInternetpropCount = 0;
                if (browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder);
                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                {
                    if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = true;
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
                {
                    if (browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = "https://chromedriver.storage.googleapis.com/";
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
                {
                    if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = true;
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
                {
                    if (browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = "https://googlechromelabs.github.io/chrome-for-testing/latest-versions-per-milestone-with-downloads.json";
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
                {
                    if (browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = false;
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
                browserDownloadSuitableChromeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetworkflow);
                if (browserDownloadSuitableChromeDriverFromInternetpropCount > 0)
                {
                    callPayload.Body = browserDownloadSuitableChromeDriverFromInternet;
                }

                return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserIsSuitableChromeDriverAvailable))]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> BrowserIsSuitableChromeDriverAvailable([WorkflowExpression] Func<string> browserIsSuitableChromeDriverAvailableworkflow, [WorkflowExpression] Func<string> browserIsSuitableChromeDriverAvailablechromeDriverFolder = null, [WorkflowExpression] Func<string> browserIsSuitableChromeDriverAvailablechromeBrowserEXE = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> __BuildBrowserIsSuitableChromeDriverAvailable(WorkflowExpression<string> browserIsSuitableChromeDriverAvailableworkflow, WorkflowExpression<string> browserIsSuitableChromeDriverAvailablechromeDriverFolder = null, WorkflowExpression<string> browserIsSuitableChromeDriverAvailablechromeBrowserEXE = null)
        {
            WorkflowExpression.Validate(browserIsSuitableChromeDriverAvailableworkflow, nameof(browserIsSuitableChromeDriverAvailableworkflow), required: true);
            WorkflowExpression.Validate(browserIsSuitableChromeDriverAvailablechromeDriverFolder, nameof(browserIsSuitableChromeDriverAvailablechromeDriverFolder), required: false);
            WorkflowExpression.Validate(browserIsSuitableChromeDriverAvailablechromeBrowserEXE, nameof(browserIsSuitableChromeDriverAvailablechromeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserIsSuitableChromeDriverAvailableResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserIsSuitableChromeDriverAvailable = new JObject();
                var browserIsSuitableChromeDriverAvailablepropCount = 0;
                if (browserIsSuitableChromeDriverAvailablechromeDriverFolder != null)
                {
                    browserIsSuitableChromeDriverAvailable["ChromeDriverFolder"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailablechromeDriverFolder);
                    browserIsSuitableChromeDriverAvailablepropCount++;
                }

                if (browserIsSuitableChromeDriverAvailablechromeBrowserEXE != null)
                {
                    browserIsSuitableChromeDriverAvailable["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailablechromeBrowserEXE);
                    browserIsSuitableChromeDriverAvailablepropCount++;
                }

                browserIsSuitableChromeDriverAvailablepropCount++;
                browserIsSuitableChromeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailableworkflow);
                if (browserIsSuitableChromeDriverAvailablepropCount > 0)
                {
                    callPayload.Body = browserIsSuitableChromeDriverAvailable;
                }

                return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserUploadNewChromeDriver))]
        public IWorkflowAction BrowserUploadNewChromeDriver([WorkflowExpression] Func<string> browserUploadNewChromeDriverlocalChromeDriverFilePath, [WorkflowExpression] Func<string> browserUploadNewChromeDriverworkflow, [WorkflowExpression] Func<bool> browserUploadNewChromeDrivercompress = null, [WorkflowExpression] Func<int> browserUploadNewChromeDriverchromeBrowserMajorVersion = null, [WorkflowExpression] Func<string> browserUploadNewChromeDriverchromeDriverRootSaveFolder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserUploadNewChromeDriver(WorkflowExpression<string> browserUploadNewChromeDriverlocalChromeDriverFilePath, WorkflowExpression<string> browserUploadNewChromeDriverworkflow, WorkflowExpression<bool> browserUploadNewChromeDrivercompress = null, WorkflowExpression<int> browserUploadNewChromeDriverchromeBrowserMajorVersion = null, WorkflowExpression<string> browserUploadNewChromeDriverchromeDriverRootSaveFolder = null)
        {
            WorkflowExpression.Validate(browserUploadNewChromeDriverlocalChromeDriverFilePath, nameof(browserUploadNewChromeDriverlocalChromeDriverFilePath), required: true);
            WorkflowExpression.Validate(browserUploadNewChromeDriverworkflow, nameof(browserUploadNewChromeDriverworkflow), required: true);
            WorkflowExpression.Validate(browserUploadNewChromeDrivercompress, nameof(browserUploadNewChromeDrivercompress), required: false);
            WorkflowExpression.Validate(browserUploadNewChromeDriverchromeBrowserMajorVersion, nameof(browserUploadNewChromeDriverchromeBrowserMajorVersion), required: false);
            WorkflowExpression.Validate(browserUploadNewChromeDriverchromeDriverRootSaveFolder, nameof(browserUploadNewChromeDriverchromeDriverRootSaveFolder), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserUploadNewChromeDriver = new JObject();
                var browserUploadNewChromeDriverpropCount = 0;
                browserUploadNewChromeDriverpropCount++;
                browserUploadNewChromeDriver["LocalChromeDriverFilePath"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverlocalChromeDriverFilePath);
                if (browserUploadNewChromeDrivercompress != null)
                {
                    if (browserUploadNewChromeDrivercompress != null)
                    {
                        browserUploadNewChromeDriver["Compress"] = ExpressionConverter.ConvertO(browserUploadNewChromeDrivercompress);
                        browserUploadNewChromeDriverpropCount++;
                    }

                    browserUploadNewChromeDriverpropCount++;
                }
                else
                {
                    browserUploadNewChromeDriver["Compress"] = false;
                    browserUploadNewChromeDriverpropCount++;
                }

                if (browserUploadNewChromeDriverchromeBrowserMajorVersion != null)
                {
                    browserUploadNewChromeDriver["ChromeBrowserMajorVersion"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverchromeBrowserMajorVersion);
                    browserUploadNewChromeDriverpropCount++;
                }

                if (browserUploadNewChromeDriverchromeDriverRootSaveFolder != null)
                {
                    browserUploadNewChromeDriver["ChromeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverchromeDriverRootSaveFolder);
                    browserUploadNewChromeDriverpropCount++;
                }

                browserUploadNewChromeDriverpropCount++;
                browserUploadNewChromeDriver["Workflow"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverworkflow);
                if (browserUploadNewChromeDriverpropCount > 0)
                {
                    callPayload.Body = browserUploadNewChromeDriver;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserOpenChrome))]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> BrowserOpenChrome([WorkflowExpression] Func<string> browserOpenChromeworkflow, [WorkflowExpression] Func<string> browserOpenChromechromeDriverFolder = null, [WorkflowExpression] Func<bool> browserOpenChromekillExistingChromeDriver = null, [WorkflowExpression] Func<string> browserOpenChromeuserDataDir = null, [WorkflowExpression] Func<bool> browserOpenChromeprintToDefaultPrinter = null, [WorkflowExpression] Func<string> browserOpenChromedefaultDownloadDirectory = null, [WorkflowExpression] Func<bool> browserOpenChromedownloadPDFInsteadOfOpening = null, [WorkflowExpression] Func<string> browserOpenChromechromeDriverLogFilename = null, [WorkflowExpression] Func<string> browserOpenChromelocalChromeDriverFolder = null, [WorkflowExpression] Func<string> browserOpenChromechromeBrowserEXE = null, [WorkflowExpression] Func<bool> browserOpenChromeignoreCertificateErrors = null, [WorkflowExpression] Func<string> browserOpenChromeadditionalArguments = null, [WorkflowExpression] Func<bool> browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> __BuildBrowserOpenChrome(WorkflowExpression<string> browserOpenChromeworkflow, WorkflowExpression<string> browserOpenChromechromeDriverFolder = null, WorkflowExpression<bool> browserOpenChromekillExistingChromeDriver = null, WorkflowExpression<string> browserOpenChromeuserDataDir = null, WorkflowExpression<bool> browserOpenChromeprintToDefaultPrinter = null, WorkflowExpression<string> browserOpenChromedefaultDownloadDirectory = null, WorkflowExpression<bool> browserOpenChromedownloadPDFInsteadOfOpening = null, WorkflowExpression<string> browserOpenChromechromeDriverLogFilename = null, WorkflowExpression<string> browserOpenChromelocalChromeDriverFolder = null, WorkflowExpression<string> browserOpenChromechromeBrowserEXE = null, WorkflowExpression<bool> browserOpenChromeignoreCertificateErrors = null, WorkflowExpression<string> browserOpenChromeadditionalArguments = null, WorkflowExpression<bool> browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = null)
        {
            WorkflowExpression.Validate(browserOpenChromeworkflow, nameof(browserOpenChromeworkflow), required: true);
            WorkflowExpression.Validate(browserOpenChromechromeDriverFolder, nameof(browserOpenChromechromeDriverFolder), required: false);
            WorkflowExpression.Validate(browserOpenChromekillExistingChromeDriver, nameof(browserOpenChromekillExistingChromeDriver), required: false);
            WorkflowExpression.Validate(browserOpenChromeuserDataDir, nameof(browserOpenChromeuserDataDir), required: false);
            WorkflowExpression.Validate(browserOpenChromeprintToDefaultPrinter, nameof(browserOpenChromeprintToDefaultPrinter), required: false);
            WorkflowExpression.Validate(browserOpenChromedefaultDownloadDirectory, nameof(browserOpenChromedefaultDownloadDirectory), required: false);
            WorkflowExpression.Validate(browserOpenChromedownloadPDFInsteadOfOpening, nameof(browserOpenChromedownloadPDFInsteadOfOpening), required: false);
            WorkflowExpression.Validate(browserOpenChromechromeDriverLogFilename, nameof(browserOpenChromechromeDriverLogFilename), required: false);
            WorkflowExpression.Validate(browserOpenChromelocalChromeDriverFolder, nameof(browserOpenChromelocalChromeDriverFolder), required: false);
            WorkflowExpression.Validate(browserOpenChromechromeBrowserEXE, nameof(browserOpenChromechromeBrowserEXE), required: false);
            WorkflowExpression.Validate(browserOpenChromeignoreCertificateErrors, nameof(browserOpenChromeignoreCertificateErrors), required: false);
            WorkflowExpression.Validate(browserOpenChromeadditionalArguments, nameof(browserOpenChromeadditionalArguments), required: false);
            WorkflowExpression.Validate(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen, nameof(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen), required: false);
            return new DeferredBodyAction<BrowserOpenChromeResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenChrome = new JObject();
                var browserOpenChromepropCount = 0;
                if (browserOpenChromechromeDriverFolder != null)
                {
                    browserOpenChrome["ChromeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromechromeDriverFolder);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromekillExistingChromeDriver != null)
                {
                    if (browserOpenChromekillExistingChromeDriver != null)
                    {
                        browserOpenChrome["KillExistingChromeDriver"] = ExpressionConverter.ConvertO(browserOpenChromekillExistingChromeDriver);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["KillExistingChromeDriver"] = true;
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromeuserDataDir != null)
                {
                    browserOpenChrome["UserDataDir"] = ExpressionConverter.ConvertO(browserOpenChromeuserDataDir);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromeprintToDefaultPrinter != null)
                {
                    if (browserOpenChromeprintToDefaultPrinter != null)
                    {
                        browserOpenChrome["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(browserOpenChromeprintToDefaultPrinter);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["PrintToDefaultPrinter"] = true;
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromedefaultDownloadDirectory != null)
                {
                    browserOpenChrome["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(browserOpenChromedefaultDownloadDirectory);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromedownloadPDFInsteadOfOpening != null)
                {
                    if (browserOpenChromedownloadPDFInsteadOfOpening != null)
                    {
                        browserOpenChrome["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(browserOpenChromedownloadPDFInsteadOfOpening);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["DownloadPDFInsteadOfOpening"] = false;
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromechromeDriverLogFilename != null)
                {
                    browserOpenChrome["ChromeDriverLogFilename"] = ExpressionConverter.ConvertO(browserOpenChromechromeDriverLogFilename);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromelocalChromeDriverFolder != null)
                {
                    browserOpenChrome["LocalChromeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromelocalChromeDriverFolder);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromechromeBrowserEXE != null)
                {
                    browserOpenChrome["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserOpenChromechromeBrowserEXE);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromeignoreCertificateErrors != null)
                {
                    if (browserOpenChromeignoreCertificateErrors != null)
                    {
                        browserOpenChrome["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(browserOpenChromeignoreCertificateErrors);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["IgnoreCertificateErrors"] = false;
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromeadditionalArguments != null)
                {
                    browserOpenChrome["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenChromeadditionalArguments);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                {
                    if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                    {
                        browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = false;
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
                browserOpenChrome["Workflow"] = ExpressionConverter.ConvertO(browserOpenChromeworkflow);
                if (browserOpenChromepropCount > 0)
                {
                    callPayload.Body = browserOpenChrome;
                }

                return new ApiConnectionAction<BrowserOpenChromeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCloseChrome))]
        public IWorkflowAction BrowserCloseChrome([WorkflowExpression] Func<string> browserCloseChromeworkflow, [WorkflowExpression] Func<bool> browserCloseChromepurgeDynamicUserDataDir = null, [WorkflowExpression] Func<bool> browserCloseChromepurgeStaticUserDataDir = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCloseChrome(WorkflowExpression<string> browserCloseChromeworkflow, WorkflowExpression<bool> browserCloseChromepurgeDynamicUserDataDir = null, WorkflowExpression<bool> browserCloseChromepurgeStaticUserDataDir = null)
        {
            WorkflowExpression.Validate(browserCloseChromeworkflow, nameof(browserCloseChromeworkflow), required: true);
            WorkflowExpression.Validate(browserCloseChromepurgeDynamicUserDataDir, nameof(browserCloseChromepurgeDynamicUserDataDir), required: false);
            WorkflowExpression.Validate(browserCloseChromepurgeStaticUserDataDir, nameof(browserCloseChromepurgeStaticUserDataDir), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseChrome = new JObject();
                var browserCloseChromepropCount = 0;
                if (browserCloseChromepurgeDynamicUserDataDir != null)
                {
                    if (browserCloseChromepurgeDynamicUserDataDir != null)
                    {
                        browserCloseChrome["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromepurgeDynamicUserDataDir);
                        browserCloseChromepropCount++;
                    }

                    browserCloseChromepropCount++;
                }
                else
                {
                    browserCloseChrome["PurgeDynamicUserDataDir"] = true;
                    browserCloseChromepropCount++;
                }

                if (browserCloseChromepurgeStaticUserDataDir != null)
                {
                    if (browserCloseChromepurgeStaticUserDataDir != null)
                    {
                        browserCloseChrome["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromepurgeStaticUserDataDir);
                        browserCloseChromepropCount++;
                    }

                    browserCloseChromepropCount++;
                }
                else
                {
                    browserCloseChrome["PurgeStaticUserDataDir"] = false;
                    browserCloseChromepropCount++;
                }

                browserCloseChromepropCount++;
                browserCloseChrome["Workflow"] = ExpressionConverter.ConvertO(browserCloseChromeworkflow);
                if (browserCloseChromepropCount > 0)
                {
                    callPayload.Body = browserCloseChrome;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserOpenInternetExplorer))]
        public IWorkflowAction BrowserOpenInternetExplorer([WorkflowExpression] Func<string> browserOpenInternetExplorerworkflow, [WorkflowExpression] Func<string> browserOpenInternetExploreriEDriverFolder = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerkillExistingIEDriver = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerkillExistingIE = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorercleanSession = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerenableNativeEvents = null, [WorkflowExpression] Func<string> browserOpenInternetExplorerwebDriverLogFile = null, [WorkflowExpression] Func<string> browserOpenInternetExplorerwebDriverLogLevel = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerdisableIEFirstRunCustomise = null, [WorkflowExpression] Func<string> browserOpenInternetExploreradditionalArguments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserOpenInternetExplorer(WorkflowExpression<string> browserOpenInternetExplorerworkflow, WorkflowExpression<string> browserOpenInternetExploreriEDriverFolder = null, WorkflowExpression<bool> browserOpenInternetExplorerkillExistingIEDriver = null, WorkflowExpression<bool> browserOpenInternetExplorerkillExistingIE = null, WorkflowExpression<bool> browserOpenInternetExplorercleanSession = null, WorkflowExpression<bool> browserOpenInternetExplorerenableNativeEvents = null, WorkflowExpression<string> browserOpenInternetExplorerwebDriverLogFile = null, WorkflowExpression<string> browserOpenInternetExplorerwebDriverLogLevel = null, WorkflowExpression<bool> browserOpenInternetExplorerdisableIEFirstRunCustomise = null, WorkflowExpression<string> browserOpenInternetExploreradditionalArguments = null)
        {
            WorkflowExpression.Validate(browserOpenInternetExplorerworkflow, nameof(browserOpenInternetExplorerworkflow), required: true);
            WorkflowExpression.Validate(browserOpenInternetExploreriEDriverFolder, nameof(browserOpenInternetExploreriEDriverFolder), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorerkillExistingIEDriver, nameof(browserOpenInternetExplorerkillExistingIEDriver), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorerkillExistingIE, nameof(browserOpenInternetExplorerkillExistingIE), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorercleanSession, nameof(browserOpenInternetExplorercleanSession), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorerenableNativeEvents, nameof(browserOpenInternetExplorerenableNativeEvents), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorerwebDriverLogFile, nameof(browserOpenInternetExplorerwebDriverLogFile), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorerwebDriverLogLevel, nameof(browserOpenInternetExplorerwebDriverLogLevel), required: false);
            WorkflowExpression.Validate(browserOpenInternetExplorerdisableIEFirstRunCustomise, nameof(browserOpenInternetExplorerdisableIEFirstRunCustomise), required: false);
            WorkflowExpression.Validate(browserOpenInternetExploreradditionalArguments, nameof(browserOpenInternetExploreradditionalArguments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/OpenInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenInternetExplorer = new JObject();
                var browserOpenInternetExplorerpropCount = 0;
                if (browserOpenInternetExploreriEDriverFolder != null)
                {
                    browserOpenInternetExplorer["IEDriverFolder"] = ExpressionConverter.ConvertO(browserOpenInternetExploreriEDriverFolder);
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerkillExistingIEDriver != null)
                {
                    if (browserOpenInternetExplorerkillExistingIEDriver != null)
                    {
                        browserOpenInternetExplorer["KillExistingIEDriver"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerkillExistingIEDriver);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["KillExistingIEDriver"] = false;
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerkillExistingIE != null)
                {
                    if (browserOpenInternetExplorerkillExistingIE != null)
                    {
                        browserOpenInternetExplorer["KillExistingIE"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerkillExistingIE);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["KillExistingIE"] = true;
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorercleanSession != null)
                {
                    if (browserOpenInternetExplorercleanSession != null)
                    {
                        browserOpenInternetExplorer["CleanSession"] = ExpressionConverter.ConvertO(browserOpenInternetExplorercleanSession);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["CleanSession"] = false;
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerenableNativeEvents != null)
                {
                    if (browserOpenInternetExplorerenableNativeEvents != null)
                    {
                        browserOpenInternetExplorer["EnableNativeEvents"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerenableNativeEvents);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["EnableNativeEvents"] = true;
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerwebDriverLogFile != null)
                {
                    browserOpenInternetExplorer["WebDriverLogFile"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerwebDriverLogFile);
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerwebDriverLogLevel != null)
                {
                    browserOpenInternetExplorer["WebDriverLogLevel"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerwebDriverLogLevel);
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                {
                    if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                    {
                        browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerdisableIEFirstRunCustomise);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = true;
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExploreradditionalArguments != null)
                {
                    browserOpenInternetExplorer["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenInternetExploreradditionalArguments);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
                browserOpenInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerworkflow);
                if (browserOpenInternetExplorerpropCount > 0)
                {
                    callPayload.Body = browserOpenInternetExplorer;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCloseInternetExplorer))]
        public IWorkflowAction BrowserCloseInternetExplorer([WorkflowExpression] Func<string> browserCloseInternetExplorerworkflow, [WorkflowExpression] Func<bool> browserCloseInternetExplorerunloadIEDriver = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCloseInternetExplorer(WorkflowExpression<string> browserCloseInternetExplorerworkflow, WorkflowExpression<bool> browserCloseInternetExplorerunloadIEDriver = null)
        {
            WorkflowExpression.Validate(browserCloseInternetExplorerworkflow, nameof(browserCloseInternetExplorerworkflow), required: true);
            WorkflowExpression.Validate(browserCloseInternetExplorerunloadIEDriver, nameof(browserCloseInternetExplorerunloadIEDriver), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseInternetExplorer = new JObject();
                var browserCloseInternetExplorerpropCount = 0;
                if (browserCloseInternetExplorerunloadIEDriver != null)
                {
                    if (browserCloseInternetExplorerunloadIEDriver != null)
                    {
                        browserCloseInternetExplorer["UnloadIEDriver"] = ExpressionConverter.ConvertO(browserCloseInternetExplorerunloadIEDriver);
                        browserCloseInternetExplorerpropCount++;
                    }

                    browserCloseInternetExplorerpropCount++;
                }
                else
                {
                    browserCloseInternetExplorer["UnloadIEDriver"] = false;
                    browserCloseInternetExplorerpropCount++;
                }

                browserCloseInternetExplorerpropCount++;
                browserCloseInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(browserCloseInternetExplorerworkflow);
                if (browserCloseInternetExplorerpropCount > 0)
                {
                    callPayload.Body = browserCloseInternetExplorer;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetChromiumEdgeDriverFolder))]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> BrowserGetChromiumEdgeDriverFolder([WorkflowExpression] Func<string> browserGetChromiumEdgeDriverFolderdirectoryPath, [WorkflowExpression] Func<string> browserGetChromiumEdgeDriverFolderworkflow, [WorkflowExpression] Func<int> browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = null, [WorkflowExpression] Func<string> browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> __BuildBrowserGetChromiumEdgeDriverFolder(WorkflowExpression<string> browserGetChromiumEdgeDriverFolderdirectoryPath, WorkflowExpression<string> browserGetChromiumEdgeDriverFolderworkflow, WorkflowExpression<int> browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = null, WorkflowExpression<string> browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = null)
        {
            WorkflowExpression.Validate(browserGetChromiumEdgeDriverFolderdirectoryPath, nameof(browserGetChromiumEdgeDriverFolderdirectoryPath), required: true);
            WorkflowExpression.Validate(browserGetChromiumEdgeDriverFolderworkflow, nameof(browserGetChromiumEdgeDriverFolderworkflow), required: true);
            WorkflowExpression.Validate(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion, nameof(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion), required: false);
            WorkflowExpression.Validate(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE, nameof(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromiumEdgeDriverFolderResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromiumEdgeDriverFolder = new JObject();
                var browserGetChromiumEdgeDriverFolderpropCount = 0;
                browserGetChromiumEdgeDriverFolderpropCount++;
                browserGetChromiumEdgeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderdirectoryPath);
                if (browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion != null)
                {
                    browserGetChromiumEdgeDriverFolder["ChromiumEdgeMajorVersion"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion);
                    browserGetChromiumEdgeDriverFolderpropCount++;
                }

                if (browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE != null)
                {
                    browserGetChromiumEdgeDriverFolder["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE);
                    browserGetChromiumEdgeDriverFolderpropCount++;
                }

                browserGetChromiumEdgeDriverFolderpropCount++;
                browserGetChromiumEdgeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderworkflow);
                if (browserGetChromiumEdgeDriverFolderpropCount > 0)
                {
                    callPayload.Body = browserGetChromiumEdgeDriverFolder;
                }

                return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetChromiumEdgeBrowserVersionFromFile))]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> BrowserGetChromiumEdgeBrowserVersionFromFile([WorkflowExpression] Func<string> browserGetChromiumEdgeBrowserVersionFromFileworkflow, [WorkflowExpression] Func<string> browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> __BuildBrowserGetChromiumEdgeBrowserVersionFromFile(WorkflowExpression<string> browserGetChromiumEdgeBrowserVersionFromFileworkflow, WorkflowExpression<string> browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = null)
        {
            WorkflowExpression.Validate(browserGetChromiumEdgeBrowserVersionFromFileworkflow, nameof(browserGetChromiumEdgeBrowserVersionFromFileworkflow), required: true);
            WorkflowExpression.Validate(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE, nameof(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromiumEdgeBrowserVersionFromFile = new JObject();
                var browserGetChromiumEdgeBrowserVersionFromFilepropCount = 0;
                if (browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE != null)
                {
                    browserGetChromiumEdgeBrowserVersionFromFile["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE);
                    browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
                }

                browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
                browserGetChromiumEdgeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeBrowserVersionFromFileworkflow);
                if (browserGetChromiumEdgeBrowserVersionFromFilepropCount > 0)
                {
                    callPayload.Body = browserGetChromiumEdgeBrowserVersionFromFile;
                }

                return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserDownloadSuitableChromiumEdgeDriverFromInternet))]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> BrowserDownloadSuitableChromiumEdgeDriverFromInternet([WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, [WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, [WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = null, [WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> __BuildBrowserDownloadSuitableChromiumEdgeDriverFromInternet(WorkflowExpression<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, WorkflowExpression<string> browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, WorkflowExpression<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = null, WorkflowExpression<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = null)
        {
            WorkflowExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder), required: true);
            WorkflowExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow), required: true);
            WorkflowExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE), required: false);
            WorkflowExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL), required: false);
            return new DeferredBodyAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDownloadSuitableChromiumEdgeDriverFromInternet = new JObject();
                var browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount = 0;
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE != null)
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE);
                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder);
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                {
                    if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                    {
                        browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL);
                        browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = "https://msedgewebdriverstorage.blob.core.windows.net/edgewebdriver/";
                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                browserDownloadSuitableChromiumEdgeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow);
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount > 0)
                {
                    callPayload.Body = browserDownloadSuitableChromiumEdgeDriverFromInternet;
                }

                return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserIsSuitableChromiumEdgeDriverAvailable))]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> BrowserIsSuitableChromiumEdgeDriverAvailable([WorkflowExpression] Func<string> browserIsSuitableChromiumEdgeDriverAvailableworkflow, [WorkflowExpression] Func<string> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = null, [WorkflowExpression] Func<string> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> __BuildBrowserIsSuitableChromiumEdgeDriverAvailable(WorkflowExpression<string> browserIsSuitableChromiumEdgeDriverAvailableworkflow, WorkflowExpression<string> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = null, WorkflowExpression<string> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = null)
        {
            WorkflowExpression.Validate(browserIsSuitableChromiumEdgeDriverAvailableworkflow, nameof(browserIsSuitableChromiumEdgeDriverAvailableworkflow), required: true);
            WorkflowExpression.Validate(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder, nameof(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder), required: false);
            WorkflowExpression.Validate(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE, nameof(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserIsSuitableChromiumEdgeDriverAvailable = new JObject();
                var browserIsSuitableChromiumEdgeDriverAvailablepropCount = 0;
                if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder != null)
                {
                    browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder);
                    browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                }

                if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE != null)
                {
                    browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE);
                    browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                }

                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                browserIsSuitableChromiumEdgeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailableworkflow);
                if (browserIsSuitableChromiumEdgeDriverAvailablepropCount > 0)
                {
                    callPayload.Body = browserIsSuitableChromiumEdgeDriverAvailable;
                }

                return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserUploadNewChromiumEdgeDriver))]
        public IWorkflowAction BrowserUploadNewChromiumEdgeDriver([WorkflowExpression] Func<string> browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, [WorkflowExpression] Func<string> browserUploadNewChromiumEdgeDriverworkflow, [WorkflowExpression] Func<bool> browserUploadNewChromiumEdgeDrivercompress = null, [WorkflowExpression] Func<int> browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = null, [WorkflowExpression] Func<string> browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserUploadNewChromiumEdgeDriver(WorkflowExpression<string> browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, WorkflowExpression<string> browserUploadNewChromiumEdgeDriverworkflow, WorkflowExpression<bool> browserUploadNewChromiumEdgeDrivercompress = null, WorkflowExpression<int> browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = null, WorkflowExpression<string> browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = null)
        {
            WorkflowExpression.Validate(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, nameof(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath), required: true);
            WorkflowExpression.Validate(browserUploadNewChromiumEdgeDriverworkflow, nameof(browserUploadNewChromiumEdgeDriverworkflow), required: true);
            WorkflowExpression.Validate(browserUploadNewChromiumEdgeDrivercompress, nameof(browserUploadNewChromiumEdgeDrivercompress), required: false);
            WorkflowExpression.Validate(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion, nameof(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion), required: false);
            WorkflowExpression.Validate(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder, nameof(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserUploadNewChromiumEdgeDriver = new JObject();
                var browserUploadNewChromiumEdgeDriverpropCount = 0;
                browserUploadNewChromiumEdgeDriverpropCount++;
                browserUploadNewChromiumEdgeDriver["LocalChromiumEdgeDriverFilePath"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath);
                if (browserUploadNewChromiumEdgeDrivercompress != null)
                {
                    if (browserUploadNewChromiumEdgeDrivercompress != null)
                    {
                        browserUploadNewChromiumEdgeDriver["Compress"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDrivercompress);
                        browserUploadNewChromiumEdgeDriverpropCount++;
                    }

                    browserUploadNewChromiumEdgeDriverpropCount++;
                }
                else
                {
                    browserUploadNewChromiumEdgeDriver["Compress"] = false;
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                if (browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion != null)
                {
                    browserUploadNewChromiumEdgeDriver["ChromiumEdgeBrowserMajorVersion"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                if (browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder != null)
                {
                    browserUploadNewChromiumEdgeDriver["ChromiumEdgeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                browserUploadNewChromiumEdgeDriverpropCount++;
                browserUploadNewChromiumEdgeDriver["Workflow"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverworkflow);
                if (browserUploadNewChromiumEdgeDriverpropCount > 0)
                {
                    callPayload.Body = browserUploadNewChromiumEdgeDriver;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserOpenChromiumEdge))]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> BrowserOpenChromiumEdge([WorkflowExpression] Func<string> browserOpenChromiumEdgeworkflow, [WorkflowExpression] Func<string> browserOpenChromiumEdgechromiumEdgeDriverFolder = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgeuserDataDir = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgekillExistingChromiumEdgeDriver = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgeprintToDefaultPrinter = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgedefaultDownloadDirectory = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgedownloadPDFInsteadOfOpening = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgechromiumEdgeDriverLogFilename = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgechromiumEdgeBrowserEXE = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgeignoreCertificateErrors = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgeadditionalArguments = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> __BuildBrowserOpenChromiumEdge(WorkflowExpression<string> browserOpenChromiumEdgeworkflow, WorkflowExpression<string> browserOpenChromiumEdgechromiumEdgeDriverFolder = null, WorkflowExpression<string> browserOpenChromiumEdgeuserDataDir = null, WorkflowExpression<bool> browserOpenChromiumEdgekillExistingChromiumEdgeDriver = null, WorkflowExpression<bool> browserOpenChromiumEdgeprintToDefaultPrinter = null, WorkflowExpression<string> browserOpenChromiumEdgedefaultDownloadDirectory = null, WorkflowExpression<bool> browserOpenChromiumEdgedownloadPDFInsteadOfOpening = null, WorkflowExpression<string> browserOpenChromiumEdgechromiumEdgeDriverLogFilename = null, WorkflowExpression<string> browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = null, WorkflowExpression<bool> browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = null, WorkflowExpression<string> browserOpenChromiumEdgechromiumEdgeBrowserEXE = null, WorkflowExpression<bool> browserOpenChromiumEdgeignoreCertificateErrors = null, WorkflowExpression<string> browserOpenChromiumEdgeadditionalArguments = null, WorkflowExpression<bool> browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            WorkflowExpression.Validate(browserOpenChromiumEdgeworkflow, nameof(browserOpenChromiumEdgeworkflow), required: true);
            WorkflowExpression.Validate(browserOpenChromiumEdgechromiumEdgeDriverFolder, nameof(browserOpenChromiumEdgechromiumEdgeDriverFolder), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgeuserDataDir, nameof(browserOpenChromiumEdgeuserDataDir), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgekillExistingChromiumEdgeDriver, nameof(browserOpenChromiumEdgekillExistingChromiumEdgeDriver), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgeprintToDefaultPrinter, nameof(browserOpenChromiumEdgeprintToDefaultPrinter), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgedefaultDownloadDirectory, nameof(browserOpenChromiumEdgedefaultDownloadDirectory), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgedownloadPDFInsteadOfOpening, nameof(browserOpenChromiumEdgedownloadPDFInsteadOfOpening), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgechromiumEdgeDriverLogFilename, nameof(browserOpenChromiumEdgechromiumEdgeDriverLogFilename), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder, nameof(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage, nameof(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgechromiumEdgeBrowserEXE, nameof(browserOpenChromiumEdgechromiumEdgeBrowserEXE), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgeignoreCertificateErrors, nameof(browserOpenChromiumEdgeignoreCertificateErrors), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgeadditionalArguments, nameof(browserOpenChromiumEdgeadditionalArguments), required: false);
            WorkflowExpression.Validate(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen, nameof(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen), required: false);
            return new DeferredBodyAction<BrowserOpenChromiumEdgeResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenChromiumEdge = new JObject();
                var browserOpenChromiumEdgepropCount = 0;
                if (browserOpenChromiumEdgechromiumEdgeDriverFolder != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgechromiumEdgeDriverFolder);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgeuserDataDir != null)
                {
                    browserOpenChromiumEdge["UserDataDir"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeuserDataDir);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                {
                    if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                    {
                        browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgekillExistingChromiumEdgeDriver);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = true;
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgeprintToDefaultPrinter != null)
                {
                    if (browserOpenChromiumEdgeprintToDefaultPrinter != null)
                    {
                        browserOpenChromiumEdge["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeprintToDefaultPrinter);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["PrintToDefaultPrinter"] = true;
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgedefaultDownloadDirectory != null)
                {
                    browserOpenChromiumEdge["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgedefaultDownloadDirectory);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                {
                    if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                    {
                        browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgedownloadPDFInsteadOfOpening);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = false;
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgechromiumEdgeDriverLogFilename != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeDriverLogFilename"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgechromiumEdgeDriverLogFilename);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgelocalChromiumEdgeDriverFolder != null)
                {
                    browserOpenChromiumEdge["LocalChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                {
                    if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                    {
                        browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = true;
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgechromiumEdgeBrowserEXE != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgechromiumEdgeBrowserEXE);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgeignoreCertificateErrors != null)
                {
                    if (browserOpenChromiumEdgeignoreCertificateErrors != null)
                    {
                        browserOpenChromiumEdge["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeignoreCertificateErrors);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["IgnoreCertificateErrors"] = false;
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgeadditionalArguments != null)
                {
                    browserOpenChromiumEdge["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeadditionalArguments);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                {
                    if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                    {
                        browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = false;
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
                browserOpenChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeworkflow);
                if (browserOpenChromiumEdgepropCount > 0)
                {
                    callPayload.Body = browserOpenChromiumEdge;
                }

                return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCloseChromiumEdge))]
        public IWorkflowAction BrowserCloseChromiumEdge([WorkflowExpression] Func<string> browserCloseChromiumEdgeworkflow, [WorkflowExpression] Func<bool> browserCloseChromiumEdgepurgeDynamicUserDataDir = null, [WorkflowExpression] Func<bool> browserCloseChromiumEdgepurgeStaticUserDataDir = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCloseChromiumEdge(WorkflowExpression<string> browserCloseChromiumEdgeworkflow, WorkflowExpression<bool> browserCloseChromiumEdgepurgeDynamicUserDataDir = null, WorkflowExpression<bool> browserCloseChromiumEdgepurgeStaticUserDataDir = null)
        {
            WorkflowExpression.Validate(browserCloseChromiumEdgeworkflow, nameof(browserCloseChromiumEdgeworkflow), required: true);
            WorkflowExpression.Validate(browserCloseChromiumEdgepurgeDynamicUserDataDir, nameof(browserCloseChromiumEdgepurgeDynamicUserDataDir), required: false);
            WorkflowExpression.Validate(browserCloseChromiumEdgepurgeStaticUserDataDir, nameof(browserCloseChromiumEdgepurgeStaticUserDataDir), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseChromiumEdge = new JObject();
                var browserCloseChromiumEdgepropCount = 0;
                if (browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
                {
                    if (browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
                    {
                        browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgepurgeDynamicUserDataDir);
                        browserCloseChromiumEdgepropCount++;
                    }

                    browserCloseChromiumEdgepropCount++;
                }
                else
                {
                    browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = true;
                    browserCloseChromiumEdgepropCount++;
                }

                if (browserCloseChromiumEdgepurgeStaticUserDataDir != null)
                {
                    if (browserCloseChromiumEdgepurgeStaticUserDataDir != null)
                    {
                        browserCloseChromiumEdge["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgepurgeStaticUserDataDir);
                        browserCloseChromiumEdgepropCount++;
                    }

                    browserCloseChromiumEdgepropCount++;
                }
                else
                {
                    browserCloseChromiumEdge["PurgeStaticUserDataDir"] = false;
                    browserCloseChromiumEdgepropCount++;
                }

                browserCloseChromiumEdgepropCount++;
                browserCloseChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgeworkflow);
                if (browserCloseChromiumEdgepropCount > 0)
                {
                    callPayload.Body = browserCloseChromiumEdge;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserMaximise))]
        public IWorkflowAction BrowserMaximise([WorkflowExpression] Func<string> browserMaximiseworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserMaximise(WorkflowExpression<string> browserMaximiseworkflow)
        {
            WorkflowExpression.Validate(browserMaximiseworkflow, nameof(browserMaximiseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MaximiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMaximise = new JObject();
                var browserMaximisepropCount = 0;
                browserMaximisepropCount++;
                browserMaximise["Workflow"] = ExpressionConverter.ConvertO(browserMaximiseworkflow);
                if (browserMaximisepropCount > 0)
                {
                    callPayload.Body = browserMaximise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserMinimise))]
        public IWorkflowAction BrowserMinimise([WorkflowExpression] Func<string> browserMinimiseworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserMinimise(WorkflowExpression<string> browserMinimiseworkflow)
        {
            WorkflowExpression.Validate(browserMinimiseworkflow, nameof(browserMinimiseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MinimiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMinimise = new JObject();
                var browserMinimisepropCount = 0;
                browserMinimisepropCount++;
                browserMinimise["Workflow"] = ExpressionConverter.ConvertO(browserMinimiseworkflow);
                if (browserMinimisepropCount > 0)
                {
                    callPayload.Body = browserMinimise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserFullscreen))]
        public IWorkflowAction BrowserFullscreen([WorkflowExpression] Func<string> browserFullscreenworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserFullscreen(WorkflowExpression<string> browserFullscreenworkflow)
        {
            WorkflowExpression.Validate(browserFullscreenworkflow, nameof(browserFullscreenworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/FullscreenBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserFullscreen = new JObject();
                var browserFullscreenpropCount = 0;
                browserFullscreenpropCount++;
                browserFullscreen["Workflow"] = ExpressionConverter.ConvertO(browserFullscreenworkflow);
                if (browserFullscreenpropCount > 0)
                {
                    callPayload.Body = browserFullscreen;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserNormaliseBrowser))]
        public IWorkflowAction BrowserNormaliseBrowser([WorkflowExpression] Func<string> browserNormaliseBrowserworkflow, [WorkflowExpression] Func<int> browserNormaliseBrowserx = null, [WorkflowExpression] Func<int> browserNormaliseBrowsery = null, [WorkflowExpression] Func<int> browserNormaliseBrowserwidth = null, [WorkflowExpression] Func<int> browserNormaliseBrowserheight = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserNormaliseBrowser(WorkflowExpression<string> browserNormaliseBrowserworkflow, WorkflowExpression<int> browserNormaliseBrowserx = null, WorkflowExpression<int> browserNormaliseBrowsery = null, WorkflowExpression<int> browserNormaliseBrowserwidth = null, WorkflowExpression<int> browserNormaliseBrowserheight = null)
        {
            WorkflowExpression.Validate(browserNormaliseBrowserworkflow, nameof(browserNormaliseBrowserworkflow), required: true);
            WorkflowExpression.Validate(browserNormaliseBrowserx, nameof(browserNormaliseBrowserx), required: false);
            WorkflowExpression.Validate(browserNormaliseBrowsery, nameof(browserNormaliseBrowsery), required: false);
            WorkflowExpression.Validate(browserNormaliseBrowserwidth, nameof(browserNormaliseBrowserwidth), required: false);
            WorkflowExpression.Validate(browserNormaliseBrowserheight, nameof(browserNormaliseBrowserheight), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/NormaliseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserNormaliseBrowser = new JObject();
                var browserNormaliseBrowserpropCount = 0;
                if (browserNormaliseBrowserx != null)
                {
                    if (browserNormaliseBrowserx != null)
                    {
                        browserNormaliseBrowser["X"] = ExpressionConverter.ConvertO(browserNormaliseBrowserx);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["X"] = 20;
                    browserNormaliseBrowserpropCount++;
                }

                if (browserNormaliseBrowsery != null)
                {
                    if (browserNormaliseBrowsery != null)
                    {
                        browserNormaliseBrowser["Y"] = ExpressionConverter.ConvertO(browserNormaliseBrowsery);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["Y"] = 20;
                    browserNormaliseBrowserpropCount++;
                }

                if (browserNormaliseBrowserwidth != null)
                {
                    if (browserNormaliseBrowserwidth != null)
                    {
                        browserNormaliseBrowser["Width"] = ExpressionConverter.ConvertO(browserNormaliseBrowserwidth);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["Width"] = -40;
                    browserNormaliseBrowserpropCount++;
                }

                if (browserNormaliseBrowserheight != null)
                {
                    if (browserNormaliseBrowserheight != null)
                    {
                        browserNormaliseBrowser["Height"] = ExpressionConverter.ConvertO(browserNormaliseBrowserheight);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["Height"] = -40;
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
                browserNormaliseBrowser["Workflow"] = ExpressionConverter.ConvertO(browserNormaliseBrowserworkflow);
                if (browserNormaliseBrowserpropCount > 0)
                {
                    callPayload.Body = browserNormaliseBrowser;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSetWindowSize))]
        public IWorkflowAction BrowserSetWindowSize([WorkflowExpression] Func<int> browserSetWindowSizewidth, [WorkflowExpression] Func<int> browserSetWindowSizeheight, [WorkflowExpression] Func<string> browserSetWindowSizeworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSetWindowSize(WorkflowExpression<int> browserSetWindowSizewidth, WorkflowExpression<int> browserSetWindowSizeheight, WorkflowExpression<string> browserSetWindowSizeworkflow)
        {
            WorkflowExpression.Validate(browserSetWindowSizewidth, nameof(browserSetWindowSizewidth), required: true);
            WorkflowExpression.Validate(browserSetWindowSizeheight, nameof(browserSetWindowSizeheight), required: true);
            WorkflowExpression.Validate(browserSetWindowSizeworkflow, nameof(browserSetWindowSizeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetWindowSize = new JObject();
                var browserSetWindowSizepropCount = 0;
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Width"] = ExpressionConverter.ConvertO(browserSetWindowSizewidth);
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Height"] = ExpressionConverter.ConvertO(browserSetWindowSizeheight);
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Workflow"] = ExpressionConverter.ConvertO(browserSetWindowSizeworkflow);
                if (browserSetWindowSizepropCount > 0)
                {
                    callPayload.Body = browserSetWindowSize;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSetWindowPosition))]
        public IWorkflowAction BrowserSetWindowPosition([WorkflowExpression] Func<int> browserSetWindowPositionx, [WorkflowExpression] Func<int> browserSetWindowPositiony, [WorkflowExpression] Func<string> browserSetWindowPositionworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSetWindowPosition(WorkflowExpression<int> browserSetWindowPositionx, WorkflowExpression<int> browserSetWindowPositiony, WorkflowExpression<string> browserSetWindowPositionworkflow)
        {
            WorkflowExpression.Validate(browserSetWindowPositionx, nameof(browserSetWindowPositionx), required: true);
            WorkflowExpression.Validate(browserSetWindowPositiony, nameof(browserSetWindowPositiony), required: true);
            WorkflowExpression.Validate(browserSetWindowPositionworkflow, nameof(browserSetWindowPositionworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetWindowPosition = new JObject();
                var browserSetWindowPositionpropCount = 0;
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["X"] = ExpressionConverter.ConvertO(browserSetWindowPositionx);
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["Y"] = ExpressionConverter.ConvertO(browserSetWindowPositiony);
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["Workflow"] = ExpressionConverter.ConvertO(browserSetWindowPositionworkflow);
                if (browserSetWindowPositionpropCount > 0)
                {
                    callPayload.Body = browserSetWindowPosition;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSetTimeouts))]
        public IWorkflowAction BrowserSetTimeouts([WorkflowExpression] Func<string> browserSetTimeoutsworkflow, [WorkflowExpression] Func<double> browserSetTimeoutselementWaitTimeoutSeconds = null, [WorkflowExpression] Func<double> browserSetTimeoutspageLoadTimeoutSeconds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSetTimeouts(WorkflowExpression<string> browserSetTimeoutsworkflow, WorkflowExpression<double> browserSetTimeoutselementWaitTimeoutSeconds = null, WorkflowExpression<double> browserSetTimeoutspageLoadTimeoutSeconds = null)
        {
            WorkflowExpression.Validate(browserSetTimeoutsworkflow, nameof(browserSetTimeoutsworkflow), required: true);
            WorkflowExpression.Validate(browserSetTimeoutselementWaitTimeoutSeconds, nameof(browserSetTimeoutselementWaitTimeoutSeconds), required: false);
            WorkflowExpression.Validate(browserSetTimeoutspageLoadTimeoutSeconds, nameof(browserSetTimeoutspageLoadTimeoutSeconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetTimeouts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetTimeouts = new JObject();
                var browserSetTimeoutspropCount = 0;
                if (browserSetTimeoutselementWaitTimeoutSeconds != null)
                {
                    browserSetTimeouts["ElementWaitTimeoutSeconds"] = ExpressionConverter.ConvertO(browserSetTimeoutselementWaitTimeoutSeconds);
                    browserSetTimeoutspropCount++;
                }

                if (browserSetTimeoutspageLoadTimeoutSeconds != null)
                {
                    browserSetTimeouts["PageLoadTimeoutSeconds"] = ExpressionConverter.ConvertO(browserSetTimeoutspageLoadTimeoutSeconds);
                    browserSetTimeoutspropCount++;
                }

                browserSetTimeoutspropCount++;
                browserSetTimeouts["Workflow"] = ExpressionConverter.ConvertO(browserSetTimeoutsworkflow);
                if (browserSetTimeoutspropCount > 0)
                {
                    callPayload.Body = browserSetTimeouts;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserNavigateToURL))]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> BrowserNavigateToURL([WorkflowExpression] Func<string> browserNavigateToURLuRL, [WorkflowExpression] Func<string> browserNavigateToURLworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> __BuildBrowserNavigateToURL(WorkflowExpression<string> browserNavigateToURLuRL, WorkflowExpression<string> browserNavigateToURLworkflow)
        {
            WorkflowExpression.Validate(browserNavigateToURLuRL, nameof(browserNavigateToURLuRL), required: true);
            WorkflowExpression.Validate(browserNavigateToURLworkflow, nameof(browserNavigateToURLworkflow), required: true);
            return new DeferredBodyAction<BrowserNavigateToURLResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/NavigateToURL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserNavigateToURL = new JObject();
                var browserNavigateToURLpropCount = 0;
                browserNavigateToURLpropCount++;
                browserNavigateToURL["URL"] = ExpressionConverter.ConvertO(browserNavigateToURLuRL);
                browserNavigateToURLpropCount++;
                browserNavigateToURL["Workflow"] = ExpressionConverter.ConvertO(browserNavigateToURLworkflow);
                if (browserNavigateToURLpropCount > 0)
                {
                    callPayload.Body = browserNavigateToURL;
                }

                return new ApiConnectionAction<BrowserNavigateToURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserRefreshPage))]
        public IWorkflowAction BrowserRefreshPage([WorkflowExpression] Func<string> browserRefreshPageworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserRefreshPage(WorkflowExpression<string> browserRefreshPageworkflow)
        {
            WorkflowExpression.Validate(browserRefreshPageworkflow, nameof(browserRefreshPageworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/RefreshPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserRefreshPage = new JObject();
                var browserRefreshPagepropCount = 0;
                browserRefreshPagepropCount++;
                browserRefreshPage["Workflow"] = ExpressionConverter.ConvertO(browserRefreshPageworkflow);
                if (browserRefreshPagepropCount > 0)
                {
                    callPayload.Body = browserRefreshPage;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserResetAllElementHandles))]
        public IWorkflowAction BrowserResetAllElementHandles([WorkflowExpression] Func<string> browserResetAllElementHandlesworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserResetAllElementHandles(WorkflowExpression<string> browserResetAllElementHandlesworkflow)
        {
            WorkflowExpression.Validate(browserResetAllElementHandlesworkflow, nameof(browserResetAllElementHandlesworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserResetAllElementHandles = new JObject();
                var browserResetAllElementHandlespropCount = 0;
                browserResetAllElementHandlespropCount++;
                browserResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(browserResetAllElementHandlesworkflow);
                if (browserResetAllElementHandlespropCount > 0)
                {
                    callPayload.Body = browserResetAllElementHandles;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserDoesElementExist))]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> BrowserDoesElementExist([WorkflowExpression] Func<string> browserDoesElementExistworkflow, [WorkflowExpression] Func<double> browserDoesElementExistparentElementHandle = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementHandle = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementName = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementID = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementTagName = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementXPath = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementClassName = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementIndex = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementType = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> __BuildBrowserDoesElementExist(WorkflowExpression<string> browserDoesElementExistworkflow, WorkflowExpression<double> browserDoesElementExistparentElementHandle = null, WorkflowExpression<double> browserDoesElementExistsearchElementHandle = null, WorkflowExpression<string> browserDoesElementExistsearchElementName = null, WorkflowExpression<string> browserDoesElementExistsearchElementID = null, WorkflowExpression<string> browserDoesElementExistsearchElementTagName = null, WorkflowExpression<string> browserDoesElementExistsearchElementXPath = null, WorkflowExpression<string> browserDoesElementExistsearchElementClassName = null, WorkflowExpression<string> browserDoesElementExistsearchElementCSSSelector = null, WorkflowExpression<double> browserDoesElementExistsearchElementIndex = null, WorkflowExpression<string> browserDoesElementExistsearchElementMatchValue = null, WorkflowExpression<string> browserDoesElementExistsearchElementMatchText = null, WorkflowExpression<string> browserDoesElementExistsearchElementType = null, WorkflowExpression<double> browserDoesElementExistsearchElementMinimumWidth = null, WorkflowExpression<double> browserDoesElementExistsearchElementMinimumHeight = null, WorkflowExpression<double> browserDoesElementExistsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserDoesElementExistsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserDoesElementExistsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserDoesElementExistsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserDoesElementExistworkflow, nameof(browserDoesElementExistworkflow), required: true);
            WorkflowExpression.Validate(browserDoesElementExistparentElementHandle, nameof(browserDoesElementExistparentElementHandle), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementHandle, nameof(browserDoesElementExistsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementName, nameof(browserDoesElementExistsearchElementName), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementID, nameof(browserDoesElementExistsearchElementID), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementTagName, nameof(browserDoesElementExistsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementXPath, nameof(browserDoesElementExistsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementClassName, nameof(browserDoesElementExistsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementCSSSelector, nameof(browserDoesElementExistsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementIndex, nameof(browserDoesElementExistsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementMatchValue, nameof(browserDoesElementExistsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementMatchText, nameof(browserDoesElementExistsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementType, nameof(browserDoesElementExistsearchElementType), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementMinimumWidth, nameof(browserDoesElementExistsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementMinimumHeight, nameof(browserDoesElementExistsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementBoundingBoxLeft, nameof(browserDoesElementExistsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementBoundingBoxRight, nameof(browserDoesElementExistsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementBoundingBoxTop, nameof(browserDoesElementExistsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserDoesElementExistsearchElementBoundingBoxBottom, nameof(browserDoesElementExistsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserDoesElementExistResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDoesElementExist = new JObject();
                var browserDoesElementExistpropCount = 0;
                if (browserDoesElementExistparentElementHandle != null)
                {
                    browserDoesElementExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDoesElementExistparentElementHandle);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementHandle != null)
                {
                    browserDoesElementExist["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementHandle);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementName != null)
                {
                    browserDoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementName);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementID != null)
                {
                    browserDoesElementExist["SearchElementID"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementID);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementTagName != null)
                {
                    browserDoesElementExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementTagName);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementXPath != null)
                {
                    browserDoesElementExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementXPath);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementClassName != null)
                {
                    browserDoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementClassName);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementCSSSelector != null)
                {
                    browserDoesElementExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementCSSSelector);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementIndex != null)
                {
                    if (browserDoesElementExistsearchElementIndex != null)
                    {
                        browserDoesElementExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementIndex);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementIndex"] = 1;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementMatchValue != null)
                {
                    browserDoesElementExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMatchValue);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementMatchText != null)
                {
                    browserDoesElementExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMatchText);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementType != null)
                {
                    browserDoesElementExist["SearchElementType"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementType);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementMinimumWidth != null)
                {
                    if (browserDoesElementExistsearchElementMinimumWidth != null)
                    {
                        browserDoesElementExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMinimumWidth);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementMinimumWidth"] = 1;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementMinimumHeight != null)
                {
                    if (browserDoesElementExistsearchElementMinimumHeight != null)
                    {
                        browserDoesElementExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMinimumHeight);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementMinimumHeight"] = 1;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementBoundingBoxLeft != null)
                {
                    if (browserDoesElementExistsearchElementBoundingBoxLeft != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxLeft);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxLeft"] = -99999;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementBoundingBoxRight != null)
                {
                    if (browserDoesElementExistsearchElementBoundingBoxRight != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxRight);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxRight"] = 99999;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementBoundingBoxTop != null)
                {
                    if (browserDoesElementExistsearchElementBoundingBoxTop != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxTop);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxTop"] = -99999;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementBoundingBoxBottom != null)
                {
                    if (browserDoesElementExistsearchElementBoundingBoxBottom != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxBottom);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxBottom"] = 99999;
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
                browserDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(browserDoesElementExistworkflow);
                if (browserDoesElementExistpropCount > 0)
                {
                    callPayload.Body = browserDoesElementExist;
                }

                return new ApiConnectionAction<BrowserDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCreateHandleToElement))]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> BrowserCreateHandleToElement([WorkflowExpression] Func<string> browserCreateHandleToElementworkflow, [WorkflowExpression] Func<double> browserCreateHandleToElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementName = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementID = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementType = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> __BuildBrowserCreateHandleToElement(WorkflowExpression<string> browserCreateHandleToElementworkflow, WorkflowExpression<double> browserCreateHandleToElementparentElementHandle = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementHandle = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementName = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementID = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementTagName = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementXPath = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementClassName = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementCSSSelector = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementIndex = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementMatchValue = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementMatchText = null, WorkflowExpression<string> browserCreateHandleToElementsearchElementType = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserCreateHandleToElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserCreateHandleToElementworkflow, nameof(browserCreateHandleToElementworkflow), required: true);
            WorkflowExpression.Validate(browserCreateHandleToElementparentElementHandle, nameof(browserCreateHandleToElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementHandle, nameof(browserCreateHandleToElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementName, nameof(browserCreateHandleToElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementID, nameof(browserCreateHandleToElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementTagName, nameof(browserCreateHandleToElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementXPath, nameof(browserCreateHandleToElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementClassName, nameof(browserCreateHandleToElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementCSSSelector, nameof(browserCreateHandleToElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementIndex, nameof(browserCreateHandleToElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementMatchValue, nameof(browserCreateHandleToElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementMatchText, nameof(browserCreateHandleToElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementType, nameof(browserCreateHandleToElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementMinimumWidth, nameof(browserCreateHandleToElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementMinimumHeight, nameof(browserCreateHandleToElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxLeft, nameof(browserCreateHandleToElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxRight, nameof(browserCreateHandleToElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxTop, nameof(browserCreateHandleToElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxBottom, nameof(browserCreateHandleToElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserCreateHandleToElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/CreateHandleToElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCreateHandleToElement = new JObject();
                var browserCreateHandleToElementpropCount = 0;
                if (browserCreateHandleToElementparentElementHandle != null)
                {
                    browserCreateHandleToElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToElementparentElementHandle);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementHandle != null)
                {
                    browserCreateHandleToElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementHandle);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementName != null)
                {
                    browserCreateHandleToElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementName);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementID != null)
                {
                    browserCreateHandleToElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementID);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementTagName != null)
                {
                    browserCreateHandleToElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementTagName);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementXPath != null)
                {
                    browserCreateHandleToElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementXPath);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementClassName != null)
                {
                    browserCreateHandleToElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementClassName);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementCSSSelector != null)
                {
                    browserCreateHandleToElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementCSSSelector);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementIndex != null)
                {
                    if (browserCreateHandleToElementsearchElementIndex != null)
                    {
                        browserCreateHandleToElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementIndex);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementIndex"] = 1;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementMatchValue != null)
                {
                    browserCreateHandleToElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMatchValue);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementMatchText != null)
                {
                    browserCreateHandleToElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMatchText);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementType != null)
                {
                    browserCreateHandleToElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementType);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementMinimumWidth != null)
                {
                    if (browserCreateHandleToElementsearchElementMinimumWidth != null)
                    {
                        browserCreateHandleToElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMinimumWidth);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementMinimumWidth"] = 1;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementMinimumHeight != null)
                {
                    if (browserCreateHandleToElementsearchElementMinimumHeight != null)
                    {
                        browserCreateHandleToElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMinimumHeight);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementMinimumHeight"] = 1;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxLeft);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementBoundingBoxRight != null)
                {
                    if (browserCreateHandleToElementsearchElementBoundingBoxRight != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxRight);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementBoundingBoxTop != null)
                {
                    if (browserCreateHandleToElementsearchElementBoundingBoxTop != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxTop);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxBottom);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
                browserCreateHandleToElement["Workflow"] = ExpressionConverter.ConvertO(browserCreateHandleToElementworkflow);
                if (browserCreateHandleToElementpropCount > 0)
                {
                    callPayload.Body = browserCreateHandleToElement;
                }

                return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCreateHandleToParentElement))]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> BrowserCreateHandleToParentElement([WorkflowExpression] Func<string> browserCreateHandleToParentElementworkflow, [WorkflowExpression] Func<double> browserCreateHandleToParentElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementName = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementID = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementType = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> __BuildBrowserCreateHandleToParentElement(WorkflowExpression<string> browserCreateHandleToParentElementworkflow, WorkflowExpression<double> browserCreateHandleToParentElementparentElementHandle = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementHandle = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementName = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementID = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementTagName = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementXPath = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementClassName = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementCSSSelector = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementIndex = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementMatchValue = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementMatchText = null, WorkflowExpression<string> browserCreateHandleToParentElementsearchElementType = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserCreateHandleToParentElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserCreateHandleToParentElementworkflow, nameof(browserCreateHandleToParentElementworkflow), required: true);
            WorkflowExpression.Validate(browserCreateHandleToParentElementparentElementHandle, nameof(browserCreateHandleToParentElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementHandle, nameof(browserCreateHandleToParentElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementName, nameof(browserCreateHandleToParentElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementID, nameof(browserCreateHandleToParentElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementTagName, nameof(browserCreateHandleToParentElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementXPath, nameof(browserCreateHandleToParentElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementClassName, nameof(browserCreateHandleToParentElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementCSSSelector, nameof(browserCreateHandleToParentElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementIndex, nameof(browserCreateHandleToParentElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementMatchValue, nameof(browserCreateHandleToParentElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementMatchText, nameof(browserCreateHandleToParentElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementType, nameof(browserCreateHandleToParentElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementMinimumWidth, nameof(browserCreateHandleToParentElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementMinimumHeight, nameof(browserCreateHandleToParentElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxLeft, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxRight, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxTop, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxBottom, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserCreateHandleToParentElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCreateHandleToParentElement = new JObject();
                var browserCreateHandleToParentElementpropCount = 0;
                if (browserCreateHandleToParentElementparentElementHandle != null)
                {
                    browserCreateHandleToParentElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementparentElementHandle);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementHandle != null)
                {
                    browserCreateHandleToParentElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementHandle);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementName != null)
                {
                    browserCreateHandleToParentElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementID != null)
                {
                    browserCreateHandleToParentElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementID);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementTagName != null)
                {
                    browserCreateHandleToParentElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementTagName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementXPath != null)
                {
                    browserCreateHandleToParentElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementXPath);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementClassName != null)
                {
                    browserCreateHandleToParentElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementClassName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementCSSSelector != null)
                {
                    browserCreateHandleToParentElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementCSSSelector);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementIndex != null)
                {
                    if (browserCreateHandleToParentElementsearchElementIndex != null)
                    {
                        browserCreateHandleToParentElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementIndex);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementIndex"] = 1;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementMatchValue != null)
                {
                    browserCreateHandleToParentElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMatchValue);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementMatchText != null)
                {
                    browserCreateHandleToParentElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMatchText);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementType != null)
                {
                    browserCreateHandleToParentElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementType);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                {
                    if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                    {
                        browserCreateHandleToParentElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMinimumWidth);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementMinimumWidth"] = 1;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementMinimumHeight != null)
                {
                    if (browserCreateHandleToParentElementsearchElementMinimumHeight != null)
                    {
                        browserCreateHandleToParentElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMinimumHeight);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementMinimumHeight"] = 1;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxLeft);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
                {
                    if (browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxRight);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
                {
                    if (browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxTop);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxBottom);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
                browserCreateHandleToParentElement["Workflow"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementworkflow);
                if (browserCreateHandleToParentElementpropCount > 0)
                {
                    callPayload.Body = browserCreateHandleToParentElement;
                }

                return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetElementProperties))]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> BrowserGetElementProperties([WorkflowExpression] Func<string> browserGetElementPropertiesworkflow, [WorkflowExpression] Func<double> browserGetElementPropertiesparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetElementPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetElementPropertiesreturnElementHandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> __BuildBrowserGetElementProperties(WorkflowExpression<string> browserGetElementPropertiesworkflow, WorkflowExpression<double> browserGetElementPropertiesparentElementHandle = null, WorkflowExpression<double> browserGetElementPropertiessearchElementHandle = null, WorkflowExpression<string> browserGetElementPropertiessearchElementName = null, WorkflowExpression<string> browserGetElementPropertiessearchElementID = null, WorkflowExpression<string> browserGetElementPropertiessearchElementTagName = null, WorkflowExpression<string> browserGetElementPropertiessearchElementXPath = null, WorkflowExpression<string> browserGetElementPropertiessearchElementClassName = null, WorkflowExpression<string> browserGetElementPropertiessearchElementCSSSelector = null, WorkflowExpression<double> browserGetElementPropertiessearchElementIndex = null, WorkflowExpression<string> browserGetElementPropertiessearchElementMatchValue = null, WorkflowExpression<string> browserGetElementPropertiessearchElementMatchText = null, WorkflowExpression<string> browserGetElementPropertiessearchElementType = null, WorkflowExpression<double> browserGetElementPropertiessearchElementMinimumWidth = null, WorkflowExpression<double> browserGetElementPropertiessearchElementMinimumHeight = null, WorkflowExpression<double> browserGetElementPropertiessearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetElementPropertiessearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetElementPropertiessearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetElementPropertiessearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserGetElementPropertiesgetHTMLCode = null, WorkflowExpression<bool> browserGetElementPropertiesreturnElementHandle = null)
        {
            WorkflowExpression.Validate(browserGetElementPropertiesworkflow, nameof(browserGetElementPropertiesworkflow), required: true);
            WorkflowExpression.Validate(browserGetElementPropertiesparentElementHandle, nameof(browserGetElementPropertiesparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementHandle, nameof(browserGetElementPropertiessearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementName, nameof(browserGetElementPropertiessearchElementName), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementID, nameof(browserGetElementPropertiessearchElementID), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementTagName, nameof(browserGetElementPropertiessearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementXPath, nameof(browserGetElementPropertiessearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementClassName, nameof(browserGetElementPropertiessearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementCSSSelector, nameof(browserGetElementPropertiessearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementIndex, nameof(browserGetElementPropertiessearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementMatchValue, nameof(browserGetElementPropertiessearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementMatchText, nameof(browserGetElementPropertiessearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementType, nameof(browserGetElementPropertiessearchElementType), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementMinimumWidth, nameof(browserGetElementPropertiessearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementMinimumHeight, nameof(browserGetElementPropertiessearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementPropertiessearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxRight, nameof(browserGetElementPropertiessearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxTop, nameof(browserGetElementPropertiessearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementPropertiessearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiesgetHTMLCode, nameof(browserGetElementPropertiesgetHTMLCode), required: false);
            WorkflowExpression.Validate(browserGetElementPropertiesreturnElementHandle, nameof(browserGetElementPropertiesreturnElementHandle), required: false);
            return new DeferredBodyAction<BrowserGetElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementProperties = new JObject();
                var browserGetElementPropertiespropCount = 0;
                if (browserGetElementPropertiesparentElementHandle != null)
                {
                    browserGetElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesparentElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementHandle != null)
                {
                    browserGetElementProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementName != null)
                {
                    browserGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementName);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementID != null)
                {
                    browserGetElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementID);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementTagName != null)
                {
                    browserGetElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementTagName);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementXPath != null)
                {
                    browserGetElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementXPath);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementClassName != null)
                {
                    browserGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementClassName);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementCSSSelector);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementIndex != null)
                {
                    if (browserGetElementPropertiessearchElementIndex != null)
                    {
                        browserGetElementProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementIndex);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementIndex"] = 1;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementMatchValue != null)
                {
                    browserGetElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMatchValue);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementMatchText != null)
                {
                    browserGetElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMatchText);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementType != null)
                {
                    browserGetElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementType);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetElementPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMinimumWidth);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementMinimumWidth"] = 1;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementMinimumHeight != null)
                {
                    if (browserGetElementPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMinimumHeight);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementMinimumHeight"] = 1;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (browserGetElementPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxLeft);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementBoundingBoxRight != null)
                {
                    if (browserGetElementPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxRight);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementBoundingBoxTop != null)
                {
                    if (browserGetElementPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxTop);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (browserGetElementPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxBottom);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiesgetHTMLCode != null)
                {
                    if (browserGetElementPropertiesgetHTMLCode != null)
                    {
                        browserGetElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementPropertiesgetHTMLCode);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["GetHTMLCode"] = false;
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiesreturnElementHandle != null)
                {
                    if (browserGetElementPropertiesreturnElementHandle != null)
                    {
                        browserGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesreturnElementHandle);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["ReturnElementHandle"] = true;
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
                browserGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementPropertiesworkflow);
                if (browserGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementProperties;
                }

                return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetMultipleElementProperties))]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> BrowserGetMultipleElementProperties([WorkflowExpression] Func<string> browserGetMultipleElementPropertiesworkflow, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiesparentElementHandle = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiescreateHandle = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnValue = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnText = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesmaxValueLength = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesmaxTextLength = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnIsDisplayed = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnCoordinates = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnDimensions = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnChildElementCount = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnParentTag = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> __BuildBrowserGetMultipleElementProperties(WorkflowExpression<string> browserGetMultipleElementPropertiesworkflow, WorkflowExpression<double> browserGetMultipleElementPropertiesparentElementHandle = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementName = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementID = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementTagName = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementXPath = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementClassName = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementCSSSelector = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementMatchValue = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementMatchText = null, WorkflowExpression<string> browserGetMultipleElementPropertiessearchElementType = null, WorkflowExpression<double> browserGetMultipleElementPropertiessearchElementMinimumWidth = null, WorkflowExpression<double> browserGetMultipleElementPropertiessearchElementMinimumHeight = null, WorkflowExpression<double> browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetMultipleElementPropertiessearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetMultipleElementPropertiessearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesgetHTMLCode = null, WorkflowExpression<bool> browserGetMultipleElementPropertiescreateHandle = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnValue = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnText = null, WorkflowExpression<int> browserGetMultipleElementPropertiesmaxValueLength = null, WorkflowExpression<int> browserGetMultipleElementPropertiesmaxTextLength = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnIsDisplayed = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnCoordinates = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnDimensions = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnChildElementCount = null, WorkflowExpression<bool> browserGetMultipleElementPropertiesreturnParentTag = null, WorkflowExpression<int> browserGetMultipleElementPropertiesfirstItemToReturn = null, WorkflowExpression<int> browserGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesworkflow, nameof(browserGetMultipleElementPropertiesworkflow), required: true);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesparentElementHandle, nameof(browserGetMultipleElementPropertiesparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementName, nameof(browserGetMultipleElementPropertiessearchElementName), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementID, nameof(browserGetMultipleElementPropertiessearchElementID), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementTagName, nameof(browserGetMultipleElementPropertiessearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementXPath, nameof(browserGetMultipleElementPropertiessearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementClassName, nameof(browserGetMultipleElementPropertiessearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementCSSSelector, nameof(browserGetMultipleElementPropertiessearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementMatchValue, nameof(browserGetMultipleElementPropertiessearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementMatchText, nameof(browserGetMultipleElementPropertiessearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementType, nameof(browserGetMultipleElementPropertiessearchElementType), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementMinimumWidth, nameof(browserGetMultipleElementPropertiessearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementMinimumHeight, nameof(browserGetMultipleElementPropertiessearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxRight, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxTop, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesgetHTMLCode, nameof(browserGetMultipleElementPropertiesgetHTMLCode), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiescreateHandle, nameof(browserGetMultipleElementPropertiescreateHandle), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnValue, nameof(browserGetMultipleElementPropertiesreturnValue), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnText, nameof(browserGetMultipleElementPropertiesreturnText), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesmaxValueLength, nameof(browserGetMultipleElementPropertiesmaxValueLength), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesmaxTextLength, nameof(browserGetMultipleElementPropertiesmaxTextLength), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnIsDisplayed, nameof(browserGetMultipleElementPropertiesreturnIsDisplayed), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnCoordinates, nameof(browserGetMultipleElementPropertiesreturnCoordinates), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnDimensions, nameof(browserGetMultipleElementPropertiesreturnDimensions), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnChildElementCount, nameof(browserGetMultipleElementPropertiesreturnChildElementCount), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesreturnParentTag, nameof(browserGetMultipleElementPropertiesreturnParentTag), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesfirstItemToReturn, nameof(browserGetMultipleElementPropertiesfirstItemToReturn), required: false);
            WorkflowExpression.Validate(browserGetMultipleElementPropertiesmaxItemsToReturn, nameof(browserGetMultipleElementPropertiesmaxItemsToReturn), required: false);
            return new DeferredBodyAction<BrowserGetMultipleElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetMultipleElementProperties = new JObject();
                var browserGetMultipleElementPropertiespropCount = 0;
                if (browserGetMultipleElementPropertiesparentElementHandle != null)
                {
                    browserGetMultipleElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesparentElementHandle);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementName != null)
                {
                    browserGetMultipleElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementID != null)
                {
                    browserGetMultipleElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementID);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementTagName != null)
                {
                    browserGetMultipleElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementTagName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementXPath != null)
                {
                    browserGetMultipleElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementXPath);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementClassName != null)
                {
                    browserGetMultipleElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementClassName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementCSSSelector != null)
                {
                    browserGetMultipleElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementCSSSelector);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMatchValue != null)
                {
                    browserGetMultipleElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMatchValue);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMatchText != null)
                {
                    browserGetMultipleElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMatchText);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementType != null)
                {
                    browserGetMultipleElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementType);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetMultipleElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMinimumWidth);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementMinimumWidth"] = 1;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetMultipleElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMinimumHeight);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementMinimumHeight"] = 1;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxRight);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxTop);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesgetHTMLCode != null)
                {
                    if (browserGetMultipleElementPropertiesgetHTMLCode != null)
                    {
                        browserGetMultipleElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesgetHTMLCode);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["GetHTMLCode"] = false;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiescreateHandle != null)
                {
                    if (browserGetMultipleElementPropertiescreateHandle != null)
                    {
                        browserGetMultipleElementProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiescreateHandle);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["CreateHandle"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnValue != null)
                {
                    if (browserGetMultipleElementPropertiesreturnValue != null)
                    {
                        browserGetMultipleElementProperties["ReturnValue"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnValue);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnValue"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnText != null)
                {
                    if (browserGetMultipleElementPropertiesreturnText != null)
                    {
                        browserGetMultipleElementProperties["ReturnText"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnText);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnText"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesmaxValueLength != null)
                {
                    if (browserGetMultipleElementPropertiesmaxValueLength != null)
                    {
                        browserGetMultipleElementProperties["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesmaxValueLength);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["MaxValueLength"] = 0;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesmaxTextLength != null)
                {
                    if (browserGetMultipleElementPropertiesmaxTextLength != null)
                    {
                        browserGetMultipleElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesmaxTextLength);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["MaxTextLength"] = 0;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnIsDisplayed != null)
                {
                    if (browserGetMultipleElementPropertiesreturnIsDisplayed != null)
                    {
                        browserGetMultipleElementProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnIsDisplayed);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnIsDisplayed"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnCoordinates != null)
                {
                    if (browserGetMultipleElementPropertiesreturnCoordinates != null)
                    {
                        browserGetMultipleElementProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnCoordinates);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnCoordinates"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnDimensions != null)
                {
                    if (browserGetMultipleElementPropertiesreturnDimensions != null)
                    {
                        browserGetMultipleElementProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnDimensions);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnDimensions"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnChildElementCount != null)
                {
                    if (browserGetMultipleElementPropertiesreturnChildElementCount != null)
                    {
                        browserGetMultipleElementProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnChildElementCount);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnChildElementCount"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesreturnParentTag != null)
                {
                    if (browserGetMultipleElementPropertiesreturnParentTag != null)
                    {
                        browserGetMultipleElementProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnParentTag);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnParentTag"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesfirstItemToReturn != null)
                {
                    if (browserGetMultipleElementPropertiesfirstItemToReturn != null)
                    {
                        browserGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesfirstItemToReturn);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["FirstItemToReturn"] = 1;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiesmaxItemsToReturn != null)
                {
                    if (browserGetMultipleElementPropertiesmaxItemsToReturn != null)
                    {
                        browserGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesmaxItemsToReturn);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["MaxItemsToReturn"] = 0;
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
                browserGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesworkflow);
                if (browserGetMultipleElementPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetMultipleElementProperties;
                }

                return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetElementParentProperties))]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> BrowserGetElementParentProperties([WorkflowExpression] Func<string> browserGetElementParentPropertiesworkflow, [WorkflowExpression] Func<double> browserGetElementParentPropertiesparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetElementParentPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetElementParentPropertiescreateHandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> __BuildBrowserGetElementParentProperties(WorkflowExpression<string> browserGetElementParentPropertiesworkflow, WorkflowExpression<double> browserGetElementParentPropertiesparentElementHandle = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementHandle = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementName = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementID = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementTagName = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementXPath = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementClassName = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementCSSSelector = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementIndex = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementMatchValue = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementMatchText = null, WorkflowExpression<string> browserGetElementParentPropertiessearchElementType = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementMinimumWidth = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementMinimumHeight = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetElementParentPropertiessearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserGetElementParentPropertiesgetHTMLCode = null, WorkflowExpression<bool> browserGetElementParentPropertiescreateHandle = null)
        {
            WorkflowExpression.Validate(browserGetElementParentPropertiesworkflow, nameof(browserGetElementParentPropertiesworkflow), required: true);
            WorkflowExpression.Validate(browserGetElementParentPropertiesparentElementHandle, nameof(browserGetElementParentPropertiesparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementHandle, nameof(browserGetElementParentPropertiessearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementName, nameof(browserGetElementParentPropertiessearchElementName), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementID, nameof(browserGetElementParentPropertiessearchElementID), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementTagName, nameof(browserGetElementParentPropertiessearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementXPath, nameof(browserGetElementParentPropertiessearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementClassName, nameof(browserGetElementParentPropertiessearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementCSSSelector, nameof(browserGetElementParentPropertiessearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementIndex, nameof(browserGetElementParentPropertiessearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementMatchValue, nameof(browserGetElementParentPropertiessearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementMatchText, nameof(browserGetElementParentPropertiessearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementType, nameof(browserGetElementParentPropertiessearchElementType), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementMinimumWidth, nameof(browserGetElementParentPropertiessearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementMinimumHeight, nameof(browserGetElementParentPropertiessearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementParentPropertiessearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxRight, nameof(browserGetElementParentPropertiessearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxTop, nameof(browserGetElementParentPropertiessearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementParentPropertiessearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiesgetHTMLCode, nameof(browserGetElementParentPropertiesgetHTMLCode), required: false);
            WorkflowExpression.Validate(browserGetElementParentPropertiescreateHandle, nameof(browserGetElementParentPropertiescreateHandle), required: false);
            return new DeferredBodyAction<BrowserGetElementParentPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementParentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementParentProperties = new JObject();
                var browserGetElementParentPropertiespropCount = 0;
                if (browserGetElementParentPropertiesparentElementHandle != null)
                {
                    browserGetElementParentProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesparentElementHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementHandle != null)
                {
                    browserGetElementParentProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementName != null)
                {
                    browserGetElementParentProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementID != null)
                {
                    browserGetElementParentProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementID);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementTagName != null)
                {
                    browserGetElementParentProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementTagName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementXPath != null)
                {
                    browserGetElementParentProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementXPath);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementClassName != null)
                {
                    browserGetElementParentProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementClassName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementParentProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementCSSSelector);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementIndex != null)
                {
                    if (browserGetElementParentPropertiessearchElementIndex != null)
                    {
                        browserGetElementParentProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementIndex);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementIndex"] = 1;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementMatchValue != null)
                {
                    browserGetElementParentProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMatchValue);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementMatchText != null)
                {
                    browserGetElementParentProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMatchText);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementType != null)
                {
                    browserGetElementParentProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementType);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementParentProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMinimumWidth);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementMinimumWidth"] = 1;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementMinimumHeight != null)
                {
                    if (browserGetElementParentPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetElementParentProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMinimumHeight);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementMinimumHeight"] = 1;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxLeft);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
                {
                    if (browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxRight);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
                {
                    if (browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxTop);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxBottom);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiesgetHTMLCode != null)
                {
                    if (browserGetElementParentPropertiesgetHTMLCode != null)
                    {
                        browserGetElementParentProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesgetHTMLCode);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["GetHTMLCode"] = false;
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiescreateHandle != null)
                {
                    if (browserGetElementParentPropertiescreateHandle != null)
                    {
                        browserGetElementParentProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiescreateHandle);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["CreateHandle"] = true;
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
                browserGetElementParentProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesworkflow);
                if (browserGetElementParentPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementParentProperties;
                }

                return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetElementChildrenProperties))]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> BrowserGetElementChildrenProperties([WorkflowExpression] Func<string> browserGetElementChildrenPropertiesworkflow, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiesparentElementHandle = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiescreateHandle = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiessearchSubTree = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnValue = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnText = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesmaxValueLength = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesmaxTextLength = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnIsDisplayed = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnCoordinates = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnDimensions = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnChildElementCount = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnParentTag = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesmaxItemsToReturn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> __BuildBrowserGetElementChildrenProperties(WorkflowExpression<string> browserGetElementChildrenPropertiesworkflow, WorkflowExpression<double> browserGetElementChildrenPropertiesparentElementHandle = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementName = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementID = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementTagName = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementXPath = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementClassName = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementCSSSelector = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementMatchValue = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementMatchText = null, WorkflowExpression<string> browserGetElementChildrenPropertiessearchElementType = null, WorkflowExpression<double> browserGetElementChildrenPropertiessearchElementMinimumWidth = null, WorkflowExpression<double> browserGetElementChildrenPropertiessearchElementMinimumHeight = null, WorkflowExpression<double> browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetElementChildrenPropertiessearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetElementChildrenPropertiessearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesgetHTMLCode = null, WorkflowExpression<bool> browserGetElementChildrenPropertiescreateHandle = null, WorkflowExpression<bool> browserGetElementChildrenPropertiessearchSubTree = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnValue = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnText = null, WorkflowExpression<int> browserGetElementChildrenPropertiesmaxValueLength = null, WorkflowExpression<int> browserGetElementChildrenPropertiesmaxTextLength = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnIsDisplayed = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnCoordinates = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnDimensions = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnChildElementCount = null, WorkflowExpression<bool> browserGetElementChildrenPropertiesreturnParentTag = null, WorkflowExpression<int> browserGetElementChildrenPropertiesfirstItemToReturn = null, WorkflowExpression<int> browserGetElementChildrenPropertiesmaxItemsToReturn = null)
        {
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesworkflow, nameof(browserGetElementChildrenPropertiesworkflow), required: true);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesparentElementHandle, nameof(browserGetElementChildrenPropertiesparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementName, nameof(browserGetElementChildrenPropertiessearchElementName), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementID, nameof(browserGetElementChildrenPropertiessearchElementID), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementTagName, nameof(browserGetElementChildrenPropertiessearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementXPath, nameof(browserGetElementChildrenPropertiessearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementClassName, nameof(browserGetElementChildrenPropertiessearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementCSSSelector, nameof(browserGetElementChildrenPropertiessearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementMatchValue, nameof(browserGetElementChildrenPropertiessearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementMatchText, nameof(browserGetElementChildrenPropertiessearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementType, nameof(browserGetElementChildrenPropertiessearchElementType), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementMinimumWidth, nameof(browserGetElementChildrenPropertiessearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementMinimumHeight, nameof(browserGetElementChildrenPropertiessearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxRight, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxTop, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesgetHTMLCode, nameof(browserGetElementChildrenPropertiesgetHTMLCode), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiescreateHandle, nameof(browserGetElementChildrenPropertiescreateHandle), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiessearchSubTree, nameof(browserGetElementChildrenPropertiessearchSubTree), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnValue, nameof(browserGetElementChildrenPropertiesreturnValue), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnText, nameof(browserGetElementChildrenPropertiesreturnText), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesmaxValueLength, nameof(browserGetElementChildrenPropertiesmaxValueLength), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesmaxTextLength, nameof(browserGetElementChildrenPropertiesmaxTextLength), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnIsDisplayed, nameof(browserGetElementChildrenPropertiesreturnIsDisplayed), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnCoordinates, nameof(browserGetElementChildrenPropertiesreturnCoordinates), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnDimensions, nameof(browserGetElementChildrenPropertiesreturnDimensions), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnChildElementCount, nameof(browserGetElementChildrenPropertiesreturnChildElementCount), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesreturnParentTag, nameof(browserGetElementChildrenPropertiesreturnParentTag), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesfirstItemToReturn, nameof(browserGetElementChildrenPropertiesfirstItemToReturn), required: false);
            WorkflowExpression.Validate(browserGetElementChildrenPropertiesmaxItemsToReturn, nameof(browserGetElementChildrenPropertiesmaxItemsToReturn), required: false);
            return new DeferredBodyAction<BrowserGetElementChildrenPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementChildrenProperties = new JObject();
                var browserGetElementChildrenPropertiespropCount = 0;
                if (browserGetElementChildrenPropertiesparentElementHandle != null)
                {
                    browserGetElementChildrenProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesparentElementHandle);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementName != null)
                {
                    browserGetElementChildrenProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementID != null)
                {
                    browserGetElementChildrenProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementID);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementTagName != null)
                {
                    browserGetElementChildrenProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementTagName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementXPath != null)
                {
                    browserGetElementChildrenProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementXPath);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementClassName != null)
                {
                    browserGetElementChildrenProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementClassName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementChildrenProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementCSSSelector);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMatchValue != null)
                {
                    browserGetElementChildrenProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMatchValue);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMatchText != null)
                {
                    browserGetElementChildrenProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMatchText);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementType != null)
                {
                    browserGetElementChildrenProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementType);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementChildrenProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMinimumWidth);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementMinimumWidth"] = 1;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetElementChildrenProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMinimumHeight);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementMinimumHeight"] = 1;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxRight);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxTop);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesgetHTMLCode != null)
                {
                    if (browserGetElementChildrenPropertiesgetHTMLCode != null)
                    {
                        browserGetElementChildrenProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesgetHTMLCode);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["GetHTMLCode"] = false;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiescreateHandle != null)
                {
                    if (browserGetElementChildrenPropertiescreateHandle != null)
                    {
                        browserGetElementChildrenProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiescreateHandle);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["CreateHandle"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchSubTree != null)
                {
                    if (browserGetElementChildrenPropertiessearchSubTree != null)
                    {
                        browserGetElementChildrenProperties["SearchSubTree"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchSubTree);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchSubTree"] = false;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnValue != null)
                {
                    if (browserGetElementChildrenPropertiesreturnValue != null)
                    {
                        browserGetElementChildrenProperties["ReturnValue"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnValue);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnValue"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnText != null)
                {
                    if (browserGetElementChildrenPropertiesreturnText != null)
                    {
                        browserGetElementChildrenProperties["ReturnText"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnText);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnText"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesmaxValueLength != null)
                {
                    if (browserGetElementChildrenPropertiesmaxValueLength != null)
                    {
                        browserGetElementChildrenProperties["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesmaxValueLength);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["MaxValueLength"] = 0;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesmaxTextLength != null)
                {
                    if (browserGetElementChildrenPropertiesmaxTextLength != null)
                    {
                        browserGetElementChildrenProperties["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesmaxTextLength);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["MaxTextLength"] = 0;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnIsDisplayed != null)
                {
                    if (browserGetElementChildrenPropertiesreturnIsDisplayed != null)
                    {
                        browserGetElementChildrenProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnIsDisplayed);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnIsDisplayed"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnCoordinates != null)
                {
                    if (browserGetElementChildrenPropertiesreturnCoordinates != null)
                    {
                        browserGetElementChildrenProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnCoordinates);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnCoordinates"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnDimensions != null)
                {
                    if (browserGetElementChildrenPropertiesreturnDimensions != null)
                    {
                        browserGetElementChildrenProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnDimensions);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnDimensions"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnChildElementCount != null)
                {
                    if (browserGetElementChildrenPropertiesreturnChildElementCount != null)
                    {
                        browserGetElementChildrenProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnChildElementCount);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnChildElementCount"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesreturnParentTag != null)
                {
                    if (browserGetElementChildrenPropertiesreturnParentTag != null)
                    {
                        browserGetElementChildrenProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnParentTag);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnParentTag"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesfirstItemToReturn != null)
                {
                    if (browserGetElementChildrenPropertiesfirstItemToReturn != null)
                    {
                        browserGetElementChildrenProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesfirstItemToReturn);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["FirstItemToReturn"] = 1;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiesmaxItemsToReturn != null)
                {
                    if (browserGetElementChildrenPropertiesmaxItemsToReturn != null)
                    {
                        browserGetElementChildrenProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesmaxItemsToReturn);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["MaxItemsToReturn"] = 0;
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
                browserGetElementChildrenProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesworkflow);
                if (browserGetElementChildrenPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementChildrenProperties;
                }

                return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserInputTextIntoElement))]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> BrowserInputTextIntoElement([WorkflowExpression] Func<string> browserInputTextIntoElementworkflow, [WorkflowExpression] Func<double> browserInputTextIntoElementparentElementHandle = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementName = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementID = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementType = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserInputTextIntoElementtextToInput = null, [WorkflowExpression] Func<bool> browserInputTextIntoElementresetExistingValue = null, [WorkflowExpression] Func<int> browserInputTextIntoElementinsertPosition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> __BuildBrowserInputTextIntoElement(WorkflowExpression<string> browserInputTextIntoElementworkflow, WorkflowExpression<double> browserInputTextIntoElementparentElementHandle = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementHandle = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementName = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementID = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementTagName = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementXPath = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementClassName = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementCSSSelector = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementIndex = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementMatchValue = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementMatchText = null, WorkflowExpression<string> browserInputTextIntoElementsearchElementType = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserInputTextIntoElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<string> browserInputTextIntoElementtextToInput = null, WorkflowExpression<bool> browserInputTextIntoElementresetExistingValue = null, WorkflowExpression<int> browserInputTextIntoElementinsertPosition = null)
        {
            WorkflowExpression.Validate(browserInputTextIntoElementworkflow, nameof(browserInputTextIntoElementworkflow), required: true);
            WorkflowExpression.Validate(browserInputTextIntoElementparentElementHandle, nameof(browserInputTextIntoElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementHandle, nameof(browserInputTextIntoElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementName, nameof(browserInputTextIntoElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementID, nameof(browserInputTextIntoElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementTagName, nameof(browserInputTextIntoElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementXPath, nameof(browserInputTextIntoElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementClassName, nameof(browserInputTextIntoElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementCSSSelector, nameof(browserInputTextIntoElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementIndex, nameof(browserInputTextIntoElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementMatchValue, nameof(browserInputTextIntoElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementMatchText, nameof(browserInputTextIntoElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementType, nameof(browserInputTextIntoElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementMinimumWidth, nameof(browserInputTextIntoElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementMinimumHeight, nameof(browserInputTextIntoElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxLeft, nameof(browserInputTextIntoElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxRight, nameof(browserInputTextIntoElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxTop, nameof(browserInputTextIntoElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxBottom, nameof(browserInputTextIntoElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementtextToInput, nameof(browserInputTextIntoElementtextToInput), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementresetExistingValue, nameof(browserInputTextIntoElementresetExistingValue), required: false);
            WorkflowExpression.Validate(browserInputTextIntoElementinsertPosition, nameof(browserInputTextIntoElementinsertPosition), required: false);
            return new DeferredBodyAction<BrowserInputTextIntoElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputTextIntoElement = new JObject();
                var browserInputTextIntoElementpropCount = 0;
                if (browserInputTextIntoElementparentElementHandle != null)
                {
                    browserInputTextIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserInputTextIntoElementparentElementHandle);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementHandle != null)
                {
                    browserInputTextIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementHandle);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementName != null)
                {
                    browserInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementName);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementID != null)
                {
                    browserInputTextIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementID);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementTagName != null)
                {
                    browserInputTextIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementTagName);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementXPath != null)
                {
                    browserInputTextIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementXPath);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementClassName != null)
                {
                    browserInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementClassName);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementCSSSelector != null)
                {
                    browserInputTextIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementCSSSelector);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementIndex != null)
                {
                    if (browserInputTextIntoElementsearchElementIndex != null)
                    {
                        browserInputTextIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementIndex);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementIndex"] = 1;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementMatchValue != null)
                {
                    browserInputTextIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMatchValue);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementMatchText != null)
                {
                    browserInputTextIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMatchText);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementType != null)
                {
                    browserInputTextIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementType);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementMinimumWidth != null)
                {
                    if (browserInputTextIntoElementsearchElementMinimumWidth != null)
                    {
                        browserInputTextIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMinimumWidth);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementMinimumWidth"] = 1;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementMinimumHeight != null)
                {
                    if (browserInputTextIntoElementsearchElementMinimumHeight != null)
                    {
                        browserInputTextIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMinimumHeight);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementMinimumHeight"] = 1;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxLeft);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementBoundingBoxRight != null)
                {
                    if (browserInputTextIntoElementsearchElementBoundingBoxRight != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxRight);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxRight"] = 99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementBoundingBoxTop != null)
                {
                    if (browserInputTextIntoElementsearchElementBoundingBoxTop != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxTop);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxTop"] = -99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxBottom);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementtextToInput != null)
                {
                    browserInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(browserInputTextIntoElementtextToInput);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementresetExistingValue != null)
                {
                    if (browserInputTextIntoElementresetExistingValue != null)
                    {
                        browserInputTextIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(browserInputTextIntoElementresetExistingValue);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["ResetExistingValue"] = true;
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementinsertPosition != null)
                {
                    if (browserInputTextIntoElementinsertPosition != null)
                    {
                        browserInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(browserInputTextIntoElementinsertPosition);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["InsertPosition"] = -1;
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
                browserInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserInputTextIntoElementworkflow);
                if (browserInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = browserInputTextIntoElement;
                }

                return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserInputTextIntoMultipleElements))]
        public IWorkflowAction BrowserInputTextIntoMultipleElements([WorkflowExpression] Func<string> browserInputTextIntoMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> browserInputTextIntoMultipleElementsworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserInputTextIntoMultipleElements(WorkflowExpression<string> browserInputTextIntoMultipleElementsinputElementsJSON, WorkflowExpression<string> browserInputTextIntoMultipleElementsworkflow)
        {
            WorkflowExpression.Validate(browserInputTextIntoMultipleElementsinputElementsJSON, nameof(browserInputTextIntoMultipleElementsinputElementsJSON), required: true);
            WorkflowExpression.Validate(browserInputTextIntoMultipleElementsworkflow, nameof(browserInputTextIntoMultipleElementsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputTextIntoMultipleElements = new JObject();
                var browserInputTextIntoMultipleElementspropCount = 0;
                browserInputTextIntoMultipleElementspropCount++;
                browserInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(browserInputTextIntoMultipleElementsinputElementsJSON);
                browserInputTextIntoMultipleElementspropCount++;
                browserInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(browserInputTextIntoMultipleElementsworkflow);
                if (browserInputTextIntoMultipleElementspropCount > 0)
                {
                    callPayload.Body = browserInputTextIntoMultipleElements;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserPressCtrlKeyOnElement))]
        public IWorkflowAction BrowserPressCtrlKeyOnElement([WorkflowExpression] Func<string> browserPressCtrlKeyOnElementcontrolKey, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementworkflow, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserPressCtrlKeyOnElement(WorkflowExpression<string> browserPressCtrlKeyOnElementcontrolKey, WorkflowExpression<string> browserPressCtrlKeyOnElementworkflow, WorkflowExpression<double> browserPressCtrlKeyOnElementparentElementHandle = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementHandle = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementName = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementID = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementTagName = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementXPath = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementClassName = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementIndex = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementMatchText = null, WorkflowExpression<string> browserPressCtrlKeyOnElementsearchElementType = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementcontrolKey, nameof(browserPressCtrlKeyOnElementcontrolKey), required: true);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementworkflow, nameof(browserPressCtrlKeyOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementparentElementHandle, nameof(browserPressCtrlKeyOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementHandle, nameof(browserPressCtrlKeyOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementName, nameof(browserPressCtrlKeyOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementID, nameof(browserPressCtrlKeyOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementTagName, nameof(browserPressCtrlKeyOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementXPath, nameof(browserPressCtrlKeyOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementClassName, nameof(browserPressCtrlKeyOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementCSSSelector, nameof(browserPressCtrlKeyOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementIndex, nameof(browserPressCtrlKeyOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementMatchValue, nameof(browserPressCtrlKeyOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementMatchText, nameof(browserPressCtrlKeyOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementType, nameof(browserPressCtrlKeyOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementMinimumWidth, nameof(browserPressCtrlKeyOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementMinimumHeight, nameof(browserPressCtrlKeyOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPressCtrlKeyOnElement = new JObject();
                var browserPressCtrlKeyOnElementpropCount = 0;
                if (browserPressCtrlKeyOnElementparentElementHandle != null)
                {
                    browserPressCtrlKeyOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementparentElementHandle);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementHandle != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementHandle);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementID != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementID);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementTagName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementTagName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementXPath != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementXPath);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementClassName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementClassName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementCSSSelector != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementCSSSelector);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementIndex != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementIndex != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementIndex);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementIndex"] = 1;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementMatchValue != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMatchValue);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementMatchText != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMatchText);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementType != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementType);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMinimumWidth);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = 1;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMinimumHeight);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = 1;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
                browserPressCtrlKeyOnElement["ControlKey"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementcontrolKey);
                browserPressCtrlKeyOnElementpropCount++;
                browserPressCtrlKeyOnElement["Workflow"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementworkflow);
                if (browserPressCtrlKeyOnElementpropCount > 0)
                {
                    callPayload.Body = browserPressCtrlKeyOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserClickElement))]
        public IWorkflowAction BrowserClickElement([WorkflowExpression] Func<string> browserClickElementworkflow, [WorkflowExpression] Func<double> browserClickElementparentElementHandle = null, [WorkflowExpression] Func<double> browserClickElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserClickElementsearchElementName = null, [WorkflowExpression] Func<string> browserClickElementsearchElementID = null, [WorkflowExpression] Func<string> browserClickElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserClickElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserClickElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserClickElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserClickElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserClickElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserClickElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserClickElementsearchElementType = null, [WorkflowExpression] Func<double> browserClickElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserClickElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserClickElement(WorkflowExpression<string> browserClickElementworkflow, WorkflowExpression<double> browserClickElementparentElementHandle = null, WorkflowExpression<double> browserClickElementsearchElementHandle = null, WorkflowExpression<string> browserClickElementsearchElementName = null, WorkflowExpression<string> browserClickElementsearchElementID = null, WorkflowExpression<string> browserClickElementsearchElementTagName = null, WorkflowExpression<string> browserClickElementsearchElementXPath = null, WorkflowExpression<string> browserClickElementsearchElementClassName = null, WorkflowExpression<string> browserClickElementsearchElementCSSSelector = null, WorkflowExpression<double> browserClickElementsearchElementIndex = null, WorkflowExpression<string> browserClickElementsearchElementMatchValue = null, WorkflowExpression<string> browserClickElementsearchElementMatchText = null, WorkflowExpression<string> browserClickElementsearchElementType = null, WorkflowExpression<double> browserClickElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserClickElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserClickElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserClickElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserClickElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserClickElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserClickElementworkflow, nameof(browserClickElementworkflow), required: true);
            WorkflowExpression.Validate(browserClickElementparentElementHandle, nameof(browserClickElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementHandle, nameof(browserClickElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementName, nameof(browserClickElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementID, nameof(browserClickElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementTagName, nameof(browserClickElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementXPath, nameof(browserClickElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementClassName, nameof(browserClickElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementCSSSelector, nameof(browserClickElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementIndex, nameof(browserClickElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementMatchValue, nameof(browserClickElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementMatchText, nameof(browserClickElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementType, nameof(browserClickElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementMinimumWidth, nameof(browserClickElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementMinimumHeight, nameof(browserClickElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementBoundingBoxLeft, nameof(browserClickElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementBoundingBoxRight, nameof(browserClickElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementBoundingBoxTop, nameof(browserClickElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserClickElementsearchElementBoundingBoxBottom, nameof(browserClickElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ClickElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserClickElement = new JObject();
                var browserClickElementpropCount = 0;
                if (browserClickElementparentElementHandle != null)
                {
                    browserClickElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserClickElementparentElementHandle);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementHandle != null)
                {
                    browserClickElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserClickElementsearchElementHandle);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementName != null)
                {
                    browserClickElement["SearchElementName"] = ExpressionConverter.ConvertO(browserClickElementsearchElementName);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementID != null)
                {
                    browserClickElement["SearchElementID"] = ExpressionConverter.ConvertO(browserClickElementsearchElementID);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementTagName != null)
                {
                    browserClickElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserClickElementsearchElementTagName);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementXPath != null)
                {
                    browserClickElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserClickElementsearchElementXPath);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementClassName != null)
                {
                    browserClickElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserClickElementsearchElementClassName);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementCSSSelector != null)
                {
                    browserClickElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserClickElementsearchElementCSSSelector);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementIndex != null)
                {
                    if (browserClickElementsearchElementIndex != null)
                    {
                        browserClickElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserClickElementsearchElementIndex);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementIndex"] = 1;
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementMatchValue != null)
                {
                    browserClickElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMatchValue);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementMatchText != null)
                {
                    browserClickElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMatchText);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementType != null)
                {
                    browserClickElement["SearchElementType"] = ExpressionConverter.ConvertO(browserClickElementsearchElementType);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementMinimumWidth != null)
                {
                    if (browserClickElementsearchElementMinimumWidth != null)
                    {
                        browserClickElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMinimumWidth);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementMinimumWidth"] = 1;
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementMinimumHeight != null)
                {
                    if (browserClickElementsearchElementMinimumHeight != null)
                    {
                        browserClickElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMinimumHeight);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementMinimumHeight"] = 1;
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserClickElementsearchElementBoundingBoxLeft != null)
                    {
                        browserClickElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxLeft);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementBoundingBoxRight != null)
                {
                    if (browserClickElementsearchElementBoundingBoxRight != null)
                    {
                        browserClickElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxRight);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxRight"] = 99999;
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementBoundingBoxTop != null)
                {
                    if (browserClickElementsearchElementBoundingBoxTop != null)
                    {
                        browserClickElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxTop);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxTop"] = -99999;
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserClickElementsearchElementBoundingBoxBottom != null)
                    {
                        browserClickElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxBottom);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserClickElementpropCount++;
                }

                if (browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
                browserClickElement["Workflow"] = ExpressionConverter.ConvertO(browserClickElementworkflow);
                if (browserClickElementpropCount > 0)
                {
                    callPayload.Body = browserClickElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSubmitElement))]
        public IWorkflowAction BrowserSubmitElement([WorkflowExpression] Func<string> browserSubmitElementworkflow, [WorkflowExpression] Func<double> browserSubmitElementparentElementHandle = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementName = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementID = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementType = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSubmitElement(WorkflowExpression<string> browserSubmitElementworkflow, WorkflowExpression<double> browserSubmitElementparentElementHandle = null, WorkflowExpression<double> browserSubmitElementsearchElementHandle = null, WorkflowExpression<string> browserSubmitElementsearchElementName = null, WorkflowExpression<string> browserSubmitElementsearchElementID = null, WorkflowExpression<string> browserSubmitElementsearchElementTagName = null, WorkflowExpression<string> browserSubmitElementsearchElementXPath = null, WorkflowExpression<string> browserSubmitElementsearchElementClassName = null, WorkflowExpression<string> browserSubmitElementsearchElementCSSSelector = null, WorkflowExpression<double> browserSubmitElementsearchElementIndex = null, WorkflowExpression<string> browserSubmitElementsearchElementMatchValue = null, WorkflowExpression<string> browserSubmitElementsearchElementMatchText = null, WorkflowExpression<string> browserSubmitElementsearchElementType = null, WorkflowExpression<double> browserSubmitElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserSubmitElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserSubmitElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserSubmitElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserSubmitElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserSubmitElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserSubmitElementworkflow, nameof(browserSubmitElementworkflow), required: true);
            WorkflowExpression.Validate(browserSubmitElementparentElementHandle, nameof(browserSubmitElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementHandle, nameof(browserSubmitElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementName, nameof(browserSubmitElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementID, nameof(browserSubmitElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementTagName, nameof(browserSubmitElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementXPath, nameof(browserSubmitElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementClassName, nameof(browserSubmitElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementCSSSelector, nameof(browserSubmitElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementIndex, nameof(browserSubmitElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementMatchValue, nameof(browserSubmitElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementMatchText, nameof(browserSubmitElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementType, nameof(browserSubmitElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementMinimumWidth, nameof(browserSubmitElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementMinimumHeight, nameof(browserSubmitElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementBoundingBoxLeft, nameof(browserSubmitElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementBoundingBoxRight, nameof(browserSubmitElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementBoundingBoxTop, nameof(browserSubmitElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserSubmitElementsearchElementBoundingBoxBottom, nameof(browserSubmitElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SubmitElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSubmitElement = new JObject();
                var browserSubmitElementpropCount = 0;
                if (browserSubmitElementparentElementHandle != null)
                {
                    browserSubmitElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSubmitElementparentElementHandle);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementHandle != null)
                {
                    browserSubmitElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementHandle);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementName != null)
                {
                    browserSubmitElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementName);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementID != null)
                {
                    browserSubmitElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementID);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementTagName != null)
                {
                    browserSubmitElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementTagName);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementXPath != null)
                {
                    browserSubmitElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementXPath);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementClassName != null)
                {
                    browserSubmitElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementClassName);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementCSSSelector != null)
                {
                    browserSubmitElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementCSSSelector);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementIndex != null)
                {
                    if (browserSubmitElementsearchElementIndex != null)
                    {
                        browserSubmitElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementIndex);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementIndex"] = 1;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementMatchValue != null)
                {
                    browserSubmitElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMatchValue);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementMatchText != null)
                {
                    browserSubmitElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMatchText);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementType != null)
                {
                    browserSubmitElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementType);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementMinimumWidth != null)
                {
                    if (browserSubmitElementsearchElementMinimumWidth != null)
                    {
                        browserSubmitElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMinimumWidth);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementMinimumWidth"] = 1;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementMinimumHeight != null)
                {
                    if (browserSubmitElementsearchElementMinimumHeight != null)
                    {
                        browserSubmitElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMinimumHeight);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementMinimumHeight"] = 1;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserSubmitElementsearchElementBoundingBoxLeft != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxLeft);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementBoundingBoxRight != null)
                {
                    if (browserSubmitElementsearchElementBoundingBoxRight != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxRight);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxRight"] = 99999;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementBoundingBoxTop != null)
                {
                    if (browserSubmitElementsearchElementBoundingBoxTop != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxTop);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxTop"] = -99999;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserSubmitElementsearchElementBoundingBoxBottom != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxBottom);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
                browserSubmitElement["Workflow"] = ExpressionConverter.ConvertO(browserSubmitElementworkflow);
                if (browserSubmitElementpropCount > 0)
                {
                    callPayload.Body = browserSubmitElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCheckElement))]
        public IWorkflowAction BrowserCheckElement([WorkflowExpression] Func<string> browserCheckElementworkflow, [WorkflowExpression] Func<double> browserCheckElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementName = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementID = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementType = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserCheckElementcheckElement = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCheckElement(WorkflowExpression<string> browserCheckElementworkflow, WorkflowExpression<double> browserCheckElementparentElementHandle = null, WorkflowExpression<double> browserCheckElementsearchElementHandle = null, WorkflowExpression<string> browserCheckElementsearchElementName = null, WorkflowExpression<string> browserCheckElementsearchElementID = null, WorkflowExpression<string> browserCheckElementsearchElementTagName = null, WorkflowExpression<string> browserCheckElementsearchElementXPath = null, WorkflowExpression<string> browserCheckElementsearchElementClassName = null, WorkflowExpression<string> browserCheckElementsearchElementCSSSelector = null, WorkflowExpression<double> browserCheckElementsearchElementIndex = null, WorkflowExpression<string> browserCheckElementsearchElementMatchValue = null, WorkflowExpression<string> browserCheckElementsearchElementMatchText = null, WorkflowExpression<string> browserCheckElementsearchElementType = null, WorkflowExpression<double> browserCheckElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserCheckElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserCheckElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserCheckElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserCheckElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserCheckElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserCheckElementcheckElement = null)
        {
            WorkflowExpression.Validate(browserCheckElementworkflow, nameof(browserCheckElementworkflow), required: true);
            WorkflowExpression.Validate(browserCheckElementparentElementHandle, nameof(browserCheckElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementHandle, nameof(browserCheckElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementName, nameof(browserCheckElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementID, nameof(browserCheckElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementTagName, nameof(browserCheckElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementXPath, nameof(browserCheckElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementClassName, nameof(browserCheckElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementCSSSelector, nameof(browserCheckElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementIndex, nameof(browserCheckElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementMatchValue, nameof(browserCheckElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementMatchText, nameof(browserCheckElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementType, nameof(browserCheckElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementMinimumWidth, nameof(browserCheckElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementMinimumHeight, nameof(browserCheckElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementBoundingBoxLeft, nameof(browserCheckElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementBoundingBoxRight, nameof(browserCheckElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementBoundingBoxTop, nameof(browserCheckElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserCheckElementsearchElementBoundingBoxBottom, nameof(browserCheckElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserCheckElementcheckElement, nameof(browserCheckElementcheckElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCheckElement = new JObject();
                var browserCheckElementpropCount = 0;
                if (browserCheckElementparentElementHandle != null)
                {
                    browserCheckElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCheckElementparentElementHandle);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementHandle != null)
                {
                    browserCheckElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementHandle);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementName != null)
                {
                    browserCheckElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementName);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementID != null)
                {
                    browserCheckElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementID);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementTagName != null)
                {
                    browserCheckElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementTagName);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementXPath != null)
                {
                    browserCheckElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementXPath);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementClassName != null)
                {
                    browserCheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementClassName);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementCSSSelector != null)
                {
                    browserCheckElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementCSSSelector);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementIndex != null)
                {
                    if (browserCheckElementsearchElementIndex != null)
                    {
                        browserCheckElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementIndex);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementIndex"] = 1;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementMatchValue != null)
                {
                    browserCheckElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMatchValue);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementMatchText != null)
                {
                    browserCheckElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMatchText);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementType != null)
                {
                    browserCheckElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementType);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementMinimumWidth != null)
                {
                    if (browserCheckElementsearchElementMinimumWidth != null)
                    {
                        browserCheckElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMinimumWidth);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementMinimumWidth"] = 1;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementMinimumHeight != null)
                {
                    if (browserCheckElementsearchElementMinimumHeight != null)
                    {
                        browserCheckElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMinimumHeight);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementMinimumHeight"] = 1;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserCheckElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxLeft);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementBoundingBoxRight != null)
                {
                    if (browserCheckElementsearchElementBoundingBoxRight != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxRight);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementBoundingBoxTop != null)
                {
                    if (browserCheckElementsearchElementBoundingBoxTop != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxTop);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserCheckElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxBottom);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementcheckElement != null)
                {
                    if (browserCheckElementcheckElement != null)
                    {
                        browserCheckElement["CheckElement"] = ExpressionConverter.ConvertO(browserCheckElementcheckElement);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["CheckElement"] = true;
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
                browserCheckElement["Workflow"] = ExpressionConverter.ConvertO(browserCheckElementworkflow);
                if (browserCheckElementpropCount > 0)
                {
                    callPayload.Body = browserCheckElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCheckMultipleElements))]
        public IWorkflowAction BrowserCheckMultipleElements([WorkflowExpression] Func<string> browserCheckMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> browserCheckMultipleElementsworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCheckMultipleElements(WorkflowExpression<string> browserCheckMultipleElementsinputElementsJSON, WorkflowExpression<string> browserCheckMultipleElementsworkflow)
        {
            WorkflowExpression.Validate(browserCheckMultipleElementsinputElementsJSON, nameof(browserCheckMultipleElementsinputElementsJSON), required: true);
            WorkflowExpression.Validate(browserCheckMultipleElementsworkflow, nameof(browserCheckMultipleElementsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCheckMultipleElements = new JObject();
                var browserCheckMultipleElementspropCount = 0;
                browserCheckMultipleElementspropCount++;
                browserCheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(browserCheckMultipleElementsinputElementsJSON);
                browserCheckMultipleElementspropCount++;
                browserCheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(browserCheckMultipleElementsworkflow);
                if (browserCheckMultipleElementspropCount > 0)
                {
                    callPayload.Body = browserCheckMultipleElements;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetSelectionProperties))]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> BrowserGetSelectionProperties([WorkflowExpression] Func<string> browserGetSelectionPropertiesworkflow, [WorkflowExpression] Func<double> browserGetSelectionPropertiesparentElementHandle = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementHandle = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementIndex = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> __BuildBrowserGetSelectionProperties(WorkflowExpression<string> browserGetSelectionPropertiesworkflow, WorkflowExpression<double> browserGetSelectionPropertiesparentElementHandle = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementHandle = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementName = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementID = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementTagName = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementXPath = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementClassName = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementCSSSelector = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementIndex = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementMatchValue = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementMatchText = null, WorkflowExpression<string> browserGetSelectionPropertiessearchElementType = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementMinimumWidth = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementMinimumHeight = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetSelectionPropertiessearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserGetSelectionPropertiesworkflow, nameof(browserGetSelectionPropertiesworkflow), required: true);
            WorkflowExpression.Validate(browserGetSelectionPropertiesparentElementHandle, nameof(browserGetSelectionPropertiesparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementHandle, nameof(browserGetSelectionPropertiessearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementName, nameof(browserGetSelectionPropertiessearchElementName), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementID, nameof(browserGetSelectionPropertiessearchElementID), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementTagName, nameof(browserGetSelectionPropertiessearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementXPath, nameof(browserGetSelectionPropertiessearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementClassName, nameof(browserGetSelectionPropertiessearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementCSSSelector, nameof(browserGetSelectionPropertiessearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementIndex, nameof(browserGetSelectionPropertiessearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementMatchValue, nameof(browserGetSelectionPropertiessearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementMatchText, nameof(browserGetSelectionPropertiessearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementType, nameof(browserGetSelectionPropertiessearchElementType), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementMinimumWidth, nameof(browserGetSelectionPropertiessearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementMinimumHeight, nameof(browserGetSelectionPropertiessearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxLeft, nameof(browserGetSelectionPropertiessearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxRight, nameof(browserGetSelectionPropertiessearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxTop, nameof(browserGetSelectionPropertiessearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxBottom, nameof(browserGetSelectionPropertiessearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserGetSelectionPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetSelectionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetSelectionProperties = new JObject();
                var browserGetSelectionPropertiespropCount = 0;
                if (browserGetSelectionPropertiesparentElementHandle != null)
                {
                    browserGetSelectionProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesparentElementHandle);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementHandle != null)
                {
                    browserGetSelectionProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementHandle);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementName != null)
                {
                    browserGetSelectionProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementID != null)
                {
                    browserGetSelectionProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementID);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementTagName != null)
                {
                    browserGetSelectionProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementTagName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementXPath != null)
                {
                    browserGetSelectionProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementXPath);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementClassName != null)
                {
                    browserGetSelectionProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementClassName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementCSSSelector != null)
                {
                    browserGetSelectionProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementCSSSelector);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementIndex != null)
                {
                    if (browserGetSelectionPropertiessearchElementIndex != null)
                    {
                        browserGetSelectionProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementIndex);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementIndex"] = 1;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementMatchValue != null)
                {
                    browserGetSelectionProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMatchValue);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementMatchText != null)
                {
                    browserGetSelectionProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMatchText);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementType != null)
                {
                    browserGetSelectionProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementType);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetSelectionProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMinimumWidth);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementMinimumWidth"] = 1;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementMinimumHeight != null)
                {
                    if (browserGetSelectionPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetSelectionProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMinimumHeight);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementMinimumHeight"] = 1;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxLeft);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
                {
                    if (browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxRight);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
                {
                    if (browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxTop);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxBottom);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
                browserGetSelectionProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesworkflow);
                if (browserGetSelectionPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetSelectionProperties;
                }

                return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSelectSelection))]
        public IWorkflowAction BrowserSelectSelection([WorkflowExpression] Func<string> browserSelectSelectionworkflow, [WorkflowExpression] Func<double> browserSelectSelectionparentElementHandle = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementHandle = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementName = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementID = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementTagName = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementXPath = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementClassName = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementIndex = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementType = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserSelectSelectionvalueToSelect = null, [WorkflowExpression] Func<string> browserSelectSelectiontextToSelect = null, [WorkflowExpression] Func<double> browserSelectSelectionindexToSelect = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSelectSelection(WorkflowExpression<string> browserSelectSelectionworkflow, WorkflowExpression<double> browserSelectSelectionparentElementHandle = null, WorkflowExpression<double> browserSelectSelectionsearchElementHandle = null, WorkflowExpression<string> browserSelectSelectionsearchElementName = null, WorkflowExpression<string> browserSelectSelectionsearchElementID = null, WorkflowExpression<string> browserSelectSelectionsearchElementTagName = null, WorkflowExpression<string> browserSelectSelectionsearchElementXPath = null, WorkflowExpression<string> browserSelectSelectionsearchElementClassName = null, WorkflowExpression<string> browserSelectSelectionsearchElementCSSSelector = null, WorkflowExpression<double> browserSelectSelectionsearchElementIndex = null, WorkflowExpression<string> browserSelectSelectionsearchElementMatchValue = null, WorkflowExpression<string> browserSelectSelectionsearchElementMatchText = null, WorkflowExpression<string> browserSelectSelectionsearchElementType = null, WorkflowExpression<double> browserSelectSelectionsearchElementMinimumWidth = null, WorkflowExpression<double> browserSelectSelectionsearchElementMinimumHeight = null, WorkflowExpression<double> browserSelectSelectionsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserSelectSelectionsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserSelectSelectionsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserSelectSelectionsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<string> browserSelectSelectionvalueToSelect = null, WorkflowExpression<string> browserSelectSelectiontextToSelect = null, WorkflowExpression<double> browserSelectSelectionindexToSelect = null)
        {
            WorkflowExpression.Validate(browserSelectSelectionworkflow, nameof(browserSelectSelectionworkflow), required: true);
            WorkflowExpression.Validate(browserSelectSelectionparentElementHandle, nameof(browserSelectSelectionparentElementHandle), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementHandle, nameof(browserSelectSelectionsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementName, nameof(browserSelectSelectionsearchElementName), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementID, nameof(browserSelectSelectionsearchElementID), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementTagName, nameof(browserSelectSelectionsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementXPath, nameof(browserSelectSelectionsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementClassName, nameof(browserSelectSelectionsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementCSSSelector, nameof(browserSelectSelectionsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementIndex, nameof(browserSelectSelectionsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementMatchValue, nameof(browserSelectSelectionsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementMatchText, nameof(browserSelectSelectionsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementType, nameof(browserSelectSelectionsearchElementType), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementMinimumWidth, nameof(browserSelectSelectionsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementMinimumHeight, nameof(browserSelectSelectionsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementBoundingBoxLeft, nameof(browserSelectSelectionsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementBoundingBoxRight, nameof(browserSelectSelectionsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementBoundingBoxTop, nameof(browserSelectSelectionsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserSelectSelectionsearchElementBoundingBoxBottom, nameof(browserSelectSelectionsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserSelectSelectionvalueToSelect, nameof(browserSelectSelectionvalueToSelect), required: false);
            WorkflowExpression.Validate(browserSelectSelectiontextToSelect, nameof(browserSelectSelectiontextToSelect), required: false);
            WorkflowExpression.Validate(browserSelectSelectionindexToSelect, nameof(browserSelectSelectionindexToSelect), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SelectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSelectSelection = new JObject();
                var browserSelectSelectionpropCount = 0;
                if (browserSelectSelectionparentElementHandle != null)
                {
                    browserSelectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSelectSelectionparentElementHandle);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementHandle != null)
                {
                    browserSelectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementHandle);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementName != null)
                {
                    browserSelectSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementName);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementID != null)
                {
                    browserSelectSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementID);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementTagName != null)
                {
                    browserSelectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementTagName);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementXPath != null)
                {
                    browserSelectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementXPath);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementClassName != null)
                {
                    browserSelectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementClassName);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementCSSSelector != null)
                {
                    browserSelectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementCSSSelector);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementIndex != null)
                {
                    if (browserSelectSelectionsearchElementIndex != null)
                    {
                        browserSelectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementIndex);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementIndex"] = 1;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementMatchValue != null)
                {
                    browserSelectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMatchValue);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementMatchText != null)
                {
                    browserSelectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMatchText);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementType != null)
                {
                    browserSelectSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementType);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementMinimumWidth != null)
                {
                    if (browserSelectSelectionsearchElementMinimumWidth != null)
                    {
                        browserSelectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMinimumWidth);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementMinimumWidth"] = 1;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementMinimumHeight != null)
                {
                    if (browserSelectSelectionsearchElementMinimumHeight != null)
                    {
                        browserSelectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMinimumHeight);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementMinimumHeight"] = 1;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementBoundingBoxLeft != null)
                {
                    if (browserSelectSelectionsearchElementBoundingBoxLeft != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxLeft);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxLeft"] = -99999;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementBoundingBoxRight != null)
                {
                    if (browserSelectSelectionsearchElementBoundingBoxRight != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxRight);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxRight"] = 99999;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementBoundingBoxTop != null)
                {
                    if (browserSelectSelectionsearchElementBoundingBoxTop != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxTop);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxTop"] = -99999;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementBoundingBoxBottom != null)
                {
                    if (browserSelectSelectionsearchElementBoundingBoxBottom != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxBottom);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxBottom"] = 99999;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionvalueToSelect != null)
                {
                    browserSelectSelection["ValueToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionvalueToSelect);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectiontextToSelect != null)
                {
                    browserSelectSelection["TextToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectiontextToSelect);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionindexToSelect != null)
                {
                    if (browserSelectSelectionindexToSelect != null)
                    {
                        browserSelectSelection["IndexToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionindexToSelect);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["IndexToSelect"] = 1;
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
                browserSelectSelection["Workflow"] = ExpressionConverter.ConvertO(browserSelectSelectionworkflow);
                if (browserSelectSelectionpropCount > 0)
                {
                    callPayload.Body = browserSelectSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserDeselectSelection))]
        public IWorkflowAction BrowserDeselectSelection([WorkflowExpression] Func<string> browserDeselectSelectionworkflow, [WorkflowExpression] Func<double> browserDeselectSelectionparentElementHandle = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementHandle = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementName = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementID = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementTagName = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementXPath = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementClassName = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementIndex = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementType = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserDeselectSelectionvalueToDeselect = null, [WorkflowExpression] Func<string> browserDeselectSelectiontextToDeselect = null, [WorkflowExpression] Func<double> browserDeselectSelectionindexToDeselect = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserDeselectSelection(WorkflowExpression<string> browserDeselectSelectionworkflow, WorkflowExpression<double> browserDeselectSelectionparentElementHandle = null, WorkflowExpression<double> browserDeselectSelectionsearchElementHandle = null, WorkflowExpression<string> browserDeselectSelectionsearchElementName = null, WorkflowExpression<string> browserDeselectSelectionsearchElementID = null, WorkflowExpression<string> browserDeselectSelectionsearchElementTagName = null, WorkflowExpression<string> browserDeselectSelectionsearchElementXPath = null, WorkflowExpression<string> browserDeselectSelectionsearchElementClassName = null, WorkflowExpression<string> browserDeselectSelectionsearchElementCSSSelector = null, WorkflowExpression<double> browserDeselectSelectionsearchElementIndex = null, WorkflowExpression<string> browserDeselectSelectionsearchElementMatchValue = null, WorkflowExpression<string> browserDeselectSelectionsearchElementMatchText = null, WorkflowExpression<string> browserDeselectSelectionsearchElementType = null, WorkflowExpression<double> browserDeselectSelectionsearchElementMinimumWidth = null, WorkflowExpression<double> browserDeselectSelectionsearchElementMinimumHeight = null, WorkflowExpression<double> browserDeselectSelectionsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserDeselectSelectionsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserDeselectSelectionsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserDeselectSelectionsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<string> browserDeselectSelectionvalueToDeselect = null, WorkflowExpression<string> browserDeselectSelectiontextToDeselect = null, WorkflowExpression<double> browserDeselectSelectionindexToDeselect = null)
        {
            WorkflowExpression.Validate(browserDeselectSelectionworkflow, nameof(browserDeselectSelectionworkflow), required: true);
            WorkflowExpression.Validate(browserDeselectSelectionparentElementHandle, nameof(browserDeselectSelectionparentElementHandle), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementHandle, nameof(browserDeselectSelectionsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementName, nameof(browserDeselectSelectionsearchElementName), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementID, nameof(browserDeselectSelectionsearchElementID), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementTagName, nameof(browserDeselectSelectionsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementXPath, nameof(browserDeselectSelectionsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementClassName, nameof(browserDeselectSelectionsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementCSSSelector, nameof(browserDeselectSelectionsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementIndex, nameof(browserDeselectSelectionsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementMatchValue, nameof(browserDeselectSelectionsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementMatchText, nameof(browserDeselectSelectionsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementType, nameof(browserDeselectSelectionsearchElementType), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementMinimumWidth, nameof(browserDeselectSelectionsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementMinimumHeight, nameof(browserDeselectSelectionsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxLeft, nameof(browserDeselectSelectionsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxRight, nameof(browserDeselectSelectionsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxTop, nameof(browserDeselectSelectionsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxBottom, nameof(browserDeselectSelectionsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionvalueToDeselect, nameof(browserDeselectSelectionvalueToDeselect), required: false);
            WorkflowExpression.Validate(browserDeselectSelectiontextToDeselect, nameof(browserDeselectSelectiontextToDeselect), required: false);
            WorkflowExpression.Validate(browserDeselectSelectionindexToDeselect, nameof(browserDeselectSelectionindexToDeselect), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/DeselectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDeselectSelection = new JObject();
                var browserDeselectSelectionpropCount = 0;
                if (browserDeselectSelectionparentElementHandle != null)
                {
                    browserDeselectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDeselectSelectionparentElementHandle);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementHandle != null)
                {
                    browserDeselectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementHandle);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementName != null)
                {
                    browserDeselectSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementName);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementID != null)
                {
                    browserDeselectSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementID);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementTagName != null)
                {
                    browserDeselectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementTagName);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementXPath != null)
                {
                    browserDeselectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementXPath);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementClassName != null)
                {
                    browserDeselectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementClassName);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementCSSSelector != null)
                {
                    browserDeselectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementCSSSelector);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementIndex != null)
                {
                    if (browserDeselectSelectionsearchElementIndex != null)
                    {
                        browserDeselectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementIndex);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementIndex"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementMatchValue != null)
                {
                    browserDeselectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMatchValue);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementMatchText != null)
                {
                    browserDeselectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMatchText);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementType != null)
                {
                    browserDeselectSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementType);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementMinimumWidth != null)
                {
                    if (browserDeselectSelectionsearchElementMinimumWidth != null)
                    {
                        browserDeselectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMinimumWidth);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementMinimumWidth"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementMinimumHeight != null)
                {
                    if (browserDeselectSelectionsearchElementMinimumHeight != null)
                    {
                        browserDeselectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMinimumHeight);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementMinimumHeight"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementBoundingBoxLeft != null)
                {
                    if (browserDeselectSelectionsearchElementBoundingBoxLeft != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxLeft);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxLeft"] = -99999;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementBoundingBoxRight != null)
                {
                    if (browserDeselectSelectionsearchElementBoundingBoxRight != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxRight);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxRight"] = 99999;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementBoundingBoxTop != null)
                {
                    if (browserDeselectSelectionsearchElementBoundingBoxTop != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxTop);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxTop"] = -99999;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementBoundingBoxBottom != null)
                {
                    if (browserDeselectSelectionsearchElementBoundingBoxBottom != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxBottom);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxBottom"] = 99999;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionvalueToDeselect != null)
                {
                    browserDeselectSelection["ValueToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionvalueToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectiontextToDeselect != null)
                {
                    browserDeselectSelection["TextToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectiontextToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionindexToDeselect != null)
                {
                    if (browserDeselectSelectionindexToDeselect != null)
                    {
                        browserDeselectSelection["IndexToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionindexToDeselect);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["IndexToDeselect"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
                browserDeselectSelection["Workflow"] = ExpressionConverter.ConvertO(browserDeselectSelectionworkflow);
                if (browserDeselectSelectionpropCount > 0)
                {
                    callPayload.Body = browserDeselectSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserDeselectAllSelection))]
        public IWorkflowAction BrowserDeselectAllSelection([WorkflowExpression] Func<string> browserDeselectAllSelectionworkflow, [WorkflowExpression] Func<double> browserDeselectAllSelectionparentElementHandle = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementHandle = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementName = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementID = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementTagName = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementXPath = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementClassName = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementIndex = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementType = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserDeselectAllSelection(WorkflowExpression<string> browserDeselectAllSelectionworkflow, WorkflowExpression<double> browserDeselectAllSelectionparentElementHandle = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementHandle = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementName = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementID = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementTagName = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementXPath = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementClassName = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementCSSSelector = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementIndex = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementMatchValue = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementMatchText = null, WorkflowExpression<string> browserDeselectAllSelectionsearchElementType = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementMinimumWidth = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementMinimumHeight = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserDeselectAllSelectionsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserDeselectAllSelectionworkflow, nameof(browserDeselectAllSelectionworkflow), required: true);
            WorkflowExpression.Validate(browserDeselectAllSelectionparentElementHandle, nameof(browserDeselectAllSelectionparentElementHandle), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementHandle, nameof(browserDeselectAllSelectionsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementName, nameof(browserDeselectAllSelectionsearchElementName), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementID, nameof(browserDeselectAllSelectionsearchElementID), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementTagName, nameof(browserDeselectAllSelectionsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementXPath, nameof(browserDeselectAllSelectionsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementClassName, nameof(browserDeselectAllSelectionsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementCSSSelector, nameof(browserDeselectAllSelectionsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementIndex, nameof(browserDeselectAllSelectionsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementMatchValue, nameof(browserDeselectAllSelectionsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementMatchText, nameof(browserDeselectAllSelectionsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementType, nameof(browserDeselectAllSelectionsearchElementType), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementMinimumWidth, nameof(browserDeselectAllSelectionsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementMinimumHeight, nameof(browserDeselectAllSelectionsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxLeft, nameof(browserDeselectAllSelectionsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxRight, nameof(browserDeselectAllSelectionsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxTop, nameof(browserDeselectAllSelectionsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxBottom, nameof(browserDeselectAllSelectionsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/DeselectAllSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDeselectAllSelection = new JObject();
                var browserDeselectAllSelectionpropCount = 0;
                if (browserDeselectAllSelectionparentElementHandle != null)
                {
                    browserDeselectAllSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionparentElementHandle);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementHandle != null)
                {
                    browserDeselectAllSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementHandle);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementName != null)
                {
                    browserDeselectAllSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementID != null)
                {
                    browserDeselectAllSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementID);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementTagName != null)
                {
                    browserDeselectAllSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementTagName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementXPath != null)
                {
                    browserDeselectAllSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementXPath);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementClassName != null)
                {
                    browserDeselectAllSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementClassName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementCSSSelector != null)
                {
                    browserDeselectAllSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementCSSSelector);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementIndex != null)
                {
                    if (browserDeselectAllSelectionsearchElementIndex != null)
                    {
                        browserDeselectAllSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementIndex);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementIndex"] = 1;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementMatchValue != null)
                {
                    browserDeselectAllSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMatchValue);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementMatchText != null)
                {
                    browserDeselectAllSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMatchText);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementType != null)
                {
                    browserDeselectAllSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementType);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
                {
                    if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
                    {
                        browserDeselectAllSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMinimumWidth);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementMinimumWidth"] = 1;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementMinimumHeight != null)
                {
                    if (browserDeselectAllSelectionsearchElementMinimumHeight != null)
                    {
                        browserDeselectAllSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMinimumHeight);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementMinimumHeight"] = 1;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
                {
                    if (browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxLeft);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = -99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
                {
                    if (browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxRight);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxRight"] = 99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
                {
                    if (browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxTop);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxTop"] = -99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
                {
                    if (browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxBottom);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = 99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
                browserDeselectAllSelection["Workflow"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionworkflow);
                if (browserDeselectAllSelectionpropCount > 0)
                {
                    callPayload.Body = browserDeselectAllSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetTableContents))]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> BrowserGetTableContents([WorkflowExpression] Func<string> browserGetTableContentsworkflow, [WorkflowExpression] Func<double> browserGetTableContentsparentElementHandle = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementHandle = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementName = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementID = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementTagName = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementXPath = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementClassName = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementIndex = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementType = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<double> browserGetTableContentscreateColumnNamesFromRow = null, [WorkflowExpression] Func<bool> browserGetTableContentsmergeChildTables = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> __BuildBrowserGetTableContents(WorkflowExpression<string> browserGetTableContentsworkflow, WorkflowExpression<double> browserGetTableContentsparentElementHandle = null, WorkflowExpression<double> browserGetTableContentssearchElementHandle = null, WorkflowExpression<string> browserGetTableContentssearchElementName = null, WorkflowExpression<string> browserGetTableContentssearchElementID = null, WorkflowExpression<string> browserGetTableContentssearchElementTagName = null, WorkflowExpression<string> browserGetTableContentssearchElementXPath = null, WorkflowExpression<string> browserGetTableContentssearchElementClassName = null, WorkflowExpression<string> browserGetTableContentssearchElementCSSSelector = null, WorkflowExpression<double> browserGetTableContentssearchElementIndex = null, WorkflowExpression<string> browserGetTableContentssearchElementMatchValue = null, WorkflowExpression<string> browserGetTableContentssearchElementMatchText = null, WorkflowExpression<string> browserGetTableContentssearchElementType = null, WorkflowExpression<double> browserGetTableContentssearchElementMinimumWidth = null, WorkflowExpression<double> browserGetTableContentssearchElementMinimumHeight = null, WorkflowExpression<double> browserGetTableContentssearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetTableContentssearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetTableContentssearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetTableContentssearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<double> browserGetTableContentscreateColumnNamesFromRow = null, WorkflowExpression<bool> browserGetTableContentsmergeChildTables = null)
        {
            WorkflowExpression.Validate(browserGetTableContentsworkflow, nameof(browserGetTableContentsworkflow), required: true);
            WorkflowExpression.Validate(browserGetTableContentsparentElementHandle, nameof(browserGetTableContentsparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementHandle, nameof(browserGetTableContentssearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementName, nameof(browserGetTableContentssearchElementName), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementID, nameof(browserGetTableContentssearchElementID), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementTagName, nameof(browserGetTableContentssearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementXPath, nameof(browserGetTableContentssearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementClassName, nameof(browserGetTableContentssearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementCSSSelector, nameof(browserGetTableContentssearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementIndex, nameof(browserGetTableContentssearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementMatchValue, nameof(browserGetTableContentssearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementMatchText, nameof(browserGetTableContentssearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementType, nameof(browserGetTableContentssearchElementType), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementMinimumWidth, nameof(browserGetTableContentssearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementMinimumHeight, nameof(browserGetTableContentssearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementBoundingBoxLeft, nameof(browserGetTableContentssearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementBoundingBoxRight, nameof(browserGetTableContentssearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementBoundingBoxTop, nameof(browserGetTableContentssearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetTableContentssearchElementBoundingBoxBottom, nameof(browserGetTableContentssearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGetTableContentscreateColumnNamesFromRow, nameof(browserGetTableContentscreateColumnNamesFromRow), required: false);
            WorkflowExpression.Validate(browserGetTableContentsmergeChildTables, nameof(browserGetTableContentsmergeChildTables), required: false);
            return new DeferredBodyAction<BrowserGetTableContentsResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetTableContents = new JObject();
                var browserGetTableContentspropCount = 0;
                if (browserGetTableContentsparentElementHandle != null)
                {
                    browserGetTableContents["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetTableContentsparentElementHandle);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementHandle != null)
                {
                    browserGetTableContents["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementHandle);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementName != null)
                {
                    browserGetTableContents["SearchElementName"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementName);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementID != null)
                {
                    browserGetTableContents["SearchElementID"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementID);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementTagName != null)
                {
                    browserGetTableContents["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementTagName);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementXPath != null)
                {
                    browserGetTableContents["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementXPath);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementClassName != null)
                {
                    browserGetTableContents["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementClassName);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementCSSSelector != null)
                {
                    browserGetTableContents["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementCSSSelector);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementIndex != null)
                {
                    if (browserGetTableContentssearchElementIndex != null)
                    {
                        browserGetTableContents["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementIndex);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementIndex"] = 1;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementMatchValue != null)
                {
                    browserGetTableContents["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMatchValue);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementMatchText != null)
                {
                    browserGetTableContents["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMatchText);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementType != null)
                {
                    browserGetTableContents["SearchElementType"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementType);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementMinimumWidth != null)
                {
                    if (browserGetTableContentssearchElementMinimumWidth != null)
                    {
                        browserGetTableContents["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMinimumWidth);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementMinimumWidth"] = 1;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementMinimumHeight != null)
                {
                    if (browserGetTableContentssearchElementMinimumHeight != null)
                    {
                        browserGetTableContents["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMinimumHeight);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementMinimumHeight"] = 1;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementBoundingBoxLeft != null)
                {
                    if (browserGetTableContentssearchElementBoundingBoxLeft != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxLeft);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementBoundingBoxRight != null)
                {
                    if (browserGetTableContentssearchElementBoundingBoxRight != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxRight);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxRight"] = 99999;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementBoundingBoxTop != null)
                {
                    if (browserGetTableContentssearchElementBoundingBoxTop != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxTop);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxTop"] = -99999;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementBoundingBoxBottom != null)
                {
                    if (browserGetTableContentssearchElementBoundingBoxBottom != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxBottom);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentscreateColumnNamesFromRow != null)
                {
                    if (browserGetTableContentscreateColumnNamesFromRow != null)
                    {
                        browserGetTableContents["CreateColumnNamesFromRow"] = ExpressionConverter.ConvertO(browserGetTableContentscreateColumnNamesFromRow);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["CreateColumnNamesFromRow"] = 0;
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentsmergeChildTables != null)
                {
                    if (browserGetTableContentsmergeChildTables != null)
                    {
                        browserGetTableContents["MergeChildTables"] = ExpressionConverter.ConvertO(browserGetTableContentsmergeChildTables);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["MergeChildTables"] = false;
                    browserGetTableContentspropCount++;
                }

                browserGetTableContents["ReturnAsDataTable"] = true;
                browserGetTableContentspropCount++;
                browserGetTableContentspropCount++;
                browserGetTableContents["Workflow"] = ExpressionConverter.ConvertO(browserGetTableContentsworkflow);
                if (browserGetTableContentspropCount > 0)
                {
                    callPayload.Body = browserGetTableContents;
                }

                return new ApiConnectionAction<BrowserGetTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserScrollElementIntoView))]
        public IWorkflowAction BrowserScrollElementIntoView([WorkflowExpression] Func<string> browserScrollElementIntoViewworkflow, [WorkflowExpression] Func<double> browserScrollElementIntoViewparentElementHandle = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementHandle = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementName = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementID = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementTagName = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementXPath = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementClassName = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementIndex = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementMatchText = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementType = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserScrollElementIntoView(WorkflowExpression<string> browserScrollElementIntoViewworkflow, WorkflowExpression<double> browserScrollElementIntoViewparentElementHandle = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementHandle = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementName = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementID = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementTagName = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementXPath = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementClassName = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementCSSSelector = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementIndex = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementMatchValue = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementMatchText = null, WorkflowExpression<string> browserScrollElementIntoViewsearchElementType = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementMinimumWidth = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementMinimumHeight = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserScrollElementIntoViewsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserScrollElementIntoViewworkflow, nameof(browserScrollElementIntoViewworkflow), required: true);
            WorkflowExpression.Validate(browserScrollElementIntoViewparentElementHandle, nameof(browserScrollElementIntoViewparentElementHandle), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementHandle, nameof(browserScrollElementIntoViewsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementName, nameof(browserScrollElementIntoViewsearchElementName), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementID, nameof(browserScrollElementIntoViewsearchElementID), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementTagName, nameof(browserScrollElementIntoViewsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementXPath, nameof(browserScrollElementIntoViewsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementClassName, nameof(browserScrollElementIntoViewsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementCSSSelector, nameof(browserScrollElementIntoViewsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementIndex, nameof(browserScrollElementIntoViewsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementMatchValue, nameof(browserScrollElementIntoViewsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementMatchText, nameof(browserScrollElementIntoViewsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementType, nameof(browserScrollElementIntoViewsearchElementType), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementMinimumWidth, nameof(browserScrollElementIntoViewsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementMinimumHeight, nameof(browserScrollElementIntoViewsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxLeft, nameof(browserScrollElementIntoViewsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxRight, nameof(browserScrollElementIntoViewsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxTop, nameof(browserScrollElementIntoViewsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxBottom, nameof(browserScrollElementIntoViewsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollElementIntoView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollElementIntoView = new JObject();
                var browserScrollElementIntoViewpropCount = 0;
                if (browserScrollElementIntoViewparentElementHandle != null)
                {
                    browserScrollElementIntoView["ParentElementHandle"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewparentElementHandle);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementHandle != null)
                {
                    browserScrollElementIntoView["SearchElementHandle"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementHandle);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementName != null)
                {
                    browserScrollElementIntoView["SearchElementName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementID != null)
                {
                    browserScrollElementIntoView["SearchElementID"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementID);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementTagName != null)
                {
                    browserScrollElementIntoView["SearchElementTagName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementTagName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementXPath != null)
                {
                    browserScrollElementIntoView["SearchElementXPath"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementXPath);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementClassName != null)
                {
                    browserScrollElementIntoView["SearchElementClassName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementClassName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementCSSSelector != null)
                {
                    browserScrollElementIntoView["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementCSSSelector);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementIndex != null)
                {
                    if (browserScrollElementIntoViewsearchElementIndex != null)
                    {
                        browserScrollElementIntoView["SearchElementIndex"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementIndex);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementIndex"] = 1;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementMatchValue != null)
                {
                    browserScrollElementIntoView["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMatchValue);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementMatchText != null)
                {
                    browserScrollElementIntoView["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMatchText);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementType != null)
                {
                    browserScrollElementIntoView["SearchElementType"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementType);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
                {
                    if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
                    {
                        browserScrollElementIntoView["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMinimumWidth);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementMinimumWidth"] = 1;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementMinimumHeight != null)
                {
                    if (browserScrollElementIntoViewsearchElementMinimumHeight != null)
                    {
                        browserScrollElementIntoView["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMinimumHeight);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementMinimumHeight"] = 1;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
                {
                    if (browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxLeft);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = -99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
                {
                    if (browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxRight);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxRight"] = 99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
                {
                    if (browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxTop);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxTop"] = -99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
                {
                    if (browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxBottom);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = 99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
                browserScrollElementIntoView["Workflow"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewworkflow);
                if (browserScrollElementIntoViewpropCount > 0)
                {
                    callPayload.Body = browserScrollElementIntoView;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserExecuteJavaScript))]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> BrowserExecuteJavaScript([WorkflowExpression] Func<string> browserExecuteJavaScriptjavaScriptCode, [WorkflowExpression] Func<string> browserExecuteJavaScriptworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> __BuildBrowserExecuteJavaScript(WorkflowExpression<string> browserExecuteJavaScriptjavaScriptCode, WorkflowExpression<string> browserExecuteJavaScriptworkflow)
        {
            WorkflowExpression.Validate(browserExecuteJavaScriptjavaScriptCode, nameof(browserExecuteJavaScriptjavaScriptCode), required: true);
            WorkflowExpression.Validate(browserExecuteJavaScriptworkflow, nameof(browserExecuteJavaScriptworkflow), required: true);
            return new DeferredBodyAction<BrowserExecuteJavaScriptResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserExecuteJavaScript = new JObject();
                var browserExecuteJavaScriptpropCount = 0;
                browserExecuteJavaScriptpropCount++;
                browserExecuteJavaScript["JavaScriptCode"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptjavaScriptCode);
                browserExecuteJavaScriptpropCount++;
                browserExecuteJavaScript["Workflow"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptworkflow);
                if (browserExecuteJavaScriptpropCount > 0)
                {
                    callPayload.Body = browserExecuteJavaScript;
                }

                return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetElementBoundingRect))]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> BrowserGetElementBoundingRect([WorkflowExpression] Func<string> browserGetElementBoundingRectworkflow, [WorkflowExpression] Func<double> browserGetElementBoundingRectparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementName = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementID = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementType = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> __BuildBrowserGetElementBoundingRect(WorkflowExpression<string> browserGetElementBoundingRectworkflow, WorkflowExpression<double> browserGetElementBoundingRectparentElementHandle = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementHandle = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementName = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementID = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementTagName = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementXPath = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementClassName = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementCSSSelector = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementIndex = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementMatchValue = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementMatchText = null, WorkflowExpression<string> browserGetElementBoundingRectsearchElementType = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementMinimumWidth = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementMinimumHeight = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetElementBoundingRectsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserGetElementBoundingRectworkflow, nameof(browserGetElementBoundingRectworkflow), required: true);
            WorkflowExpression.Validate(browserGetElementBoundingRectparentElementHandle, nameof(browserGetElementBoundingRectparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementHandle, nameof(browserGetElementBoundingRectsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementName, nameof(browserGetElementBoundingRectsearchElementName), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementID, nameof(browserGetElementBoundingRectsearchElementID), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementTagName, nameof(browserGetElementBoundingRectsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementXPath, nameof(browserGetElementBoundingRectsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementClassName, nameof(browserGetElementBoundingRectsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementCSSSelector, nameof(browserGetElementBoundingRectsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementIndex, nameof(browserGetElementBoundingRectsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementMatchValue, nameof(browserGetElementBoundingRectsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementMatchText, nameof(browserGetElementBoundingRectsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementType, nameof(browserGetElementBoundingRectsearchElementType), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementMinimumWidth, nameof(browserGetElementBoundingRectsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementMinimumHeight, nameof(browserGetElementBoundingRectsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxLeft, nameof(browserGetElementBoundingRectsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxRight, nameof(browserGetElementBoundingRectsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxTop, nameof(browserGetElementBoundingRectsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxBottom, nameof(browserGetElementBoundingRectsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserGetElementBoundingRectResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementBoundingRect = new JObject();
                var browserGetElementBoundingRectpropCount = 0;
                if (browserGetElementBoundingRectparentElementHandle != null)
                {
                    browserGetElementBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectparentElementHandle);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementHandle != null)
                {
                    browserGetElementBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementHandle);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementName != null)
                {
                    browserGetElementBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementID != null)
                {
                    browserGetElementBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementID);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementTagName != null)
                {
                    browserGetElementBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementTagName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementXPath != null)
                {
                    browserGetElementBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementXPath);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementClassName != null)
                {
                    browserGetElementBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementClassName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementCSSSelector != null)
                {
                    browserGetElementBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementCSSSelector);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementIndex != null)
                {
                    if (browserGetElementBoundingRectsearchElementIndex != null)
                    {
                        browserGetElementBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementIndex);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementIndex"] = 1;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementMatchValue != null)
                {
                    browserGetElementBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMatchValue);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementMatchText != null)
                {
                    browserGetElementBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMatchText);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementType != null)
                {
                    browserGetElementBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementType);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
                {
                    if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
                    {
                        browserGetElementBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMinimumWidth);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementMinimumWidth"] = 1;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementMinimumHeight != null)
                {
                    if (browserGetElementBoundingRectsearchElementMinimumHeight != null)
                    {
                        browserGetElementBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMinimumHeight);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementMinimumHeight"] = 1;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    if (browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxLeft);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
                {
                    if (browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxRight);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
                {
                    if (browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxTop);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    if (browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxBottom);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
                browserGetElementBoundingRect["Workflow"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectworkflow);
                if (browserGetElementBoundingRectpropCount > 0)
                {
                    callPayload.Body = browserGetElementBoundingRect;
                }

                return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserDrawRectangleAroundElement))]
        public IWorkflowAction BrowserDrawRectangleAroundElement([WorkflowExpression] Func<string> browserDrawRectangleAroundElementworkflow, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementparentElementHandle = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementName = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementID = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementType = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementpenColour = null, [WorkflowExpression] Func<int> browserDrawRectangleAroundElementpenThicknessPixels = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserDrawRectangleAroundElement(WorkflowExpression<string> browserDrawRectangleAroundElementworkflow, WorkflowExpression<double> browserDrawRectangleAroundElementparentElementHandle = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementHandle = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementName = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementID = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementTagName = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementXPath = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementClassName = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementCSSSelector = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementIndex = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementMatchValue = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementMatchText = null, WorkflowExpression<string> browserDrawRectangleAroundElementsearchElementType = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<string> browserDrawRectangleAroundElementpenColour = null, WorkflowExpression<int> browserDrawRectangleAroundElementpenThicknessPixels = null)
        {
            WorkflowExpression.Validate(browserDrawRectangleAroundElementworkflow, nameof(browserDrawRectangleAroundElementworkflow), required: true);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementparentElementHandle, nameof(browserDrawRectangleAroundElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementHandle, nameof(browserDrawRectangleAroundElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementName, nameof(browserDrawRectangleAroundElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementID, nameof(browserDrawRectangleAroundElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementTagName, nameof(browserDrawRectangleAroundElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementXPath, nameof(browserDrawRectangleAroundElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementClassName, nameof(browserDrawRectangleAroundElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementCSSSelector, nameof(browserDrawRectangleAroundElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementIndex, nameof(browserDrawRectangleAroundElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementMatchValue, nameof(browserDrawRectangleAroundElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementMatchText, nameof(browserDrawRectangleAroundElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementType, nameof(browserDrawRectangleAroundElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementMinimumWidth, nameof(browserDrawRectangleAroundElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementMinimumHeight, nameof(browserDrawRectangleAroundElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxRight, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxTop, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementpenColour, nameof(browserDrawRectangleAroundElementpenColour), required: false);
            WorkflowExpression.Validate(browserDrawRectangleAroundElementpenThicknessPixels, nameof(browserDrawRectangleAroundElementpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDrawRectangleAroundElement = new JObject();
                var browserDrawRectangleAroundElementpropCount = 0;
                if (browserDrawRectangleAroundElementparentElementHandle != null)
                {
                    browserDrawRectangleAroundElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementparentElementHandle);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementHandle != null)
                {
                    browserDrawRectangleAroundElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementHandle);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementID != null)
                {
                    browserDrawRectangleAroundElement["SearchElementID"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementID);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementTagName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementTagName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementXPath != null)
                {
                    browserDrawRectangleAroundElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementXPath);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementClassName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementClassName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementCSSSelector != null)
                {
                    browserDrawRectangleAroundElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementCSSSelector);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementIndex != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementIndex != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementIndex);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementIndex"] = 1;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementMatchValue != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMatchValue);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementMatchText != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMatchText);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementType != null)
                {
                    browserDrawRectangleAroundElement["SearchElementType"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementType);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMinimumWidth);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = 1;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMinimumHeight);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = 1;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxRight);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = 99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxTop);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = -99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementpenColour != null)
                {
                    if (browserDrawRectangleAroundElementpenColour != null)
                    {
                        browserDrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementpenColour);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["PenColour"] = "green";
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementpenThicknessPixels != null)
                {
                    if (browserDrawRectangleAroundElementpenThicknessPixels != null)
                    {
                        browserDrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementpenThicknessPixels);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["PenThicknessPixels"] = 4;
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
                browserDrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementworkflow);
                if (browserDrawRectangleAroundElementpropCount > 0)
                {
                    callPayload.Body = browserDrawRectangleAroundElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetBrowserParentWindowDetails))]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> BrowserGetBrowserParentWindowDetails([WorkflowExpression] Func<string> browserGetBrowserParentWindowDetailsworkflow, [WorkflowExpression] Func<int> browserGetBrowserParentWindowDetailsbrowserPID = null, [WorkflowExpression] Func<string> browserGetBrowserParentWindowDetailssearchDocumentElementClassName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> __BuildBrowserGetBrowserParentWindowDetails(WorkflowExpression<string> browserGetBrowserParentWindowDetailsworkflow, WorkflowExpression<int> browserGetBrowserParentWindowDetailsbrowserPID = null, WorkflowExpression<string> browserGetBrowserParentWindowDetailssearchDocumentElementClassName = null)
        {
            WorkflowExpression.Validate(browserGetBrowserParentWindowDetailsworkflow, nameof(browserGetBrowserParentWindowDetailsworkflow), required: true);
            WorkflowExpression.Validate(browserGetBrowserParentWindowDetailsbrowserPID, nameof(browserGetBrowserParentWindowDetailsbrowserPID), required: false);
            WorkflowExpression.Validate(browserGetBrowserParentWindowDetailssearchDocumentElementClassName, nameof(browserGetBrowserParentWindowDetailssearchDocumentElementClassName), required: false);
            return new DeferredBodyAction<BrowserGetBrowserParentWindowDetailsResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetBrowserParentWindowDetails = new JObject();
                var browserGetBrowserParentWindowDetailspropCount = 0;
                if (browserGetBrowserParentWindowDetailsbrowserPID != null)
                {
                    browserGetBrowserParentWindowDetails["BrowserPID"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsbrowserPID);
                    browserGetBrowserParentWindowDetailspropCount++;
                }

                if (browserGetBrowserParentWindowDetailssearchDocumentElementClassName != null)
                {
                    browserGetBrowserParentWindowDetails["SearchDocumentElementClassName"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailssearchDocumentElementClassName);
                    browserGetBrowserParentWindowDetailspropCount++;
                }

                browserGetBrowserParentWindowDetailspropCount++;
                browserGetBrowserParentWindowDetails["Workflow"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsworkflow);
                if (browserGetBrowserParentWindowDetailspropCount > 0)
                {
                    callPayload.Body = browserGetBrowserParentWindowDetails;
                }

                return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetElementScreenBoundingRect))]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> BrowserGetElementScreenBoundingRect([WorkflowExpression] Func<string> browserGetElementScreenBoundingRectworkflow, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementName = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementID = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementType = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> __BuildBrowserGetElementScreenBoundingRect(WorkflowExpression<string> browserGetElementScreenBoundingRectworkflow, WorkflowExpression<double> browserGetElementScreenBoundingRectparentElementHandle = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementHandle = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementName = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementID = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementTagName = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementXPath = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementClassName = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementCSSSelector = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementIndex = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementMatchValue = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementMatchText = null, WorkflowExpression<string> browserGetElementScreenBoundingRectsearchElementType = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementMinimumWidth = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementMinimumHeight = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectworkflow, nameof(browserGetElementScreenBoundingRectworkflow), required: true);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectparentElementHandle, nameof(browserGetElementScreenBoundingRectparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementHandle, nameof(browserGetElementScreenBoundingRectsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementName, nameof(browserGetElementScreenBoundingRectsearchElementName), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementID, nameof(browserGetElementScreenBoundingRectsearchElementID), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementTagName, nameof(browserGetElementScreenBoundingRectsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementXPath, nameof(browserGetElementScreenBoundingRectsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementClassName, nameof(browserGetElementScreenBoundingRectsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementCSSSelector, nameof(browserGetElementScreenBoundingRectsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementIndex, nameof(browserGetElementScreenBoundingRectsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementMatchValue, nameof(browserGetElementScreenBoundingRectsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementMatchText, nameof(browserGetElementScreenBoundingRectsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementType, nameof(browserGetElementScreenBoundingRectsearchElementType), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementMinimumWidth, nameof(browserGetElementScreenBoundingRectsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementMinimumHeight, nameof(browserGetElementScreenBoundingRectsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserGetElementScreenBoundingRectResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementScreenBoundingRect = new JObject();
                var browserGetElementScreenBoundingRectpropCount = 0;
                if (browserGetElementScreenBoundingRectparentElementHandle != null)
                {
                    browserGetElementScreenBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectparentElementHandle);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementHandle != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementHandle);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementID != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementID);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementTagName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementTagName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementXPath != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementXPath);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementClassName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementClassName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementCSSSelector != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementCSSSelector);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementIndex != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementIndex != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementIndex);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementIndex"] = 1;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementMatchValue != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMatchValue);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementMatchText != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMatchText);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementType != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementType);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMinimumWidth);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = 1;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMinimumHeight);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = 1;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
                browserGetElementScreenBoundingRect["Workflow"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectworkflow);
                if (browserGetElementScreenBoundingRectpropCount > 0)
                {
                    callPayload.Body = browserGetElementScreenBoundingRect;
                }

                return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserFocusElement))]
        public IWorkflowAction BrowserFocusElement([WorkflowExpression] Func<string> browserFocusElementworkflow, [WorkflowExpression] Func<double> browserFocusElementparentElementHandle = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementName = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementID = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementType = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserFocusElement(WorkflowExpression<string> browserFocusElementworkflow, WorkflowExpression<double> browserFocusElementparentElementHandle = null, WorkflowExpression<double> browserFocusElementsearchElementHandle = null, WorkflowExpression<string> browserFocusElementsearchElementName = null, WorkflowExpression<string> browserFocusElementsearchElementID = null, WorkflowExpression<string> browserFocusElementsearchElementTagName = null, WorkflowExpression<string> browserFocusElementsearchElementXPath = null, WorkflowExpression<string> browserFocusElementsearchElementClassName = null, WorkflowExpression<string> browserFocusElementsearchElementCSSSelector = null, WorkflowExpression<double> browserFocusElementsearchElementIndex = null, WorkflowExpression<string> browserFocusElementsearchElementMatchValue = null, WorkflowExpression<string> browserFocusElementsearchElementMatchText = null, WorkflowExpression<string> browserFocusElementsearchElementType = null, WorkflowExpression<double> browserFocusElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserFocusElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserFocusElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserFocusElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserFocusElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserFocusElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserFocusElementworkflow, nameof(browserFocusElementworkflow), required: true);
            WorkflowExpression.Validate(browserFocusElementparentElementHandle, nameof(browserFocusElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementHandle, nameof(browserFocusElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementName, nameof(browserFocusElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementID, nameof(browserFocusElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementTagName, nameof(browserFocusElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementXPath, nameof(browserFocusElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementClassName, nameof(browserFocusElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementCSSSelector, nameof(browserFocusElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementIndex, nameof(browserFocusElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementMatchValue, nameof(browserFocusElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementMatchText, nameof(browserFocusElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementType, nameof(browserFocusElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementMinimumWidth, nameof(browserFocusElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementMinimumHeight, nameof(browserFocusElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementBoundingBoxLeft, nameof(browserFocusElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementBoundingBoxRight, nameof(browserFocusElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementBoundingBoxTop, nameof(browserFocusElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserFocusElementsearchElementBoundingBoxBottom, nameof(browserFocusElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserFocusElement = new JObject();
                var browserFocusElementpropCount = 0;
                if (browserFocusElementparentElementHandle != null)
                {
                    browserFocusElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserFocusElementparentElementHandle);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementHandle != null)
                {
                    browserFocusElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementHandle);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementName != null)
                {
                    browserFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementName);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementID != null)
                {
                    browserFocusElement["SearchElementID"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementID);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementTagName != null)
                {
                    browserFocusElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementTagName);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementXPath != null)
                {
                    browserFocusElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementXPath);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementClassName != null)
                {
                    browserFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementClassName);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementCSSSelector != null)
                {
                    browserFocusElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementCSSSelector);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementIndex != null)
                {
                    if (browserFocusElementsearchElementIndex != null)
                    {
                        browserFocusElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementIndex);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementIndex"] = 1;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementMatchValue != null)
                {
                    browserFocusElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMatchValue);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementMatchText != null)
                {
                    browserFocusElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMatchText);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementType != null)
                {
                    browserFocusElement["SearchElementType"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementType);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementMinimumWidth != null)
                {
                    if (browserFocusElementsearchElementMinimumWidth != null)
                    {
                        browserFocusElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMinimumWidth);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementMinimumWidth"] = 1;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementMinimumHeight != null)
                {
                    if (browserFocusElementsearchElementMinimumHeight != null)
                    {
                        browserFocusElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMinimumHeight);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementMinimumHeight"] = 1;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserFocusElementsearchElementBoundingBoxLeft != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxLeft);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementBoundingBoxRight != null)
                {
                    if (browserFocusElementsearchElementBoundingBoxRight != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxRight);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxRight"] = 99999;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementBoundingBoxTop != null)
                {
                    if (browserFocusElementsearchElementBoundingBoxTop != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxTop);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxTop"] = -99999;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserFocusElementsearchElementBoundingBoxBottom != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxBottom);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
                browserFocusElement["Workflow"] = ExpressionConverter.ConvertO(browserFocusElementworkflow);
                if (browserFocusElementpropCount > 0)
                {
                    callPayload.Body = browserFocusElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserPressEnterOnElement))]
        public IWorkflowAction BrowserPressEnterOnElement([WorkflowExpression] Func<string> browserPressEnterOnElementworkflow, [WorkflowExpression] Func<double> browserPressEnterOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserPressEnterOnElement(WorkflowExpression<string> browserPressEnterOnElementworkflow, WorkflowExpression<double> browserPressEnterOnElementparentElementHandle = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementHandle = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementName = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementID = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementTagName = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementXPath = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementClassName = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementIndex = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementMatchText = null, WorkflowExpression<string> browserPressEnterOnElementsearchElementType = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserPressEnterOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserPressEnterOnElementworkflow, nameof(browserPressEnterOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserPressEnterOnElementparentElementHandle, nameof(browserPressEnterOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementHandle, nameof(browserPressEnterOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementName, nameof(browserPressEnterOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementID, nameof(browserPressEnterOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementTagName, nameof(browserPressEnterOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementXPath, nameof(browserPressEnterOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementClassName, nameof(browserPressEnterOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementCSSSelector, nameof(browserPressEnterOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementIndex, nameof(browserPressEnterOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementMatchValue, nameof(browserPressEnterOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementMatchText, nameof(browserPressEnterOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementType, nameof(browserPressEnterOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementMinimumWidth, nameof(browserPressEnterOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementMinimumHeight, nameof(browserPressEnterOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxLeft, nameof(browserPressEnterOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxRight, nameof(browserPressEnterOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxTop, nameof(browserPressEnterOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxBottom, nameof(browserPressEnterOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PressEnterOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPressEnterOnElement = new JObject();
                var browserPressEnterOnElementpropCount = 0;
                if (browserPressEnterOnElementparentElementHandle != null)
                {
                    browserPressEnterOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPressEnterOnElementparentElementHandle);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementHandle != null)
                {
                    browserPressEnterOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementHandle);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementName != null)
                {
                    browserPressEnterOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementName);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementID != null)
                {
                    browserPressEnterOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementID);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementTagName != null)
                {
                    browserPressEnterOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementTagName);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementXPath != null)
                {
                    browserPressEnterOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementXPath);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementClassName != null)
                {
                    browserPressEnterOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementClassName);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementCSSSelector != null)
                {
                    browserPressEnterOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementCSSSelector);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementIndex != null)
                {
                    if (browserPressEnterOnElementsearchElementIndex != null)
                    {
                        browserPressEnterOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementIndex);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementIndex"] = 1;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementMatchValue != null)
                {
                    browserPressEnterOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMatchValue);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementMatchText != null)
                {
                    browserPressEnterOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMatchText);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementType != null)
                {
                    browserPressEnterOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementType);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementMinimumWidth != null)
                {
                    if (browserPressEnterOnElementsearchElementMinimumWidth != null)
                    {
                        browserPressEnterOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMinimumWidth);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementMinimumWidth"] = 1;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementMinimumHeight != null)
                {
                    if (browserPressEnterOnElementsearchElementMinimumHeight != null)
                    {
                        browserPressEnterOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMinimumHeight);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementMinimumHeight"] = 1;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxLeft);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserPressEnterOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxRight);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserPressEnterOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxTop);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxBottom);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
                browserPressEnterOnElement["Workflow"] = ExpressionConverter.ConvertO(browserPressEnterOnElementworkflow);
                if (browserPressEnterOnElementpropCount > 0)
                {
                    callPayload.Body = browserPressEnterOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserMouseLeftClickOnElement))]
        public IWorkflowAction BrowserMouseLeftClickOnElement([WorkflowExpression] Func<string> browserMouseLeftClickOnElementworkflow, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserMouseLeftClickOnElementfocusFirst = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserMouseLeftClickOnElement(WorkflowExpression<string> browserMouseLeftClickOnElementworkflow, WorkflowExpression<double> browserMouseLeftClickOnElementparentElementHandle = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementHandle = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementName = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementID = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementTagName = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementXPath = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementClassName = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementIndex = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementMatchText = null, WorkflowExpression<string> browserMouseLeftClickOnElementsearchElementType = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserMouseLeftClickOnElementfocusFirst = null)
        {
            WorkflowExpression.Validate(browserMouseLeftClickOnElementworkflow, nameof(browserMouseLeftClickOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementparentElementHandle, nameof(browserMouseLeftClickOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementHandle, nameof(browserMouseLeftClickOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementName, nameof(browserMouseLeftClickOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementID, nameof(browserMouseLeftClickOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementTagName, nameof(browserMouseLeftClickOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementXPath, nameof(browserMouseLeftClickOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementClassName, nameof(browserMouseLeftClickOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementCSSSelector, nameof(browserMouseLeftClickOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementIndex, nameof(browserMouseLeftClickOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementMatchValue, nameof(browserMouseLeftClickOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementMatchText, nameof(browserMouseLeftClickOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementType, nameof(browserMouseLeftClickOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementMinimumWidth, nameof(browserMouseLeftClickOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementMinimumHeight, nameof(browserMouseLeftClickOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxRight, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxTop, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserMouseLeftClickOnElementfocusFirst, nameof(browserMouseLeftClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMouseLeftClickOnElement = new JObject();
                var browserMouseLeftClickOnElementpropCount = 0;
                if (browserMouseLeftClickOnElementparentElementHandle != null)
                {
                    browserMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementparentElementHandle);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementHandle != null)
                {
                    browserMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementHandle);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementID != null)
                {
                    browserMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementID);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementTagName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementTagName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementXPath != null)
                {
                    browserMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementXPath);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementClassName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementClassName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementCSSSelector != null)
                {
                    browserMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementCSSSelector);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementIndex != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementIndex != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementIndex);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementIndex"] = 1;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementMatchValue != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMatchValue);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementMatchText != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMatchText);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementType != null)
                {
                    browserMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementType);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMinimumWidth);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMinimumHeight);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxRight);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxTop);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementfocusFirst != null)
                {
                    if (browserMouseLeftClickOnElementfocusFirst != null)
                    {
                        browserMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementfocusFirst);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["FocusFirst"] = false;
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
                browserMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementworkflow);
                if (browserMouseLeftClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserMouseLeftClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserMouseRightClickOnElement))]
        public IWorkflowAction BrowserMouseRightClickOnElement([WorkflowExpression] Func<string> browserMouseRightClickOnElementworkflow, [WorkflowExpression] Func<double> browserMouseRightClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserMouseRightClickOnElementfocusFirst = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserMouseRightClickOnElement(WorkflowExpression<string> browserMouseRightClickOnElementworkflow, WorkflowExpression<double> browserMouseRightClickOnElementparentElementHandle = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementHandle = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementName = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementID = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementTagName = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementXPath = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementClassName = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementIndex = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementMatchText = null, WorkflowExpression<string> browserMouseRightClickOnElementsearchElementType = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserMouseRightClickOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserMouseRightClickOnElementfocusFirst = null)
        {
            WorkflowExpression.Validate(browserMouseRightClickOnElementworkflow, nameof(browserMouseRightClickOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserMouseRightClickOnElementparentElementHandle, nameof(browserMouseRightClickOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementHandle, nameof(browserMouseRightClickOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementName, nameof(browserMouseRightClickOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementID, nameof(browserMouseRightClickOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementTagName, nameof(browserMouseRightClickOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementXPath, nameof(browserMouseRightClickOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementClassName, nameof(browserMouseRightClickOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementCSSSelector, nameof(browserMouseRightClickOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementIndex, nameof(browserMouseRightClickOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementMatchValue, nameof(browserMouseRightClickOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementMatchText, nameof(browserMouseRightClickOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementType, nameof(browserMouseRightClickOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementMinimumWidth, nameof(browserMouseRightClickOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementMinimumHeight, nameof(browserMouseRightClickOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxLeft, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxRight, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxTop, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxBottom, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserMouseRightClickOnElementfocusFirst, nameof(browserMouseRightClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMouseRightClickOnElement = new JObject();
                var browserMouseRightClickOnElementpropCount = 0;
                if (browserMouseRightClickOnElementparentElementHandle != null)
                {
                    browserMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementparentElementHandle);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementHandle != null)
                {
                    browserMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementHandle);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementName != null)
                {
                    browserMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementID != null)
                {
                    browserMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementID);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementTagName != null)
                {
                    browserMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementTagName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementXPath != null)
                {
                    browserMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementXPath);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementClassName != null)
                {
                    browserMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementClassName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementCSSSelector != null)
                {
                    browserMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementCSSSelector);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementIndex != null)
                {
                    if (browserMouseRightClickOnElementsearchElementIndex != null)
                    {
                        browserMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementIndex);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementIndex"] = 1;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementMatchValue != null)
                {
                    browserMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMatchValue);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementMatchText != null)
                {
                    browserMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMatchText);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementType != null)
                {
                    browserMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementType);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMinimumWidth);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    if (browserMouseRightClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMinimumHeight);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxLeft);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxRight);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxTop);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxBottom);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementfocusFirst != null)
                {
                    if (browserMouseRightClickOnElementfocusFirst != null)
                    {
                        browserMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementfocusFirst);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["FocusFirst"] = false;
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
                browserMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementworkflow);
                if (browserMouseRightClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserMouseRightClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserJavaScriptClickOnElement))]
        public IWorkflowAction BrowserJavaScriptClickOnElement([WorkflowExpression] Func<string> browserJavaScriptClickOnElementworkflow, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserJavaScriptClickOnElement(WorkflowExpression<string> browserJavaScriptClickOnElementworkflow, WorkflowExpression<double> browserJavaScriptClickOnElementparentElementHandle = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementHandle = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementName = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementID = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementTagName = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementXPath = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementClassName = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementIndex = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementMatchText = null, WorkflowExpression<string> browserJavaScriptClickOnElementsearchElementType = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserJavaScriptClickOnElementworkflow, nameof(browserJavaScriptClickOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementparentElementHandle, nameof(browserJavaScriptClickOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementHandle, nameof(browserJavaScriptClickOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementName, nameof(browserJavaScriptClickOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementID, nameof(browserJavaScriptClickOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementTagName, nameof(browserJavaScriptClickOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementXPath, nameof(browserJavaScriptClickOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementClassName, nameof(browserJavaScriptClickOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementCSSSelector, nameof(browserJavaScriptClickOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementIndex, nameof(browserJavaScriptClickOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementMatchValue, nameof(browserJavaScriptClickOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementMatchText, nameof(browserJavaScriptClickOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementType, nameof(browserJavaScriptClickOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementMinimumWidth, nameof(browserJavaScriptClickOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementMinimumHeight, nameof(browserJavaScriptClickOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxRight, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxTop, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserJavaScriptClickOnElement = new JObject();
                var browserJavaScriptClickOnElementpropCount = 0;
                if (browserJavaScriptClickOnElementparentElementHandle != null)
                {
                    browserJavaScriptClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementparentElementHandle);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementHandle != null)
                {
                    browserJavaScriptClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementHandle);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementID != null)
                {
                    browserJavaScriptClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementID);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementTagName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementTagName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementXPath != null)
                {
                    browserJavaScriptClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementXPath);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementClassName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementClassName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementCSSSelector != null)
                {
                    browserJavaScriptClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementCSSSelector);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementIndex != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementIndex != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementIndex);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementIndex"] = 1;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementMatchValue != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMatchValue);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementMatchText != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMatchText);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementType != null)
                {
                    browserJavaScriptClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementType);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMinimumWidth);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMinimumHeight);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxRight);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxTop);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
                browserJavaScriptClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementworkflow);
                if (browserJavaScriptClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserJavaScriptClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserExecuteJavaScriptOnElement))]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> BrowserExecuteJavaScriptOnElement([WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementjavaScriptToExecute, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementworkflow, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> __BuildBrowserExecuteJavaScriptOnElement(WorkflowExpression<string> browserExecuteJavaScriptOnElementjavaScriptToExecute, WorkflowExpression<string> browserExecuteJavaScriptOnElementworkflow, WorkflowExpression<double> browserExecuteJavaScriptOnElementparentElementHandle = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementHandle = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementName = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementID = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementTagName = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementXPath = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementClassName = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementIndex = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementMatchText = null, WorkflowExpression<string> browserExecuteJavaScriptOnElementsearchElementType = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementjavaScriptToExecute, nameof(browserExecuteJavaScriptOnElementjavaScriptToExecute), required: true);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementworkflow, nameof(browserExecuteJavaScriptOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementparentElementHandle, nameof(browserExecuteJavaScriptOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementHandle, nameof(browserExecuteJavaScriptOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementName, nameof(browserExecuteJavaScriptOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementID, nameof(browserExecuteJavaScriptOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementTagName, nameof(browserExecuteJavaScriptOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementXPath, nameof(browserExecuteJavaScriptOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementClassName, nameof(browserExecuteJavaScriptOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementCSSSelector, nameof(browserExecuteJavaScriptOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementIndex, nameof(browserExecuteJavaScriptOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMatchValue, nameof(browserExecuteJavaScriptOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMatchText, nameof(browserExecuteJavaScriptOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementType, nameof(browserExecuteJavaScriptOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMinimumWidth, nameof(browserExecuteJavaScriptOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMinimumHeight, nameof(browserExecuteJavaScriptOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserExecuteJavaScriptOnElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserExecuteJavaScriptOnElement = new JObject();
                var browserExecuteJavaScriptOnElementpropCount = 0;
                if (browserExecuteJavaScriptOnElementparentElementHandle != null)
                {
                    browserExecuteJavaScriptOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementparentElementHandle);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementHandle != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementHandle);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementID != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementID);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementTagName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementTagName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementXPath != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementXPath);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementClassName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementClassName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementCSSSelector != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementCSSSelector);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementIndex);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementIndex"] = 1;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementMatchValue != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMatchValue);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementMatchText != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMatchText);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementType != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementType);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMinimumWidth);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = 1;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMinimumHeight);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = 1;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
                browserExecuteJavaScriptOnElement["JavaScriptToExecute"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementjavaScriptToExecute);
                browserExecuteJavaScriptOnElementpropCount++;
                browserExecuteJavaScriptOnElement["Workflow"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementworkflow);
                if (browserExecuteJavaScriptOnElementpropCount > 0)
                {
                    callPayload.Body = browserExecuteJavaScriptOnElement;
                }

                return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGlobalMouseLeftClickOnElement))]
        public IWorkflowAction BrowserGlobalMouseLeftClickOnElement([WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementworkflow, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<int> browserGlobalMouseLeftClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> browserGlobalMouseLeftClickOnElementclickOffsetY = null, [WorkflowExpression] Func<bool> browserGlobalMouseLeftClickOnElementfocusFirst = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserGlobalMouseLeftClickOnElement(WorkflowExpression<string> browserGlobalMouseLeftClickOnElementworkflow, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementparentElementHandle = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementHandle = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementName = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementID = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementTagName = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementXPath = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementClassName = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementIndex = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementMatchText = null, WorkflowExpression<string> browserGlobalMouseLeftClickOnElementsearchElementType = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<int> browserGlobalMouseLeftClickOnElementclickOffsetX = null, WorkflowExpression<int> browserGlobalMouseLeftClickOnElementclickOffsetY = null, WorkflowExpression<bool> browserGlobalMouseLeftClickOnElementfocusFirst = null)
        {
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementworkflow, nameof(browserGlobalMouseLeftClickOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementparentElementHandle, nameof(browserGlobalMouseLeftClickOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementHandle, nameof(browserGlobalMouseLeftClickOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementName, nameof(browserGlobalMouseLeftClickOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementID, nameof(browserGlobalMouseLeftClickOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementTagName, nameof(browserGlobalMouseLeftClickOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementXPath, nameof(browserGlobalMouseLeftClickOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementClassName, nameof(browserGlobalMouseLeftClickOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector, nameof(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementIndex, nameof(browserGlobalMouseLeftClickOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMatchValue, nameof(browserGlobalMouseLeftClickOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMatchText, nameof(browserGlobalMouseLeftClickOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementType, nameof(browserGlobalMouseLeftClickOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth, nameof(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight, nameof(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementclickOffsetX, nameof(browserGlobalMouseLeftClickOnElementclickOffsetX), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementclickOffsetY, nameof(browserGlobalMouseLeftClickOnElementclickOffsetY), required: false);
            WorkflowExpression.Validate(browserGlobalMouseLeftClickOnElementfocusFirst, nameof(browserGlobalMouseLeftClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGlobalMouseLeftClickOnElement = new JObject();
                var browserGlobalMouseLeftClickOnElementpropCount = 0;
                if (browserGlobalMouseLeftClickOnElementparentElementHandle != null)
                {
                    browserGlobalMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementparentElementHandle);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementHandle != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementHandle);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementID != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementID);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementTagName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementTagName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementXPath != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementXPath);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementClassName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementClassName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementCSSSelector != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementIndex);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = 1;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementMatchValue != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMatchValue);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementMatchText != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMatchText);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementType != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementType);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementclickOffsetX != null)
                {
                    browserGlobalMouseLeftClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementclickOffsetX);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementclickOffsetY != null)
                {
                    browserGlobalMouseLeftClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementclickOffsetY);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
                {
                    if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
                    {
                        browserGlobalMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementfocusFirst);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["FocusFirst"] = false;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
                browserGlobalMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementworkflow);
                if (browserGlobalMouseLeftClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserGlobalMouseLeftClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGlobalMouseRightClickOnElement))]
        public IWorkflowAction BrowserGlobalMouseRightClickOnElement([WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementworkflow, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<int> browserGlobalMouseRightClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> browserGlobalMouseRightClickOnElementclickOffsetY = null, [WorkflowExpression] Func<bool> browserGlobalMouseRightClickOnElementfocusFirst = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserGlobalMouseRightClickOnElement(WorkflowExpression<string> browserGlobalMouseRightClickOnElementworkflow, WorkflowExpression<double> browserGlobalMouseRightClickOnElementparentElementHandle = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementHandle = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementName = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementID = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementTagName = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementXPath = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementClassName = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementIndex = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementMatchText = null, WorkflowExpression<string> browserGlobalMouseRightClickOnElementsearchElementType = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<int> browserGlobalMouseRightClickOnElementclickOffsetX = null, WorkflowExpression<int> browserGlobalMouseRightClickOnElementclickOffsetY = null, WorkflowExpression<bool> browserGlobalMouseRightClickOnElementfocusFirst = null)
        {
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementworkflow, nameof(browserGlobalMouseRightClickOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementparentElementHandle, nameof(browserGlobalMouseRightClickOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementHandle, nameof(browserGlobalMouseRightClickOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementName, nameof(browserGlobalMouseRightClickOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementID, nameof(browserGlobalMouseRightClickOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementTagName, nameof(browserGlobalMouseRightClickOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementXPath, nameof(browserGlobalMouseRightClickOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementClassName, nameof(browserGlobalMouseRightClickOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementCSSSelector, nameof(browserGlobalMouseRightClickOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementIndex, nameof(browserGlobalMouseRightClickOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMatchValue, nameof(browserGlobalMouseRightClickOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMatchText, nameof(browserGlobalMouseRightClickOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementType, nameof(browserGlobalMouseRightClickOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth, nameof(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight, nameof(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementclickOffsetX, nameof(browserGlobalMouseRightClickOnElementclickOffsetX), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementclickOffsetY, nameof(browserGlobalMouseRightClickOnElementclickOffsetY), required: false);
            WorkflowExpression.Validate(browserGlobalMouseRightClickOnElementfocusFirst, nameof(browserGlobalMouseRightClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGlobalMouseRightClickOnElement = new JObject();
                var browserGlobalMouseRightClickOnElementpropCount = 0;
                if (browserGlobalMouseRightClickOnElementparentElementHandle != null)
                {
                    browserGlobalMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementparentElementHandle);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementHandle != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementHandle);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementID != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementID);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementTagName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementTagName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementXPath != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementXPath);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementClassName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementClassName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementCSSSelector != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementCSSSelector);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementIndex);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementIndex"] = 1;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementMatchValue != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMatchValue);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementMatchText != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMatchText);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementType != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementType);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementclickOffsetX != null)
                {
                    browserGlobalMouseRightClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementclickOffsetX);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementclickOffsetY != null)
                {
                    browserGlobalMouseRightClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementclickOffsetY);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementfocusFirst != null)
                {
                    if (browserGlobalMouseRightClickOnElementfocusFirst != null)
                    {
                        browserGlobalMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementfocusFirst);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["FocusFirst"] = false;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
                browserGlobalMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementworkflow);
                if (browserGlobalMouseRightClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserGlobalMouseRightClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserOpenNewTab))]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> BrowserOpenNewTab([WorkflowExpression] Func<string> browserOpenNewTabworkflow, [WorkflowExpression] Func<string> browserOpenNewTabuRL = null, [WorkflowExpression] Func<bool> browserOpenNewTabswitchControlToNewTab = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> __BuildBrowserOpenNewTab(WorkflowExpression<string> browserOpenNewTabworkflow, WorkflowExpression<string> browserOpenNewTabuRL = null, WorkflowExpression<bool> browserOpenNewTabswitchControlToNewTab = null)
        {
            WorkflowExpression.Validate(browserOpenNewTabworkflow, nameof(browserOpenNewTabworkflow), required: true);
            WorkflowExpression.Validate(browserOpenNewTabuRL, nameof(browserOpenNewTabuRL), required: false);
            WorkflowExpression.Validate(browserOpenNewTabswitchControlToNewTab, nameof(browserOpenNewTabswitchControlToNewTab), required: false);
            return new DeferredBodyAction<BrowserOpenNewTabResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenNewTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenNewTab = new JObject();
                var browserOpenNewTabpropCount = 0;
                if (browserOpenNewTabuRL != null)
                {
                    browserOpenNewTab["URL"] = ExpressionConverter.ConvertO(browserOpenNewTabuRL);
                    browserOpenNewTabpropCount++;
                }

                if (browserOpenNewTabswitchControlToNewTab != null)
                {
                    if (browserOpenNewTabswitchControlToNewTab != null)
                    {
                        browserOpenNewTab["SwitchControlToNewTab"] = ExpressionConverter.ConvertO(browserOpenNewTabswitchControlToNewTab);
                        browserOpenNewTabpropCount++;
                    }

                    browserOpenNewTabpropCount++;
                }
                else
                {
                    browserOpenNewTab["SwitchControlToNewTab"] = true;
                    browserOpenNewTabpropCount++;
                }

                browserOpenNewTabpropCount++;
                browserOpenNewTab["Workflow"] = ExpressionConverter.ConvertO(browserOpenNewTabworkflow);
                if (browserOpenNewTabpropCount > 0)
                {
                    callPayload.Body = browserOpenNewTab;
                }

                return new ApiConnectionAction<BrowserOpenNewTabResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetTabs))]
        public IBodyWorkflowAction<BrowserGetTabsResponse> BrowserGetTabs([WorkflowExpression] Func<string> browserGetTabsworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetTabsResponse> __BuildBrowserGetTabs(WorkflowExpression<string> browserGetTabsworkflow)
        {
            WorkflowExpression.Validate(browserGetTabsworkflow, nameof(browserGetTabsworkflow), required: true);
            return new DeferredBodyAction<BrowserGetTabsResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetTabs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetTabs = new JObject();
                var browserGetTabspropCount = 0;
                browserGetTabspropCount++;
                browserGetTabs["Workflow"] = ExpressionConverter.ConvertO(browserGetTabsworkflow);
                if (browserGetTabspropCount > 0)
                {
                    callPayload.Body = browserGetTabs;
                }

                return new ApiConnectionAction<BrowserGetTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSetTab))]
        public IWorkflowAction BrowserSetTab([WorkflowExpression] Func<string> browserSetTabworkflow, [WorkflowExpression] Func<string> browserSetTabtabName = null, [WorkflowExpression] Func<int> browserSetTabtabIndex = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSetTab(WorkflowExpression<string> browserSetTabworkflow, WorkflowExpression<string> browserSetTabtabName = null, WorkflowExpression<int> browserSetTabtabIndex = null)
        {
            WorkflowExpression.Validate(browserSetTabworkflow, nameof(browserSetTabworkflow), required: true);
            WorkflowExpression.Validate(browserSetTabtabName, nameof(browserSetTabtabName), required: false);
            WorkflowExpression.Validate(browserSetTabtabIndex, nameof(browserSetTabtabIndex), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetTab = new JObject();
                var browserSetTabpropCount = 0;
                if (browserSetTabtabName != null)
                {
                    browserSetTab["TabName"] = ExpressionConverter.ConvertO(browserSetTabtabName);
                    browserSetTabpropCount++;
                }

                if (browserSetTabtabIndex != null)
                {
                    browserSetTab["TabIndex"] = ExpressionConverter.ConvertO(browserSetTabtabIndex);
                    browserSetTabpropCount++;
                }

                browserSetTabpropCount++;
                browserSetTab["Workflow"] = ExpressionConverter.ConvertO(browserSetTabworkflow);
                if (browserSetTabpropCount > 0)
                {
                    callPayload.Body = browserSetTab;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCloseActiveTab))]
        public IWorkflowAction BrowserCloseActiveTab([WorkflowExpression] Func<string> browserCloseActiveTabworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCloseActiveTab(WorkflowExpression<string> browserCloseActiveTabworkflow)
        {
            WorkflowExpression.Validate(browserCloseActiveTabworkflow, nameof(browserCloseActiveTabworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseActiveTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseActiveTab = new JObject();
                var browserCloseActiveTabpropCount = 0;
                browserCloseActiveTabpropCount++;
                browserCloseActiveTab["Workflow"] = ExpressionConverter.ConvertO(browserCloseActiveTabworkflow);
                if (browserCloseActiveTabpropCount > 0)
                {
                    callPayload.Body = browserCloseActiveTab;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSavePageToFile))]
        public IWorkflowAction BrowserSavePageToFile([WorkflowExpression] Func<string> browserSavePageToFilesaveFilename, [WorkflowExpression] Func<string> browserSavePageToFileworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSavePageToFile(WorkflowExpression<string> browserSavePageToFilesaveFilename, WorkflowExpression<string> browserSavePageToFileworkflow)
        {
            WorkflowExpression.Validate(browserSavePageToFilesaveFilename, nameof(browserSavePageToFilesaveFilename), required: true);
            WorkflowExpression.Validate(browserSavePageToFileworkflow, nameof(browserSavePageToFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SavePageToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSavePageToFile = new JObject();
                var browserSavePageToFilepropCount = 0;
                browserSavePageToFilepropCount++;
                browserSavePageToFile["SaveFilename"] = ExpressionConverter.ConvertO(browserSavePageToFilesaveFilename);
                browserSavePageToFilepropCount++;
                browserSavePageToFile["Workflow"] = ExpressionConverter.ConvertO(browserSavePageToFileworkflow);
                if (browserSavePageToFilepropCount > 0)
                {
                    callPayload.Body = browserSavePageToFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetPageText))]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> BrowserGetPageText([WorkflowExpression] Func<string> browserGetPageTextworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> __BuildBrowserGetPageText(WorkflowExpression<string> browserGetPageTextworkflow)
        {
            WorkflowExpression.Validate(browserGetPageTextworkflow, nameof(browserGetPageTextworkflow), required: true);
            return new DeferredBodyAction<BrowserGetPageTextResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetPageText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetPageText = new JObject();
                var browserGetPageTextpropCount = 0;
                browserGetPageTextpropCount++;
                browserGetPageText["Workflow"] = ExpressionConverter.ConvertO(browserGetPageTextworkflow);
                if (browserGetPageTextpropCount > 0)
                {
                    callPayload.Body = browserGetPageText;
                }

                return new ApiConnectionAction<BrowserGetPageTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSwitchToFrameElement))]
        public IWorkflowAction BrowserSwitchToFrameElement([WorkflowExpression] Func<string> browserSwitchToFrameElementworkflow, [WorkflowExpression] Func<double> browserSwitchToFrameElementparentElementHandle = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementName = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementID = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementType = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSwitchToFrameElement(WorkflowExpression<string> browserSwitchToFrameElementworkflow, WorkflowExpression<double> browserSwitchToFrameElementparentElementHandle = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementHandle = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementName = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementID = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementTagName = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementXPath = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementClassName = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementCSSSelector = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementIndex = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementMatchValue = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementMatchText = null, WorkflowExpression<string> browserSwitchToFrameElementsearchElementType = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserSwitchToFrameElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserSwitchToFrameElementworkflow, nameof(browserSwitchToFrameElementworkflow), required: true);
            WorkflowExpression.Validate(browserSwitchToFrameElementparentElementHandle, nameof(browserSwitchToFrameElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementHandle, nameof(browserSwitchToFrameElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementName, nameof(browserSwitchToFrameElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementID, nameof(browserSwitchToFrameElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementTagName, nameof(browserSwitchToFrameElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementXPath, nameof(browserSwitchToFrameElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementClassName, nameof(browserSwitchToFrameElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementCSSSelector, nameof(browserSwitchToFrameElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementIndex, nameof(browserSwitchToFrameElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementMatchValue, nameof(browserSwitchToFrameElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementMatchText, nameof(browserSwitchToFrameElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementType, nameof(browserSwitchToFrameElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementMinimumWidth, nameof(browserSwitchToFrameElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementMinimumHeight, nameof(browserSwitchToFrameElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxLeft, nameof(browserSwitchToFrameElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxRight, nameof(browserSwitchToFrameElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxTop, nameof(browserSwitchToFrameElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxBottom, nameof(browserSwitchToFrameElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToFrameElement = new JObject();
                var browserSwitchToFrameElementpropCount = 0;
                if (browserSwitchToFrameElementparentElementHandle != null)
                {
                    browserSwitchToFrameElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementparentElementHandle);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementHandle != null)
                {
                    browserSwitchToFrameElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementHandle);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementName != null)
                {
                    browserSwitchToFrameElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementID != null)
                {
                    browserSwitchToFrameElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementID);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementTagName != null)
                {
                    browserSwitchToFrameElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementTagName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementXPath != null)
                {
                    browserSwitchToFrameElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementXPath);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementClassName != null)
                {
                    browserSwitchToFrameElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementClassName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementCSSSelector != null)
                {
                    browserSwitchToFrameElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementCSSSelector);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementIndex != null)
                {
                    if (browserSwitchToFrameElementsearchElementIndex != null)
                    {
                        browserSwitchToFrameElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementIndex);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementIndex"] = 1;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementMatchValue != null)
                {
                    browserSwitchToFrameElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMatchValue);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementMatchText != null)
                {
                    browserSwitchToFrameElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMatchText);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementType != null)
                {
                    browserSwitchToFrameElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementType);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
                {
                    if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
                    {
                        browserSwitchToFrameElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMinimumWidth);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementMinimumWidth"] = 1;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementMinimumHeight != null)
                {
                    if (browserSwitchToFrameElementsearchElementMinimumHeight != null)
                    {
                        browserSwitchToFrameElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMinimumHeight);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementMinimumHeight"] = 1;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxLeft);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
                {
                    if (browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxRight);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = 99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
                {
                    if (browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxTop);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = -99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxBottom);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
                browserSwitchToFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementworkflow);
                if (browserSwitchToFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToFrameElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetCurrentFrameWindowPixelCoordinate))]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> BrowserGetCurrentFrameWindowPixelCoordinate([WorkflowExpression] Func<string> browserGetCurrentFrameWindowPixelCoordinateworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> __BuildBrowserGetCurrentFrameWindowPixelCoordinate(WorkflowExpression<string> browserGetCurrentFrameWindowPixelCoordinateworkflow)
        {
            WorkflowExpression.Validate(browserGetCurrentFrameWindowPixelCoordinateworkflow, nameof(browserGetCurrentFrameWindowPixelCoordinateworkflow), required: true);
            return new DeferredBodyAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetCurrentFrameWindowPixelCoordinate = new JObject();
                var browserGetCurrentFrameWindowPixelCoordinatepropCount = 0;
                browserGetCurrentFrameWindowPixelCoordinatepropCount++;
                browserGetCurrentFrameWindowPixelCoordinate["Workflow"] = ExpressionConverter.ConvertO(browserGetCurrentFrameWindowPixelCoordinateworkflow);
                if (browserGetCurrentFrameWindowPixelCoordinatepropCount > 0)
                {
                    callPayload.Body = browserGetCurrentFrameWindowPixelCoordinate;
                }

                return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSwitchToParentFrameElement))]
        public IWorkflowAction BrowserSwitchToParentFrameElement([WorkflowExpression] Func<string> browserSwitchToParentFrameElementworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSwitchToParentFrameElement(WorkflowExpression<string> browserSwitchToParentFrameElementworkflow)
        {
            WorkflowExpression.Validate(browserSwitchToParentFrameElementworkflow, nameof(browserSwitchToParentFrameElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToParentFrameElement = new JObject();
                var browserSwitchToParentFrameElementpropCount = 0;
                browserSwitchToParentFrameElementpropCount++;
                browserSwitchToParentFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToParentFrameElementworkflow);
                if (browserSwitchToParentFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToParentFrameElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSwitchToRootFrameElement))]
        public IWorkflowAction BrowserSwitchToRootFrameElement([WorkflowExpression] Func<string> browserSwitchToRootFrameElementworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSwitchToRootFrameElement(WorkflowExpression<string> browserSwitchToRootFrameElementworkflow)
        {
            WorkflowExpression.Validate(browserSwitchToRootFrameElementworkflow, nameof(browserSwitchToRootFrameElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToRootFrameElement = new JObject();
                var browserSwitchToRootFrameElementpropCount = 0;
                browserSwitchToRootFrameElementpropCount++;
                browserSwitchToRootFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToRootFrameElementworkflow);
                if (browserSwitchToRootFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToRootFrameElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserResetFrameStack))]
        public IWorkflowAction BrowserResetFrameStack([WorkflowExpression] Func<string> browserResetFrameStackworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserResetFrameStack(WorkflowExpression<string> browserResetFrameStackworkflow)
        {
            WorkflowExpression.Validate(browserResetFrameStackworkflow, nameof(browserResetFrameStackworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ResetFrameStack";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserResetFrameStack = new JObject();
                var browserResetFrameStackpropCount = 0;
                browserResetFrameStackpropCount++;
                browserResetFrameStack["Workflow"] = ExpressionConverter.ConvertO(browserResetFrameStackworkflow);
                if (browserResetFrameStackpropCount > 0)
                {
                    callPayload.Body = browserResetFrameStack;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserClearElementText))]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> BrowserClearElementText([WorkflowExpression] Func<string> browserClearElementTextworkflow, [WorkflowExpression] Func<double> browserClearElementTextparentElementHandle = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementHandle = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementName = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementID = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementTagName = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementXPath = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementClassName = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementIndex = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementMatchText = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementType = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> __BuildBrowserClearElementText(WorkflowExpression<string> browserClearElementTextworkflow, WorkflowExpression<double> browserClearElementTextparentElementHandle = null, WorkflowExpression<double> browserClearElementTextsearchElementHandle = null, WorkflowExpression<string> browserClearElementTextsearchElementName = null, WorkflowExpression<string> browserClearElementTextsearchElementID = null, WorkflowExpression<string> browserClearElementTextsearchElementTagName = null, WorkflowExpression<string> browserClearElementTextsearchElementXPath = null, WorkflowExpression<string> browserClearElementTextsearchElementClassName = null, WorkflowExpression<string> browserClearElementTextsearchElementCSSSelector = null, WorkflowExpression<double> browserClearElementTextsearchElementIndex = null, WorkflowExpression<string> browserClearElementTextsearchElementMatchValue = null, WorkflowExpression<string> browserClearElementTextsearchElementMatchText = null, WorkflowExpression<string> browserClearElementTextsearchElementType = null, WorkflowExpression<double> browserClearElementTextsearchElementMinimumWidth = null, WorkflowExpression<double> browserClearElementTextsearchElementMinimumHeight = null, WorkflowExpression<double> browserClearElementTextsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserClearElementTextsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserClearElementTextsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserClearElementTextsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserClearElementTextworkflow, nameof(browserClearElementTextworkflow), required: true);
            WorkflowExpression.Validate(browserClearElementTextparentElementHandle, nameof(browserClearElementTextparentElementHandle), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementHandle, nameof(browserClearElementTextsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementName, nameof(browserClearElementTextsearchElementName), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementID, nameof(browserClearElementTextsearchElementID), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementTagName, nameof(browserClearElementTextsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementXPath, nameof(browserClearElementTextsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementClassName, nameof(browserClearElementTextsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementCSSSelector, nameof(browserClearElementTextsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementIndex, nameof(browserClearElementTextsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementMatchValue, nameof(browserClearElementTextsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementMatchText, nameof(browserClearElementTextsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementType, nameof(browserClearElementTextsearchElementType), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementMinimumWidth, nameof(browserClearElementTextsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementMinimumHeight, nameof(browserClearElementTextsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementBoundingBoxLeft, nameof(browserClearElementTextsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementBoundingBoxRight, nameof(browserClearElementTextsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementBoundingBoxTop, nameof(browserClearElementTextsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserClearElementTextsearchElementBoundingBoxBottom, nameof(browserClearElementTextsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserClearElementTextResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/ClearElementText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserClearElementText = new JObject();
                var browserClearElementTextpropCount = 0;
                if (browserClearElementTextparentElementHandle != null)
                {
                    browserClearElementText["ParentElementHandle"] = ExpressionConverter.ConvertO(browserClearElementTextparentElementHandle);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementHandle != null)
                {
                    browserClearElementText["SearchElementHandle"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementHandle);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementName != null)
                {
                    browserClearElementText["SearchElementName"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementName);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementID != null)
                {
                    browserClearElementText["SearchElementID"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementID);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementTagName != null)
                {
                    browserClearElementText["SearchElementTagName"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementTagName);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementXPath != null)
                {
                    browserClearElementText["SearchElementXPath"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementXPath);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementClassName != null)
                {
                    browserClearElementText["SearchElementClassName"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementClassName);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementCSSSelector != null)
                {
                    browserClearElementText["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementCSSSelector);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementIndex != null)
                {
                    if (browserClearElementTextsearchElementIndex != null)
                    {
                        browserClearElementText["SearchElementIndex"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementIndex);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementIndex"] = 1;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementMatchValue != null)
                {
                    browserClearElementText["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMatchValue);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementMatchText != null)
                {
                    browserClearElementText["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMatchText);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementType != null)
                {
                    browserClearElementText["SearchElementType"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementType);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementMinimumWidth != null)
                {
                    if (browserClearElementTextsearchElementMinimumWidth != null)
                    {
                        browserClearElementText["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMinimumWidth);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementMinimumWidth"] = 1;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementMinimumHeight != null)
                {
                    if (browserClearElementTextsearchElementMinimumHeight != null)
                    {
                        browserClearElementText["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMinimumHeight);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementMinimumHeight"] = 1;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementBoundingBoxLeft != null)
                {
                    if (browserClearElementTextsearchElementBoundingBoxLeft != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxLeft);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxLeft"] = -99999;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementBoundingBoxRight != null)
                {
                    if (browserClearElementTextsearchElementBoundingBoxRight != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxRight);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxRight"] = 99999;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementBoundingBoxTop != null)
                {
                    if (browserClearElementTextsearchElementBoundingBoxTop != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxTop);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxTop"] = -99999;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementBoundingBoxBottom != null)
                {
                    if (browserClearElementTextsearchElementBoundingBoxBottom != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxBottom);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxBottom"] = 99999;
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
                browserClearElementText["Workflow"] = ExpressionConverter.ConvertO(browserClearElementTextworkflow);
                if (browserClearElementTextpropCount > 0)
                {
                    callPayload.Body = browserClearElementText;
                }

                return new ApiConnectionAction<BrowserClearElementTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserCopySelectedTextOnElement))]
        public IWorkflowAction BrowserCopySelectedTextOnElement([WorkflowExpression] Func<string> browserCopySelectedTextOnElementworkflow, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserCopySelectedTextOnElement(WorkflowExpression<string> browserCopySelectedTextOnElementworkflow, WorkflowExpression<double> browserCopySelectedTextOnElementparentElementHandle = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementHandle = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementName = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementID = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementTagName = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementXPath = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementClassName = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementIndex = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementMatchText = null, WorkflowExpression<string> browserCopySelectedTextOnElementsearchElementType = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserCopySelectedTextOnElementworkflow, nameof(browserCopySelectedTextOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementparentElementHandle, nameof(browserCopySelectedTextOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementHandle, nameof(browserCopySelectedTextOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementName, nameof(browserCopySelectedTextOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementID, nameof(browserCopySelectedTextOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementTagName, nameof(browserCopySelectedTextOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementXPath, nameof(browserCopySelectedTextOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementClassName, nameof(browserCopySelectedTextOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementCSSSelector, nameof(browserCopySelectedTextOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementIndex, nameof(browserCopySelectedTextOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementMatchValue, nameof(browserCopySelectedTextOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementMatchText, nameof(browserCopySelectedTextOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementType, nameof(browserCopySelectedTextOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementMinimumWidth, nameof(browserCopySelectedTextOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementMinimumHeight, nameof(browserCopySelectedTextOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxRight, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxTop, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCopySelectedTextOnElement = new JObject();
                var browserCopySelectedTextOnElementpropCount = 0;
                if (browserCopySelectedTextOnElementparentElementHandle != null)
                {
                    browserCopySelectedTextOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementparentElementHandle);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementHandle != null)
                {
                    browserCopySelectedTextOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementHandle);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementID != null)
                {
                    browserCopySelectedTextOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementID);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementTagName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementTagName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementXPath != null)
                {
                    browserCopySelectedTextOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementXPath);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementClassName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementClassName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementCSSSelector != null)
                {
                    browserCopySelectedTextOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementCSSSelector);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementIndex != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementIndex != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementIndex);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementIndex"] = 1;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementMatchValue != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMatchValue);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementMatchText != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMatchText);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementType != null)
                {
                    browserCopySelectedTextOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementType);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMinimumWidth);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = 1;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMinimumHeight);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = 1;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxRight);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxTop);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
                browserCopySelectedTextOnElement["Workflow"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementworkflow);
                if (browserCopySelectedTextOnElementpropCount > 0)
                {
                    callPayload.Body = browserCopySelectedTextOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserInputPasswordIntoElement))]
        public IWorkflowAction BrowserInputPasswordIntoElement([WorkflowExpression] Func<string> browserInputPasswordIntoElementpasswordToInput, [WorkflowExpression] Func<string> browserInputPasswordIntoElementworkflow, [WorkflowExpression] Func<double> browserInputPasswordIntoElementparentElementHandle = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementName = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementID = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementType = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserInputPasswordIntoElementresetExistingValue = null, [WorkflowExpression] Func<bool> browserInputPasswordIntoElementpasswordContainsStoredPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserInputPasswordIntoElement(WorkflowExpression<string> browserInputPasswordIntoElementpasswordToInput, WorkflowExpression<string> browserInputPasswordIntoElementworkflow, WorkflowExpression<double> browserInputPasswordIntoElementparentElementHandle = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementHandle = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementName = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementID = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementTagName = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementXPath = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementClassName = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementCSSSelector = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementIndex = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementMatchValue = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementMatchText = null, WorkflowExpression<string> browserInputPasswordIntoElementsearchElementType = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserInputPasswordIntoElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserInputPasswordIntoElementresetExistingValue = null, WorkflowExpression<bool> browserInputPasswordIntoElementpasswordContainsStoredPassword = null)
        {
            WorkflowExpression.Validate(browserInputPasswordIntoElementpasswordToInput, nameof(browserInputPasswordIntoElementpasswordToInput), required: true);
            WorkflowExpression.Validate(browserInputPasswordIntoElementworkflow, nameof(browserInputPasswordIntoElementworkflow), required: true);
            WorkflowExpression.Validate(browserInputPasswordIntoElementparentElementHandle, nameof(browserInputPasswordIntoElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementHandle, nameof(browserInputPasswordIntoElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementName, nameof(browserInputPasswordIntoElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementID, nameof(browserInputPasswordIntoElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementTagName, nameof(browserInputPasswordIntoElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementXPath, nameof(browserInputPasswordIntoElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementClassName, nameof(browserInputPasswordIntoElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementCSSSelector, nameof(browserInputPasswordIntoElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementIndex, nameof(browserInputPasswordIntoElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementMatchValue, nameof(browserInputPasswordIntoElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementMatchText, nameof(browserInputPasswordIntoElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementType, nameof(browserInputPasswordIntoElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementMinimumWidth, nameof(browserInputPasswordIntoElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementMinimumHeight, nameof(browserInputPasswordIntoElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxLeft, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxRight, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxTop, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxBottom, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementresetExistingValue, nameof(browserInputPasswordIntoElementresetExistingValue), required: false);
            WorkflowExpression.Validate(browserInputPasswordIntoElementpasswordContainsStoredPassword, nameof(browserInputPasswordIntoElementpasswordContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputPasswordIntoElement = new JObject();
                var browserInputPasswordIntoElementpropCount = 0;
                if (browserInputPasswordIntoElementparentElementHandle != null)
                {
                    browserInputPasswordIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementparentElementHandle);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementHandle != null)
                {
                    browserInputPasswordIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementHandle);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementName != null)
                {
                    browserInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementID != null)
                {
                    browserInputPasswordIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementID);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementTagName != null)
                {
                    browserInputPasswordIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementTagName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementXPath != null)
                {
                    browserInputPasswordIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementXPath);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementClassName != null)
                {
                    browserInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementClassName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementCSSSelector != null)
                {
                    browserInputPasswordIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementCSSSelector);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementIndex != null)
                {
                    if (browserInputPasswordIntoElementsearchElementIndex != null)
                    {
                        browserInputPasswordIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementIndex);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementIndex"] = 1;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementMatchValue != null)
                {
                    browserInputPasswordIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMatchValue);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementMatchText != null)
                {
                    browserInputPasswordIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMatchText);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementType != null)
                {
                    browserInputPasswordIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementType);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                {
                    if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                    {
                        browserInputPasswordIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMinimumWidth);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementMinimumWidth"] = 1;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementMinimumHeight != null)
                {
                    if (browserInputPasswordIntoElementsearchElementMinimumHeight != null)
                    {
                        browserInputPasswordIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMinimumHeight);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementMinimumHeight"] = 1;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxLeft);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
                {
                    if (browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxRight);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = 99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
                {
                    if (browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxTop);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = -99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxBottom);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
                browserInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementpasswordToInput);
                if (browserInputPasswordIntoElementresetExistingValue != null)
                {
                    if (browserInputPasswordIntoElementresetExistingValue != null)
                    {
                        browserInputPasswordIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementresetExistingValue);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["ResetExistingValue"] = true;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
                {
                    if (browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
                    {
                        browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementpasswordContainsStoredPassword);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = false;
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
                browserInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementworkflow);
                if (browserInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = browserInputPasswordIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserPasteIntoElement))]
        public IWorkflowAction BrowserPasteIntoElement([WorkflowExpression] Func<string> browserPasteIntoElementworkflow, [WorkflowExpression] Func<double> browserPasteIntoElementparentElementHandle = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementName = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementID = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementType = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserPasteIntoElement(WorkflowExpression<string> browserPasteIntoElementworkflow, WorkflowExpression<double> browserPasteIntoElementparentElementHandle = null, WorkflowExpression<double> browserPasteIntoElementsearchElementHandle = null, WorkflowExpression<string> browserPasteIntoElementsearchElementName = null, WorkflowExpression<string> browserPasteIntoElementsearchElementID = null, WorkflowExpression<string> browserPasteIntoElementsearchElementTagName = null, WorkflowExpression<string> browserPasteIntoElementsearchElementXPath = null, WorkflowExpression<string> browserPasteIntoElementsearchElementClassName = null, WorkflowExpression<string> browserPasteIntoElementsearchElementCSSSelector = null, WorkflowExpression<double> browserPasteIntoElementsearchElementIndex = null, WorkflowExpression<string> browserPasteIntoElementsearchElementMatchValue = null, WorkflowExpression<string> browserPasteIntoElementsearchElementMatchText = null, WorkflowExpression<string> browserPasteIntoElementsearchElementType = null, WorkflowExpression<double> browserPasteIntoElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserPasteIntoElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserPasteIntoElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserPasteIntoElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserPasteIntoElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserPasteIntoElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserPasteIntoElementworkflow, nameof(browserPasteIntoElementworkflow), required: true);
            WorkflowExpression.Validate(browserPasteIntoElementparentElementHandle, nameof(browserPasteIntoElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementHandle, nameof(browserPasteIntoElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementName, nameof(browserPasteIntoElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementID, nameof(browserPasteIntoElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementTagName, nameof(browserPasteIntoElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementXPath, nameof(browserPasteIntoElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementClassName, nameof(browserPasteIntoElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementCSSSelector, nameof(browserPasteIntoElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementIndex, nameof(browserPasteIntoElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementMatchValue, nameof(browserPasteIntoElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementMatchText, nameof(browserPasteIntoElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementType, nameof(browserPasteIntoElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementMinimumWidth, nameof(browserPasteIntoElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementMinimumHeight, nameof(browserPasteIntoElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxLeft, nameof(browserPasteIntoElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxRight, nameof(browserPasteIntoElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxTop, nameof(browserPasteIntoElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxBottom, nameof(browserPasteIntoElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PasteIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPasteIntoElement = new JObject();
                var browserPasteIntoElementpropCount = 0;
                if (browserPasteIntoElementparentElementHandle != null)
                {
                    browserPasteIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPasteIntoElementparentElementHandle);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementHandle != null)
                {
                    browserPasteIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementHandle);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementName != null)
                {
                    browserPasteIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementName);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementID != null)
                {
                    browserPasteIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementID);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementTagName != null)
                {
                    browserPasteIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementTagName);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementXPath != null)
                {
                    browserPasteIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementXPath);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementClassName != null)
                {
                    browserPasteIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementClassName);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementCSSSelector != null)
                {
                    browserPasteIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementCSSSelector);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementIndex != null)
                {
                    if (browserPasteIntoElementsearchElementIndex != null)
                    {
                        browserPasteIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementIndex);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementIndex"] = 1;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementMatchValue != null)
                {
                    browserPasteIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMatchValue);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementMatchText != null)
                {
                    browserPasteIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMatchText);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementType != null)
                {
                    browserPasteIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementType);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementMinimumWidth != null)
                {
                    if (browserPasteIntoElementsearchElementMinimumWidth != null)
                    {
                        browserPasteIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMinimumWidth);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementMinimumWidth"] = 1;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementMinimumHeight != null)
                {
                    if (browserPasteIntoElementsearchElementMinimumHeight != null)
                    {
                        browserPasteIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMinimumHeight);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementMinimumHeight"] = 1;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserPasteIntoElementsearchElementBoundingBoxLeft != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxLeft);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementBoundingBoxRight != null)
                {
                    if (browserPasteIntoElementsearchElementBoundingBoxRight != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxRight);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxRight"] = 99999;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementBoundingBoxTop != null)
                {
                    if (browserPasteIntoElementsearchElementBoundingBoxTop != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxTop);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxTop"] = -99999;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserPasteIntoElementsearchElementBoundingBoxBottom != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxBottom);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
                browserPasteIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserPasteIntoElementworkflow);
                if (browserPasteIntoElementpropCount > 0)
                {
                    callPayload.Body = browserPasteIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserPrintCurrentPage))]
        public IWorkflowAction BrowserPrintCurrentPage([WorkflowExpression] Func<string> browserPrintCurrentPageworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserPrintCurrentPage(WorkflowExpression<string> browserPrintCurrentPageworkflow)
        {
            WorkflowExpression.Validate(browserPrintCurrentPageworkflow, nameof(browserPrintCurrentPageworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PrintCurrentPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPrintCurrentPage = new JObject();
                var browserPrintCurrentPagepropCount = 0;
                browserPrintCurrentPagepropCount++;
                browserPrintCurrentPage["Workflow"] = ExpressionConverter.ConvertO(browserPrintCurrentPageworkflow);
                if (browserPrintCurrentPagepropCount > 0)
                {
                    callPayload.Body = browserPrintCurrentPage;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserScrollWindowByPixels))]
        public IWorkflowAction BrowserScrollWindowByPixels([WorkflowExpression] Func<string> browserScrollWindowByPixelsworkflow, [WorkflowExpression] Func<double> browserScrollWindowByPixelsx = null, [WorkflowExpression] Func<double> browserScrollWindowByPixelsy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserScrollWindowByPixels(WorkflowExpression<string> browserScrollWindowByPixelsworkflow, WorkflowExpression<double> browserScrollWindowByPixelsx = null, WorkflowExpression<double> browserScrollWindowByPixelsy = null)
        {
            WorkflowExpression.Validate(browserScrollWindowByPixelsworkflow, nameof(browserScrollWindowByPixelsworkflow), required: true);
            WorkflowExpression.Validate(browserScrollWindowByPixelsx, nameof(browserScrollWindowByPixelsx), required: false);
            WorkflowExpression.Validate(browserScrollWindowByPixelsy, nameof(browserScrollWindowByPixelsy), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollWindowByPixels = new JObject();
                var browserScrollWindowByPixelspropCount = 0;
                if (browserScrollWindowByPixelsx != null)
                {
                    browserScrollWindowByPixels["X"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsx);
                    browserScrollWindowByPixelspropCount++;
                }

                if (browserScrollWindowByPixelsy != null)
                {
                    browserScrollWindowByPixels["Y"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsy);
                    browserScrollWindowByPixelspropCount++;
                }

                browserScrollWindowByPixelspropCount++;
                browserScrollWindowByPixels["Workflow"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsworkflow);
                if (browserScrollWindowByPixelspropCount > 0)
                {
                    callPayload.Body = browserScrollWindowByPixels;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserScrollWindowToPixels))]
        public IWorkflowAction BrowserScrollWindowToPixels([WorkflowExpression] Func<string> browserScrollWindowToPixelsworkflow, [WorkflowExpression] Func<double> browserScrollWindowToPixelsx = null, [WorkflowExpression] Func<double> browserScrollWindowToPixelsy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserScrollWindowToPixels(WorkflowExpression<string> browserScrollWindowToPixelsworkflow, WorkflowExpression<double> browserScrollWindowToPixelsx = null, WorkflowExpression<double> browserScrollWindowToPixelsy = null)
        {
            WorkflowExpression.Validate(browserScrollWindowToPixelsworkflow, nameof(browserScrollWindowToPixelsworkflow), required: true);
            WorkflowExpression.Validate(browserScrollWindowToPixelsx, nameof(browserScrollWindowToPixelsx), required: false);
            WorkflowExpression.Validate(browserScrollWindowToPixelsy, nameof(browserScrollWindowToPixelsy), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollWindowToPixels = new JObject();
                var browserScrollWindowToPixelspropCount = 0;
                if (browserScrollWindowToPixelsx != null)
                {
                    browserScrollWindowToPixels["X"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsx);
                    browserScrollWindowToPixelspropCount++;
                }

                if (browserScrollWindowToPixelsy != null)
                {
                    browserScrollWindowToPixels["Y"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsy);
                    browserScrollWindowToPixelspropCount++;
                }

                browserScrollWindowToPixelspropCount++;
                browserScrollWindowToPixels["Workflow"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsworkflow);
                if (browserScrollWindowToPixelspropCount > 0)
                {
                    callPayload.Body = browserScrollWindowToPixels;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserSelectAllOnElement))]
        public IWorkflowAction BrowserSelectAllOnElement([WorkflowExpression] Func<string> browserSelectAllOnElementworkflow, [WorkflowExpression] Func<double> browserSelectAllOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBrowserSelectAllOnElement(WorkflowExpression<string> browserSelectAllOnElementworkflow, WorkflowExpression<double> browserSelectAllOnElementparentElementHandle = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementHandle = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementName = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementID = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementTagName = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementXPath = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementClassName = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementCSSSelector = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementIndex = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementMatchValue = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementMatchText = null, WorkflowExpression<string> browserSelectAllOnElementsearchElementType = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementMinimumWidth = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementMinimumHeight = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserSelectAllOnElementsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            WorkflowExpression.Validate(browserSelectAllOnElementworkflow, nameof(browserSelectAllOnElementworkflow), required: true);
            WorkflowExpression.Validate(browserSelectAllOnElementparentElementHandle, nameof(browserSelectAllOnElementparentElementHandle), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementHandle, nameof(browserSelectAllOnElementsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementName, nameof(browserSelectAllOnElementsearchElementName), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementID, nameof(browserSelectAllOnElementsearchElementID), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementTagName, nameof(browserSelectAllOnElementsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementXPath, nameof(browserSelectAllOnElementsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementClassName, nameof(browserSelectAllOnElementsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementCSSSelector, nameof(browserSelectAllOnElementsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementIndex, nameof(browserSelectAllOnElementsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementMatchValue, nameof(browserSelectAllOnElementsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementMatchText, nameof(browserSelectAllOnElementsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementType, nameof(browserSelectAllOnElementsearchElementType), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementMinimumWidth, nameof(browserSelectAllOnElementsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementMinimumHeight, nameof(browserSelectAllOnElementsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxLeft, nameof(browserSelectAllOnElementsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxRight, nameof(browserSelectAllOnElementsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxTop, nameof(browserSelectAllOnElementsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxBottom, nameof(browserSelectAllOnElementsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SelectAllOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSelectAllOnElement = new JObject();
                var browserSelectAllOnElementpropCount = 0;
                if (browserSelectAllOnElementparentElementHandle != null)
                {
                    browserSelectAllOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSelectAllOnElementparentElementHandle);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementHandle != null)
                {
                    browserSelectAllOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementHandle);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementName != null)
                {
                    browserSelectAllOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementName);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementID != null)
                {
                    browserSelectAllOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementID);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementTagName != null)
                {
                    browserSelectAllOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementTagName);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementXPath != null)
                {
                    browserSelectAllOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementXPath);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementClassName != null)
                {
                    browserSelectAllOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementClassName);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementCSSSelector != null)
                {
                    browserSelectAllOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementCSSSelector);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementIndex != null)
                {
                    if (browserSelectAllOnElementsearchElementIndex != null)
                    {
                        browserSelectAllOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementIndex);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementIndex"] = 1;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementMatchValue != null)
                {
                    browserSelectAllOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMatchValue);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementMatchText != null)
                {
                    browserSelectAllOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMatchText);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementType != null)
                {
                    browserSelectAllOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementType);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementMinimumWidth != null)
                {
                    if (browserSelectAllOnElementsearchElementMinimumWidth != null)
                    {
                        browserSelectAllOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMinimumWidth);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementMinimumWidth"] = 1;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementMinimumHeight != null)
                {
                    if (browserSelectAllOnElementsearchElementMinimumHeight != null)
                    {
                        browserSelectAllOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMinimumHeight);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementMinimumHeight"] = 1;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxLeft);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementBoundingBoxRight != null)
                {
                    if (browserSelectAllOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxRight);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementBoundingBoxTop != null)
                {
                    if (browserSelectAllOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxTop);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxBottom);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
                browserSelectAllOnElement["Workflow"] = ExpressionConverter.ConvertO(browserSelectAllOnElementworkflow);
                if (browserSelectAllOnElementpropCount > 0)
                {
                    callPayload.Body = browserSelectAllOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserWaitForElementToExist))]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> BrowserWaitForElementToExist([WorkflowExpression] Func<int> browserWaitForElementToExistsecondsToWait, [WorkflowExpression] Func<string> browserWaitForElementToExistworkflow, [WorkflowExpression] Func<double> browserWaitForElementToExistparentElementHandle = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementName = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementID = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementTagName = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementXPath = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementClassName = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementIndex = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementMatchText = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementType = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistraiseExceptionIfElementNotFound = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistwaitForSearchElementToBeDisplayed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> __BuildBrowserWaitForElementToExist(WorkflowExpression<int> browserWaitForElementToExistsecondsToWait, WorkflowExpression<string> browserWaitForElementToExistworkflow, WorkflowExpression<double> browserWaitForElementToExistparentElementHandle = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementName = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementID = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementTagName = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementXPath = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementClassName = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementCSSSelector = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementIndex = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementMatchValue = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementMatchText = null, WorkflowExpression<string> browserWaitForElementToExistsearchElementType = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementMinimumWidth = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementMinimumHeight = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserWaitForElementToExistsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserWaitForElementToExistraiseExceptionIfElementNotFound = null, WorkflowExpression<bool> browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = null, WorkflowExpression<bool> browserWaitForElementToExistwaitForSearchElementToBeDisplayed = null)
        {
            WorkflowExpression.Validate(browserWaitForElementToExistsecondsToWait, nameof(browserWaitForElementToExistsecondsToWait), required: true);
            WorkflowExpression.Validate(browserWaitForElementToExistworkflow, nameof(browserWaitForElementToExistworkflow), required: true);
            WorkflowExpression.Validate(browserWaitForElementToExistparentElementHandle, nameof(browserWaitForElementToExistparentElementHandle), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementName, nameof(browserWaitForElementToExistsearchElementName), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementID, nameof(browserWaitForElementToExistsearchElementID), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementTagName, nameof(browserWaitForElementToExistsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementXPath, nameof(browserWaitForElementToExistsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementClassName, nameof(browserWaitForElementToExistsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementCSSSelector, nameof(browserWaitForElementToExistsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementIndex, nameof(browserWaitForElementToExistsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementMatchValue, nameof(browserWaitForElementToExistsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementMatchText, nameof(browserWaitForElementToExistsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementType, nameof(browserWaitForElementToExistsearchElementType), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementMinimumWidth, nameof(browserWaitForElementToExistsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementMinimumHeight, nameof(browserWaitForElementToExistsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxLeft, nameof(browserWaitForElementToExistsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxRight, nameof(browserWaitForElementToExistsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxTop, nameof(browserWaitForElementToExistsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxBottom, nameof(browserWaitForElementToExistsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistraiseExceptionIfElementNotFound, nameof(browserWaitForElementToExistraiseExceptionIfElementNotFound), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible, nameof(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible), required: false);
            WorkflowExpression.Validate(browserWaitForElementToExistwaitForSearchElementToBeDisplayed, nameof(browserWaitForElementToExistwaitForSearchElementToBeDisplayed), required: false);
            return new DeferredBodyAction<BrowserWaitForElementToExistResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/WaitForElementToExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserWaitForElementToExist = new JObject();
                var browserWaitForElementToExistpropCount = 0;
                if (browserWaitForElementToExistparentElementHandle != null)
                {
                    browserWaitForElementToExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToExistparentElementHandle);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementName != null)
                {
                    browserWaitForElementToExist["SearchElementName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementName);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementID != null)
                {
                    browserWaitForElementToExist["SearchElementID"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementID);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementTagName != null)
                {
                    browserWaitForElementToExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementTagName);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementXPath != null)
                {
                    browserWaitForElementToExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementXPath);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementClassName != null)
                {
                    browserWaitForElementToExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementClassName);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementCSSSelector != null)
                {
                    browserWaitForElementToExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementCSSSelector);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementIndex != null)
                {
                    if (browserWaitForElementToExistsearchElementIndex != null)
                    {
                        browserWaitForElementToExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementIndex);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementIndex"] = 1;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementMatchValue != null)
                {
                    browserWaitForElementToExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMatchValue);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementMatchText != null)
                {
                    browserWaitForElementToExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMatchText);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementType != null)
                {
                    browserWaitForElementToExist["SearchElementType"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementType);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementMinimumWidth != null)
                {
                    if (browserWaitForElementToExistsearchElementMinimumWidth != null)
                    {
                        browserWaitForElementToExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMinimumWidth);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementMinimumWidth"] = 1;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementMinimumHeight != null)
                {
                    if (browserWaitForElementToExistsearchElementMinimumHeight != null)
                    {
                        browserWaitForElementToExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMinimumHeight);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementMinimumHeight"] = 1;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
                {
                    if (browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxLeft);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = -99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementBoundingBoxRight != null)
                {
                    if (browserWaitForElementToExistsearchElementBoundingBoxRight != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxRight);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxRight"] = 99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementBoundingBoxTop != null)
                {
                    if (browserWaitForElementToExistsearchElementBoundingBoxTop != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxTop);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxTop"] = -99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
                {
                    if (browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxBottom);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = 99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
                browserWaitForElementToExist["SecondsToWait"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsecondsToWait);
                if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                {
                    if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                    {
                        browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserWaitForElementToExistraiseExceptionIfElementNotFound);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = false;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
                {
                    if (browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
                    {
                        browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = ExpressionConverter.ConvertO(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = true;
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
                {
                    if (browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
                    {
                        browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = ExpressionConverter.ConvertO(browserWaitForElementToExistwaitForSearchElementToBeDisplayed);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = false;
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
                browserWaitForElementToExist["Workflow"] = ExpressionConverter.ConvertO(browserWaitForElementToExistworkflow);
                if (browserWaitForElementToExistpropCount > 0)
                {
                    callPayload.Body = browserWaitForElementToExist;
                }

                return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserWaitForElementToNotExist))]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> BrowserWaitForElementToNotExist([WorkflowExpression] Func<int> browserWaitForElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> browserWaitForElementToNotExistworkflow, [WorkflowExpression] Func<double> browserWaitForElementToNotExistparentElementHandle = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementHandle = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementName = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementID = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementTagName = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementXPath = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementClassName = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementIndex = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementMatchText = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementType = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserWaitForElementToNotExistraiseExceptionIfElementStillExists = null, [WorkflowExpression] Func<bool> browserWaitForElementToNotExistsearchElementMustBeDisplayed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> __BuildBrowserWaitForElementToNotExist(WorkflowExpression<int> browserWaitForElementToNotExistsecondsToWait, WorkflowExpression<string> browserWaitForElementToNotExistworkflow, WorkflowExpression<double> browserWaitForElementToNotExistparentElementHandle = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementHandle = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementName = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementID = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementTagName = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementXPath = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementClassName = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementCSSSelector = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementIndex = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementMatchValue = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementMatchText = null, WorkflowExpression<string> browserWaitForElementToNotExistsearchElementType = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementMinimumWidth = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementMinimumHeight = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementBoundingBoxLeft = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementBoundingBoxRight = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementBoundingBoxTop = null, WorkflowExpression<double> browserWaitForElementToNotExistsearchElementBoundingBoxBottom = null, WorkflowExpression<bool> browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = null, WorkflowExpression<bool> browserWaitForElementToNotExistraiseExceptionIfElementStillExists = null, WorkflowExpression<bool> browserWaitForElementToNotExistsearchElementMustBeDisplayed = null)
        {
            WorkflowExpression.Validate(browserWaitForElementToNotExistsecondsToWait, nameof(browserWaitForElementToNotExistsecondsToWait), required: true);
            WorkflowExpression.Validate(browserWaitForElementToNotExistworkflow, nameof(browserWaitForElementToNotExistworkflow), required: true);
            WorkflowExpression.Validate(browserWaitForElementToNotExistparentElementHandle, nameof(browserWaitForElementToNotExistparentElementHandle), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementHandle, nameof(browserWaitForElementToNotExistsearchElementHandle), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementName, nameof(browserWaitForElementToNotExistsearchElementName), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementID, nameof(browserWaitForElementToNotExistsearchElementID), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementTagName, nameof(browserWaitForElementToNotExistsearchElementTagName), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementXPath, nameof(browserWaitForElementToNotExistsearchElementXPath), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementClassName, nameof(browserWaitForElementToNotExistsearchElementClassName), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementCSSSelector, nameof(browserWaitForElementToNotExistsearchElementCSSSelector), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementIndex, nameof(browserWaitForElementToNotExistsearchElementIndex), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementMatchValue, nameof(browserWaitForElementToNotExistsearchElementMatchValue), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementMatchText, nameof(browserWaitForElementToNotExistsearchElementMatchText), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementType, nameof(browserWaitForElementToNotExistsearchElementType), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementMinimumWidth, nameof(browserWaitForElementToNotExistsearchElementMinimumWidth), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementMinimumHeight, nameof(browserWaitForElementToNotExistsearchElementMinimumHeight), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxLeft, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxLeft), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxRight, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxRight), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxTop, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxTop), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxBottom, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxBottom), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistraiseExceptionIfElementStillExists, nameof(browserWaitForElementToNotExistraiseExceptionIfElementStillExists), required: false);
            WorkflowExpression.Validate(browserWaitForElementToNotExistsearchElementMustBeDisplayed, nameof(browserWaitForElementToNotExistsearchElementMustBeDisplayed), required: false);
            return new DeferredBodyAction<BrowserWaitForElementToNotExistResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserWaitForElementToNotExist = new JObject();
                var browserWaitForElementToNotExistpropCount = 0;
                if (browserWaitForElementToNotExistparentElementHandle != null)
                {
                    browserWaitForElementToNotExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistparentElementHandle);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementHandle != null)
                {
                    browserWaitForElementToNotExist["SearchElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementHandle);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementName != null)
                {
                    browserWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementID != null)
                {
                    browserWaitForElementToNotExist["SearchElementID"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementID);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementTagName != null)
                {
                    browserWaitForElementToNotExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementTagName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementXPath != null)
                {
                    browserWaitForElementToNotExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementXPath);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementClassName != null)
                {
                    browserWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementClassName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementCSSSelector != null)
                {
                    browserWaitForElementToNotExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementCSSSelector);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementIndex != null)
                {
                    if (browserWaitForElementToNotExistsearchElementIndex != null)
                    {
                        browserWaitForElementToNotExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementIndex);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementIndex"] = 1;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMatchValue != null)
                {
                    browserWaitForElementToNotExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMatchValue);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMatchText != null)
                {
                    browserWaitForElementToNotExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMatchText);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementType != null)
                {
                    browserWaitForElementToNotExist["SearchElementType"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementType);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                {
                    if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMinimumWidth);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementMinimumWidth"] = 1;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMinimumHeight != null)
                {
                    if (browserWaitForElementToNotExistsearchElementMinimumHeight != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMinimumHeight);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementMinimumHeight"] = 1;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
                {
                    if (browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxLeft);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = -99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
                {
                    if (browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxRight);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = 99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
                {
                    if (browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxTop);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = -99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
                {
                    if (browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxBottom);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = 99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
                browserWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsecondsToWait);
                if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistraiseExceptionIfElementStillExists);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
                {
                    if (browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMustBeDisplayed);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = false;
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
                browserWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistworkflow);
                if (browserWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = browserWaitForElementToNotExist;
                }

                return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetWebElementAtScreenCoordinates))]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> BrowserGetWebElementAtScreenCoordinates([WorkflowExpression] Func<string> browserGetWebElementAtScreenCoordinatesworkflow, [WorkflowExpression] Func<int> browserGetWebElementAtScreenCoordinatesxCoord = null, [WorkflowExpression] Func<int> browserGetWebElementAtScreenCoordinatesyCoord = null, [WorkflowExpression] Func<bool> browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> __BuildBrowserGetWebElementAtScreenCoordinates(WorkflowExpression<string> browserGetWebElementAtScreenCoordinatesworkflow, WorkflowExpression<int> browserGetWebElementAtScreenCoordinatesxCoord = null, WorkflowExpression<int> browserGetWebElementAtScreenCoordinatesyCoord = null, WorkflowExpression<bool> browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = null)
        {
            WorkflowExpression.Validate(browserGetWebElementAtScreenCoordinatesworkflow, nameof(browserGetWebElementAtScreenCoordinatesworkflow), required: true);
            WorkflowExpression.Validate(browserGetWebElementAtScreenCoordinatesxCoord, nameof(browserGetWebElementAtScreenCoordinatesxCoord), required: false);
            WorkflowExpression.Validate(browserGetWebElementAtScreenCoordinatesyCoord, nameof(browserGetWebElementAtScreenCoordinatesyCoord), required: false);
            WorkflowExpression.Validate(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound, nameof(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<BrowserGetWebElementAtScreenCoordinatesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetWebElementAtScreenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementAtScreenCoordinates = new JObject();
                var browserGetWebElementAtScreenCoordinatespropCount = 0;
                if (browserGetWebElementAtScreenCoordinatesxCoord != null)
                {
                    if (browserGetWebElementAtScreenCoordinatesxCoord != null)
                    {
                        browserGetWebElementAtScreenCoordinates["XCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesxCoord);
                        browserGetWebElementAtScreenCoordinatespropCount++;
                    }

                    browserGetWebElementAtScreenCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtScreenCoordinates["XCoord"] = 0;
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                if (browserGetWebElementAtScreenCoordinatesyCoord != null)
                {
                    if (browserGetWebElementAtScreenCoordinatesyCoord != null)
                    {
                        browserGetWebElementAtScreenCoordinates["YCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesyCoord);
                        browserGetWebElementAtScreenCoordinatespropCount++;
                    }

                    browserGetWebElementAtScreenCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtScreenCoordinates["YCoord"] = 0;
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                if (browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    if (browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
                    {
                        browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound);
                        browserGetWebElementAtScreenCoordinatespropCount++;
                    }

                    browserGetWebElementAtScreenCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = false;
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
                browserGetWebElementAtScreenCoordinates["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesworkflow);
                if (browserGetWebElementAtScreenCoordinatespropCount > 0)
                {
                    callPayload.Body = browserGetWebElementAtScreenCoordinates;
                }

                return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetWebElementAtBrowserDocumentWindowCoordinates))]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> BrowserGetWebElementAtBrowserDocumentWindowCoordinates([WorkflowExpression] Func<string> browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, [WorkflowExpression] Func<int> browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = null, [WorkflowExpression] Func<int> browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = null, [WorkflowExpression] Func<bool> browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> __BuildBrowserGetWebElementAtBrowserDocumentWindowCoordinates(WorkflowExpression<string> browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, WorkflowExpression<int> browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = null, WorkflowExpression<int> browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = null, WorkflowExpression<bool> browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = null)
        {
            WorkflowExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow), required: true);
            WorkflowExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord), required: false);
            WorkflowExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord), required: false);
            WorkflowExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetWebElementAtBrowserDocumentWindowCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementAtBrowserDocumentWindowCoordinates = new JObject();
                var browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount = 0;
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
                {
                    if (browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
                    {
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord);
                        browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                    }

                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = 0;
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
                {
                    if (browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
                    {
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord);
                        browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                    }

                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = 0;
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    if (browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
                    {
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound);
                        browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                    }

                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = false;
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                browserGetWebElementAtBrowserDocumentWindowCoordinates["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow);
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount > 0)
                {
                    callPayload.Body = browserGetWebElementAtBrowserDocumentWindowCoordinates;
                }

                return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildBrowserGetWebElementPropertiesAsList))]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> BrowserGetWebElementPropertiesAsList([WorkflowExpression] Func<int> browserGetWebElementPropertiesAsListelementHandle, [WorkflowExpression] Func<string> browserGetWebElementPropertiesAsListworkflow, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnValue = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnText = null, [WorkflowExpression] Func<int> browserGetWebElementPropertiesAsListmaxValueLength = null, [WorkflowExpression] Func<int> browserGetWebElementPropertiesAsListmaxTextLength = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnCoordinates = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnParentTag = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> __BuildBrowserGetWebElementPropertiesAsList(WorkflowExpression<int> browserGetWebElementPropertiesAsListelementHandle, WorkflowExpression<string> browserGetWebElementPropertiesAsListworkflow, WorkflowExpression<bool> browserGetWebElementPropertiesAsListgetHTMLCode = null, WorkflowExpression<bool> browserGetWebElementPropertiesAsListreturnValue = null, WorkflowExpression<bool> browserGetWebElementPropertiesAsListreturnText = null, WorkflowExpression<int> browserGetWebElementPropertiesAsListmaxValueLength = null, WorkflowExpression<int> browserGetWebElementPropertiesAsListmaxTextLength = null, WorkflowExpression<bool> browserGetWebElementPropertiesAsListreturnCoordinates = null, WorkflowExpression<bool> browserGetWebElementPropertiesAsListreturnParentTag = null)
        {
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListelementHandle, nameof(browserGetWebElementPropertiesAsListelementHandle), required: true);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListworkflow, nameof(browserGetWebElementPropertiesAsListworkflow), required: true);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListgetHTMLCode, nameof(browserGetWebElementPropertiesAsListgetHTMLCode), required: false);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListreturnValue, nameof(browserGetWebElementPropertiesAsListreturnValue), required: false);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListreturnText, nameof(browserGetWebElementPropertiesAsListreturnText), required: false);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListmaxValueLength, nameof(browserGetWebElementPropertiesAsListmaxValueLength), required: false);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListmaxTextLength, nameof(browserGetWebElementPropertiesAsListmaxTextLength), required: false);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListreturnCoordinates, nameof(browserGetWebElementPropertiesAsListreturnCoordinates), required: false);
            WorkflowExpression.Validate(browserGetWebElementPropertiesAsListreturnParentTag, nameof(browserGetWebElementPropertiesAsListreturnParentTag), required: false);
            return new DeferredBodyAction<BrowserGetWebElementPropertiesAsListResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementPropertiesAsList = new JObject();
                var browserGetWebElementPropertiesAsListpropCount = 0;
                browserGetWebElementPropertiesAsListpropCount++;
                browserGetWebElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListelementHandle);
                if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
                {
                    if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
                    {
                        browserGetWebElementPropertiesAsList["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListgetHTMLCode);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["GetHTMLCode"] = false;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (browserGetWebElementPropertiesAsListreturnValue != null)
                {
                    if (browserGetWebElementPropertiesAsListreturnValue != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnValue"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnValue);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnValue"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (browserGetWebElementPropertiesAsListreturnText != null)
                {
                    if (browserGetWebElementPropertiesAsListreturnText != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnText"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnText);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnText"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (browserGetWebElementPropertiesAsListmaxValueLength != null)
                {
                    if (browserGetWebElementPropertiesAsListmaxValueLength != null)
                    {
                        browserGetWebElementPropertiesAsList["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListmaxValueLength);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["MaxValueLength"] = 0;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (browserGetWebElementPropertiesAsListmaxTextLength != null)
                {
                    if (browserGetWebElementPropertiesAsListmaxTextLength != null)
                    {
                        browserGetWebElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListmaxTextLength);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["MaxTextLength"] = 0;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (browserGetWebElementPropertiesAsListreturnCoordinates != null)
                {
                    if (browserGetWebElementPropertiesAsListreturnCoordinates != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnCoordinates);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnCoordinates"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (browserGetWebElementPropertiesAsListreturnParentTag != null)
                {
                    if (browserGetWebElementPropertiesAsListreturnParentTag != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnParentTag);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnParentTag"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
                browserGetWebElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListworkflow);
                if (browserGetWebElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = browserGetWebElementPropertiesAsList;
                }

                return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [WorkflowExpressionFactory(nameof(__BuildIsBrowserInstanceOpen))]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> IsBrowserInstanceOpen([WorkflowExpression] Func<string> isBrowserInstanceOpenworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> __BuildIsBrowserInstanceOpen(WorkflowExpression<string> isBrowserInstanceOpenworkflow)
        {
            WorkflowExpression.Validate(isBrowserInstanceOpenworkflow, nameof(isBrowserInstanceOpenworkflow), required: true);
            return new DeferredBodyAction<IsBrowserInstanceOpenResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isBrowserInstanceOpen = new JObject();
                var isBrowserInstanceOpenpropCount = 0;
                isBrowserInstanceOpenpropCount++;
                isBrowserInstanceOpen["Workflow"] = ExpressionConverter.ConvertO(isBrowserInstanceOpenworkflow);
                if (isBrowserInstanceOpenpropCount > 0)
                {
                    callPayload.Body = isBrowserInstanceOpen;
                }

                return new ApiConnectionAction<IsBrowserInstanceOpenResponse>(callPayload);
            });
        }
    }

    public class IaconnectwebbrowserTriggers([ConnectionName] string connectionId)
    {
    }

    public class BrowserGetChromeBrowserVersionFromFileResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
    }

    public class BrowserGetChromeDriverFolderResponse
    {
        public string ChromeDriverFolder { get; set; }
    }

    public class BrowserDownloadSuitableChromeDriverFromInternetResponse
    {
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromeDriverAvailableResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
        public bool SuitableChromeDriverAvailable { get; set; }
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserOpenChromeResponse
    {
        public int ChromeDriverPID { get; set; }
        public int ChromeDriverTCPPort { get; set; }
        public int ChromePID { get; set; }
        public int ChromeTCPPort { get; set; }
        public string ChromeInstanceUserDataDir { get; set; }
        public bool ChromeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserGetChromiumEdgeDriverFolderResponse
    {
        public string ChromiumEdgeDriverFolder { get; set; }
    }

    public class BrowserGetChromiumEdgeBrowserVersionFromFileResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
    }

    public class BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse
    {
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromiumEdgeDriverAvailableResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
        public bool SuitableChromiumEdgeDriverAvailable { get; set; }
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserOpenChromiumEdgeResponse
    {
        public int ChromiumEdgeDriverPID { get; set; }
        public int ChromiumEdgeDriverTCPPort { get; set; }
        public int ChromiumEdgePID { get; set; }
        public int ChromiumEdgeTCPPort { get; set; }
        public string ChromiumEdgeInstanceUserDataDir { get; set; }
        public bool ChromiumEdgeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserNavigateToURLResponse
    {
        public string PageTitle { get; set; }
        public string PageURL { get; set; }
    }

    public class BrowserDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
    }

    public class BrowserCreateHandleToElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserCreateHandleToParentElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetElementPropertiesResponse
    {
        public string ElementName { get; set; }
        public string ElementID { get; set; }
        public string ElementTagName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementValue { get; set; }
        public string ElementText { get; set; }
        public bool ElementEnabled { get; set; }
        public bool ElementDisplayed { get; set; }
        public double ElementXCoordinate { get; set; }
        public double ElementYCoordinate { get; set; }
        public double ElementWidth { get; set; }
        public double ElementHeight { get; set; }
        public bool ElementSelected { get; set; }
        public string ElementType { get; set; }
        public string InnerHTML { get; set; }
        public string OuterHTML { get; set; }
        public double ChildElementCount { get; set; }
        public string ParentTagName { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserGetMultipleElementPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserGetElementParentPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class BrowserGetElementChildrenPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserInputTextIntoElementResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserGetSelectionPropertiesResponse
    {
        public string SelectedOptionText { get; set; }
        public string SelectedOptionValue { get; set; }
        public double NumberOfOptions { get; set; }
        public JToken[] SelectionOptions { get; set; }
    }

    public class BrowserGetTableContentsResponse
    {
        public double NumberOfRows { get; set; }
        public double NumberOfColumns { get; set; }
        public string TableContentsJSON { get; set; }
    }

    public class BrowserExecuteJavaScriptResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserGetElementBoundingRectResponse
    {
        public double ElementLeftPixels { get; set; }
        public double ElementRightPixels { get; set; }
        public double ElementTopPixels { get; set; }
        public double ElementBottomPixels { get; set; }
        public double ElementCenterXPixels { get; set; }
        public double ElementCenterYPixels { get; set; }
    }

    public class BrowserGetBrowserParentWindowDetailsResponse
    {
        public string MainWindowElementName { get; set; }
        public string MainWindowElementClassName { get; set; }
        public int MainWindowLeftXPixels { get; set; }
        public int MainWindowTopYPixels { get; set; }
        public int MainWindowWidthPixels { get; set; }
        public int MainWindowHeightPixels { get; set; }
        public string DocumentElementName { get; set; }
        public string DocumentElementClassName { get; set; }
        public int DocumentLeftXPixels { get; set; }
        public int DocumentTopYPixels { get; set; }
        public int DocumentWidthPixels { get; set; }
        public int DocumentHeightPixels { get; set; }
    }

    public class BrowserGetElementScreenBoundingRectResponse
    {
        public double ElementScreenLeftPixels { get; set; }
        public double ElementScreenRightPixels { get; set; }
        public double ElementScreenTopPixels { get; set; }
        public double ElementScreenBottomPixels { get; set; }
        public double ElementScreenCenterXPixels { get; set; }
        public double ElementScreenCenterYPixels { get; set; }
        public bool ElementIsOnscreen { get; set; }
        public string OffscreenDirection { get; set; }
    }

    public class BrowserExecuteJavaScriptOnElementResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserOpenNewTabResponse
    {
        public string NewTabName { get; set; }
        public int NewTabIndex { get; set; }
    }

    public class BrowserGetTabsResponse
    {
        public int NumberOfTabs { get; set; }
        public string CurrentTabHandle { get; set; }
        public string BrowserTabsJSON { get; set; }
    }

    public class BrowserGetPageTextResponse
    {
        public string PageText { get; set; }
    }

    public class BrowserGetCurrentFrameWindowPixelCoordinateResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class BrowserClearElementTextResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserWaitForElementToExistResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class BrowserGetWebElementAtScreenCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string ElementPropertiesJSON { get; set; }
    }

    public class IsBrowserInstanceOpenResponse
    {
        public bool IsBrowserInstanceOpen { get; set; }
        public string BrowserName { get; set; }
        public int BrowserMajorVersion { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser;

    public partial class WorkflowManagedActions
    {
        public IaconnectwebbrowserActions Iaconnectwebbrowser(string connectionId) => new IaconnectwebbrowserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectwebbrowserTriggers Iaconnectwebbrowser(string connectionId) => new IaconnectwebbrowserTriggers(connectionId);
    }
}