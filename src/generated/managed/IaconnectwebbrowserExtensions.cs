//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectwebbrowserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> BrowserGetChromeBrowserVersionFromFile([WorkflowExpression] Func<string> browserGetChromeBrowserVersionFromFileworkflow, [WorkflowExpression] Func<string> browserGetChromeBrowserVersionFromFilechromeBrowserEXE = null)
        {
            SourceExpression.Validate(browserGetChromeBrowserVersionFromFileworkflow, nameof(browserGetChromeBrowserVersionFromFileworkflow), required: true);
            SourceExpression.Validate(browserGetChromeBrowserVersionFromFilechromeBrowserEXE, nameof(browserGetChromeBrowserVersionFromFilechromeBrowserEXE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromeBrowserVersionFromFile = new JObject();
                var browserGetChromeBrowserVersionFromFilepropCount = 0;
                if (browserGetChromeBrowserVersionFromFilechromeBrowserEXE != null)
                {
                    browserGetChromeBrowserVersionFromFile["ChromeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserGetChromeBrowserVersionFromFilechromeBrowserEXE);
                    browserGetChromeBrowserVersionFromFilepropCount++;
                }

                browserGetChromeBrowserVersionFromFilepropCount++;
                browserGetChromeBrowserVersionFromFile["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetChromeBrowserVersionFromFileworkflow);
                if (browserGetChromeBrowserVersionFromFilepropCount > 0)
                {
                    callPayload.Body = browserGetChromeBrowserVersionFromFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> BrowserGetChromeDriverFolder([WorkflowExpression] Func<string> browserGetChromeDriverFolderdirectoryPath, [WorkflowExpression] Func<string> browserGetChromeDriverFolderworkflow, [WorkflowExpression] Func<int> browserGetChromeDriverFolderchromeMajorVersion = null, [WorkflowExpression] Func<string> browserGetChromeDriverFolderchromeBrowserEXE = null)
        {
            SourceExpression.Validate(browserGetChromeDriverFolderdirectoryPath, nameof(browserGetChromeDriverFolderdirectoryPath), required: true);
            SourceExpression.Validate(browserGetChromeDriverFolderworkflow, nameof(browserGetChromeDriverFolderworkflow), required: true);
            SourceExpression.Validate(browserGetChromeDriverFolderchromeMajorVersion, nameof(browserGetChromeDriverFolderchromeMajorVersion), required: false);
            SourceExpression.Validate(browserGetChromeDriverFolderchromeBrowserEXE, nameof(browserGetChromeDriverFolderchromeBrowserEXE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromeDriverFolder = new JObject();
                var browserGetChromeDriverFolderpropCount = 0;
                browserGetChromeDriverFolderpropCount++;
                browserGetChromeDriverFolder["DirectoryPath"] = SourceExpressionConverter.ConvertToken(browserGetChromeDriverFolderdirectoryPath);
                if (browserGetChromeDriverFolderchromeMajorVersion != null)
                {
                    browserGetChromeDriverFolder["ChromeMajorVersion"] = SourceExpressionConverter.ConvertToken(browserGetChromeDriverFolderchromeMajorVersion);
                    browserGetChromeDriverFolderpropCount++;
                }

                if (browserGetChromeDriverFolderchromeBrowserEXE != null)
                {
                    browserGetChromeDriverFolder["ChromeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserGetChromeDriverFolderchromeBrowserEXE);
                    browserGetChromeDriverFolderpropCount++;
                }

                browserGetChromeDriverFolderpropCount++;
                browserGetChromeDriverFolder["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetChromeDriverFolderworkflow);
                if (browserGetChromeDriverFolderpropCount > 0)
                {
                    callPayload.Body = browserGetChromeDriverFolder;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> BrowserDownloadSuitableChromeDriverFromInternet([WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetworkflow, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = null, [WorkflowExpression] Func<bool> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = null, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = null, [WorkflowExpression] Func<bool> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = null, [WorkflowExpression] Func<string> browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = null, [WorkflowExpression] Func<bool> browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = null)
        {
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder), required: true);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetworkflow, nameof(browserDownloadSuitableChromeDriverFromInternetworkflow), required: true);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE, nameof(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE), required: false);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex, nameof(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex), required: false);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL), required: false);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex, nameof(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex), required: false);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL), required: false);
            SourceExpression.Validate(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver, nameof(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDownloadSuitableChromeDriverFromInternet = new JObject();
                var browserDownloadSuitableChromeDriverFromInternetpropCount = 0;
                if (browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverDownloadParentFolder"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder);
                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                {
                    if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex);
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
                        browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL);
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
                        browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex);
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
                        browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL);
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
                        browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver);
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
                browserDownloadSuitableChromeDriverFromInternet["Workflow"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetworkflow);
                if (browserDownloadSuitableChromeDriverFromInternetpropCount > 0)
                {
                    callPayload.Body = browserDownloadSuitableChromeDriverFromInternet;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> BrowserIsSuitableChromeDriverAvailable([WorkflowExpression] Func<string> browserIsSuitableChromeDriverAvailableworkflow, [WorkflowExpression] Func<string> browserIsSuitableChromeDriverAvailablechromeDriverFolder = null, [WorkflowExpression] Func<string> browserIsSuitableChromeDriverAvailablechromeBrowserEXE = null)
        {
            SourceExpression.Validate(browserIsSuitableChromeDriverAvailableworkflow, nameof(browserIsSuitableChromeDriverAvailableworkflow), required: true);
            SourceExpression.Validate(browserIsSuitableChromeDriverAvailablechromeDriverFolder, nameof(browserIsSuitableChromeDriverAvailablechromeDriverFolder), required: false);
            SourceExpression.Validate(browserIsSuitableChromeDriverAvailablechromeBrowserEXE, nameof(browserIsSuitableChromeDriverAvailablechromeBrowserEXE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserIsSuitableChromeDriverAvailable = new JObject();
                var browserIsSuitableChromeDriverAvailablepropCount = 0;
                if (browserIsSuitableChromeDriverAvailablechromeDriverFolder != null)
                {
                    browserIsSuitableChromeDriverAvailable["ChromeDriverFolder"] = SourceExpressionConverter.ConvertToken(browserIsSuitableChromeDriverAvailablechromeDriverFolder);
                    browserIsSuitableChromeDriverAvailablepropCount++;
                }

                if (browserIsSuitableChromeDriverAvailablechromeBrowserEXE != null)
                {
                    browserIsSuitableChromeDriverAvailable["ChromeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserIsSuitableChromeDriverAvailablechromeBrowserEXE);
                    browserIsSuitableChromeDriverAvailablepropCount++;
                }

                browserIsSuitableChromeDriverAvailablepropCount++;
                browserIsSuitableChromeDriverAvailable["Workflow"] = SourceExpressionConverter.ConvertToken(browserIsSuitableChromeDriverAvailableworkflow);
                if (browserIsSuitableChromeDriverAvailablepropCount > 0)
                {
                    callPayload.Body = browserIsSuitableChromeDriverAvailable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromeDriver([WorkflowExpression] Func<string> browserUploadNewChromeDriverlocalChromeDriverFilePath, [WorkflowExpression] Func<string> browserUploadNewChromeDriverworkflow, [WorkflowExpression] Func<bool> browserUploadNewChromeDrivercompress = null, [WorkflowExpression] Func<int> browserUploadNewChromeDriverchromeBrowserMajorVersion = null, [WorkflowExpression] Func<string> browserUploadNewChromeDriverchromeDriverRootSaveFolder = null)
        {
            SourceExpression.Validate(browserUploadNewChromeDriverlocalChromeDriverFilePath, nameof(browserUploadNewChromeDriverlocalChromeDriverFilePath), required: true);
            SourceExpression.Validate(browserUploadNewChromeDriverworkflow, nameof(browserUploadNewChromeDriverworkflow), required: true);
            SourceExpression.Validate(browserUploadNewChromeDrivercompress, nameof(browserUploadNewChromeDrivercompress), required: false);
            SourceExpression.Validate(browserUploadNewChromeDriverchromeBrowserMajorVersion, nameof(browserUploadNewChromeDriverchromeBrowserMajorVersion), required: false);
            SourceExpression.Validate(browserUploadNewChromeDriverchromeDriverRootSaveFolder, nameof(browserUploadNewChromeDriverchromeDriverRootSaveFolder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserUploadNewChromeDriver = new JObject();
                var browserUploadNewChromeDriverpropCount = 0;
                browserUploadNewChromeDriverpropCount++;
                browserUploadNewChromeDriver["LocalChromeDriverFilePath"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromeDriverlocalChromeDriverFilePath);
                if (browserUploadNewChromeDrivercompress != null)
                {
                    if (browserUploadNewChromeDrivercompress != null)
                    {
                        browserUploadNewChromeDriver["Compress"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromeDrivercompress);
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
                    browserUploadNewChromeDriver["ChromeBrowserMajorVersion"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromeDriverchromeBrowserMajorVersion);
                    browserUploadNewChromeDriverpropCount++;
                }

                if (browserUploadNewChromeDriverchromeDriverRootSaveFolder != null)
                {
                    browserUploadNewChromeDriver["ChromeDriverRootSaveFolder"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromeDriverchromeDriverRootSaveFolder);
                    browserUploadNewChromeDriverpropCount++;
                }

                browserUploadNewChromeDriverpropCount++;
                browserUploadNewChromeDriver["Workflow"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromeDriverworkflow);
                if (browserUploadNewChromeDriverpropCount > 0)
                {
                    callPayload.Body = browserUploadNewChromeDriver;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> BrowserOpenChrome([WorkflowExpression] Func<string> browserOpenChromeworkflow, [WorkflowExpression] Func<string> browserOpenChromechromeDriverFolder = null, [WorkflowExpression] Func<bool> browserOpenChromekillExistingChromeDriver = null, [WorkflowExpression] Func<string> browserOpenChromeuserDataDir = null, [WorkflowExpression] Func<bool> browserOpenChromeprintToDefaultPrinter = null, [WorkflowExpression] Func<string> browserOpenChromedefaultDownloadDirectory = null, [WorkflowExpression] Func<bool> browserOpenChromedownloadPDFInsteadOfOpening = null, [WorkflowExpression] Func<string> browserOpenChromechromeDriverLogFilename = null, [WorkflowExpression] Func<string> browserOpenChromelocalChromeDriverFolder = null, [WorkflowExpression] Func<string> browserOpenChromechromeBrowserEXE = null, [WorkflowExpression] Func<bool> browserOpenChromeignoreCertificateErrors = null, [WorkflowExpression] Func<string> browserOpenChromeadditionalArguments = null, [WorkflowExpression] Func<bool> browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = null)
        {
            SourceExpression.Validate(browserOpenChromeworkflow, nameof(browserOpenChromeworkflow), required: true);
            SourceExpression.Validate(browserOpenChromechromeDriverFolder, nameof(browserOpenChromechromeDriverFolder), required: false);
            SourceExpression.Validate(browserOpenChromekillExistingChromeDriver, nameof(browserOpenChromekillExistingChromeDriver), required: false);
            SourceExpression.Validate(browserOpenChromeuserDataDir, nameof(browserOpenChromeuserDataDir), required: false);
            SourceExpression.Validate(browserOpenChromeprintToDefaultPrinter, nameof(browserOpenChromeprintToDefaultPrinter), required: false);
            SourceExpression.Validate(browserOpenChromedefaultDownloadDirectory, nameof(browserOpenChromedefaultDownloadDirectory), required: false);
            SourceExpression.Validate(browserOpenChromedownloadPDFInsteadOfOpening, nameof(browserOpenChromedownloadPDFInsteadOfOpening), required: false);
            SourceExpression.Validate(browserOpenChromechromeDriverLogFilename, nameof(browserOpenChromechromeDriverLogFilename), required: false);
            SourceExpression.Validate(browserOpenChromelocalChromeDriverFolder, nameof(browserOpenChromelocalChromeDriverFolder), required: false);
            SourceExpression.Validate(browserOpenChromechromeBrowserEXE, nameof(browserOpenChromechromeBrowserEXE), required: false);
            SourceExpression.Validate(browserOpenChromeignoreCertificateErrors, nameof(browserOpenChromeignoreCertificateErrors), required: false);
            SourceExpression.Validate(browserOpenChromeadditionalArguments, nameof(browserOpenChromeadditionalArguments), required: false);
            SourceExpression.Validate(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen, nameof(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/OpenChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenChrome = new JObject();
                var browserOpenChromepropCount = 0;
                if (browserOpenChromechromeDriverFolder != null)
                {
                    browserOpenChrome["ChromeDriverFolder"] = SourceExpressionConverter.ConvertToken(browserOpenChromechromeDriverFolder);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromekillExistingChromeDriver != null)
                {
                    if (browserOpenChromekillExistingChromeDriver != null)
                    {
                        browserOpenChrome["KillExistingChromeDriver"] = SourceExpressionConverter.ConvertToken(browserOpenChromekillExistingChromeDriver);
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
                    browserOpenChrome["UserDataDir"] = SourceExpressionConverter.ConvertToken(browserOpenChromeuserDataDir);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromeprintToDefaultPrinter != null)
                {
                    if (browserOpenChromeprintToDefaultPrinter != null)
                    {
                        browserOpenChrome["PrintToDefaultPrinter"] = SourceExpressionConverter.ConvertToken(browserOpenChromeprintToDefaultPrinter);
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
                    browserOpenChrome["DefaultDownloadDirectory"] = SourceExpressionConverter.ConvertToken(browserOpenChromedefaultDownloadDirectory);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromedownloadPDFInsteadOfOpening != null)
                {
                    if (browserOpenChromedownloadPDFInsteadOfOpening != null)
                    {
                        browserOpenChrome["DownloadPDFInsteadOfOpening"] = SourceExpressionConverter.ConvertToken(browserOpenChromedownloadPDFInsteadOfOpening);
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
                    browserOpenChrome["ChromeDriverLogFilename"] = SourceExpressionConverter.ConvertToken(browserOpenChromechromeDriverLogFilename);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromelocalChromeDriverFolder != null)
                {
                    browserOpenChrome["LocalChromeDriverFolder"] = SourceExpressionConverter.ConvertToken(browserOpenChromelocalChromeDriverFolder);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromechromeBrowserEXE != null)
                {
                    browserOpenChrome["ChromeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserOpenChromechromeBrowserEXE);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromeignoreCertificateErrors != null)
                {
                    if (browserOpenChromeignoreCertificateErrors != null)
                    {
                        browserOpenChrome["IgnoreCertificateErrors"] = SourceExpressionConverter.ConvertToken(browserOpenChromeignoreCertificateErrors);
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
                    browserOpenChrome["AdditionalArguments"] = SourceExpressionConverter.ConvertToken(browserOpenChromeadditionalArguments);
                    browserOpenChromepropCount++;
                }

                if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                {
                    if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                    {
                        browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = SourceExpressionConverter.ConvertToken(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen);
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
                browserOpenChrome["Workflow"] = SourceExpressionConverter.ConvertToken(browserOpenChromeworkflow);
                if (browserOpenChromepropCount > 0)
                {
                    callPayload.Body = browserOpenChrome;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserOpenChromeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChrome([WorkflowExpression] Func<string> browserCloseChromeworkflow, [WorkflowExpression] Func<bool> browserCloseChromepurgeDynamicUserDataDir = null, [WorkflowExpression] Func<bool> browserCloseChromepurgeStaticUserDataDir = null)
        {
            SourceExpression.Validate(browserCloseChromeworkflow, nameof(browserCloseChromeworkflow), required: true);
            SourceExpression.Validate(browserCloseChromepurgeDynamicUserDataDir, nameof(browserCloseChromepurgeDynamicUserDataDir), required: false);
            SourceExpression.Validate(browserCloseChromepurgeStaticUserDataDir, nameof(browserCloseChromepurgeStaticUserDataDir), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        browserCloseChrome["PurgeDynamicUserDataDir"] = SourceExpressionConverter.ConvertToken(browserCloseChromepurgeDynamicUserDataDir);
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
                        browserCloseChrome["PurgeStaticUserDataDir"] = SourceExpressionConverter.ConvertToken(browserCloseChromepurgeStaticUserDataDir);
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
                browserCloseChrome["Workflow"] = SourceExpressionConverter.ConvertToken(browserCloseChromeworkflow);
                if (browserCloseChromepropCount > 0)
                {
                    callPayload.Body = browserCloseChrome;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserOpenInternetExplorer([WorkflowExpression] Func<string> browserOpenInternetExplorerworkflow, [WorkflowExpression] Func<string> browserOpenInternetExploreriEDriverFolder = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerkillExistingIEDriver = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerkillExistingIE = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorercleanSession = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerenableNativeEvents = null, [WorkflowExpression] Func<string> browserOpenInternetExplorerwebDriverLogFile = null, [WorkflowExpression] Func<string> browserOpenInternetExplorerwebDriverLogLevel = null, [WorkflowExpression] Func<bool> browserOpenInternetExplorerdisableIEFirstRunCustomise = null, [WorkflowExpression] Func<string> browserOpenInternetExploreradditionalArguments = null)
        {
            SourceExpression.Validate(browserOpenInternetExplorerworkflow, nameof(browserOpenInternetExplorerworkflow), required: true);
            SourceExpression.Validate(browserOpenInternetExploreriEDriverFolder, nameof(browserOpenInternetExploreriEDriverFolder), required: false);
            SourceExpression.Validate(browserOpenInternetExplorerkillExistingIEDriver, nameof(browserOpenInternetExplorerkillExistingIEDriver), required: false);
            SourceExpression.Validate(browserOpenInternetExplorerkillExistingIE, nameof(browserOpenInternetExplorerkillExistingIE), required: false);
            SourceExpression.Validate(browserOpenInternetExplorercleanSession, nameof(browserOpenInternetExplorercleanSession), required: false);
            SourceExpression.Validate(browserOpenInternetExplorerenableNativeEvents, nameof(browserOpenInternetExplorerenableNativeEvents), required: false);
            SourceExpression.Validate(browserOpenInternetExplorerwebDriverLogFile, nameof(browserOpenInternetExplorerwebDriverLogFile), required: false);
            SourceExpression.Validate(browserOpenInternetExplorerwebDriverLogLevel, nameof(browserOpenInternetExplorerwebDriverLogLevel), required: false);
            SourceExpression.Validate(browserOpenInternetExplorerdisableIEFirstRunCustomise, nameof(browserOpenInternetExplorerdisableIEFirstRunCustomise), required: false);
            SourceExpression.Validate(browserOpenInternetExploreradditionalArguments, nameof(browserOpenInternetExploreradditionalArguments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/OpenInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenInternetExplorer = new JObject();
                var browserOpenInternetExplorerpropCount = 0;
                if (browserOpenInternetExploreriEDriverFolder != null)
                {
                    browserOpenInternetExplorer["IEDriverFolder"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExploreriEDriverFolder);
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerkillExistingIEDriver != null)
                {
                    if (browserOpenInternetExplorerkillExistingIEDriver != null)
                    {
                        browserOpenInternetExplorer["KillExistingIEDriver"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerkillExistingIEDriver);
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
                        browserOpenInternetExplorer["KillExistingIE"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerkillExistingIE);
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
                        browserOpenInternetExplorer["CleanSession"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorercleanSession);
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
                        browserOpenInternetExplorer["EnableNativeEvents"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerenableNativeEvents);
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
                    browserOpenInternetExplorer["WebDriverLogFile"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerwebDriverLogFile);
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerwebDriverLogLevel != null)
                {
                    browserOpenInternetExplorer["WebDriverLogLevel"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerwebDriverLogLevel);
                    browserOpenInternetExplorerpropCount++;
                }

                if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                {
                    if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                    {
                        browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerdisableIEFirstRunCustomise);
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
                    browserOpenInternetExplorer["AdditionalArguments"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExploreradditionalArguments);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
                browserOpenInternetExplorer["Workflow"] = SourceExpressionConverter.ConvertToken(browserOpenInternetExplorerworkflow);
                if (browserOpenInternetExplorerpropCount > 0)
                {
                    callPayload.Body = browserOpenInternetExplorer;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseInternetExplorer([WorkflowExpression] Func<string> browserCloseInternetExplorerworkflow, [WorkflowExpression] Func<bool> browserCloseInternetExplorerunloadIEDriver = null)
        {
            SourceExpression.Validate(browserCloseInternetExplorerworkflow, nameof(browserCloseInternetExplorerworkflow), required: true);
            SourceExpression.Validate(browserCloseInternetExplorerunloadIEDriver, nameof(browserCloseInternetExplorerunloadIEDriver), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        browserCloseInternetExplorer["UnloadIEDriver"] = SourceExpressionConverter.ConvertToken(browserCloseInternetExplorerunloadIEDriver);
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
                browserCloseInternetExplorer["Workflow"] = SourceExpressionConverter.ConvertToken(browserCloseInternetExplorerworkflow);
                if (browserCloseInternetExplorerpropCount > 0)
                {
                    callPayload.Body = browserCloseInternetExplorer;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> BrowserGetChromiumEdgeDriverFolder([WorkflowExpression] Func<string> browserGetChromiumEdgeDriverFolderdirectoryPath, [WorkflowExpression] Func<string> browserGetChromiumEdgeDriverFolderworkflow, [WorkflowExpression] Func<int> browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = null, [WorkflowExpression] Func<string> browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = null)
        {
            SourceExpression.Validate(browserGetChromiumEdgeDriverFolderdirectoryPath, nameof(browserGetChromiumEdgeDriverFolderdirectoryPath), required: true);
            SourceExpression.Validate(browserGetChromiumEdgeDriverFolderworkflow, nameof(browserGetChromiumEdgeDriverFolderworkflow), required: true);
            SourceExpression.Validate(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion, nameof(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion), required: false);
            SourceExpression.Validate(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE, nameof(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromiumEdgeDriverFolder = new JObject();
                var browserGetChromiumEdgeDriverFolderpropCount = 0;
                browserGetChromiumEdgeDriverFolderpropCount++;
                browserGetChromiumEdgeDriverFolder["DirectoryPath"] = SourceExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderdirectoryPath);
                if (browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion != null)
                {
                    browserGetChromiumEdgeDriverFolder["ChromiumEdgeMajorVersion"] = SourceExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion);
                    browserGetChromiumEdgeDriverFolderpropCount++;
                }

                if (browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE != null)
                {
                    browserGetChromiumEdgeDriverFolder["ChromiumEdgeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE);
                    browserGetChromiumEdgeDriverFolderpropCount++;
                }

                browserGetChromiumEdgeDriverFolderpropCount++;
                browserGetChromiumEdgeDriverFolder["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderworkflow);
                if (browserGetChromiumEdgeDriverFolderpropCount > 0)
                {
                    callPayload.Body = browserGetChromiumEdgeDriverFolder;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> BrowserGetChromiumEdgeBrowserVersionFromFile([WorkflowExpression] Func<string> browserGetChromiumEdgeBrowserVersionFromFileworkflow, [WorkflowExpression] Func<string> browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = null)
        {
            SourceExpression.Validate(browserGetChromiumEdgeBrowserVersionFromFileworkflow, nameof(browserGetChromiumEdgeBrowserVersionFromFileworkflow), required: true);
            SourceExpression.Validate(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE, nameof(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromiumEdgeBrowserVersionFromFile = new JObject();
                var browserGetChromiumEdgeBrowserVersionFromFilepropCount = 0;
                if (browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE != null)
                {
                    browserGetChromiumEdgeBrowserVersionFromFile["ChromiumEdgeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE);
                    browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
                }

                browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
                browserGetChromiumEdgeBrowserVersionFromFile["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetChromiumEdgeBrowserVersionFromFileworkflow);
                if (browserGetChromiumEdgeBrowserVersionFromFilepropCount > 0)
                {
                    callPayload.Body = browserGetChromiumEdgeBrowserVersionFromFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> BrowserDownloadSuitableChromiumEdgeDriverFromInternet([WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, [WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, [WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = null, [WorkflowExpression] Func<string> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = null)
        {
            SourceExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder), required: true);
            SourceExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow), required: true);
            SourceExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE), required: false);
            SourceExpression.Validate(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDownloadSuitableChromiumEdgeDriverFromInternet = new JObject();
                var browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount = 0;
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE != null)
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE);
                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverDownloadParentFolder"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder);
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                {
                    if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                    {
                        browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL);
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
                browserDownloadSuitableChromiumEdgeDriverFromInternet["Workflow"] = SourceExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow);
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount > 0)
                {
                    callPayload.Body = browserDownloadSuitableChromiumEdgeDriverFromInternet;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> BrowserIsSuitableChromiumEdgeDriverAvailable([WorkflowExpression] Func<string> browserIsSuitableChromiumEdgeDriverAvailableworkflow, [WorkflowExpression] Func<string> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = null, [WorkflowExpression] Func<string> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = null)
        {
            SourceExpression.Validate(browserIsSuitableChromiumEdgeDriverAvailableworkflow, nameof(browserIsSuitableChromiumEdgeDriverAvailableworkflow), required: true);
            SourceExpression.Validate(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder, nameof(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder), required: false);
            SourceExpression.Validate(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE, nameof(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserIsSuitableChromiumEdgeDriverAvailable = new JObject();
                var browserIsSuitableChromiumEdgeDriverAvailablepropCount = 0;
                if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder != null)
                {
                    browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeDriverFolder"] = SourceExpressionConverter.ConvertToken(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder);
                    browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                }

                if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE != null)
                {
                    browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE);
                    browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                }

                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                browserIsSuitableChromiumEdgeDriverAvailable["Workflow"] = SourceExpressionConverter.ConvertToken(browserIsSuitableChromiumEdgeDriverAvailableworkflow);
                if (browserIsSuitableChromiumEdgeDriverAvailablepropCount > 0)
                {
                    callPayload.Body = browserIsSuitableChromiumEdgeDriverAvailable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromiumEdgeDriver([WorkflowExpression] Func<string> browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, [WorkflowExpression] Func<string> browserUploadNewChromiumEdgeDriverworkflow, [WorkflowExpression] Func<bool> browserUploadNewChromiumEdgeDrivercompress = null, [WorkflowExpression] Func<int> browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = null, [WorkflowExpression] Func<string> browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = null)
        {
            SourceExpression.Validate(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, nameof(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath), required: true);
            SourceExpression.Validate(browserUploadNewChromiumEdgeDriverworkflow, nameof(browserUploadNewChromiumEdgeDriverworkflow), required: true);
            SourceExpression.Validate(browserUploadNewChromiumEdgeDrivercompress, nameof(browserUploadNewChromiumEdgeDrivercompress), required: false);
            SourceExpression.Validate(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion, nameof(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion), required: false);
            SourceExpression.Validate(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder, nameof(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserUploadNewChromiumEdgeDriver = new JObject();
                var browserUploadNewChromiumEdgeDriverpropCount = 0;
                browserUploadNewChromiumEdgeDriverpropCount++;
                browserUploadNewChromiumEdgeDriver["LocalChromiumEdgeDriverFilePath"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath);
                if (browserUploadNewChromiumEdgeDrivercompress != null)
                {
                    if (browserUploadNewChromiumEdgeDrivercompress != null)
                    {
                        browserUploadNewChromiumEdgeDriver["Compress"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDrivercompress);
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
                    browserUploadNewChromiumEdgeDriver["ChromiumEdgeBrowserMajorVersion"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                if (browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder != null)
                {
                    browserUploadNewChromiumEdgeDriver["ChromiumEdgeDriverRootSaveFolder"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                browserUploadNewChromiumEdgeDriverpropCount++;
                browserUploadNewChromiumEdgeDriver["Workflow"] = SourceExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverworkflow);
                if (browserUploadNewChromiumEdgeDriverpropCount > 0)
                {
                    callPayload.Body = browserUploadNewChromiumEdgeDriver;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> BrowserOpenChromiumEdge([WorkflowExpression] Func<string> browserOpenChromiumEdgeworkflow, [WorkflowExpression] Func<string> browserOpenChromiumEdgechromiumEdgeDriverFolder = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgeuserDataDir = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgekillExistingChromiumEdgeDriver = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgeprintToDefaultPrinter = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgedefaultDownloadDirectory = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgedownloadPDFInsteadOfOpening = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgechromiumEdgeDriverLogFilename = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgechromiumEdgeBrowserEXE = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgeignoreCertificateErrors = null, [WorkflowExpression] Func<string> browserOpenChromiumEdgeadditionalArguments = null, [WorkflowExpression] Func<bool> browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            SourceExpression.Validate(browserOpenChromiumEdgeworkflow, nameof(browserOpenChromiumEdgeworkflow), required: true);
            SourceExpression.Validate(browserOpenChromiumEdgechromiumEdgeDriverFolder, nameof(browserOpenChromiumEdgechromiumEdgeDriverFolder), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgeuserDataDir, nameof(browserOpenChromiumEdgeuserDataDir), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgekillExistingChromiumEdgeDriver, nameof(browserOpenChromiumEdgekillExistingChromiumEdgeDriver), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgeprintToDefaultPrinter, nameof(browserOpenChromiumEdgeprintToDefaultPrinter), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgedefaultDownloadDirectory, nameof(browserOpenChromiumEdgedefaultDownloadDirectory), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgedownloadPDFInsteadOfOpening, nameof(browserOpenChromiumEdgedownloadPDFInsteadOfOpening), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgechromiumEdgeDriverLogFilename, nameof(browserOpenChromiumEdgechromiumEdgeDriverLogFilename), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder, nameof(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage, nameof(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgechromiumEdgeBrowserEXE, nameof(browserOpenChromiumEdgechromiumEdgeBrowserEXE), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgeignoreCertificateErrors, nameof(browserOpenChromiumEdgeignoreCertificateErrors), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgeadditionalArguments, nameof(browserOpenChromiumEdgeadditionalArguments), required: false);
            SourceExpression.Validate(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen, nameof(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/OpenChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenChromiumEdge = new JObject();
                var browserOpenChromiumEdgepropCount = 0;
                if (browserOpenChromiumEdgechromiumEdgeDriverFolder != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeDriverFolder"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgechromiumEdgeDriverFolder);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgeuserDataDir != null)
                {
                    browserOpenChromiumEdge["UserDataDir"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgeuserDataDir);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                {
                    if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                    {
                        browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgekillExistingChromiumEdgeDriver);
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
                        browserOpenChromiumEdge["PrintToDefaultPrinter"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgeprintToDefaultPrinter);
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
                    browserOpenChromiumEdge["DefaultDownloadDirectory"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgedefaultDownloadDirectory);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                {
                    if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                    {
                        browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgedownloadPDFInsteadOfOpening);
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
                    browserOpenChromiumEdge["ChromiumEdgeDriverLogFilename"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgechromiumEdgeDriverLogFilename);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgelocalChromiumEdgeDriverFolder != null)
                {
                    browserOpenChromiumEdge["LocalChromiumEdgeDriverFolder"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                {
                    if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                    {
                        browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage);
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
                    browserOpenChromiumEdge["ChromiumEdgeBrowserEXE"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgechromiumEdgeBrowserEXE);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgeignoreCertificateErrors != null)
                {
                    if (browserOpenChromiumEdgeignoreCertificateErrors != null)
                    {
                        browserOpenChromiumEdge["IgnoreCertificateErrors"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgeignoreCertificateErrors);
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
                    browserOpenChromiumEdge["AdditionalArguments"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgeadditionalArguments);
                    browserOpenChromiumEdgepropCount++;
                }

                if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                {
                    if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                    {
                        browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen);
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
                browserOpenChromiumEdge["Workflow"] = SourceExpressionConverter.ConvertToken(browserOpenChromiumEdgeworkflow);
                if (browserOpenChromiumEdgepropCount > 0)
                {
                    callPayload.Body = browserOpenChromiumEdge;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChromiumEdge([WorkflowExpression] Func<string> browserCloseChromiumEdgeworkflow, [WorkflowExpression] Func<bool> browserCloseChromiumEdgepurgeDynamicUserDataDir = null, [WorkflowExpression] Func<bool> browserCloseChromiumEdgepurgeStaticUserDataDir = null)
        {
            SourceExpression.Validate(browserCloseChromiumEdgeworkflow, nameof(browserCloseChromiumEdgeworkflow), required: true);
            SourceExpression.Validate(browserCloseChromiumEdgepurgeDynamicUserDataDir, nameof(browserCloseChromiumEdgepurgeDynamicUserDataDir), required: false);
            SourceExpression.Validate(browserCloseChromiumEdgepurgeStaticUserDataDir, nameof(browserCloseChromiumEdgepurgeStaticUserDataDir), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = SourceExpressionConverter.ConvertToken(browserCloseChromiumEdgepurgeDynamicUserDataDir);
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
                        browserCloseChromiumEdge["PurgeStaticUserDataDir"] = SourceExpressionConverter.ConvertToken(browserCloseChromiumEdgepurgeStaticUserDataDir);
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
                browserCloseChromiumEdge["Workflow"] = SourceExpressionConverter.ConvertToken(browserCloseChromiumEdgeworkflow);
                if (browserCloseChromiumEdgepropCount > 0)
                {
                    callPayload.Body = browserCloseChromiumEdge;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMaximise([WorkflowExpression] Func<string> browserMaximiseworkflow)
        {
            SourceExpression.Validate(browserMaximiseworkflow, nameof(browserMaximiseworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/MaximiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMaximise = new JObject();
                var browserMaximisepropCount = 0;
                browserMaximisepropCount++;
                browserMaximise["Workflow"] = SourceExpressionConverter.ConvertToken(browserMaximiseworkflow);
                if (browserMaximisepropCount > 0)
                {
                    callPayload.Body = browserMaximise;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMinimise([WorkflowExpression] Func<string> browserMinimiseworkflow)
        {
            SourceExpression.Validate(browserMinimiseworkflow, nameof(browserMinimiseworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/MinimiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMinimise = new JObject();
                var browserMinimisepropCount = 0;
                browserMinimisepropCount++;
                browserMinimise["Workflow"] = SourceExpressionConverter.ConvertToken(browserMinimiseworkflow);
                if (browserMinimisepropCount > 0)
                {
                    callPayload.Body = browserMinimise;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFullscreen([WorkflowExpression] Func<string> browserFullscreenworkflow)
        {
            SourceExpression.Validate(browserFullscreenworkflow, nameof(browserFullscreenworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/FullscreenBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserFullscreen = new JObject();
                var browserFullscreenpropCount = 0;
                browserFullscreenpropCount++;
                browserFullscreen["Workflow"] = SourceExpressionConverter.ConvertToken(browserFullscreenworkflow);
                if (browserFullscreenpropCount > 0)
                {
                    callPayload.Body = browserFullscreen;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserNormaliseBrowser([WorkflowExpression] Func<string> browserNormaliseBrowserworkflow, [WorkflowExpression] Func<int> browserNormaliseBrowserx = null, [WorkflowExpression] Func<int> browserNormaliseBrowsery = null, [WorkflowExpression] Func<int> browserNormaliseBrowserwidth = null, [WorkflowExpression] Func<int> browserNormaliseBrowserheight = null)
        {
            SourceExpression.Validate(browserNormaliseBrowserworkflow, nameof(browserNormaliseBrowserworkflow), required: true);
            SourceExpression.Validate(browserNormaliseBrowserx, nameof(browserNormaliseBrowserx), required: false);
            SourceExpression.Validate(browserNormaliseBrowsery, nameof(browserNormaliseBrowsery), required: false);
            SourceExpression.Validate(browserNormaliseBrowserwidth, nameof(browserNormaliseBrowserwidth), required: false);
            SourceExpression.Validate(browserNormaliseBrowserheight, nameof(browserNormaliseBrowserheight), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        browserNormaliseBrowser["X"] = SourceExpressionConverter.ConvertToken(browserNormaliseBrowserx);
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
                        browserNormaliseBrowser["Y"] = SourceExpressionConverter.ConvertToken(browserNormaliseBrowsery);
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
                        browserNormaliseBrowser["Width"] = SourceExpressionConverter.ConvertToken(browserNormaliseBrowserwidth);
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
                        browserNormaliseBrowser["Height"] = SourceExpressionConverter.ConvertToken(browserNormaliseBrowserheight);
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
                browserNormaliseBrowser["Workflow"] = SourceExpressionConverter.ConvertToken(browserNormaliseBrowserworkflow);
                if (browserNormaliseBrowserpropCount > 0)
                {
                    callPayload.Body = browserNormaliseBrowser;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowSize([WorkflowExpression] Func<int> browserSetWindowSizewidth, [WorkflowExpression] Func<int> browserSetWindowSizeheight, [WorkflowExpression] Func<string> browserSetWindowSizeworkflow)
        {
            SourceExpression.Validate(browserSetWindowSizewidth, nameof(browserSetWindowSizewidth), required: true);
            SourceExpression.Validate(browserSetWindowSizeheight, nameof(browserSetWindowSizeheight), required: true);
            SourceExpression.Validate(browserSetWindowSizeworkflow, nameof(browserSetWindowSizeworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetWindowSize = new JObject();
                var browserSetWindowSizepropCount = 0;
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Width"] = SourceExpressionConverter.ConvertToken(browserSetWindowSizewidth);
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Height"] = SourceExpressionConverter.ConvertToken(browserSetWindowSizeheight);
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Workflow"] = SourceExpressionConverter.ConvertToken(browserSetWindowSizeworkflow);
                if (browserSetWindowSizepropCount > 0)
                {
                    callPayload.Body = browserSetWindowSize;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowPosition([WorkflowExpression] Func<int> browserSetWindowPositionx, [WorkflowExpression] Func<int> browserSetWindowPositiony, [WorkflowExpression] Func<string> browserSetWindowPositionworkflow)
        {
            SourceExpression.Validate(browserSetWindowPositionx, nameof(browserSetWindowPositionx), required: true);
            SourceExpression.Validate(browserSetWindowPositiony, nameof(browserSetWindowPositiony), required: true);
            SourceExpression.Validate(browserSetWindowPositionworkflow, nameof(browserSetWindowPositionworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetWindowPosition = new JObject();
                var browserSetWindowPositionpropCount = 0;
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["X"] = SourceExpressionConverter.ConvertToken(browserSetWindowPositionx);
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["Y"] = SourceExpressionConverter.ConvertToken(browserSetWindowPositiony);
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["Workflow"] = SourceExpressionConverter.ConvertToken(browserSetWindowPositionworkflow);
                if (browserSetWindowPositionpropCount > 0)
                {
                    callPayload.Body = browserSetWindowPosition;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTimeouts([WorkflowExpression] Func<string> browserSetTimeoutsworkflow, [WorkflowExpression] Func<double> browserSetTimeoutselementWaitTimeoutSeconds = null, [WorkflowExpression] Func<double> browserSetTimeoutspageLoadTimeoutSeconds = null)
        {
            SourceExpression.Validate(browserSetTimeoutsworkflow, nameof(browserSetTimeoutsworkflow), required: true);
            SourceExpression.Validate(browserSetTimeoutselementWaitTimeoutSeconds, nameof(browserSetTimeoutselementWaitTimeoutSeconds), required: false);
            SourceExpression.Validate(browserSetTimeoutspageLoadTimeoutSeconds, nameof(browserSetTimeoutspageLoadTimeoutSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SetTimeouts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetTimeouts = new JObject();
                var browserSetTimeoutspropCount = 0;
                if (browserSetTimeoutselementWaitTimeoutSeconds != null)
                {
                    browserSetTimeouts["ElementWaitTimeoutSeconds"] = SourceExpressionConverter.ConvertToken(browserSetTimeoutselementWaitTimeoutSeconds);
                    browserSetTimeoutspropCount++;
                }

                if (browserSetTimeoutspageLoadTimeoutSeconds != null)
                {
                    browserSetTimeouts["PageLoadTimeoutSeconds"] = SourceExpressionConverter.ConvertToken(browserSetTimeoutspageLoadTimeoutSeconds);
                    browserSetTimeoutspropCount++;
                }

                browserSetTimeoutspropCount++;
                browserSetTimeouts["Workflow"] = SourceExpressionConverter.ConvertToken(browserSetTimeoutsworkflow);
                if (browserSetTimeoutspropCount > 0)
                {
                    callPayload.Body = browserSetTimeouts;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> BrowserNavigateToURL([WorkflowExpression] Func<string> browserNavigateToURLuRL, [WorkflowExpression] Func<string> browserNavigateToURLworkflow)
        {
            SourceExpression.Validate(browserNavigateToURLuRL, nameof(browserNavigateToURLuRL), required: true);
            SourceExpression.Validate(browserNavigateToURLworkflow, nameof(browserNavigateToURLworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/NavigateToURL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserNavigateToURL = new JObject();
                var browserNavigateToURLpropCount = 0;
                browserNavigateToURLpropCount++;
                browserNavigateToURL["URL"] = SourceExpressionConverter.ConvertToken(browserNavigateToURLuRL);
                browserNavigateToURLpropCount++;
                browserNavigateToURL["Workflow"] = SourceExpressionConverter.ConvertToken(browserNavigateToURLworkflow);
                if (browserNavigateToURLpropCount > 0)
                {
                    callPayload.Body = browserNavigateToURL;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserNavigateToURLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserRefreshPage([WorkflowExpression] Func<string> browserRefreshPageworkflow)
        {
            SourceExpression.Validate(browserRefreshPageworkflow, nameof(browserRefreshPageworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/RefreshPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserRefreshPage = new JObject();
                var browserRefreshPagepropCount = 0;
                browserRefreshPagepropCount++;
                browserRefreshPage["Workflow"] = SourceExpressionConverter.ConvertToken(browserRefreshPageworkflow);
                if (browserRefreshPagepropCount > 0)
                {
                    callPayload.Body = browserRefreshPage;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetAllElementHandles([WorkflowExpression] Func<string> browserResetAllElementHandlesworkflow)
        {
            SourceExpression.Validate(browserResetAllElementHandlesworkflow, nameof(browserResetAllElementHandlesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserResetAllElementHandles = new JObject();
                var browserResetAllElementHandlespropCount = 0;
                browserResetAllElementHandlespropCount++;
                browserResetAllElementHandles["Workflow"] = SourceExpressionConverter.ConvertToken(browserResetAllElementHandlesworkflow);
                if (browserResetAllElementHandlespropCount > 0)
                {
                    callPayload.Body = browserResetAllElementHandles;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> BrowserDoesElementExist([WorkflowExpression] Func<string> browserDoesElementExistworkflow, [WorkflowExpression] Func<double> browserDoesElementExistparentElementHandle = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementHandle = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementName = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementID = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementTagName = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementXPath = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementClassName = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementIndex = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDoesElementExistsearchElementType = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDoesElementExistsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserDoesElementExistworkflow, nameof(browserDoesElementExistworkflow), required: true);
            SourceExpression.Validate(browserDoesElementExistparentElementHandle, nameof(browserDoesElementExistparentElementHandle), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementHandle, nameof(browserDoesElementExistsearchElementHandle), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementName, nameof(browserDoesElementExistsearchElementName), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementID, nameof(browserDoesElementExistsearchElementID), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementTagName, nameof(browserDoesElementExistsearchElementTagName), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementXPath, nameof(browserDoesElementExistsearchElementXPath), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementClassName, nameof(browserDoesElementExistsearchElementClassName), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementCSSSelector, nameof(browserDoesElementExistsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementIndex, nameof(browserDoesElementExistsearchElementIndex), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementMatchValue, nameof(browserDoesElementExistsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementMatchText, nameof(browserDoesElementExistsearchElementMatchText), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementType, nameof(browserDoesElementExistsearchElementType), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementMinimumWidth, nameof(browserDoesElementExistsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementMinimumHeight, nameof(browserDoesElementExistsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementBoundingBoxLeft, nameof(browserDoesElementExistsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementBoundingBoxRight, nameof(browserDoesElementExistsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementBoundingBoxTop, nameof(browserDoesElementExistsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserDoesElementExistsearchElementBoundingBoxBottom, nameof(browserDoesElementExistsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDoesElementExist = new JObject();
                var browserDoesElementExistpropCount = 0;
                if (browserDoesElementExistparentElementHandle != null)
                {
                    browserDoesElementExist["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistparentElementHandle);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementHandle != null)
                {
                    browserDoesElementExist["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementHandle);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementName != null)
                {
                    browserDoesElementExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementName);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementID != null)
                {
                    browserDoesElementExist["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementID);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementTagName != null)
                {
                    browserDoesElementExist["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementTagName);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementXPath != null)
                {
                    browserDoesElementExist["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementXPath);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementClassName != null)
                {
                    browserDoesElementExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementClassName);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementCSSSelector != null)
                {
                    browserDoesElementExist["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementCSSSelector);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementIndex != null)
                {
                    if (browserDoesElementExistsearchElementIndex != null)
                    {
                        browserDoesElementExist["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementIndex);
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
                    browserDoesElementExist["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMatchValue);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementMatchText != null)
                {
                    browserDoesElementExist["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMatchText);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementType != null)
                {
                    browserDoesElementExist["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementType);
                    browserDoesElementExistpropCount++;
                }

                if (browserDoesElementExistsearchElementMinimumWidth != null)
                {
                    if (browserDoesElementExistsearchElementMinimumWidth != null)
                    {
                        browserDoesElementExist["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMinimumWidth);
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
                        browserDoesElementExist["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMinimumHeight);
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
                        browserDoesElementExist["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxLeft);
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
                        browserDoesElementExist["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxRight);
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
                        browserDoesElementExist["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxTop);
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
                        browserDoesElementExist["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxBottom);
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
                        browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserDoesElementExist["Workflow"] = SourceExpressionConverter.ConvertToken(browserDoesElementExistworkflow);
                if (browserDoesElementExistpropCount > 0)
                {
                    callPayload.Body = browserDoesElementExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserDoesElementExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> BrowserCreateHandleToElement([WorkflowExpression] Func<string> browserCreateHandleToElementworkflow, [WorkflowExpression] Func<double> browserCreateHandleToElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementName = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementID = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCreateHandleToElementsearchElementType = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCreateHandleToElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserCreateHandleToElementworkflow, nameof(browserCreateHandleToElementworkflow), required: true);
            SourceExpression.Validate(browserCreateHandleToElementparentElementHandle, nameof(browserCreateHandleToElementparentElementHandle), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementHandle, nameof(browserCreateHandleToElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementName, nameof(browserCreateHandleToElementsearchElementName), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementID, nameof(browserCreateHandleToElementsearchElementID), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementTagName, nameof(browserCreateHandleToElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementXPath, nameof(browserCreateHandleToElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementClassName, nameof(browserCreateHandleToElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementCSSSelector, nameof(browserCreateHandleToElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementIndex, nameof(browserCreateHandleToElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementMatchValue, nameof(browserCreateHandleToElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementMatchText, nameof(browserCreateHandleToElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementType, nameof(browserCreateHandleToElementsearchElementType), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementMinimumWidth, nameof(browserCreateHandleToElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementMinimumHeight, nameof(browserCreateHandleToElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxLeft, nameof(browserCreateHandleToElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxRight, nameof(browserCreateHandleToElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxTop, nameof(browserCreateHandleToElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserCreateHandleToElementsearchElementBoundingBoxBottom, nameof(browserCreateHandleToElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/CreateHandleToElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCreateHandleToElement = new JObject();
                var browserCreateHandleToElementpropCount = 0;
                if (browserCreateHandleToElementparentElementHandle != null)
                {
                    browserCreateHandleToElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementparentElementHandle);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementHandle != null)
                {
                    browserCreateHandleToElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementHandle);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementName != null)
                {
                    browserCreateHandleToElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementName);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementID != null)
                {
                    browserCreateHandleToElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementID);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementTagName != null)
                {
                    browserCreateHandleToElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementTagName);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementXPath != null)
                {
                    browserCreateHandleToElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementXPath);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementClassName != null)
                {
                    browserCreateHandleToElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementClassName);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementCSSSelector != null)
                {
                    browserCreateHandleToElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementCSSSelector);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementIndex != null)
                {
                    if (browserCreateHandleToElementsearchElementIndex != null)
                    {
                        browserCreateHandleToElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementIndex);
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
                    browserCreateHandleToElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMatchValue);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementMatchText != null)
                {
                    browserCreateHandleToElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMatchText);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementType != null)
                {
                    browserCreateHandleToElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementType);
                    browserCreateHandleToElementpropCount++;
                }

                if (browserCreateHandleToElementsearchElementMinimumWidth != null)
                {
                    if (browserCreateHandleToElementsearchElementMinimumWidth != null)
                    {
                        browserCreateHandleToElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMinimumWidth);
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
                        browserCreateHandleToElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMinimumHeight);
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
                        browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxLeft);
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
                        browserCreateHandleToElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxRight);
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
                        browserCreateHandleToElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxTop);
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
                        browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxBottom);
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
                        browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserCreateHandleToElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToElementworkflow);
                if (browserCreateHandleToElementpropCount > 0)
                {
                    callPayload.Body = browserCreateHandleToElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> BrowserCreateHandleToParentElement([WorkflowExpression] Func<string> browserCreateHandleToParentElementworkflow, [WorkflowExpression] Func<double> browserCreateHandleToParentElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementName = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementID = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCreateHandleToParentElementsearchElementType = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCreateHandleToParentElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserCreateHandleToParentElementworkflow, nameof(browserCreateHandleToParentElementworkflow), required: true);
            SourceExpression.Validate(browserCreateHandleToParentElementparentElementHandle, nameof(browserCreateHandleToParentElementparentElementHandle), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementHandle, nameof(browserCreateHandleToParentElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementName, nameof(browserCreateHandleToParentElementsearchElementName), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementID, nameof(browserCreateHandleToParentElementsearchElementID), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementTagName, nameof(browserCreateHandleToParentElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementXPath, nameof(browserCreateHandleToParentElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementClassName, nameof(browserCreateHandleToParentElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementCSSSelector, nameof(browserCreateHandleToParentElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementIndex, nameof(browserCreateHandleToParentElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementMatchValue, nameof(browserCreateHandleToParentElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementMatchText, nameof(browserCreateHandleToParentElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementType, nameof(browserCreateHandleToParentElementsearchElementType), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementMinimumWidth, nameof(browserCreateHandleToParentElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementMinimumHeight, nameof(browserCreateHandleToParentElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxLeft, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxRight, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxTop, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementsearchElementBoundingBoxBottom, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCreateHandleToParentElement = new JObject();
                var browserCreateHandleToParentElementpropCount = 0;
                if (browserCreateHandleToParentElementparentElementHandle != null)
                {
                    browserCreateHandleToParentElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementparentElementHandle);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementHandle != null)
                {
                    browserCreateHandleToParentElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementHandle);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementName != null)
                {
                    browserCreateHandleToParentElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementID != null)
                {
                    browserCreateHandleToParentElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementID);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementTagName != null)
                {
                    browserCreateHandleToParentElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementTagName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementXPath != null)
                {
                    browserCreateHandleToParentElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementXPath);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementClassName != null)
                {
                    browserCreateHandleToParentElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementClassName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementCSSSelector != null)
                {
                    browserCreateHandleToParentElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementCSSSelector);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementIndex != null)
                {
                    if (browserCreateHandleToParentElementsearchElementIndex != null)
                    {
                        browserCreateHandleToParentElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementIndex);
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
                    browserCreateHandleToParentElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMatchValue);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementMatchText != null)
                {
                    browserCreateHandleToParentElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMatchText);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementType != null)
                {
                    browserCreateHandleToParentElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementType);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                {
                    if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                    {
                        browserCreateHandleToParentElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMinimumWidth);
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
                        browserCreateHandleToParentElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMinimumHeight);
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
                        browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxLeft);
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
                        browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxRight);
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
                        browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxTop);
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
                        browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxBottom);
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
                        browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserCreateHandleToParentElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserCreateHandleToParentElementworkflow);
                if (browserCreateHandleToParentElementpropCount > 0)
                {
                    callPayload.Body = browserCreateHandleToParentElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> BrowserGetElementProperties([WorkflowExpression] Func<string> browserGetElementPropertiesworkflow, [WorkflowExpression] Func<double> browserGetElementPropertiesparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetElementPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetElementPropertiesreturnElementHandle = null)
        {
            SourceExpression.Validate(browserGetElementPropertiesworkflow, nameof(browserGetElementPropertiesworkflow), required: true);
            SourceExpression.Validate(browserGetElementPropertiesparentElementHandle, nameof(browserGetElementPropertiesparentElementHandle), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementHandle, nameof(browserGetElementPropertiessearchElementHandle), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementName, nameof(browserGetElementPropertiessearchElementName), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementID, nameof(browserGetElementPropertiessearchElementID), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementTagName, nameof(browserGetElementPropertiessearchElementTagName), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementXPath, nameof(browserGetElementPropertiessearchElementXPath), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementClassName, nameof(browserGetElementPropertiessearchElementClassName), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementCSSSelector, nameof(browserGetElementPropertiessearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementIndex, nameof(browserGetElementPropertiessearchElementIndex), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementMatchValue, nameof(browserGetElementPropertiessearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementMatchText, nameof(browserGetElementPropertiessearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementType, nameof(browserGetElementPropertiessearchElementType), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementMinimumWidth, nameof(browserGetElementPropertiessearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementMinimumHeight, nameof(browserGetElementPropertiessearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementPropertiessearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxRight, nameof(browserGetElementPropertiessearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxTop, nameof(browserGetElementPropertiessearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetElementPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementPropertiessearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGetElementPropertiesgetHTMLCode, nameof(browserGetElementPropertiesgetHTMLCode), required: false);
            SourceExpression.Validate(browserGetElementPropertiesreturnElementHandle, nameof(browserGetElementPropertiesreturnElementHandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementProperties = new JObject();
                var browserGetElementPropertiespropCount = 0;
                if (browserGetElementPropertiesparentElementHandle != null)
                {
                    browserGetElementProperties["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiesparentElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementHandle != null)
                {
                    browserGetElementProperties["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementName != null)
                {
                    browserGetElementProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementName);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementID != null)
                {
                    browserGetElementProperties["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementID);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementTagName != null)
                {
                    browserGetElementProperties["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementTagName);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementXPath != null)
                {
                    browserGetElementProperties["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementXPath);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementClassName != null)
                {
                    browserGetElementProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementClassName);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementProperties["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementCSSSelector);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementIndex != null)
                {
                    if (browserGetElementPropertiessearchElementIndex != null)
                    {
                        browserGetElementProperties["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementIndex);
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
                    browserGetElementProperties["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMatchValue);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementMatchText != null)
                {
                    browserGetElementProperties["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMatchText);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementType != null)
                {
                    browserGetElementProperties["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementType);
                    browserGetElementPropertiespropCount++;
                }

                if (browserGetElementPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetElementPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementProperties["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMinimumWidth);
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
                        browserGetElementProperties["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMinimumHeight);
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
                        browserGetElementProperties["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxLeft);
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
                        browserGetElementProperties["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxRight);
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
                        browserGetElementProperties["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxTop);
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
                        browserGetElementProperties["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxBottom);
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
                        browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserGetElementProperties["GetHTMLCode"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiesgetHTMLCode);
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
                        browserGetElementProperties["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiesreturnElementHandle);
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
                browserGetElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetElementPropertiesworkflow);
                if (browserGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> BrowserGetMultipleElementProperties([WorkflowExpression] Func<string> browserGetMultipleElementPropertiesworkflow, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiesparentElementHandle = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetMultipleElementPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiescreateHandle = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnValue = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnText = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesmaxValueLength = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesmaxTextLength = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnIsDisplayed = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnCoordinates = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnDimensions = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnChildElementCount = null, [WorkflowExpression] Func<bool> browserGetMultipleElementPropertiesreturnParentTag = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> browserGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            SourceExpression.Validate(browserGetMultipleElementPropertiesworkflow, nameof(browserGetMultipleElementPropertiesworkflow), required: true);
            SourceExpression.Validate(browserGetMultipleElementPropertiesparentElementHandle, nameof(browserGetMultipleElementPropertiesparentElementHandle), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementName, nameof(browserGetMultipleElementPropertiessearchElementName), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementID, nameof(browserGetMultipleElementPropertiessearchElementID), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementTagName, nameof(browserGetMultipleElementPropertiessearchElementTagName), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementXPath, nameof(browserGetMultipleElementPropertiessearchElementXPath), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementClassName, nameof(browserGetMultipleElementPropertiessearchElementClassName), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementCSSSelector, nameof(browserGetMultipleElementPropertiessearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementMatchValue, nameof(browserGetMultipleElementPropertiessearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementMatchText, nameof(browserGetMultipleElementPropertiessearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementType, nameof(browserGetMultipleElementPropertiessearchElementType), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementMinimumWidth, nameof(browserGetMultipleElementPropertiessearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementMinimumHeight, nameof(browserGetMultipleElementPropertiessearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxRight, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxTop, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesgetHTMLCode, nameof(browserGetMultipleElementPropertiesgetHTMLCode), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiescreateHandle, nameof(browserGetMultipleElementPropertiescreateHandle), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnValue, nameof(browserGetMultipleElementPropertiesreturnValue), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnText, nameof(browserGetMultipleElementPropertiesreturnText), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesmaxValueLength, nameof(browserGetMultipleElementPropertiesmaxValueLength), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesmaxTextLength, nameof(browserGetMultipleElementPropertiesmaxTextLength), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnIsDisplayed, nameof(browserGetMultipleElementPropertiesreturnIsDisplayed), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnCoordinates, nameof(browserGetMultipleElementPropertiesreturnCoordinates), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnDimensions, nameof(browserGetMultipleElementPropertiesreturnDimensions), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnChildElementCount, nameof(browserGetMultipleElementPropertiesreturnChildElementCount), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesreturnParentTag, nameof(browserGetMultipleElementPropertiesreturnParentTag), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesfirstItemToReturn, nameof(browserGetMultipleElementPropertiesfirstItemToReturn), required: false);
            SourceExpression.Validate(browserGetMultipleElementPropertiesmaxItemsToReturn, nameof(browserGetMultipleElementPropertiesmaxItemsToReturn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetMultipleElementProperties = new JObject();
                var browserGetMultipleElementPropertiespropCount = 0;
                if (browserGetMultipleElementPropertiesparentElementHandle != null)
                {
                    browserGetMultipleElementProperties["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesparentElementHandle);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementName != null)
                {
                    browserGetMultipleElementProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementID != null)
                {
                    browserGetMultipleElementProperties["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementID);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementTagName != null)
                {
                    browserGetMultipleElementProperties["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementTagName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementXPath != null)
                {
                    browserGetMultipleElementProperties["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementXPath);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementClassName != null)
                {
                    browserGetMultipleElementProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementClassName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementCSSSelector != null)
                {
                    browserGetMultipleElementProperties["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementCSSSelector);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMatchValue != null)
                {
                    browserGetMultipleElementProperties["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMatchValue);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMatchText != null)
                {
                    browserGetMultipleElementProperties["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMatchText);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementType != null)
                {
                    browserGetMultipleElementProperties["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementType);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetMultipleElementProperties["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMinimumWidth);
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
                        browserGetMultipleElementProperties["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMinimumHeight);
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
                        browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft);
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
                        browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxRight);
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
                        browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxTop);
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
                        browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom);
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
                        browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserGetMultipleElementProperties["GetHTMLCode"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesgetHTMLCode);
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
                        browserGetMultipleElementProperties["CreateHandle"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiescreateHandle);
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
                        browserGetMultipleElementProperties["ReturnValue"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnValue);
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
                        browserGetMultipleElementProperties["ReturnText"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnText);
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
                        browserGetMultipleElementProperties["MaxValueLength"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesmaxValueLength);
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
                        browserGetMultipleElementProperties["MaxTextLength"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesmaxTextLength);
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
                        browserGetMultipleElementProperties["ReturnIsDisplayed"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnIsDisplayed);
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
                        browserGetMultipleElementProperties["ReturnCoordinates"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnCoordinates);
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
                        browserGetMultipleElementProperties["ReturnDimensions"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnDimensions);
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
                        browserGetMultipleElementProperties["ReturnChildElementCount"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnChildElementCount);
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
                        browserGetMultipleElementProperties["ReturnParentTag"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnParentTag);
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
                        browserGetMultipleElementProperties["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesfirstItemToReturn);
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
                        browserGetMultipleElementProperties["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesmaxItemsToReturn);
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
                browserGetMultipleElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesworkflow);
                if (browserGetMultipleElementPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetMultipleElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> BrowserGetElementParentProperties([WorkflowExpression] Func<string> browserGetElementParentPropertiesworkflow, [WorkflowExpression] Func<double> browserGetElementParentPropertiesparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementParentPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementParentPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetElementParentPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetElementParentPropertiescreateHandle = null)
        {
            SourceExpression.Validate(browserGetElementParentPropertiesworkflow, nameof(browserGetElementParentPropertiesworkflow), required: true);
            SourceExpression.Validate(browserGetElementParentPropertiesparentElementHandle, nameof(browserGetElementParentPropertiesparentElementHandle), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementHandle, nameof(browserGetElementParentPropertiessearchElementHandle), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementName, nameof(browserGetElementParentPropertiessearchElementName), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementID, nameof(browserGetElementParentPropertiessearchElementID), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementTagName, nameof(browserGetElementParentPropertiessearchElementTagName), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementXPath, nameof(browserGetElementParentPropertiessearchElementXPath), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementClassName, nameof(browserGetElementParentPropertiessearchElementClassName), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementCSSSelector, nameof(browserGetElementParentPropertiessearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementIndex, nameof(browserGetElementParentPropertiessearchElementIndex), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementMatchValue, nameof(browserGetElementParentPropertiessearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementMatchText, nameof(browserGetElementParentPropertiessearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementType, nameof(browserGetElementParentPropertiessearchElementType), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementMinimumWidth, nameof(browserGetElementParentPropertiessearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementMinimumHeight, nameof(browserGetElementParentPropertiessearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementParentPropertiessearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxRight, nameof(browserGetElementParentPropertiessearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxTop, nameof(browserGetElementParentPropertiessearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementParentPropertiessearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiesgetHTMLCode, nameof(browserGetElementParentPropertiesgetHTMLCode), required: false);
            SourceExpression.Validate(browserGetElementParentPropertiescreateHandle, nameof(browserGetElementParentPropertiescreateHandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetElementParentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementParentProperties = new JObject();
                var browserGetElementParentPropertiespropCount = 0;
                if (browserGetElementParentPropertiesparentElementHandle != null)
                {
                    browserGetElementParentProperties["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiesparentElementHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementHandle != null)
                {
                    browserGetElementParentProperties["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementName != null)
                {
                    browserGetElementParentProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementID != null)
                {
                    browserGetElementParentProperties["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementID);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementTagName != null)
                {
                    browserGetElementParentProperties["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementTagName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementXPath != null)
                {
                    browserGetElementParentProperties["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementXPath);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementClassName != null)
                {
                    browserGetElementParentProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementClassName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementParentProperties["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementCSSSelector);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementIndex != null)
                {
                    if (browserGetElementParentPropertiessearchElementIndex != null)
                    {
                        browserGetElementParentProperties["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementIndex);
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
                    browserGetElementParentProperties["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMatchValue);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementMatchText != null)
                {
                    browserGetElementParentProperties["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMatchText);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementType != null)
                {
                    browserGetElementParentProperties["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementType);
                    browserGetElementParentPropertiespropCount++;
                }

                if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementParentProperties["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMinimumWidth);
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
                        browserGetElementParentProperties["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMinimumHeight);
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
                        browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxLeft);
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
                        browserGetElementParentProperties["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxRight);
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
                        browserGetElementParentProperties["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxTop);
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
                        browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxBottom);
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
                        browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserGetElementParentProperties["GetHTMLCode"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiesgetHTMLCode);
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
                        browserGetElementParentProperties["CreateHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiescreateHandle);
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
                browserGetElementParentProperties["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetElementParentPropertiesworkflow);
                if (browserGetElementParentPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementParentProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> BrowserGetElementChildrenProperties([WorkflowExpression] Func<string> browserGetElementChildrenPropertiesworkflow, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiesparentElementHandle = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementChildrenPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiescreateHandle = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiessearchSubTree = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnValue = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnText = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesmaxValueLength = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesmaxTextLength = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnIsDisplayed = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnCoordinates = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnDimensions = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnChildElementCount = null, [WorkflowExpression] Func<bool> browserGetElementChildrenPropertiesreturnParentTag = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> browserGetElementChildrenPropertiesmaxItemsToReturn = null)
        {
            SourceExpression.Validate(browserGetElementChildrenPropertiesworkflow, nameof(browserGetElementChildrenPropertiesworkflow), required: true);
            SourceExpression.Validate(browserGetElementChildrenPropertiesparentElementHandle, nameof(browserGetElementChildrenPropertiesparentElementHandle), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementName, nameof(browserGetElementChildrenPropertiessearchElementName), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementID, nameof(browserGetElementChildrenPropertiessearchElementID), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementTagName, nameof(browserGetElementChildrenPropertiessearchElementTagName), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementXPath, nameof(browserGetElementChildrenPropertiessearchElementXPath), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementClassName, nameof(browserGetElementChildrenPropertiessearchElementClassName), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementCSSSelector, nameof(browserGetElementChildrenPropertiessearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementMatchValue, nameof(browserGetElementChildrenPropertiessearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementMatchText, nameof(browserGetElementChildrenPropertiessearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementType, nameof(browserGetElementChildrenPropertiessearchElementType), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementMinimumWidth, nameof(browserGetElementChildrenPropertiessearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementMinimumHeight, nameof(browserGetElementChildrenPropertiessearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxRight, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxTop, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesgetHTMLCode, nameof(browserGetElementChildrenPropertiesgetHTMLCode), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiescreateHandle, nameof(browserGetElementChildrenPropertiescreateHandle), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiessearchSubTree, nameof(browserGetElementChildrenPropertiessearchSubTree), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnValue, nameof(browserGetElementChildrenPropertiesreturnValue), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnText, nameof(browserGetElementChildrenPropertiesreturnText), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesmaxValueLength, nameof(browserGetElementChildrenPropertiesmaxValueLength), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesmaxTextLength, nameof(browserGetElementChildrenPropertiesmaxTextLength), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnIsDisplayed, nameof(browserGetElementChildrenPropertiesreturnIsDisplayed), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnCoordinates, nameof(browserGetElementChildrenPropertiesreturnCoordinates), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnDimensions, nameof(browserGetElementChildrenPropertiesreturnDimensions), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnChildElementCount, nameof(browserGetElementChildrenPropertiesreturnChildElementCount), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesreturnParentTag, nameof(browserGetElementChildrenPropertiesreturnParentTag), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesfirstItemToReturn, nameof(browserGetElementChildrenPropertiesfirstItemToReturn), required: false);
            SourceExpression.Validate(browserGetElementChildrenPropertiesmaxItemsToReturn, nameof(browserGetElementChildrenPropertiesmaxItemsToReturn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementChildrenProperties = new JObject();
                var browserGetElementChildrenPropertiespropCount = 0;
                if (browserGetElementChildrenPropertiesparentElementHandle != null)
                {
                    browserGetElementChildrenProperties["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesparentElementHandle);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementName != null)
                {
                    browserGetElementChildrenProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementID != null)
                {
                    browserGetElementChildrenProperties["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementID);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementTagName != null)
                {
                    browserGetElementChildrenProperties["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementTagName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementXPath != null)
                {
                    browserGetElementChildrenProperties["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementXPath);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementClassName != null)
                {
                    browserGetElementChildrenProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementClassName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementChildrenProperties["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementCSSSelector);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMatchValue != null)
                {
                    browserGetElementChildrenProperties["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMatchValue);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMatchText != null)
                {
                    browserGetElementChildrenProperties["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMatchText);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementType != null)
                {
                    browserGetElementChildrenProperties["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementType);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementChildrenProperties["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMinimumWidth);
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
                        browserGetElementChildrenProperties["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMinimumHeight);
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
                        browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft);
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
                        browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxRight);
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
                        browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxTop);
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
                        browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom);
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
                        browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserGetElementChildrenProperties["GetHTMLCode"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesgetHTMLCode);
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
                        browserGetElementChildrenProperties["CreateHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiescreateHandle);
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
                        browserGetElementChildrenProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchSubTree);
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
                        browserGetElementChildrenProperties["ReturnValue"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnValue);
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
                        browserGetElementChildrenProperties["ReturnText"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnText);
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
                        browserGetElementChildrenProperties["MaxValueLength"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesmaxValueLength);
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
                        browserGetElementChildrenProperties["MaxTextLength"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesmaxTextLength);
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
                        browserGetElementChildrenProperties["ReturnIsDisplayed"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnIsDisplayed);
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
                        browserGetElementChildrenProperties["ReturnCoordinates"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnCoordinates);
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
                        browserGetElementChildrenProperties["ReturnDimensions"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnDimensions);
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
                        browserGetElementChildrenProperties["ReturnChildElementCount"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnChildElementCount);
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
                        browserGetElementChildrenProperties["ReturnParentTag"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnParentTag);
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
                        browserGetElementChildrenProperties["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesfirstItemToReturn);
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
                        browserGetElementChildrenProperties["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesmaxItemsToReturn);
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
                browserGetElementChildrenProperties["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesworkflow);
                if (browserGetElementChildrenPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementChildrenProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> BrowserInputTextIntoElement([WorkflowExpression] Func<string> browserInputTextIntoElementworkflow, [WorkflowExpression] Func<double> browserInputTextIntoElementparentElementHandle = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementName = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementID = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserInputTextIntoElementsearchElementType = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserInputTextIntoElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserInputTextIntoElementtextToInput = null, [WorkflowExpression] Func<bool> browserInputTextIntoElementresetExistingValue = null, [WorkflowExpression] Func<int> browserInputTextIntoElementinsertPosition = null)
        {
            SourceExpression.Validate(browserInputTextIntoElementworkflow, nameof(browserInputTextIntoElementworkflow), required: true);
            SourceExpression.Validate(browserInputTextIntoElementparentElementHandle, nameof(browserInputTextIntoElementparentElementHandle), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementHandle, nameof(browserInputTextIntoElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementName, nameof(browserInputTextIntoElementsearchElementName), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementID, nameof(browserInputTextIntoElementsearchElementID), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementTagName, nameof(browserInputTextIntoElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementXPath, nameof(browserInputTextIntoElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementClassName, nameof(browserInputTextIntoElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementCSSSelector, nameof(browserInputTextIntoElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementIndex, nameof(browserInputTextIntoElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementMatchValue, nameof(browserInputTextIntoElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementMatchText, nameof(browserInputTextIntoElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementType, nameof(browserInputTextIntoElementsearchElementType), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementMinimumWidth, nameof(browserInputTextIntoElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementMinimumHeight, nameof(browserInputTextIntoElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxLeft, nameof(browserInputTextIntoElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxRight, nameof(browserInputTextIntoElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxTop, nameof(browserInputTextIntoElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserInputTextIntoElementsearchElementBoundingBoxBottom, nameof(browserInputTextIntoElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserInputTextIntoElementtextToInput, nameof(browserInputTextIntoElementtextToInput), required: false);
            SourceExpression.Validate(browserInputTextIntoElementresetExistingValue, nameof(browserInputTextIntoElementresetExistingValue), required: false);
            SourceExpression.Validate(browserInputTextIntoElementinsertPosition, nameof(browserInputTextIntoElementinsertPosition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputTextIntoElement = new JObject();
                var browserInputTextIntoElementpropCount = 0;
                if (browserInputTextIntoElementparentElementHandle != null)
                {
                    browserInputTextIntoElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementparentElementHandle);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementHandle != null)
                {
                    browserInputTextIntoElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementHandle);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementName != null)
                {
                    browserInputTextIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementName);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementID != null)
                {
                    browserInputTextIntoElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementID);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementTagName != null)
                {
                    browserInputTextIntoElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementTagName);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementXPath != null)
                {
                    browserInputTextIntoElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementXPath);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementClassName != null)
                {
                    browserInputTextIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementClassName);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementCSSSelector != null)
                {
                    browserInputTextIntoElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementCSSSelector);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementIndex != null)
                {
                    if (browserInputTextIntoElementsearchElementIndex != null)
                    {
                        browserInputTextIntoElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementIndex);
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
                    browserInputTextIntoElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMatchValue);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementMatchText != null)
                {
                    browserInputTextIntoElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMatchText);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementType != null)
                {
                    browserInputTextIntoElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementType);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementsearchElementMinimumWidth != null)
                {
                    if (browserInputTextIntoElementsearchElementMinimumWidth != null)
                    {
                        browserInputTextIntoElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMinimumWidth);
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
                        browserInputTextIntoElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMinimumHeight);
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
                        browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxLeft);
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
                        browserInputTextIntoElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxRight);
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
                        browserInputTextIntoElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxTop);
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
                        browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxBottom);
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
                        browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                    browserInputTextIntoElement["TextToInput"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementtextToInput);
                    browserInputTextIntoElementpropCount++;
                }

                if (browserInputTextIntoElementresetExistingValue != null)
                {
                    if (browserInputTextIntoElementresetExistingValue != null)
                    {
                        browserInputTextIntoElement["ResetExistingValue"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementresetExistingValue);
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
                        browserInputTextIntoElement["InsertPosition"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementinsertPosition);
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
                browserInputTextIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoElementworkflow);
                if (browserInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = browserInputTextIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputTextIntoMultipleElements([WorkflowExpression] Func<string> browserInputTextIntoMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> browserInputTextIntoMultipleElementsworkflow)
        {
            SourceExpression.Validate(browserInputTextIntoMultipleElementsinputElementsJSON, nameof(browserInputTextIntoMultipleElementsinputElementsJSON), required: true);
            SourceExpression.Validate(browserInputTextIntoMultipleElementsworkflow, nameof(browserInputTextIntoMultipleElementsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputTextIntoMultipleElements = new JObject();
                var browserInputTextIntoMultipleElementspropCount = 0;
                browserInputTextIntoMultipleElementspropCount++;
                browserInputTextIntoMultipleElements["InputElementsJSON"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoMultipleElementsinputElementsJSON);
                browserInputTextIntoMultipleElementspropCount++;
                browserInputTextIntoMultipleElements["Workflow"] = SourceExpressionConverter.ConvertToken(browserInputTextIntoMultipleElementsworkflow);
                if (browserInputTextIntoMultipleElementspropCount > 0)
                {
                    callPayload.Body = browserInputTextIntoMultipleElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressCtrlKeyOnElement([WorkflowExpression] Func<string> browserPressCtrlKeyOnElementcontrolKey, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementworkflow, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserPressCtrlKeyOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserPressCtrlKeyOnElementcontrolKey, nameof(browserPressCtrlKeyOnElementcontrolKey), required: true);
            SourceExpression.Validate(browserPressCtrlKeyOnElementworkflow, nameof(browserPressCtrlKeyOnElementworkflow), required: true);
            SourceExpression.Validate(browserPressCtrlKeyOnElementparentElementHandle, nameof(browserPressCtrlKeyOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementHandle, nameof(browserPressCtrlKeyOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementName, nameof(browserPressCtrlKeyOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementID, nameof(browserPressCtrlKeyOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementTagName, nameof(browserPressCtrlKeyOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementXPath, nameof(browserPressCtrlKeyOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementClassName, nameof(browserPressCtrlKeyOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementCSSSelector, nameof(browserPressCtrlKeyOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementIndex, nameof(browserPressCtrlKeyOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementMatchValue, nameof(browserPressCtrlKeyOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementMatchText, nameof(browserPressCtrlKeyOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementType, nameof(browserPressCtrlKeyOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementMinimumWidth, nameof(browserPressCtrlKeyOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementMinimumHeight, nameof(browserPressCtrlKeyOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPressCtrlKeyOnElement = new JObject();
                var browserPressCtrlKeyOnElementpropCount = 0;
                if (browserPressCtrlKeyOnElementparentElementHandle != null)
                {
                    browserPressCtrlKeyOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementparentElementHandle);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementHandle != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementHandle);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementID != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementID);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementTagName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementTagName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementXPath != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementXPath);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementClassName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementClassName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementCSSSelector != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementCSSSelector);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementIndex != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementIndex != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementIndex);
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
                    browserPressCtrlKeyOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMatchValue);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementMatchText != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMatchText);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementType != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementType);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                {
                    if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMinimumWidth);
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
                        browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMinimumHeight);
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
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft);
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
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight);
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
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop);
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
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom);
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
                        browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserPressCtrlKeyOnElement["ControlKey"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementcontrolKey);
                browserPressCtrlKeyOnElementpropCount++;
                browserPressCtrlKeyOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementworkflow);
                if (browserPressCtrlKeyOnElementpropCount > 0)
                {
                    callPayload.Body = browserPressCtrlKeyOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserClickElement([WorkflowExpression] Func<string> browserClickElementworkflow, [WorkflowExpression] Func<double> browserClickElementparentElementHandle = null, [WorkflowExpression] Func<double> browserClickElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserClickElementsearchElementName = null, [WorkflowExpression] Func<string> browserClickElementsearchElementID = null, [WorkflowExpression] Func<string> browserClickElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserClickElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserClickElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserClickElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserClickElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserClickElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserClickElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserClickElementsearchElementType = null, [WorkflowExpression] Func<double> browserClickElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserClickElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserClickElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserClickElementworkflow, nameof(browserClickElementworkflow), required: true);
            SourceExpression.Validate(browserClickElementparentElementHandle, nameof(browserClickElementparentElementHandle), required: false);
            SourceExpression.Validate(browserClickElementsearchElementHandle, nameof(browserClickElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserClickElementsearchElementName, nameof(browserClickElementsearchElementName), required: false);
            SourceExpression.Validate(browserClickElementsearchElementID, nameof(browserClickElementsearchElementID), required: false);
            SourceExpression.Validate(browserClickElementsearchElementTagName, nameof(browserClickElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserClickElementsearchElementXPath, nameof(browserClickElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserClickElementsearchElementClassName, nameof(browserClickElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserClickElementsearchElementCSSSelector, nameof(browserClickElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserClickElementsearchElementIndex, nameof(browserClickElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserClickElementsearchElementMatchValue, nameof(browserClickElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserClickElementsearchElementMatchText, nameof(browserClickElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserClickElementsearchElementType, nameof(browserClickElementsearchElementType), required: false);
            SourceExpression.Validate(browserClickElementsearchElementMinimumWidth, nameof(browserClickElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserClickElementsearchElementMinimumHeight, nameof(browserClickElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserClickElementsearchElementBoundingBoxLeft, nameof(browserClickElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserClickElementsearchElementBoundingBoxRight, nameof(browserClickElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserClickElementsearchElementBoundingBoxTop, nameof(browserClickElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserClickElementsearchElementBoundingBoxBottom, nameof(browserClickElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ClickElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserClickElement = new JObject();
                var browserClickElementpropCount = 0;
                if (browserClickElementparentElementHandle != null)
                {
                    browserClickElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserClickElementparentElementHandle);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementHandle != null)
                {
                    browserClickElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementHandle);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementName != null)
                {
                    browserClickElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementName);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementID != null)
                {
                    browserClickElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementID);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementTagName != null)
                {
                    browserClickElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementTagName);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementXPath != null)
                {
                    browserClickElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementXPath);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementClassName != null)
                {
                    browserClickElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementClassName);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementCSSSelector != null)
                {
                    browserClickElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementCSSSelector);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementIndex != null)
                {
                    if (browserClickElementsearchElementIndex != null)
                    {
                        browserClickElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementIndex);
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
                    browserClickElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementMatchValue);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementMatchText != null)
                {
                    browserClickElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementMatchText);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementType != null)
                {
                    browserClickElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementType);
                    browserClickElementpropCount++;
                }

                if (browserClickElementsearchElementMinimumWidth != null)
                {
                    if (browserClickElementsearchElementMinimumWidth != null)
                    {
                        browserClickElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementMinimumWidth);
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
                        browserClickElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementMinimumHeight);
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
                        browserClickElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxLeft);
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
                        browserClickElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxRight);
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
                        browserClickElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxTop);
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
                        browserClickElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxBottom);
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
                        browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserClickElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserClickElementworkflow);
                if (browserClickElementpropCount > 0)
                {
                    callPayload.Body = browserClickElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSubmitElement([WorkflowExpression] Func<string> browserSubmitElementworkflow, [WorkflowExpression] Func<double> browserSubmitElementparentElementHandle = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementName = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementID = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSubmitElementsearchElementType = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSubmitElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserSubmitElementworkflow, nameof(browserSubmitElementworkflow), required: true);
            SourceExpression.Validate(browserSubmitElementparentElementHandle, nameof(browserSubmitElementparentElementHandle), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementHandle, nameof(browserSubmitElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementName, nameof(browserSubmitElementsearchElementName), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementID, nameof(browserSubmitElementsearchElementID), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementTagName, nameof(browserSubmitElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementXPath, nameof(browserSubmitElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementClassName, nameof(browserSubmitElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementCSSSelector, nameof(browserSubmitElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementIndex, nameof(browserSubmitElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementMatchValue, nameof(browserSubmitElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementMatchText, nameof(browserSubmitElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementType, nameof(browserSubmitElementsearchElementType), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementMinimumWidth, nameof(browserSubmitElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementMinimumHeight, nameof(browserSubmitElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementBoundingBoxLeft, nameof(browserSubmitElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementBoundingBoxRight, nameof(browserSubmitElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementBoundingBoxTop, nameof(browserSubmitElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserSubmitElementsearchElementBoundingBoxBottom, nameof(browserSubmitElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SubmitElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSubmitElement = new JObject();
                var browserSubmitElementpropCount = 0;
                if (browserSubmitElementparentElementHandle != null)
                {
                    browserSubmitElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserSubmitElementparentElementHandle);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementHandle != null)
                {
                    browserSubmitElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementHandle);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementName != null)
                {
                    browserSubmitElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementName);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementID != null)
                {
                    browserSubmitElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementID);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementTagName != null)
                {
                    browserSubmitElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementTagName);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementXPath != null)
                {
                    browserSubmitElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementXPath);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementClassName != null)
                {
                    browserSubmitElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementClassName);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementCSSSelector != null)
                {
                    browserSubmitElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementCSSSelector);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementIndex != null)
                {
                    if (browserSubmitElementsearchElementIndex != null)
                    {
                        browserSubmitElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementIndex);
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
                    browserSubmitElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementMatchValue);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementMatchText != null)
                {
                    browserSubmitElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementMatchText);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementType != null)
                {
                    browserSubmitElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementType);
                    browserSubmitElementpropCount++;
                }

                if (browserSubmitElementsearchElementMinimumWidth != null)
                {
                    if (browserSubmitElementsearchElementMinimumWidth != null)
                    {
                        browserSubmitElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementMinimumWidth);
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
                        browserSubmitElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementMinimumHeight);
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
                        browserSubmitElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxLeft);
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
                        browserSubmitElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxRight);
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
                        browserSubmitElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxTop);
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
                        browserSubmitElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxBottom);
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
                        browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserSubmitElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserSubmitElementworkflow);
                if (browserSubmitElementpropCount > 0)
                {
                    callPayload.Body = browserSubmitElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckElement([WorkflowExpression] Func<string> browserCheckElementworkflow, [WorkflowExpression] Func<double> browserCheckElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementName = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementID = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCheckElementsearchElementType = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCheckElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserCheckElementcheckElement = null)
        {
            SourceExpression.Validate(browserCheckElementworkflow, nameof(browserCheckElementworkflow), required: true);
            SourceExpression.Validate(browserCheckElementparentElementHandle, nameof(browserCheckElementparentElementHandle), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementHandle, nameof(browserCheckElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementName, nameof(browserCheckElementsearchElementName), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementID, nameof(browserCheckElementsearchElementID), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementTagName, nameof(browserCheckElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementXPath, nameof(browserCheckElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementClassName, nameof(browserCheckElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementCSSSelector, nameof(browserCheckElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementIndex, nameof(browserCheckElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementMatchValue, nameof(browserCheckElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementMatchText, nameof(browserCheckElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementType, nameof(browserCheckElementsearchElementType), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementMinimumWidth, nameof(browserCheckElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementMinimumHeight, nameof(browserCheckElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementBoundingBoxLeft, nameof(browserCheckElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementBoundingBoxRight, nameof(browserCheckElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementBoundingBoxTop, nameof(browserCheckElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserCheckElementsearchElementBoundingBoxBottom, nameof(browserCheckElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserCheckElementcheckElement, nameof(browserCheckElementcheckElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCheckElement = new JObject();
                var browserCheckElementpropCount = 0;
                if (browserCheckElementparentElementHandle != null)
                {
                    browserCheckElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserCheckElementparentElementHandle);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementHandle != null)
                {
                    browserCheckElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementHandle);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementName != null)
                {
                    browserCheckElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementName);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementID != null)
                {
                    browserCheckElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementID);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementTagName != null)
                {
                    browserCheckElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementTagName);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementXPath != null)
                {
                    browserCheckElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementXPath);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementClassName != null)
                {
                    browserCheckElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementClassName);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementCSSSelector != null)
                {
                    browserCheckElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementCSSSelector);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementIndex != null)
                {
                    if (browserCheckElementsearchElementIndex != null)
                    {
                        browserCheckElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementIndex);
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
                    browserCheckElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementMatchValue);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementMatchText != null)
                {
                    browserCheckElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementMatchText);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementType != null)
                {
                    browserCheckElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementType);
                    browserCheckElementpropCount++;
                }

                if (browserCheckElementsearchElementMinimumWidth != null)
                {
                    if (browserCheckElementsearchElementMinimumWidth != null)
                    {
                        browserCheckElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementMinimumWidth);
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
                        browserCheckElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementMinimumHeight);
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
                        browserCheckElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxLeft);
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
                        browserCheckElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxRight);
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
                        browserCheckElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxTop);
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
                        browserCheckElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxBottom);
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
                        browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserCheckElement["CheckElement"] = SourceExpressionConverter.ConvertToken(browserCheckElementcheckElement);
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
                browserCheckElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserCheckElementworkflow);
                if (browserCheckElementpropCount > 0)
                {
                    callPayload.Body = browserCheckElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckMultipleElements([WorkflowExpression] Func<string> browserCheckMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> browserCheckMultipleElementsworkflow)
        {
            SourceExpression.Validate(browserCheckMultipleElementsinputElementsJSON, nameof(browserCheckMultipleElementsinputElementsJSON), required: true);
            SourceExpression.Validate(browserCheckMultipleElementsworkflow, nameof(browserCheckMultipleElementsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCheckMultipleElements = new JObject();
                var browserCheckMultipleElementspropCount = 0;
                browserCheckMultipleElementspropCount++;
                browserCheckMultipleElements["InputElementsJSON"] = SourceExpressionConverter.ConvertToken(browserCheckMultipleElementsinputElementsJSON);
                browserCheckMultipleElementspropCount++;
                browserCheckMultipleElements["Workflow"] = SourceExpressionConverter.ConvertToken(browserCheckMultipleElementsworkflow);
                if (browserCheckMultipleElementspropCount > 0)
                {
                    callPayload.Body = browserCheckMultipleElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> BrowserGetSelectionProperties([WorkflowExpression] Func<string> browserGetSelectionPropertiesworkflow, [WorkflowExpression] Func<double> browserGetSelectionPropertiesparentElementHandle = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementHandle = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementName = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementID = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementTagName = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementXPath = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementIndex = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetSelectionPropertiessearchElementType = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetSelectionPropertiessearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserGetSelectionPropertiesworkflow, nameof(browserGetSelectionPropertiesworkflow), required: true);
            SourceExpression.Validate(browserGetSelectionPropertiesparentElementHandle, nameof(browserGetSelectionPropertiesparentElementHandle), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementHandle, nameof(browserGetSelectionPropertiessearchElementHandle), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementName, nameof(browserGetSelectionPropertiessearchElementName), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementID, nameof(browserGetSelectionPropertiessearchElementID), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementTagName, nameof(browserGetSelectionPropertiessearchElementTagName), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementXPath, nameof(browserGetSelectionPropertiessearchElementXPath), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementClassName, nameof(browserGetSelectionPropertiessearchElementClassName), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementCSSSelector, nameof(browserGetSelectionPropertiessearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementIndex, nameof(browserGetSelectionPropertiessearchElementIndex), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementMatchValue, nameof(browserGetSelectionPropertiessearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementMatchText, nameof(browserGetSelectionPropertiessearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementType, nameof(browserGetSelectionPropertiessearchElementType), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementMinimumWidth, nameof(browserGetSelectionPropertiessearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementMinimumHeight, nameof(browserGetSelectionPropertiessearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxLeft, nameof(browserGetSelectionPropertiessearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxRight, nameof(browserGetSelectionPropertiessearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxTop, nameof(browserGetSelectionPropertiessearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiessearchElementBoundingBoxBottom, nameof(browserGetSelectionPropertiessearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetSelectionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetSelectionProperties = new JObject();
                var browserGetSelectionPropertiespropCount = 0;
                if (browserGetSelectionPropertiesparentElementHandle != null)
                {
                    browserGetSelectionProperties["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiesparentElementHandle);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementHandle != null)
                {
                    browserGetSelectionProperties["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementHandle);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementName != null)
                {
                    browserGetSelectionProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementID != null)
                {
                    browserGetSelectionProperties["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementID);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementTagName != null)
                {
                    browserGetSelectionProperties["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementTagName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementXPath != null)
                {
                    browserGetSelectionProperties["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementXPath);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementClassName != null)
                {
                    browserGetSelectionProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementClassName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementCSSSelector != null)
                {
                    browserGetSelectionProperties["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementCSSSelector);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementIndex != null)
                {
                    if (browserGetSelectionPropertiessearchElementIndex != null)
                    {
                        browserGetSelectionProperties["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementIndex);
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
                    browserGetSelectionProperties["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMatchValue);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementMatchText != null)
                {
                    browserGetSelectionProperties["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMatchText);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementType != null)
                {
                    browserGetSelectionProperties["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementType);
                    browserGetSelectionPropertiespropCount++;
                }

                if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
                {
                    if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetSelectionProperties["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMinimumWidth);
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
                        browserGetSelectionProperties["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMinimumHeight);
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
                        browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxLeft);
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
                        browserGetSelectionProperties["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxRight);
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
                        browserGetSelectionProperties["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxTop);
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
                        browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxBottom);
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
                        browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserGetSelectionProperties["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetSelectionPropertiesworkflow);
                if (browserGetSelectionPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetSelectionProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectSelection([WorkflowExpression] Func<string> browserSelectSelectionworkflow, [WorkflowExpression] Func<double> browserSelectSelectionparentElementHandle = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementHandle = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementName = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementID = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementTagName = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementXPath = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementClassName = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementIndex = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSelectSelectionsearchElementType = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSelectSelectionsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserSelectSelectionvalueToSelect = null, [WorkflowExpression] Func<string> browserSelectSelectiontextToSelect = null, [WorkflowExpression] Func<double> browserSelectSelectionindexToSelect = null)
        {
            SourceExpression.Validate(browserSelectSelectionworkflow, nameof(browserSelectSelectionworkflow), required: true);
            SourceExpression.Validate(browserSelectSelectionparentElementHandle, nameof(browserSelectSelectionparentElementHandle), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementHandle, nameof(browserSelectSelectionsearchElementHandle), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementName, nameof(browserSelectSelectionsearchElementName), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementID, nameof(browserSelectSelectionsearchElementID), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementTagName, nameof(browserSelectSelectionsearchElementTagName), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementXPath, nameof(browserSelectSelectionsearchElementXPath), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementClassName, nameof(browserSelectSelectionsearchElementClassName), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementCSSSelector, nameof(browserSelectSelectionsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementIndex, nameof(browserSelectSelectionsearchElementIndex), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementMatchValue, nameof(browserSelectSelectionsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementMatchText, nameof(browserSelectSelectionsearchElementMatchText), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementType, nameof(browserSelectSelectionsearchElementType), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementMinimumWidth, nameof(browserSelectSelectionsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementMinimumHeight, nameof(browserSelectSelectionsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementBoundingBoxLeft, nameof(browserSelectSelectionsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementBoundingBoxRight, nameof(browserSelectSelectionsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementBoundingBoxTop, nameof(browserSelectSelectionsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserSelectSelectionsearchElementBoundingBoxBottom, nameof(browserSelectSelectionsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserSelectSelectionvalueToSelect, nameof(browserSelectSelectionvalueToSelect), required: false);
            SourceExpression.Validate(browserSelectSelectiontextToSelect, nameof(browserSelectSelectiontextToSelect), required: false);
            SourceExpression.Validate(browserSelectSelectionindexToSelect, nameof(browserSelectSelectionindexToSelect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SelectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSelectSelection = new JObject();
                var browserSelectSelectionpropCount = 0;
                if (browserSelectSelectionparentElementHandle != null)
                {
                    browserSelectSelection["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionparentElementHandle);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementHandle != null)
                {
                    browserSelectSelection["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementHandle);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementName != null)
                {
                    browserSelectSelection["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementName);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementID != null)
                {
                    browserSelectSelection["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementID);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementTagName != null)
                {
                    browserSelectSelection["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementTagName);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementXPath != null)
                {
                    browserSelectSelection["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementXPath);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementClassName != null)
                {
                    browserSelectSelection["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementClassName);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementCSSSelector != null)
                {
                    browserSelectSelection["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementCSSSelector);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementIndex != null)
                {
                    if (browserSelectSelectionsearchElementIndex != null)
                    {
                        browserSelectSelection["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementIndex);
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
                    browserSelectSelection["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMatchValue);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementMatchText != null)
                {
                    browserSelectSelection["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMatchText);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementType != null)
                {
                    browserSelectSelection["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementType);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionsearchElementMinimumWidth != null)
                {
                    if (browserSelectSelectionsearchElementMinimumWidth != null)
                    {
                        browserSelectSelection["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMinimumWidth);
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
                        browserSelectSelection["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMinimumHeight);
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
                        browserSelectSelection["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxLeft);
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
                        browserSelectSelection["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxRight);
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
                        browserSelectSelection["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxTop);
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
                        browserSelectSelection["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxBottom);
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
                        browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
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
                    browserSelectSelection["ValueToSelect"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionvalueToSelect);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectiontextToSelect != null)
                {
                    browserSelectSelection["TextToSelect"] = SourceExpressionConverter.ConvertToken(browserSelectSelectiontextToSelect);
                    browserSelectSelectionpropCount++;
                }

                if (browserSelectSelectionindexToSelect != null)
                {
                    if (browserSelectSelectionindexToSelect != null)
                    {
                        browserSelectSelection["IndexToSelect"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionindexToSelect);
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
                browserSelectSelection["Workflow"] = SourceExpressionConverter.ConvertToken(browserSelectSelectionworkflow);
                if (browserSelectSelectionpropCount > 0)
                {
                    callPayload.Body = browserSelectSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectSelection([WorkflowExpression] Func<string> browserDeselectSelectionworkflow, [WorkflowExpression] Func<double> browserDeselectSelectionparentElementHandle = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementHandle = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementName = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementID = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementTagName = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementXPath = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementClassName = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementIndex = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDeselectSelectionsearchElementType = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDeselectSelectionsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserDeselectSelectionvalueToDeselect = null, [WorkflowExpression] Func<string> browserDeselectSelectiontextToDeselect = null, [WorkflowExpression] Func<double> browserDeselectSelectionindexToDeselect = null)
        {
            SourceExpression.Validate(browserDeselectSelectionworkflow, nameof(browserDeselectSelectionworkflow), required: true);
            SourceExpression.Validate(browserDeselectSelectionparentElementHandle, nameof(browserDeselectSelectionparentElementHandle), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementHandle, nameof(browserDeselectSelectionsearchElementHandle), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementName, nameof(browserDeselectSelectionsearchElementName), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementID, nameof(browserDeselectSelectionsearchElementID), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementTagName, nameof(browserDeselectSelectionsearchElementTagName), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementXPath, nameof(browserDeselectSelectionsearchElementXPath), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementClassName, nameof(browserDeselectSelectionsearchElementClassName), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementCSSSelector, nameof(browserDeselectSelectionsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementIndex, nameof(browserDeselectSelectionsearchElementIndex), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementMatchValue, nameof(browserDeselectSelectionsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementMatchText, nameof(browserDeselectSelectionsearchElementMatchText), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementType, nameof(browserDeselectSelectionsearchElementType), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementMinimumWidth, nameof(browserDeselectSelectionsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementMinimumHeight, nameof(browserDeselectSelectionsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxLeft, nameof(browserDeselectSelectionsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxRight, nameof(browserDeselectSelectionsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxTop, nameof(browserDeselectSelectionsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserDeselectSelectionsearchElementBoundingBoxBottom, nameof(browserDeselectSelectionsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserDeselectSelectionvalueToDeselect, nameof(browserDeselectSelectionvalueToDeselect), required: false);
            SourceExpression.Validate(browserDeselectSelectiontextToDeselect, nameof(browserDeselectSelectiontextToDeselect), required: false);
            SourceExpression.Validate(browserDeselectSelectionindexToDeselect, nameof(browserDeselectSelectionindexToDeselect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/DeselectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDeselectSelection = new JObject();
                var browserDeselectSelectionpropCount = 0;
                if (browserDeselectSelectionparentElementHandle != null)
                {
                    browserDeselectSelection["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionparentElementHandle);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementHandle != null)
                {
                    browserDeselectSelection["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementHandle);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementName != null)
                {
                    browserDeselectSelection["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementName);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementID != null)
                {
                    browserDeselectSelection["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementID);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementTagName != null)
                {
                    browserDeselectSelection["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementTagName);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementXPath != null)
                {
                    browserDeselectSelection["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementXPath);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementClassName != null)
                {
                    browserDeselectSelection["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementClassName);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementCSSSelector != null)
                {
                    browserDeselectSelection["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementCSSSelector);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementIndex != null)
                {
                    if (browserDeselectSelectionsearchElementIndex != null)
                    {
                        browserDeselectSelection["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementIndex);
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
                    browserDeselectSelection["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMatchValue);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementMatchText != null)
                {
                    browserDeselectSelection["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMatchText);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementType != null)
                {
                    browserDeselectSelection["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementType);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionsearchElementMinimumWidth != null)
                {
                    if (browserDeselectSelectionsearchElementMinimumWidth != null)
                    {
                        browserDeselectSelection["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMinimumWidth);
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
                        browserDeselectSelection["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMinimumHeight);
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
                        browserDeselectSelection["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxLeft);
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
                        browserDeselectSelection["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxRight);
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
                        browserDeselectSelection["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxTop);
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
                        browserDeselectSelection["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxBottom);
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
                        browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
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
                    browserDeselectSelection["ValueToDeselect"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionvalueToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectiontextToDeselect != null)
                {
                    browserDeselectSelection["TextToDeselect"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectiontextToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                if (browserDeselectSelectionindexToDeselect != null)
                {
                    if (browserDeselectSelectionindexToDeselect != null)
                    {
                        browserDeselectSelection["IndexToDeselect"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionindexToDeselect);
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
                browserDeselectSelection["Workflow"] = SourceExpressionConverter.ConvertToken(browserDeselectSelectionworkflow);
                if (browserDeselectSelectionpropCount > 0)
                {
                    callPayload.Body = browserDeselectSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectAllSelection([WorkflowExpression] Func<string> browserDeselectAllSelectionworkflow, [WorkflowExpression] Func<double> browserDeselectAllSelectionparentElementHandle = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementHandle = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementName = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementID = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementTagName = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementXPath = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementClassName = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementIndex = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDeselectAllSelectionsearchElementType = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDeselectAllSelectionsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserDeselectAllSelectionworkflow, nameof(browserDeselectAllSelectionworkflow), required: true);
            SourceExpression.Validate(browserDeselectAllSelectionparentElementHandle, nameof(browserDeselectAllSelectionparentElementHandle), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementHandle, nameof(browserDeselectAllSelectionsearchElementHandle), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementName, nameof(browserDeselectAllSelectionsearchElementName), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementID, nameof(browserDeselectAllSelectionsearchElementID), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementTagName, nameof(browserDeselectAllSelectionsearchElementTagName), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementXPath, nameof(browserDeselectAllSelectionsearchElementXPath), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementClassName, nameof(browserDeselectAllSelectionsearchElementClassName), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementCSSSelector, nameof(browserDeselectAllSelectionsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementIndex, nameof(browserDeselectAllSelectionsearchElementIndex), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementMatchValue, nameof(browserDeselectAllSelectionsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementMatchText, nameof(browserDeselectAllSelectionsearchElementMatchText), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementType, nameof(browserDeselectAllSelectionsearchElementType), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementMinimumWidth, nameof(browserDeselectAllSelectionsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementMinimumHeight, nameof(browserDeselectAllSelectionsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxLeft, nameof(browserDeselectAllSelectionsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxRight, nameof(browserDeselectAllSelectionsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxTop, nameof(browserDeselectAllSelectionsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserDeselectAllSelectionsearchElementBoundingBoxBottom, nameof(browserDeselectAllSelectionsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/DeselectAllSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDeselectAllSelection = new JObject();
                var browserDeselectAllSelectionpropCount = 0;
                if (browserDeselectAllSelectionparentElementHandle != null)
                {
                    browserDeselectAllSelection["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionparentElementHandle);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementHandle != null)
                {
                    browserDeselectAllSelection["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementHandle);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementName != null)
                {
                    browserDeselectAllSelection["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementID != null)
                {
                    browserDeselectAllSelection["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementID);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementTagName != null)
                {
                    browserDeselectAllSelection["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementTagName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementXPath != null)
                {
                    browserDeselectAllSelection["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementXPath);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementClassName != null)
                {
                    browserDeselectAllSelection["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementClassName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementCSSSelector != null)
                {
                    browserDeselectAllSelection["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementCSSSelector);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementIndex != null)
                {
                    if (browserDeselectAllSelectionsearchElementIndex != null)
                    {
                        browserDeselectAllSelection["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementIndex);
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
                    browserDeselectAllSelection["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMatchValue);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementMatchText != null)
                {
                    browserDeselectAllSelection["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMatchText);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementType != null)
                {
                    browserDeselectAllSelection["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementType);
                    browserDeselectAllSelectionpropCount++;
                }

                if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
                {
                    if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
                    {
                        browserDeselectAllSelection["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMinimumWidth);
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
                        browserDeselectAllSelection["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMinimumHeight);
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
                        browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxLeft);
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
                        browserDeselectAllSelection["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxRight);
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
                        browserDeselectAllSelection["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxTop);
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
                        browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxBottom);
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
                        browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserDeselectAllSelection["Workflow"] = SourceExpressionConverter.ConvertToken(browserDeselectAllSelectionworkflow);
                if (browserDeselectAllSelectionpropCount > 0)
                {
                    callPayload.Body = browserDeselectAllSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> BrowserGetTableContents([WorkflowExpression] Func<string> browserGetTableContentsworkflow, [WorkflowExpression] Func<double> browserGetTableContentsparentElementHandle = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementHandle = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementName = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementID = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementTagName = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementXPath = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementClassName = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementIndex = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetTableContentssearchElementType = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetTableContentssearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<double> browserGetTableContentscreateColumnNamesFromRow = null, [WorkflowExpression] Func<bool> browserGetTableContentsmergeChildTables = null)
        {
            SourceExpression.Validate(browserGetTableContentsworkflow, nameof(browserGetTableContentsworkflow), required: true);
            SourceExpression.Validate(browserGetTableContentsparentElementHandle, nameof(browserGetTableContentsparentElementHandle), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementHandle, nameof(browserGetTableContentssearchElementHandle), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementName, nameof(browserGetTableContentssearchElementName), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementID, nameof(browserGetTableContentssearchElementID), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementTagName, nameof(browserGetTableContentssearchElementTagName), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementXPath, nameof(browserGetTableContentssearchElementXPath), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementClassName, nameof(browserGetTableContentssearchElementClassName), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementCSSSelector, nameof(browserGetTableContentssearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementIndex, nameof(browserGetTableContentssearchElementIndex), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementMatchValue, nameof(browserGetTableContentssearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementMatchText, nameof(browserGetTableContentssearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementType, nameof(browserGetTableContentssearchElementType), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementMinimumWidth, nameof(browserGetTableContentssearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementMinimumHeight, nameof(browserGetTableContentssearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementBoundingBoxLeft, nameof(browserGetTableContentssearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementBoundingBoxRight, nameof(browserGetTableContentssearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementBoundingBoxTop, nameof(browserGetTableContentssearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetTableContentssearchElementBoundingBoxBottom, nameof(browserGetTableContentssearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGetTableContentscreateColumnNamesFromRow, nameof(browserGetTableContentscreateColumnNamesFromRow), required: false);
            SourceExpression.Validate(browserGetTableContentsmergeChildTables, nameof(browserGetTableContentsmergeChildTables), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetTableContents = new JObject();
                var browserGetTableContentspropCount = 0;
                if (browserGetTableContentsparentElementHandle != null)
                {
                    browserGetTableContents["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetTableContentsparentElementHandle);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementHandle != null)
                {
                    browserGetTableContents["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementHandle);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementName != null)
                {
                    browserGetTableContents["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementName);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementID != null)
                {
                    browserGetTableContents["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementID);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementTagName != null)
                {
                    browserGetTableContents["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementTagName);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementXPath != null)
                {
                    browserGetTableContents["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementXPath);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementClassName != null)
                {
                    browserGetTableContents["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementClassName);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementCSSSelector != null)
                {
                    browserGetTableContents["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementCSSSelector);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementIndex != null)
                {
                    if (browserGetTableContentssearchElementIndex != null)
                    {
                        browserGetTableContents["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementIndex);
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
                    browserGetTableContents["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementMatchValue);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementMatchText != null)
                {
                    browserGetTableContents["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementMatchText);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementType != null)
                {
                    browserGetTableContents["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementType);
                    browserGetTableContentspropCount++;
                }

                if (browserGetTableContentssearchElementMinimumWidth != null)
                {
                    if (browserGetTableContentssearchElementMinimumWidth != null)
                    {
                        browserGetTableContents["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementMinimumWidth);
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
                        browserGetTableContents["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementMinimumHeight);
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
                        browserGetTableContents["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxLeft);
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
                        browserGetTableContents["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxRight);
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
                        browserGetTableContents["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxTop);
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
                        browserGetTableContents["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxBottom);
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
                        browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserGetTableContents["CreateColumnNamesFromRow"] = SourceExpressionConverter.ConvertToken(browserGetTableContentscreateColumnNamesFromRow);
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
                        browserGetTableContents["MergeChildTables"] = SourceExpressionConverter.ConvertToken(browserGetTableContentsmergeChildTables);
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
                browserGetTableContents["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetTableContentsworkflow);
                if (browserGetTableContentspropCount > 0)
                {
                    callPayload.Body = browserGetTableContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetTableContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollElementIntoView([WorkflowExpression] Func<string> browserScrollElementIntoViewworkflow, [WorkflowExpression] Func<double> browserScrollElementIntoViewparentElementHandle = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementHandle = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementName = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementID = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementTagName = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementXPath = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementClassName = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementIndex = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementMatchText = null, [WorkflowExpression] Func<string> browserScrollElementIntoViewsearchElementType = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserScrollElementIntoViewsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserScrollElementIntoViewworkflow, nameof(browserScrollElementIntoViewworkflow), required: true);
            SourceExpression.Validate(browserScrollElementIntoViewparentElementHandle, nameof(browserScrollElementIntoViewparentElementHandle), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementHandle, nameof(browserScrollElementIntoViewsearchElementHandle), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementName, nameof(browserScrollElementIntoViewsearchElementName), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementID, nameof(browserScrollElementIntoViewsearchElementID), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementTagName, nameof(browserScrollElementIntoViewsearchElementTagName), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementXPath, nameof(browserScrollElementIntoViewsearchElementXPath), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementClassName, nameof(browserScrollElementIntoViewsearchElementClassName), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementCSSSelector, nameof(browserScrollElementIntoViewsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementIndex, nameof(browserScrollElementIntoViewsearchElementIndex), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementMatchValue, nameof(browserScrollElementIntoViewsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementMatchText, nameof(browserScrollElementIntoViewsearchElementMatchText), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementType, nameof(browserScrollElementIntoViewsearchElementType), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementMinimumWidth, nameof(browserScrollElementIntoViewsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementMinimumHeight, nameof(browserScrollElementIntoViewsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxLeft, nameof(browserScrollElementIntoViewsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxRight, nameof(browserScrollElementIntoViewsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxTop, nameof(browserScrollElementIntoViewsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewsearchElementBoundingBoxBottom, nameof(browserScrollElementIntoViewsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ScrollElementIntoView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollElementIntoView = new JObject();
                var browserScrollElementIntoViewpropCount = 0;
                if (browserScrollElementIntoViewparentElementHandle != null)
                {
                    browserScrollElementIntoView["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewparentElementHandle);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementHandle != null)
                {
                    browserScrollElementIntoView["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementHandle);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementName != null)
                {
                    browserScrollElementIntoView["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementID != null)
                {
                    browserScrollElementIntoView["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementID);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementTagName != null)
                {
                    browserScrollElementIntoView["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementTagName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementXPath != null)
                {
                    browserScrollElementIntoView["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementXPath);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementClassName != null)
                {
                    browserScrollElementIntoView["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementClassName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementCSSSelector != null)
                {
                    browserScrollElementIntoView["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementCSSSelector);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementIndex != null)
                {
                    if (browserScrollElementIntoViewsearchElementIndex != null)
                    {
                        browserScrollElementIntoView["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementIndex);
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
                    browserScrollElementIntoView["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMatchValue);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementMatchText != null)
                {
                    browserScrollElementIntoView["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMatchText);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementType != null)
                {
                    browserScrollElementIntoView["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementType);
                    browserScrollElementIntoViewpropCount++;
                }

                if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
                {
                    if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
                    {
                        browserScrollElementIntoView["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMinimumWidth);
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
                        browserScrollElementIntoView["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMinimumHeight);
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
                        browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxLeft);
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
                        browserScrollElementIntoView["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxRight);
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
                        browserScrollElementIntoView["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxTop);
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
                        browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxBottom);
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
                        browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserScrollElementIntoView["Workflow"] = SourceExpressionConverter.ConvertToken(browserScrollElementIntoViewworkflow);
                if (browserScrollElementIntoViewpropCount > 0)
                {
                    callPayload.Body = browserScrollElementIntoView;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> BrowserExecuteJavaScript([WorkflowExpression] Func<string> browserExecuteJavaScriptjavaScriptCode, [WorkflowExpression] Func<string> browserExecuteJavaScriptworkflow)
        {
            SourceExpression.Validate(browserExecuteJavaScriptjavaScriptCode, nameof(browserExecuteJavaScriptjavaScriptCode), required: true);
            SourceExpression.Validate(browserExecuteJavaScriptworkflow, nameof(browserExecuteJavaScriptworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserExecuteJavaScript = new JObject();
                var browserExecuteJavaScriptpropCount = 0;
                browserExecuteJavaScriptpropCount++;
                browserExecuteJavaScript["JavaScriptCode"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptjavaScriptCode);
                browserExecuteJavaScriptpropCount++;
                browserExecuteJavaScript["Workflow"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptworkflow);
                if (browserExecuteJavaScriptpropCount > 0)
                {
                    callPayload.Body = browserExecuteJavaScript;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> BrowserGetElementBoundingRect([WorkflowExpression] Func<string> browserGetElementBoundingRectworkflow, [WorkflowExpression] Func<double> browserGetElementBoundingRectparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementName = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementID = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementBoundingRectsearchElementType = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementBoundingRectsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserGetElementBoundingRectworkflow, nameof(browserGetElementBoundingRectworkflow), required: true);
            SourceExpression.Validate(browserGetElementBoundingRectparentElementHandle, nameof(browserGetElementBoundingRectparentElementHandle), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementHandle, nameof(browserGetElementBoundingRectsearchElementHandle), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementName, nameof(browserGetElementBoundingRectsearchElementName), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementID, nameof(browserGetElementBoundingRectsearchElementID), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementTagName, nameof(browserGetElementBoundingRectsearchElementTagName), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementXPath, nameof(browserGetElementBoundingRectsearchElementXPath), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementClassName, nameof(browserGetElementBoundingRectsearchElementClassName), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementCSSSelector, nameof(browserGetElementBoundingRectsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementIndex, nameof(browserGetElementBoundingRectsearchElementIndex), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementMatchValue, nameof(browserGetElementBoundingRectsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementMatchText, nameof(browserGetElementBoundingRectsearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementType, nameof(browserGetElementBoundingRectsearchElementType), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementMinimumWidth, nameof(browserGetElementBoundingRectsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementMinimumHeight, nameof(browserGetElementBoundingRectsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxLeft, nameof(browserGetElementBoundingRectsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxRight, nameof(browserGetElementBoundingRectsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxTop, nameof(browserGetElementBoundingRectsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectsearchElementBoundingBoxBottom, nameof(browserGetElementBoundingRectsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetElementBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementBoundingRect = new JObject();
                var browserGetElementBoundingRectpropCount = 0;
                if (browserGetElementBoundingRectparentElementHandle != null)
                {
                    browserGetElementBoundingRect["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectparentElementHandle);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementHandle != null)
                {
                    browserGetElementBoundingRect["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementHandle);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementName != null)
                {
                    browserGetElementBoundingRect["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementID != null)
                {
                    browserGetElementBoundingRect["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementID);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementTagName != null)
                {
                    browserGetElementBoundingRect["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementTagName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementXPath != null)
                {
                    browserGetElementBoundingRect["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementXPath);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementClassName != null)
                {
                    browserGetElementBoundingRect["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementClassName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementCSSSelector != null)
                {
                    browserGetElementBoundingRect["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementCSSSelector);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementIndex != null)
                {
                    if (browserGetElementBoundingRectsearchElementIndex != null)
                    {
                        browserGetElementBoundingRect["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementIndex);
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
                    browserGetElementBoundingRect["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMatchValue);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementMatchText != null)
                {
                    browserGetElementBoundingRect["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMatchText);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementType != null)
                {
                    browserGetElementBoundingRect["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementType);
                    browserGetElementBoundingRectpropCount++;
                }

                if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
                {
                    if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
                    {
                        browserGetElementBoundingRect["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMinimumWidth);
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
                        browserGetElementBoundingRect["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMinimumHeight);
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
                        browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxLeft);
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
                        browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxRight);
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
                        browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxTop);
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
                        browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxBottom);
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
                        browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserGetElementBoundingRect["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetElementBoundingRectworkflow);
                if (browserGetElementBoundingRectpropCount > 0)
                {
                    callPayload.Body = browserGetElementBoundingRect;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDrawRectangleAroundElement([WorkflowExpression] Func<string> browserDrawRectangleAroundElementworkflow, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementparentElementHandle = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementName = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementID = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementsearchElementType = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<string> browserDrawRectangleAroundElementpenColour = null, [WorkflowExpression] Func<int> browserDrawRectangleAroundElementpenThicknessPixels = null)
        {
            SourceExpression.Validate(browserDrawRectangleAroundElementworkflow, nameof(browserDrawRectangleAroundElementworkflow), required: true);
            SourceExpression.Validate(browserDrawRectangleAroundElementparentElementHandle, nameof(browserDrawRectangleAroundElementparentElementHandle), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementHandle, nameof(browserDrawRectangleAroundElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementName, nameof(browserDrawRectangleAroundElementsearchElementName), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementID, nameof(browserDrawRectangleAroundElementsearchElementID), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementTagName, nameof(browserDrawRectangleAroundElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementXPath, nameof(browserDrawRectangleAroundElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementClassName, nameof(browserDrawRectangleAroundElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementCSSSelector, nameof(browserDrawRectangleAroundElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementIndex, nameof(browserDrawRectangleAroundElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementMatchValue, nameof(browserDrawRectangleAroundElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementMatchText, nameof(browserDrawRectangleAroundElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementType, nameof(browserDrawRectangleAroundElementsearchElementType), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementMinimumWidth, nameof(browserDrawRectangleAroundElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementMinimumHeight, nameof(browserDrawRectangleAroundElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxRight, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxTop, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementpenColour, nameof(browserDrawRectangleAroundElementpenColour), required: false);
            SourceExpression.Validate(browserDrawRectangleAroundElementpenThicknessPixels, nameof(browserDrawRectangleAroundElementpenThicknessPixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDrawRectangleAroundElement = new JObject();
                var browserDrawRectangleAroundElementpropCount = 0;
                if (browserDrawRectangleAroundElementparentElementHandle != null)
                {
                    browserDrawRectangleAroundElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementparentElementHandle);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementHandle != null)
                {
                    browserDrawRectangleAroundElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementHandle);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementID != null)
                {
                    browserDrawRectangleAroundElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementID);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementTagName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementTagName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementXPath != null)
                {
                    browserDrawRectangleAroundElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementXPath);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementClassName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementClassName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementCSSSelector != null)
                {
                    browserDrawRectangleAroundElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementCSSSelector);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementIndex != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementIndex != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementIndex);
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
                    browserDrawRectangleAroundElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMatchValue);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementMatchText != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMatchText);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementType != null)
                {
                    browserDrawRectangleAroundElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementType);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                {
                    if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMinimumWidth);
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
                        browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMinimumHeight);
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
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft);
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
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxRight);
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
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxTop);
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
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom);
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
                        browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserDrawRectangleAroundElement["PenColour"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementpenColour);
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
                        browserDrawRectangleAroundElement["PenThicknessPixels"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementpenThicknessPixels);
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
                browserDrawRectangleAroundElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserDrawRectangleAroundElementworkflow);
                if (browserDrawRectangleAroundElementpropCount > 0)
                {
                    callPayload.Body = browserDrawRectangleAroundElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> BrowserGetBrowserParentWindowDetails([WorkflowExpression] Func<string> browserGetBrowserParentWindowDetailsworkflow, [WorkflowExpression] Func<int> browserGetBrowserParentWindowDetailsbrowserPID = null, [WorkflowExpression] Func<string> browserGetBrowserParentWindowDetailssearchDocumentElementClassName = null)
        {
            SourceExpression.Validate(browserGetBrowserParentWindowDetailsworkflow, nameof(browserGetBrowserParentWindowDetailsworkflow), required: true);
            SourceExpression.Validate(browserGetBrowserParentWindowDetailsbrowserPID, nameof(browserGetBrowserParentWindowDetailsbrowserPID), required: false);
            SourceExpression.Validate(browserGetBrowserParentWindowDetailssearchDocumentElementClassName, nameof(browserGetBrowserParentWindowDetailssearchDocumentElementClassName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetBrowserParentWindowDetails = new JObject();
                var browserGetBrowserParentWindowDetailspropCount = 0;
                if (browserGetBrowserParentWindowDetailsbrowserPID != null)
                {
                    browserGetBrowserParentWindowDetails["BrowserPID"] = SourceExpressionConverter.ConvertToken(browserGetBrowserParentWindowDetailsbrowserPID);
                    browserGetBrowserParentWindowDetailspropCount++;
                }

                if (browserGetBrowserParentWindowDetailssearchDocumentElementClassName != null)
                {
                    browserGetBrowserParentWindowDetails["SearchDocumentElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetBrowserParentWindowDetailssearchDocumentElementClassName);
                    browserGetBrowserParentWindowDetailspropCount++;
                }

                browserGetBrowserParentWindowDetailspropCount++;
                browserGetBrowserParentWindowDetails["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetBrowserParentWindowDetailsworkflow);
                if (browserGetBrowserParentWindowDetailspropCount > 0)
                {
                    callPayload.Body = browserGetBrowserParentWindowDetails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> BrowserGetElementScreenBoundingRect([WorkflowExpression] Func<string> browserGetElementScreenBoundingRectworkflow, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectparentElementHandle = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementHandle = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementName = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementID = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementTagName = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementXPath = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementClassName = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementIndex = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGetElementScreenBoundingRectsearchElementType = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserGetElementScreenBoundingRectworkflow, nameof(browserGetElementScreenBoundingRectworkflow), required: true);
            SourceExpression.Validate(browserGetElementScreenBoundingRectparentElementHandle, nameof(browserGetElementScreenBoundingRectparentElementHandle), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementHandle, nameof(browserGetElementScreenBoundingRectsearchElementHandle), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementName, nameof(browserGetElementScreenBoundingRectsearchElementName), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementID, nameof(browserGetElementScreenBoundingRectsearchElementID), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementTagName, nameof(browserGetElementScreenBoundingRectsearchElementTagName), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementXPath, nameof(browserGetElementScreenBoundingRectsearchElementXPath), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementClassName, nameof(browserGetElementScreenBoundingRectsearchElementClassName), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementCSSSelector, nameof(browserGetElementScreenBoundingRectsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementIndex, nameof(browserGetElementScreenBoundingRectsearchElementIndex), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementMatchValue, nameof(browserGetElementScreenBoundingRectsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementMatchText, nameof(browserGetElementScreenBoundingRectsearchElementMatchText), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementType, nameof(browserGetElementScreenBoundingRectsearchElementType), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementMinimumWidth, nameof(browserGetElementScreenBoundingRectsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementMinimumHeight, nameof(browserGetElementScreenBoundingRectsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementScreenBoundingRect = new JObject();
                var browserGetElementScreenBoundingRectpropCount = 0;
                if (browserGetElementScreenBoundingRectparentElementHandle != null)
                {
                    browserGetElementScreenBoundingRect["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectparentElementHandle);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementHandle != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementHandle);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementID != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementID);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementTagName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementTagName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementXPath != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementXPath);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementClassName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementClassName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementCSSSelector != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementCSSSelector);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementIndex != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementIndex != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementIndex);
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
                    browserGetElementScreenBoundingRect["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMatchValue);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementMatchText != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMatchText);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementType != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementType);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                {
                    if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMinimumWidth);
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
                        browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMinimumHeight);
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
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft);
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
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight);
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
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop);
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
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom);
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
                        browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserGetElementScreenBoundingRect["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectworkflow);
                if (browserGetElementScreenBoundingRectpropCount > 0)
                {
                    callPayload.Body = browserGetElementScreenBoundingRect;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFocusElement([WorkflowExpression] Func<string> browserFocusElementworkflow, [WorkflowExpression] Func<double> browserFocusElementparentElementHandle = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementName = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementID = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserFocusElementsearchElementType = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserFocusElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserFocusElementworkflow, nameof(browserFocusElementworkflow), required: true);
            SourceExpression.Validate(browserFocusElementparentElementHandle, nameof(browserFocusElementparentElementHandle), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementHandle, nameof(browserFocusElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementName, nameof(browserFocusElementsearchElementName), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementID, nameof(browserFocusElementsearchElementID), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementTagName, nameof(browserFocusElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementXPath, nameof(browserFocusElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementClassName, nameof(browserFocusElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementCSSSelector, nameof(browserFocusElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementIndex, nameof(browserFocusElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementMatchValue, nameof(browserFocusElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementMatchText, nameof(browserFocusElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementType, nameof(browserFocusElementsearchElementType), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementMinimumWidth, nameof(browserFocusElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementMinimumHeight, nameof(browserFocusElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementBoundingBoxLeft, nameof(browserFocusElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementBoundingBoxRight, nameof(browserFocusElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementBoundingBoxTop, nameof(browserFocusElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserFocusElementsearchElementBoundingBoxBottom, nameof(browserFocusElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserFocusElement = new JObject();
                var browserFocusElementpropCount = 0;
                if (browserFocusElementparentElementHandle != null)
                {
                    browserFocusElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserFocusElementparentElementHandle);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementHandle != null)
                {
                    browserFocusElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementHandle);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementName != null)
                {
                    browserFocusElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementName);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementID != null)
                {
                    browserFocusElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementID);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementTagName != null)
                {
                    browserFocusElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementTagName);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementXPath != null)
                {
                    browserFocusElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementXPath);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementClassName != null)
                {
                    browserFocusElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementClassName);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementCSSSelector != null)
                {
                    browserFocusElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementCSSSelector);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementIndex != null)
                {
                    if (browserFocusElementsearchElementIndex != null)
                    {
                        browserFocusElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementIndex);
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
                    browserFocusElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementMatchValue);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementMatchText != null)
                {
                    browserFocusElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementMatchText);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementType != null)
                {
                    browserFocusElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementType);
                    browserFocusElementpropCount++;
                }

                if (browserFocusElementsearchElementMinimumWidth != null)
                {
                    if (browserFocusElementsearchElementMinimumWidth != null)
                    {
                        browserFocusElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementMinimumWidth);
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
                        browserFocusElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementMinimumHeight);
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
                        browserFocusElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxLeft);
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
                        browserFocusElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxRight);
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
                        browserFocusElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxTop);
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
                        browserFocusElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxBottom);
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
                        browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserFocusElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserFocusElementworkflow);
                if (browserFocusElementpropCount > 0)
                {
                    callPayload.Body = browserFocusElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressEnterOnElement([WorkflowExpression] Func<string> browserPressEnterOnElementworkflow, [WorkflowExpression] Func<double> browserPressEnterOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserPressEnterOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserPressEnterOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserPressEnterOnElementworkflow, nameof(browserPressEnterOnElementworkflow), required: true);
            SourceExpression.Validate(browserPressEnterOnElementparentElementHandle, nameof(browserPressEnterOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementHandle, nameof(browserPressEnterOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementName, nameof(browserPressEnterOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementID, nameof(browserPressEnterOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementTagName, nameof(browserPressEnterOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementXPath, nameof(browserPressEnterOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementClassName, nameof(browserPressEnterOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementCSSSelector, nameof(browserPressEnterOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementIndex, nameof(browserPressEnterOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementMatchValue, nameof(browserPressEnterOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementMatchText, nameof(browserPressEnterOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementType, nameof(browserPressEnterOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementMinimumWidth, nameof(browserPressEnterOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementMinimumHeight, nameof(browserPressEnterOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxLeft, nameof(browserPressEnterOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxRight, nameof(browserPressEnterOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxTop, nameof(browserPressEnterOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserPressEnterOnElementsearchElementBoundingBoxBottom, nameof(browserPressEnterOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/PressEnterOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPressEnterOnElement = new JObject();
                var browserPressEnterOnElementpropCount = 0;
                if (browserPressEnterOnElementparentElementHandle != null)
                {
                    browserPressEnterOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementparentElementHandle);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementHandle != null)
                {
                    browserPressEnterOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementHandle);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementName != null)
                {
                    browserPressEnterOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementName);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementID != null)
                {
                    browserPressEnterOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementID);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementTagName != null)
                {
                    browserPressEnterOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementTagName);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementXPath != null)
                {
                    browserPressEnterOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementXPath);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementClassName != null)
                {
                    browserPressEnterOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementClassName);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementCSSSelector != null)
                {
                    browserPressEnterOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementCSSSelector);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementIndex != null)
                {
                    if (browserPressEnterOnElementsearchElementIndex != null)
                    {
                        browserPressEnterOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementIndex);
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
                    browserPressEnterOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMatchValue);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementMatchText != null)
                {
                    browserPressEnterOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMatchText);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementType != null)
                {
                    browserPressEnterOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementType);
                    browserPressEnterOnElementpropCount++;
                }

                if (browserPressEnterOnElementsearchElementMinimumWidth != null)
                {
                    if (browserPressEnterOnElementsearchElementMinimumWidth != null)
                    {
                        browserPressEnterOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMinimumWidth);
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
                        browserPressEnterOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMinimumHeight);
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
                        browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxLeft);
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
                        browserPressEnterOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxRight);
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
                        browserPressEnterOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxTop);
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
                        browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxBottom);
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
                        browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserPressEnterOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserPressEnterOnElementworkflow);
                if (browserPressEnterOnElementpropCount > 0)
                {
                    callPayload.Body = browserPressEnterOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseLeftClickOnElement([WorkflowExpression] Func<string> browserMouseLeftClickOnElementworkflow, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserMouseLeftClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserMouseLeftClickOnElementfocusFirst = null)
        {
            SourceExpression.Validate(browserMouseLeftClickOnElementworkflow, nameof(browserMouseLeftClickOnElementworkflow), required: true);
            SourceExpression.Validate(browserMouseLeftClickOnElementparentElementHandle, nameof(browserMouseLeftClickOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementHandle, nameof(browserMouseLeftClickOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementName, nameof(browserMouseLeftClickOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementID, nameof(browserMouseLeftClickOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementTagName, nameof(browserMouseLeftClickOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementXPath, nameof(browserMouseLeftClickOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementClassName, nameof(browserMouseLeftClickOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementCSSSelector, nameof(browserMouseLeftClickOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementIndex, nameof(browserMouseLeftClickOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementMatchValue, nameof(browserMouseLeftClickOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementMatchText, nameof(browserMouseLeftClickOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementType, nameof(browserMouseLeftClickOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementMinimumWidth, nameof(browserMouseLeftClickOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementMinimumHeight, nameof(browserMouseLeftClickOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxRight, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxTop, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserMouseLeftClickOnElementfocusFirst, nameof(browserMouseLeftClickOnElementfocusFirst), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMouseLeftClickOnElement = new JObject();
                var browserMouseLeftClickOnElementpropCount = 0;
                if (browserMouseLeftClickOnElementparentElementHandle != null)
                {
                    browserMouseLeftClickOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementparentElementHandle);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementHandle != null)
                {
                    browserMouseLeftClickOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementHandle);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementID != null)
                {
                    browserMouseLeftClickOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementID);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementTagName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementTagName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementXPath != null)
                {
                    browserMouseLeftClickOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementXPath);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementClassName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementClassName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementCSSSelector != null)
                {
                    browserMouseLeftClickOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementCSSSelector);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementIndex != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementIndex != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementIndex);
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
                    browserMouseLeftClickOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMatchValue);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementMatchText != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMatchText);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementType != null)
                {
                    browserMouseLeftClickOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementType);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMinimumWidth);
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
                        browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMinimumHeight);
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
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft);
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
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxRight);
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
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxTop);
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
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom);
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
                        browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserMouseLeftClickOnElement["FocusFirst"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementfocusFirst);
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
                browserMouseLeftClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserMouseLeftClickOnElementworkflow);
                if (browserMouseLeftClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserMouseLeftClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseRightClickOnElement([WorkflowExpression] Func<string> browserMouseRightClickOnElementworkflow, [WorkflowExpression] Func<double> browserMouseRightClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserMouseRightClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserMouseRightClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserMouseRightClickOnElementfocusFirst = null)
        {
            SourceExpression.Validate(browserMouseRightClickOnElementworkflow, nameof(browserMouseRightClickOnElementworkflow), required: true);
            SourceExpression.Validate(browserMouseRightClickOnElementparentElementHandle, nameof(browserMouseRightClickOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementHandle, nameof(browserMouseRightClickOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementName, nameof(browserMouseRightClickOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementID, nameof(browserMouseRightClickOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementTagName, nameof(browserMouseRightClickOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementXPath, nameof(browserMouseRightClickOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementClassName, nameof(browserMouseRightClickOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementCSSSelector, nameof(browserMouseRightClickOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementIndex, nameof(browserMouseRightClickOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementMatchValue, nameof(browserMouseRightClickOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementMatchText, nameof(browserMouseRightClickOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementType, nameof(browserMouseRightClickOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementMinimumWidth, nameof(browserMouseRightClickOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementMinimumHeight, nameof(browserMouseRightClickOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxLeft, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxRight, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxTop, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementsearchElementBoundingBoxBottom, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserMouseRightClickOnElementfocusFirst, nameof(browserMouseRightClickOnElementfocusFirst), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMouseRightClickOnElement = new JObject();
                var browserMouseRightClickOnElementpropCount = 0;
                if (browserMouseRightClickOnElementparentElementHandle != null)
                {
                    browserMouseRightClickOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementparentElementHandle);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementHandle != null)
                {
                    browserMouseRightClickOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementHandle);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementName != null)
                {
                    browserMouseRightClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementID != null)
                {
                    browserMouseRightClickOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementID);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementTagName != null)
                {
                    browserMouseRightClickOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementTagName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementXPath != null)
                {
                    browserMouseRightClickOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementXPath);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementClassName != null)
                {
                    browserMouseRightClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementClassName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementCSSSelector != null)
                {
                    browserMouseRightClickOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementCSSSelector);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementIndex != null)
                {
                    if (browserMouseRightClickOnElementsearchElementIndex != null)
                    {
                        browserMouseRightClickOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementIndex);
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
                    browserMouseRightClickOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMatchValue);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementMatchText != null)
                {
                    browserMouseRightClickOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMatchText);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementType != null)
                {
                    browserMouseRightClickOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementType);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserMouseRightClickOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMinimumWidth);
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
                        browserMouseRightClickOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMinimumHeight);
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
                        browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxLeft);
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
                        browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxRight);
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
                        browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxTop);
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
                        browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxBottom);
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
                        browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                        browserMouseRightClickOnElement["FocusFirst"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementfocusFirst);
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
                browserMouseRightClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserMouseRightClickOnElementworkflow);
                if (browserMouseRightClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserMouseRightClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserJavaScriptClickOnElement([WorkflowExpression] Func<string> browserJavaScriptClickOnElementworkflow, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserJavaScriptClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserJavaScriptClickOnElementworkflow, nameof(browserJavaScriptClickOnElementworkflow), required: true);
            SourceExpression.Validate(browserJavaScriptClickOnElementparentElementHandle, nameof(browserJavaScriptClickOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementHandle, nameof(browserJavaScriptClickOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementName, nameof(browserJavaScriptClickOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementID, nameof(browserJavaScriptClickOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementTagName, nameof(browserJavaScriptClickOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementXPath, nameof(browserJavaScriptClickOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementClassName, nameof(browserJavaScriptClickOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementCSSSelector, nameof(browserJavaScriptClickOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementIndex, nameof(browserJavaScriptClickOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementMatchValue, nameof(browserJavaScriptClickOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementMatchText, nameof(browserJavaScriptClickOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementType, nameof(browserJavaScriptClickOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementMinimumWidth, nameof(browserJavaScriptClickOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementMinimumHeight, nameof(browserJavaScriptClickOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxRight, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxTop, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserJavaScriptClickOnElement = new JObject();
                var browserJavaScriptClickOnElementpropCount = 0;
                if (browserJavaScriptClickOnElementparentElementHandle != null)
                {
                    browserJavaScriptClickOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementparentElementHandle);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementHandle != null)
                {
                    browserJavaScriptClickOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementHandle);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementID != null)
                {
                    browserJavaScriptClickOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementID);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementTagName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementTagName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementXPath != null)
                {
                    browserJavaScriptClickOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementXPath);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementClassName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementClassName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementCSSSelector != null)
                {
                    browserJavaScriptClickOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementCSSSelector);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementIndex != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementIndex != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementIndex);
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
                    browserJavaScriptClickOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMatchValue);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementMatchText != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMatchText);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementType != null)
                {
                    browserJavaScriptClickOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementType);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMinimumWidth);
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
                        browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMinimumHeight);
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
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft);
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
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxRight);
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
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxTop);
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
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom);
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
                        browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserJavaScriptClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserJavaScriptClickOnElementworkflow);
                if (browserJavaScriptClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserJavaScriptClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> BrowserExecuteJavaScriptOnElement([WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementjavaScriptToExecute, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementworkflow, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserExecuteJavaScriptOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserExecuteJavaScriptOnElementjavaScriptToExecute, nameof(browserExecuteJavaScriptOnElementjavaScriptToExecute), required: true);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementworkflow, nameof(browserExecuteJavaScriptOnElementworkflow), required: true);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementparentElementHandle, nameof(browserExecuteJavaScriptOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementHandle, nameof(browserExecuteJavaScriptOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementName, nameof(browserExecuteJavaScriptOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementID, nameof(browserExecuteJavaScriptOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementTagName, nameof(browserExecuteJavaScriptOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementXPath, nameof(browserExecuteJavaScriptOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementClassName, nameof(browserExecuteJavaScriptOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementCSSSelector, nameof(browserExecuteJavaScriptOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementIndex, nameof(browserExecuteJavaScriptOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMatchValue, nameof(browserExecuteJavaScriptOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMatchText, nameof(browserExecuteJavaScriptOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementType, nameof(browserExecuteJavaScriptOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMinimumWidth, nameof(browserExecuteJavaScriptOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementMinimumHeight, nameof(browserExecuteJavaScriptOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserExecuteJavaScriptOnElement = new JObject();
                var browserExecuteJavaScriptOnElementpropCount = 0;
                if (browserExecuteJavaScriptOnElementparentElementHandle != null)
                {
                    browserExecuteJavaScriptOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementparentElementHandle);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementHandle != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementHandle);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementID != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementID);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementTagName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementTagName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementXPath != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementXPath);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementClassName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementClassName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementCSSSelector != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementCSSSelector);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementIndex);
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
                    browserExecuteJavaScriptOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMatchValue);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementMatchText != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMatchText);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementType != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementType);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                {
                    if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMinimumWidth);
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
                        browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMinimumHeight);
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
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft);
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
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight);
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
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop);
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
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom);
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
                        browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserExecuteJavaScriptOnElement["JavaScriptToExecute"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementjavaScriptToExecute);
                browserExecuteJavaScriptOnElementpropCount++;
                browserExecuteJavaScriptOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementworkflow);
                if (browserExecuteJavaScriptOnElementpropCount > 0)
                {
                    callPayload.Body = browserExecuteJavaScriptOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseLeftClickOnElement([WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementworkflow, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGlobalMouseLeftClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<int> browserGlobalMouseLeftClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> browserGlobalMouseLeftClickOnElementclickOffsetY = null, [WorkflowExpression] Func<bool> browserGlobalMouseLeftClickOnElementfocusFirst = null)
        {
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementworkflow, nameof(browserGlobalMouseLeftClickOnElementworkflow), required: true);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementparentElementHandle, nameof(browserGlobalMouseLeftClickOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementHandle, nameof(browserGlobalMouseLeftClickOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementName, nameof(browserGlobalMouseLeftClickOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementID, nameof(browserGlobalMouseLeftClickOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementTagName, nameof(browserGlobalMouseLeftClickOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementXPath, nameof(browserGlobalMouseLeftClickOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementClassName, nameof(browserGlobalMouseLeftClickOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector, nameof(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementIndex, nameof(browserGlobalMouseLeftClickOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMatchValue, nameof(browserGlobalMouseLeftClickOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMatchText, nameof(browserGlobalMouseLeftClickOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementType, nameof(browserGlobalMouseLeftClickOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth, nameof(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight, nameof(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementclickOffsetX, nameof(browserGlobalMouseLeftClickOnElementclickOffsetX), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementclickOffsetY, nameof(browserGlobalMouseLeftClickOnElementclickOffsetY), required: false);
            SourceExpression.Validate(browserGlobalMouseLeftClickOnElementfocusFirst, nameof(browserGlobalMouseLeftClickOnElementfocusFirst), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGlobalMouseLeftClickOnElement = new JObject();
                var browserGlobalMouseLeftClickOnElementpropCount = 0;
                if (browserGlobalMouseLeftClickOnElementparentElementHandle != null)
                {
                    browserGlobalMouseLeftClickOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementparentElementHandle);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementHandle != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementHandle);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementID != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementID);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementTagName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementTagName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementXPath != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementXPath);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementClassName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementClassName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementCSSSelector != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementIndex);
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
                    browserGlobalMouseLeftClickOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMatchValue);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementMatchText != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMatchText);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementType != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementType);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth);
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
                        browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight);
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
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft);
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
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight);
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
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop);
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
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom);
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
                        browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                    browserGlobalMouseLeftClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementclickOffsetX);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementclickOffsetY != null)
                {
                    browserGlobalMouseLeftClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementclickOffsetY);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
                {
                    if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
                    {
                        browserGlobalMouseLeftClickOnElement["FocusFirst"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementfocusFirst);
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
                browserGlobalMouseLeftClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementworkflow);
                if (browserGlobalMouseLeftClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserGlobalMouseLeftClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseRightClickOnElement([WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementworkflow, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserGlobalMouseRightClickOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<int> browserGlobalMouseRightClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> browserGlobalMouseRightClickOnElementclickOffsetY = null, [WorkflowExpression] Func<bool> browserGlobalMouseRightClickOnElementfocusFirst = null)
        {
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementworkflow, nameof(browserGlobalMouseRightClickOnElementworkflow), required: true);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementparentElementHandle, nameof(browserGlobalMouseRightClickOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementHandle, nameof(browserGlobalMouseRightClickOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementName, nameof(browserGlobalMouseRightClickOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementID, nameof(browserGlobalMouseRightClickOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementTagName, nameof(browserGlobalMouseRightClickOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementXPath, nameof(browserGlobalMouseRightClickOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementClassName, nameof(browserGlobalMouseRightClickOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementCSSSelector, nameof(browserGlobalMouseRightClickOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementIndex, nameof(browserGlobalMouseRightClickOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMatchValue, nameof(browserGlobalMouseRightClickOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMatchText, nameof(browserGlobalMouseRightClickOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementType, nameof(browserGlobalMouseRightClickOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth, nameof(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight, nameof(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementclickOffsetX, nameof(browserGlobalMouseRightClickOnElementclickOffsetX), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementclickOffsetY, nameof(browserGlobalMouseRightClickOnElementclickOffsetY), required: false);
            SourceExpression.Validate(browserGlobalMouseRightClickOnElementfocusFirst, nameof(browserGlobalMouseRightClickOnElementfocusFirst), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGlobalMouseRightClickOnElement = new JObject();
                var browserGlobalMouseRightClickOnElementpropCount = 0;
                if (browserGlobalMouseRightClickOnElementparentElementHandle != null)
                {
                    browserGlobalMouseRightClickOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementparentElementHandle);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementHandle != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementHandle);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementID != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementID);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementTagName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementTagName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementXPath != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementXPath);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementClassName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementClassName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementCSSSelector != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementCSSSelector);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementIndex);
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
                    browserGlobalMouseRightClickOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMatchValue);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementMatchText != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMatchText);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementType != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementType);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth);
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
                        browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight);
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
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft);
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
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight);
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
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop);
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
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom);
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
                        browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                    browserGlobalMouseRightClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementclickOffsetX);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementclickOffsetY != null)
                {
                    browserGlobalMouseRightClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementclickOffsetY);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (browserGlobalMouseRightClickOnElementfocusFirst != null)
                {
                    if (browserGlobalMouseRightClickOnElementfocusFirst != null)
                    {
                        browserGlobalMouseRightClickOnElement["FocusFirst"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementfocusFirst);
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
                browserGlobalMouseRightClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementworkflow);
                if (browserGlobalMouseRightClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserGlobalMouseRightClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> BrowserOpenNewTab([WorkflowExpression] Func<string> browserOpenNewTabworkflow, [WorkflowExpression] Func<string> browserOpenNewTabuRL = null, [WorkflowExpression] Func<bool> browserOpenNewTabswitchControlToNewTab = null)
        {
            SourceExpression.Validate(browserOpenNewTabworkflow, nameof(browserOpenNewTabworkflow), required: true);
            SourceExpression.Validate(browserOpenNewTabuRL, nameof(browserOpenNewTabuRL), required: false);
            SourceExpression.Validate(browserOpenNewTabswitchControlToNewTab, nameof(browserOpenNewTabswitchControlToNewTab), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/OpenNewTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenNewTab = new JObject();
                var browserOpenNewTabpropCount = 0;
                if (browserOpenNewTabuRL != null)
                {
                    browserOpenNewTab["URL"] = SourceExpressionConverter.ConvertToken(browserOpenNewTabuRL);
                    browserOpenNewTabpropCount++;
                }

                if (browserOpenNewTabswitchControlToNewTab != null)
                {
                    if (browserOpenNewTabswitchControlToNewTab != null)
                    {
                        browserOpenNewTab["SwitchControlToNewTab"] = SourceExpressionConverter.ConvertToken(browserOpenNewTabswitchControlToNewTab);
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
                browserOpenNewTab["Workflow"] = SourceExpressionConverter.ConvertToken(browserOpenNewTabworkflow);
                if (browserOpenNewTabpropCount > 0)
                {
                    callPayload.Body = browserOpenNewTab;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserOpenNewTabResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTabsResponse> BrowserGetTabs([WorkflowExpression] Func<string> browserGetTabsworkflow)
        {
            SourceExpression.Validate(browserGetTabsworkflow, nameof(browserGetTabsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetTabs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetTabs = new JObject();
                var browserGetTabspropCount = 0;
                browserGetTabspropCount++;
                browserGetTabs["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetTabsworkflow);
                if (browserGetTabspropCount > 0)
                {
                    callPayload.Body = browserGetTabs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetTabsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTab([WorkflowExpression] Func<string> browserSetTabworkflow, [WorkflowExpression] Func<string> browserSetTabtabName = null, [WorkflowExpression] Func<int> browserSetTabtabIndex = null)
        {
            SourceExpression.Validate(browserSetTabworkflow, nameof(browserSetTabworkflow), required: true);
            SourceExpression.Validate(browserSetTabtabName, nameof(browserSetTabtabName), required: false);
            SourceExpression.Validate(browserSetTabtabIndex, nameof(browserSetTabtabIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SetTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetTab = new JObject();
                var browserSetTabpropCount = 0;
                if (browserSetTabtabName != null)
                {
                    browserSetTab["TabName"] = SourceExpressionConverter.ConvertToken(browserSetTabtabName);
                    browserSetTabpropCount++;
                }

                if (browserSetTabtabIndex != null)
                {
                    browserSetTab["TabIndex"] = SourceExpressionConverter.ConvertToken(browserSetTabtabIndex);
                    browserSetTabpropCount++;
                }

                browserSetTabpropCount++;
                browserSetTab["Workflow"] = SourceExpressionConverter.ConvertToken(browserSetTabworkflow);
                if (browserSetTabpropCount > 0)
                {
                    callPayload.Body = browserSetTab;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseActiveTab([WorkflowExpression] Func<string> browserCloseActiveTabworkflow)
        {
            SourceExpression.Validate(browserCloseActiveTabworkflow, nameof(browserCloseActiveTabworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/CloseActiveTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseActiveTab = new JObject();
                var browserCloseActiveTabpropCount = 0;
                browserCloseActiveTabpropCount++;
                browserCloseActiveTab["Workflow"] = SourceExpressionConverter.ConvertToken(browserCloseActiveTabworkflow);
                if (browserCloseActiveTabpropCount > 0)
                {
                    callPayload.Body = browserCloseActiveTab;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSavePageToFile([WorkflowExpression] Func<string> browserSavePageToFilesaveFilename, [WorkflowExpression] Func<string> browserSavePageToFileworkflow)
        {
            SourceExpression.Validate(browserSavePageToFilesaveFilename, nameof(browserSavePageToFilesaveFilename), required: true);
            SourceExpression.Validate(browserSavePageToFileworkflow, nameof(browserSavePageToFileworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SavePageToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSavePageToFile = new JObject();
                var browserSavePageToFilepropCount = 0;
                browserSavePageToFilepropCount++;
                browserSavePageToFile["SaveFilename"] = SourceExpressionConverter.ConvertToken(browserSavePageToFilesaveFilename);
                browserSavePageToFilepropCount++;
                browserSavePageToFile["Workflow"] = SourceExpressionConverter.ConvertToken(browserSavePageToFileworkflow);
                if (browserSavePageToFilepropCount > 0)
                {
                    callPayload.Body = browserSavePageToFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> BrowserGetPageText([WorkflowExpression] Func<string> browserGetPageTextworkflow)
        {
            SourceExpression.Validate(browserGetPageTextworkflow, nameof(browserGetPageTextworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetPageText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetPageText = new JObject();
                var browserGetPageTextpropCount = 0;
                browserGetPageTextpropCount++;
                browserGetPageText["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetPageTextworkflow);
                if (browserGetPageTextpropCount > 0)
                {
                    callPayload.Body = browserGetPageText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetPageTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToFrameElement([WorkflowExpression] Func<string> browserSwitchToFrameElementworkflow, [WorkflowExpression] Func<double> browserSwitchToFrameElementparentElementHandle = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementName = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementID = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSwitchToFrameElementsearchElementType = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSwitchToFrameElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserSwitchToFrameElementworkflow, nameof(browserSwitchToFrameElementworkflow), required: true);
            SourceExpression.Validate(browserSwitchToFrameElementparentElementHandle, nameof(browserSwitchToFrameElementparentElementHandle), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementHandle, nameof(browserSwitchToFrameElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementName, nameof(browserSwitchToFrameElementsearchElementName), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementID, nameof(browserSwitchToFrameElementsearchElementID), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementTagName, nameof(browserSwitchToFrameElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementXPath, nameof(browserSwitchToFrameElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementClassName, nameof(browserSwitchToFrameElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementCSSSelector, nameof(browserSwitchToFrameElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementIndex, nameof(browserSwitchToFrameElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementMatchValue, nameof(browserSwitchToFrameElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementMatchText, nameof(browserSwitchToFrameElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementType, nameof(browserSwitchToFrameElementsearchElementType), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementMinimumWidth, nameof(browserSwitchToFrameElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementMinimumHeight, nameof(browserSwitchToFrameElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxLeft, nameof(browserSwitchToFrameElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxRight, nameof(browserSwitchToFrameElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxTop, nameof(browserSwitchToFrameElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementsearchElementBoundingBoxBottom, nameof(browserSwitchToFrameElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SwitchToFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToFrameElement = new JObject();
                var browserSwitchToFrameElementpropCount = 0;
                if (browserSwitchToFrameElementparentElementHandle != null)
                {
                    browserSwitchToFrameElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementparentElementHandle);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementHandle != null)
                {
                    browserSwitchToFrameElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementHandle);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementName != null)
                {
                    browserSwitchToFrameElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementID != null)
                {
                    browserSwitchToFrameElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementID);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementTagName != null)
                {
                    browserSwitchToFrameElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementTagName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementXPath != null)
                {
                    browserSwitchToFrameElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementXPath);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementClassName != null)
                {
                    browserSwitchToFrameElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementClassName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementCSSSelector != null)
                {
                    browserSwitchToFrameElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementCSSSelector);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementIndex != null)
                {
                    if (browserSwitchToFrameElementsearchElementIndex != null)
                    {
                        browserSwitchToFrameElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementIndex);
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
                    browserSwitchToFrameElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMatchValue);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementMatchText != null)
                {
                    browserSwitchToFrameElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMatchText);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementType != null)
                {
                    browserSwitchToFrameElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementType);
                    browserSwitchToFrameElementpropCount++;
                }

                if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
                {
                    if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
                    {
                        browserSwitchToFrameElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMinimumWidth);
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
                        browserSwitchToFrameElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMinimumHeight);
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
                        browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxLeft);
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
                        browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxRight);
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
                        browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxTop);
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
                        browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxBottom);
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
                        browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserSwitchToFrameElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserSwitchToFrameElementworkflow);
                if (browserSwitchToFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToFrameElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> BrowserGetCurrentFrameWindowPixelCoordinate([WorkflowExpression] Func<string> browserGetCurrentFrameWindowPixelCoordinateworkflow)
        {
            SourceExpression.Validate(browserGetCurrentFrameWindowPixelCoordinateworkflow, nameof(browserGetCurrentFrameWindowPixelCoordinateworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetCurrentFrameWindowPixelCoordinate = new JObject();
                var browserGetCurrentFrameWindowPixelCoordinatepropCount = 0;
                browserGetCurrentFrameWindowPixelCoordinatepropCount++;
                browserGetCurrentFrameWindowPixelCoordinate["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetCurrentFrameWindowPixelCoordinateworkflow);
                if (browserGetCurrentFrameWindowPixelCoordinatepropCount > 0)
                {
                    callPayload.Body = browserGetCurrentFrameWindowPixelCoordinate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToParentFrameElement([WorkflowExpression] Func<string> browserSwitchToParentFrameElementworkflow)
        {
            SourceExpression.Validate(browserSwitchToParentFrameElementworkflow, nameof(browserSwitchToParentFrameElementworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToParentFrameElement = new JObject();
                var browserSwitchToParentFrameElementpropCount = 0;
                browserSwitchToParentFrameElementpropCount++;
                browserSwitchToParentFrameElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserSwitchToParentFrameElementworkflow);
                if (browserSwitchToParentFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToParentFrameElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToRootFrameElement([WorkflowExpression] Func<string> browserSwitchToRootFrameElementworkflow)
        {
            SourceExpression.Validate(browserSwitchToRootFrameElementworkflow, nameof(browserSwitchToRootFrameElementworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToRootFrameElement = new JObject();
                var browserSwitchToRootFrameElementpropCount = 0;
                browserSwitchToRootFrameElementpropCount++;
                browserSwitchToRootFrameElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserSwitchToRootFrameElementworkflow);
                if (browserSwitchToRootFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToRootFrameElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetFrameStack([WorkflowExpression] Func<string> browserResetFrameStackworkflow)
        {
            SourceExpression.Validate(browserResetFrameStackworkflow, nameof(browserResetFrameStackworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ResetFrameStack";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserResetFrameStack = new JObject();
                var browserResetFrameStackpropCount = 0;
                browserResetFrameStackpropCount++;
                browserResetFrameStack["Workflow"] = SourceExpressionConverter.ConvertToken(browserResetFrameStackworkflow);
                if (browserResetFrameStackpropCount > 0)
                {
                    callPayload.Body = browserResetFrameStack;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> BrowserClearElementText([WorkflowExpression] Func<string> browserClearElementTextworkflow, [WorkflowExpression] Func<double> browserClearElementTextparentElementHandle = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementHandle = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementName = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementID = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementTagName = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementXPath = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementClassName = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementIndex = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementMatchText = null, [WorkflowExpression] Func<string> browserClearElementTextsearchElementType = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserClearElementTextsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserClearElementTextworkflow, nameof(browserClearElementTextworkflow), required: true);
            SourceExpression.Validate(browserClearElementTextparentElementHandle, nameof(browserClearElementTextparentElementHandle), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementHandle, nameof(browserClearElementTextsearchElementHandle), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementName, nameof(browserClearElementTextsearchElementName), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementID, nameof(browserClearElementTextsearchElementID), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementTagName, nameof(browserClearElementTextsearchElementTagName), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementXPath, nameof(browserClearElementTextsearchElementXPath), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementClassName, nameof(browserClearElementTextsearchElementClassName), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementCSSSelector, nameof(browserClearElementTextsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementIndex, nameof(browserClearElementTextsearchElementIndex), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementMatchValue, nameof(browserClearElementTextsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementMatchText, nameof(browserClearElementTextsearchElementMatchText), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementType, nameof(browserClearElementTextsearchElementType), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementMinimumWidth, nameof(browserClearElementTextsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementMinimumHeight, nameof(browserClearElementTextsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementBoundingBoxLeft, nameof(browserClearElementTextsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementBoundingBoxRight, nameof(browserClearElementTextsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementBoundingBoxTop, nameof(browserClearElementTextsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserClearElementTextsearchElementBoundingBoxBottom, nameof(browserClearElementTextsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ClearElementText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserClearElementText = new JObject();
                var browserClearElementTextpropCount = 0;
                if (browserClearElementTextparentElementHandle != null)
                {
                    browserClearElementText["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserClearElementTextparentElementHandle);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementHandle != null)
                {
                    browserClearElementText["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementHandle);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementName != null)
                {
                    browserClearElementText["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementName);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementID != null)
                {
                    browserClearElementText["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementID);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementTagName != null)
                {
                    browserClearElementText["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementTagName);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementXPath != null)
                {
                    browserClearElementText["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementXPath);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementClassName != null)
                {
                    browserClearElementText["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementClassName);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementCSSSelector != null)
                {
                    browserClearElementText["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementCSSSelector);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementIndex != null)
                {
                    if (browserClearElementTextsearchElementIndex != null)
                    {
                        browserClearElementText["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementIndex);
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
                    browserClearElementText["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementMatchValue);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementMatchText != null)
                {
                    browserClearElementText["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementMatchText);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementType != null)
                {
                    browserClearElementText["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementType);
                    browserClearElementTextpropCount++;
                }

                if (browserClearElementTextsearchElementMinimumWidth != null)
                {
                    if (browserClearElementTextsearchElementMinimumWidth != null)
                    {
                        browserClearElementText["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementMinimumWidth);
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
                        browserClearElementText["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementMinimumHeight);
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
                        browserClearElementText["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxLeft);
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
                        browserClearElementText["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxRight);
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
                        browserClearElementText["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxTop);
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
                        browserClearElementText["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxBottom);
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
                        browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserClearElementText["Workflow"] = SourceExpressionConverter.ConvertToken(browserClearElementTextworkflow);
                if (browserClearElementTextpropCount > 0)
                {
                    callPayload.Body = browserClearElementText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserClearElementTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCopySelectedTextOnElement([WorkflowExpression] Func<string> browserCopySelectedTextOnElementworkflow, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserCopySelectedTextOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserCopySelectedTextOnElementworkflow, nameof(browserCopySelectedTextOnElementworkflow), required: true);
            SourceExpression.Validate(browserCopySelectedTextOnElementparentElementHandle, nameof(browserCopySelectedTextOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementHandle, nameof(browserCopySelectedTextOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementName, nameof(browserCopySelectedTextOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementID, nameof(browserCopySelectedTextOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementTagName, nameof(browserCopySelectedTextOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementXPath, nameof(browserCopySelectedTextOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementClassName, nameof(browserCopySelectedTextOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementCSSSelector, nameof(browserCopySelectedTextOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementIndex, nameof(browserCopySelectedTextOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementMatchValue, nameof(browserCopySelectedTextOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementMatchText, nameof(browserCopySelectedTextOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementType, nameof(browserCopySelectedTextOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementMinimumWidth, nameof(browserCopySelectedTextOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementMinimumHeight, nameof(browserCopySelectedTextOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxRight, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxTop, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCopySelectedTextOnElement = new JObject();
                var browserCopySelectedTextOnElementpropCount = 0;
                if (browserCopySelectedTextOnElementparentElementHandle != null)
                {
                    browserCopySelectedTextOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementparentElementHandle);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementHandle != null)
                {
                    browserCopySelectedTextOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementHandle);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementID != null)
                {
                    browserCopySelectedTextOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementID);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementTagName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementTagName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementXPath != null)
                {
                    browserCopySelectedTextOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementXPath);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementClassName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementClassName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementCSSSelector != null)
                {
                    browserCopySelectedTextOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementCSSSelector);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementIndex != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementIndex != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementIndex);
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
                    browserCopySelectedTextOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMatchValue);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementMatchText != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMatchText);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementType != null)
                {
                    browserCopySelectedTextOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementType);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                {
                    if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMinimumWidth);
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
                        browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMinimumHeight);
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
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft);
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
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxRight);
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
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxTop);
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
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom);
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
                        browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserCopySelectedTextOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserCopySelectedTextOnElementworkflow);
                if (browserCopySelectedTextOnElementpropCount > 0)
                {
                    callPayload.Body = browserCopySelectedTextOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputPasswordIntoElement([WorkflowExpression] Func<string> browserInputPasswordIntoElementpasswordToInput, [WorkflowExpression] Func<string> browserInputPasswordIntoElementworkflow, [WorkflowExpression] Func<double> browserInputPasswordIntoElementparentElementHandle = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementName = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementID = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserInputPasswordIntoElementsearchElementType = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserInputPasswordIntoElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserInputPasswordIntoElementresetExistingValue = null, [WorkflowExpression] Func<bool> browserInputPasswordIntoElementpasswordContainsStoredPassword = null)
        {
            SourceExpression.Validate(browserInputPasswordIntoElementpasswordToInput, nameof(browserInputPasswordIntoElementpasswordToInput), required: true);
            SourceExpression.Validate(browserInputPasswordIntoElementworkflow, nameof(browserInputPasswordIntoElementworkflow), required: true);
            SourceExpression.Validate(browserInputPasswordIntoElementparentElementHandle, nameof(browserInputPasswordIntoElementparentElementHandle), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementHandle, nameof(browserInputPasswordIntoElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementName, nameof(browserInputPasswordIntoElementsearchElementName), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementID, nameof(browserInputPasswordIntoElementsearchElementID), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementTagName, nameof(browserInputPasswordIntoElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementXPath, nameof(browserInputPasswordIntoElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementClassName, nameof(browserInputPasswordIntoElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementCSSSelector, nameof(browserInputPasswordIntoElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementIndex, nameof(browserInputPasswordIntoElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementMatchValue, nameof(browserInputPasswordIntoElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementMatchText, nameof(browserInputPasswordIntoElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementType, nameof(browserInputPasswordIntoElementsearchElementType), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementMinimumWidth, nameof(browserInputPasswordIntoElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementMinimumHeight, nameof(browserInputPasswordIntoElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxLeft, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxRight, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxTop, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementsearchElementBoundingBoxBottom, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementresetExistingValue, nameof(browserInputPasswordIntoElementresetExistingValue), required: false);
            SourceExpression.Validate(browserInputPasswordIntoElementpasswordContainsStoredPassword, nameof(browserInputPasswordIntoElementpasswordContainsStoredPassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputPasswordIntoElement = new JObject();
                var browserInputPasswordIntoElementpropCount = 0;
                if (browserInputPasswordIntoElementparentElementHandle != null)
                {
                    browserInputPasswordIntoElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementparentElementHandle);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementHandle != null)
                {
                    browserInputPasswordIntoElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementHandle);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementName != null)
                {
                    browserInputPasswordIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementID != null)
                {
                    browserInputPasswordIntoElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementID);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementTagName != null)
                {
                    browserInputPasswordIntoElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementTagName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementXPath != null)
                {
                    browserInputPasswordIntoElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementXPath);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementClassName != null)
                {
                    browserInputPasswordIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementClassName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementCSSSelector != null)
                {
                    browserInputPasswordIntoElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementCSSSelector);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementIndex != null)
                {
                    if (browserInputPasswordIntoElementsearchElementIndex != null)
                    {
                        browserInputPasswordIntoElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementIndex);
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
                    browserInputPasswordIntoElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMatchValue);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementMatchText != null)
                {
                    browserInputPasswordIntoElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMatchText);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementType != null)
                {
                    browserInputPasswordIntoElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementType);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                {
                    if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                    {
                        browserInputPasswordIntoElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMinimumWidth);
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
                        browserInputPasswordIntoElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMinimumHeight);
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
                        browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxLeft);
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
                        browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxRight);
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
                        browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxTop);
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
                        browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxBottom);
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
                        browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserInputPasswordIntoElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementpasswordToInput);
                if (browserInputPasswordIntoElementresetExistingValue != null)
                {
                    if (browserInputPasswordIntoElementresetExistingValue != null)
                    {
                        browserInputPasswordIntoElement["ResetExistingValue"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementresetExistingValue);
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
                        browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementpasswordContainsStoredPassword);
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
                browserInputPasswordIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserInputPasswordIntoElementworkflow);
                if (browserInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = browserInputPasswordIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPasteIntoElement([WorkflowExpression] Func<string> browserPasteIntoElementworkflow, [WorkflowExpression] Func<double> browserPasteIntoElementparentElementHandle = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementName = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementID = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserPasteIntoElementsearchElementType = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserPasteIntoElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserPasteIntoElementworkflow, nameof(browserPasteIntoElementworkflow), required: true);
            SourceExpression.Validate(browserPasteIntoElementparentElementHandle, nameof(browserPasteIntoElementparentElementHandle), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementHandle, nameof(browserPasteIntoElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementName, nameof(browserPasteIntoElementsearchElementName), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementID, nameof(browserPasteIntoElementsearchElementID), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementTagName, nameof(browserPasteIntoElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementXPath, nameof(browserPasteIntoElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementClassName, nameof(browserPasteIntoElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementCSSSelector, nameof(browserPasteIntoElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementIndex, nameof(browserPasteIntoElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementMatchValue, nameof(browserPasteIntoElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementMatchText, nameof(browserPasteIntoElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementType, nameof(browserPasteIntoElementsearchElementType), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementMinimumWidth, nameof(browserPasteIntoElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementMinimumHeight, nameof(browserPasteIntoElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxLeft, nameof(browserPasteIntoElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxRight, nameof(browserPasteIntoElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxTop, nameof(browserPasteIntoElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserPasteIntoElementsearchElementBoundingBoxBottom, nameof(browserPasteIntoElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/PasteIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPasteIntoElement = new JObject();
                var browserPasteIntoElementpropCount = 0;
                if (browserPasteIntoElementparentElementHandle != null)
                {
                    browserPasteIntoElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementparentElementHandle);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementHandle != null)
                {
                    browserPasteIntoElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementHandle);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementName != null)
                {
                    browserPasteIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementName);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementID != null)
                {
                    browserPasteIntoElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementID);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementTagName != null)
                {
                    browserPasteIntoElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementTagName);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementXPath != null)
                {
                    browserPasteIntoElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementXPath);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementClassName != null)
                {
                    browserPasteIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementClassName);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementCSSSelector != null)
                {
                    browserPasteIntoElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementCSSSelector);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementIndex != null)
                {
                    if (browserPasteIntoElementsearchElementIndex != null)
                    {
                        browserPasteIntoElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementIndex);
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
                    browserPasteIntoElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMatchValue);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementMatchText != null)
                {
                    browserPasteIntoElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMatchText);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementType != null)
                {
                    browserPasteIntoElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementType);
                    browserPasteIntoElementpropCount++;
                }

                if (browserPasteIntoElementsearchElementMinimumWidth != null)
                {
                    if (browserPasteIntoElementsearchElementMinimumWidth != null)
                    {
                        browserPasteIntoElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMinimumWidth);
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
                        browserPasteIntoElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMinimumHeight);
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
                        browserPasteIntoElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxLeft);
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
                        browserPasteIntoElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxRight);
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
                        browserPasteIntoElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxTop);
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
                        browserPasteIntoElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxBottom);
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
                        browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserPasteIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserPasteIntoElementworkflow);
                if (browserPasteIntoElementpropCount > 0)
                {
                    callPayload.Body = browserPasteIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPrintCurrentPage([WorkflowExpression] Func<string> browserPrintCurrentPageworkflow)
        {
            SourceExpression.Validate(browserPrintCurrentPageworkflow, nameof(browserPrintCurrentPageworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/PrintCurrentPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPrintCurrentPage = new JObject();
                var browserPrintCurrentPagepropCount = 0;
                browserPrintCurrentPagepropCount++;
                browserPrintCurrentPage["Workflow"] = SourceExpressionConverter.ConvertToken(browserPrintCurrentPageworkflow);
                if (browserPrintCurrentPagepropCount > 0)
                {
                    callPayload.Body = browserPrintCurrentPage;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowByPixels([WorkflowExpression] Func<string> browserScrollWindowByPixelsworkflow, [WorkflowExpression] Func<double> browserScrollWindowByPixelsx = null, [WorkflowExpression] Func<double> browserScrollWindowByPixelsy = null)
        {
            SourceExpression.Validate(browserScrollWindowByPixelsworkflow, nameof(browserScrollWindowByPixelsworkflow), required: true);
            SourceExpression.Validate(browserScrollWindowByPixelsx, nameof(browserScrollWindowByPixelsx), required: false);
            SourceExpression.Validate(browserScrollWindowByPixelsy, nameof(browserScrollWindowByPixelsy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollWindowByPixels = new JObject();
                var browserScrollWindowByPixelspropCount = 0;
                if (browserScrollWindowByPixelsx != null)
                {
                    browserScrollWindowByPixels["X"] = SourceExpressionConverter.ConvertToken(browserScrollWindowByPixelsx);
                    browserScrollWindowByPixelspropCount++;
                }

                if (browserScrollWindowByPixelsy != null)
                {
                    browserScrollWindowByPixels["Y"] = SourceExpressionConverter.ConvertToken(browserScrollWindowByPixelsy);
                    browserScrollWindowByPixelspropCount++;
                }

                browserScrollWindowByPixelspropCount++;
                browserScrollWindowByPixels["Workflow"] = SourceExpressionConverter.ConvertToken(browserScrollWindowByPixelsworkflow);
                if (browserScrollWindowByPixelspropCount > 0)
                {
                    callPayload.Body = browserScrollWindowByPixels;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowToPixels([WorkflowExpression] Func<string> browserScrollWindowToPixelsworkflow, [WorkflowExpression] Func<double> browserScrollWindowToPixelsx = null, [WorkflowExpression] Func<double> browserScrollWindowToPixelsy = null)
        {
            SourceExpression.Validate(browserScrollWindowToPixelsworkflow, nameof(browserScrollWindowToPixelsworkflow), required: true);
            SourceExpression.Validate(browserScrollWindowToPixelsx, nameof(browserScrollWindowToPixelsx), required: false);
            SourceExpression.Validate(browserScrollWindowToPixelsy, nameof(browserScrollWindowToPixelsy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollWindowToPixels = new JObject();
                var browserScrollWindowToPixelspropCount = 0;
                if (browserScrollWindowToPixelsx != null)
                {
                    browserScrollWindowToPixels["X"] = SourceExpressionConverter.ConvertToken(browserScrollWindowToPixelsx);
                    browserScrollWindowToPixelspropCount++;
                }

                if (browserScrollWindowToPixelsy != null)
                {
                    browserScrollWindowToPixels["Y"] = SourceExpressionConverter.ConvertToken(browserScrollWindowToPixelsy);
                    browserScrollWindowToPixelspropCount++;
                }

                browserScrollWindowToPixelspropCount++;
                browserScrollWindowToPixels["Workflow"] = SourceExpressionConverter.ConvertToken(browserScrollWindowToPixelsworkflow);
                if (browserScrollWindowToPixelspropCount > 0)
                {
                    callPayload.Body = browserScrollWindowToPixels;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectAllOnElement([WorkflowExpression] Func<string> browserSelectAllOnElementworkflow, [WorkflowExpression] Func<double> browserSelectAllOnElementparentElementHandle = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementHandle = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementName = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementID = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementTagName = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementXPath = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementIndex = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementMatchText = null, [WorkflowExpression] Func<string> browserSelectAllOnElementsearchElementType = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserSelectAllOnElementsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            SourceExpression.Validate(browserSelectAllOnElementworkflow, nameof(browserSelectAllOnElementworkflow), required: true);
            SourceExpression.Validate(browserSelectAllOnElementparentElementHandle, nameof(browserSelectAllOnElementparentElementHandle), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementHandle, nameof(browserSelectAllOnElementsearchElementHandle), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementName, nameof(browserSelectAllOnElementsearchElementName), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementID, nameof(browserSelectAllOnElementsearchElementID), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementTagName, nameof(browserSelectAllOnElementsearchElementTagName), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementXPath, nameof(browserSelectAllOnElementsearchElementXPath), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementClassName, nameof(browserSelectAllOnElementsearchElementClassName), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementCSSSelector, nameof(browserSelectAllOnElementsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementIndex, nameof(browserSelectAllOnElementsearchElementIndex), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementMatchValue, nameof(browserSelectAllOnElementsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementMatchText, nameof(browserSelectAllOnElementsearchElementMatchText), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementType, nameof(browserSelectAllOnElementsearchElementType), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementMinimumWidth, nameof(browserSelectAllOnElementsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementMinimumHeight, nameof(browserSelectAllOnElementsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxLeft, nameof(browserSelectAllOnElementsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxRight, nameof(browserSelectAllOnElementsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxTop, nameof(browserSelectAllOnElementsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserSelectAllOnElementsearchElementBoundingBoxBottom, nameof(browserSelectAllOnElementsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/SelectAllOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSelectAllOnElement = new JObject();
                var browserSelectAllOnElementpropCount = 0;
                if (browserSelectAllOnElementparentElementHandle != null)
                {
                    browserSelectAllOnElement["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementparentElementHandle);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementHandle != null)
                {
                    browserSelectAllOnElement["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementHandle);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementName != null)
                {
                    browserSelectAllOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementName);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementID != null)
                {
                    browserSelectAllOnElement["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementID);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementTagName != null)
                {
                    browserSelectAllOnElement["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementTagName);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementXPath != null)
                {
                    browserSelectAllOnElement["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementXPath);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementClassName != null)
                {
                    browserSelectAllOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementClassName);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementCSSSelector != null)
                {
                    browserSelectAllOnElement["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementCSSSelector);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementIndex != null)
                {
                    if (browserSelectAllOnElementsearchElementIndex != null)
                    {
                        browserSelectAllOnElement["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementIndex);
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
                    browserSelectAllOnElement["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMatchValue);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementMatchText != null)
                {
                    browserSelectAllOnElement["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMatchText);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementType != null)
                {
                    browserSelectAllOnElement["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementType);
                    browserSelectAllOnElementpropCount++;
                }

                if (browserSelectAllOnElementsearchElementMinimumWidth != null)
                {
                    if (browserSelectAllOnElementsearchElementMinimumWidth != null)
                    {
                        browserSelectAllOnElement["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMinimumWidth);
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
                        browserSelectAllOnElement["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMinimumHeight);
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
                        browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxLeft);
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
                        browserSelectAllOnElement["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxRight);
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
                        browserSelectAllOnElement["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxTop);
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
                        browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxBottom);
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
                        browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserSelectAllOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(browserSelectAllOnElementworkflow);
                if (browserSelectAllOnElementpropCount > 0)
                {
                    callPayload.Body = browserSelectAllOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> BrowserWaitForElementToExist([WorkflowExpression] Func<int> browserWaitForElementToExistsecondsToWait, [WorkflowExpression] Func<string> browserWaitForElementToExistworkflow, [WorkflowExpression] Func<double> browserWaitForElementToExistparentElementHandle = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementName = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementID = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementTagName = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementXPath = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementClassName = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementIndex = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementMatchText = null, [WorkflowExpression] Func<string> browserWaitForElementToExistsearchElementType = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserWaitForElementToExistsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistraiseExceptionIfElementNotFound = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = null, [WorkflowExpression] Func<bool> browserWaitForElementToExistwaitForSearchElementToBeDisplayed = null)
        {
            SourceExpression.Validate(browserWaitForElementToExistsecondsToWait, nameof(browserWaitForElementToExistsecondsToWait), required: true);
            SourceExpression.Validate(browserWaitForElementToExistworkflow, nameof(browserWaitForElementToExistworkflow), required: true);
            SourceExpression.Validate(browserWaitForElementToExistparentElementHandle, nameof(browserWaitForElementToExistparentElementHandle), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementName, nameof(browserWaitForElementToExistsearchElementName), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementID, nameof(browserWaitForElementToExistsearchElementID), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementTagName, nameof(browserWaitForElementToExistsearchElementTagName), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementXPath, nameof(browserWaitForElementToExistsearchElementXPath), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementClassName, nameof(browserWaitForElementToExistsearchElementClassName), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementCSSSelector, nameof(browserWaitForElementToExistsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementIndex, nameof(browserWaitForElementToExistsearchElementIndex), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementMatchValue, nameof(browserWaitForElementToExistsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementMatchText, nameof(browserWaitForElementToExistsearchElementMatchText), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementType, nameof(browserWaitForElementToExistsearchElementType), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementMinimumWidth, nameof(browserWaitForElementToExistsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementMinimumHeight, nameof(browserWaitForElementToExistsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxLeft, nameof(browserWaitForElementToExistsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxRight, nameof(browserWaitForElementToExistsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxTop, nameof(browserWaitForElementToExistsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserWaitForElementToExistsearchElementBoundingBoxBottom, nameof(browserWaitForElementToExistsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserWaitForElementToExistraiseExceptionIfElementNotFound, nameof(browserWaitForElementToExistraiseExceptionIfElementNotFound), required: false);
            SourceExpression.Validate(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible, nameof(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible), required: false);
            SourceExpression.Validate(browserWaitForElementToExistwaitForSearchElementToBeDisplayed, nameof(browserWaitForElementToExistwaitForSearchElementToBeDisplayed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/WaitForElementToExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserWaitForElementToExist = new JObject();
                var browserWaitForElementToExistpropCount = 0;
                if (browserWaitForElementToExistparentElementHandle != null)
                {
                    browserWaitForElementToExist["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistparentElementHandle);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementName != null)
                {
                    browserWaitForElementToExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementName);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementID != null)
                {
                    browserWaitForElementToExist["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementID);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementTagName != null)
                {
                    browserWaitForElementToExist["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementTagName);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementXPath != null)
                {
                    browserWaitForElementToExist["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementXPath);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementClassName != null)
                {
                    browserWaitForElementToExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementClassName);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementCSSSelector != null)
                {
                    browserWaitForElementToExist["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementCSSSelector);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementIndex != null)
                {
                    if (browserWaitForElementToExistsearchElementIndex != null)
                    {
                        browserWaitForElementToExist["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementIndex);
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
                    browserWaitForElementToExist["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMatchValue);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementMatchText != null)
                {
                    browserWaitForElementToExist["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMatchText);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementType != null)
                {
                    browserWaitForElementToExist["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementType);
                    browserWaitForElementToExistpropCount++;
                }

                if (browserWaitForElementToExistsearchElementMinimumWidth != null)
                {
                    if (browserWaitForElementToExistsearchElementMinimumWidth != null)
                    {
                        browserWaitForElementToExist["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMinimumWidth);
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
                        browserWaitForElementToExist["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMinimumHeight);
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
                        browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxLeft);
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
                        browserWaitForElementToExist["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxRight);
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
                        browserWaitForElementToExist["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxTop);
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
                        browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxBottom);
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
                        browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserWaitForElementToExist["SecondsToWait"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistsecondsToWait);
                if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                {
                    if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                    {
                        browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistraiseExceptionIfElementNotFound);
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
                        browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible);
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
                        browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistwaitForSearchElementToBeDisplayed);
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
                browserWaitForElementToExist["Workflow"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToExistworkflow);
                if (browserWaitForElementToExistpropCount > 0)
                {
                    callPayload.Body = browserWaitForElementToExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> BrowserWaitForElementToNotExist([WorkflowExpression] Func<int> browserWaitForElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> browserWaitForElementToNotExistworkflow, [WorkflowExpression] Func<double> browserWaitForElementToNotExistparentElementHandle = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementHandle = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementName = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementID = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementTagName = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementXPath = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementClassName = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementCSSSelector = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementIndex = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementMatchValue = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementMatchText = null, [WorkflowExpression] Func<string> browserWaitForElementToNotExistsearchElementType = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementMinimumWidth = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementMinimumHeight = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxLeft = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxRight = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxTop = null, [WorkflowExpression] Func<double> browserWaitForElementToNotExistsearchElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = null, [WorkflowExpression] Func<bool> browserWaitForElementToNotExistraiseExceptionIfElementStillExists = null, [WorkflowExpression] Func<bool> browserWaitForElementToNotExistsearchElementMustBeDisplayed = null)
        {
            SourceExpression.Validate(browserWaitForElementToNotExistsecondsToWait, nameof(browserWaitForElementToNotExistsecondsToWait), required: true);
            SourceExpression.Validate(browserWaitForElementToNotExistworkflow, nameof(browserWaitForElementToNotExistworkflow), required: true);
            SourceExpression.Validate(browserWaitForElementToNotExistparentElementHandle, nameof(browserWaitForElementToNotExistparentElementHandle), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementHandle, nameof(browserWaitForElementToNotExistsearchElementHandle), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementName, nameof(browserWaitForElementToNotExistsearchElementName), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementID, nameof(browserWaitForElementToNotExistsearchElementID), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementTagName, nameof(browserWaitForElementToNotExistsearchElementTagName), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementXPath, nameof(browserWaitForElementToNotExistsearchElementXPath), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementClassName, nameof(browserWaitForElementToNotExistsearchElementClassName), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementCSSSelector, nameof(browserWaitForElementToNotExistsearchElementCSSSelector), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementIndex, nameof(browserWaitForElementToNotExistsearchElementIndex), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementMatchValue, nameof(browserWaitForElementToNotExistsearchElementMatchValue), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementMatchText, nameof(browserWaitForElementToNotExistsearchElementMatchText), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementType, nameof(browserWaitForElementToNotExistsearchElementType), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementMinimumWidth, nameof(browserWaitForElementToNotExistsearchElementMinimumWidth), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementMinimumHeight, nameof(browserWaitForElementToNotExistsearchElementMinimumHeight), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxLeft, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxLeft), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxRight, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxRight), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxTop, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxTop), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementBoundingBoxBottom, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxBottom), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistraiseExceptionIfElementStillExists, nameof(browserWaitForElementToNotExistraiseExceptionIfElementStillExists), required: false);
            SourceExpression.Validate(browserWaitForElementToNotExistsearchElementMustBeDisplayed, nameof(browserWaitForElementToNotExistsearchElementMustBeDisplayed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserWaitForElementToNotExist = new JObject();
                var browserWaitForElementToNotExistpropCount = 0;
                if (browserWaitForElementToNotExistparentElementHandle != null)
                {
                    browserWaitForElementToNotExist["ParentElementHandle"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistparentElementHandle);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementHandle != null)
                {
                    browserWaitForElementToNotExist["SearchElementHandle"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementHandle);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementName != null)
                {
                    browserWaitForElementToNotExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementID != null)
                {
                    browserWaitForElementToNotExist["SearchElementID"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementID);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementTagName != null)
                {
                    browserWaitForElementToNotExist["SearchElementTagName"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementTagName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementXPath != null)
                {
                    browserWaitForElementToNotExist["SearchElementXPath"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementXPath);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementClassName != null)
                {
                    browserWaitForElementToNotExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementClassName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementCSSSelector != null)
                {
                    browserWaitForElementToNotExist["SearchElementCSSSelector"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementCSSSelector);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementIndex != null)
                {
                    if (browserWaitForElementToNotExistsearchElementIndex != null)
                    {
                        browserWaitForElementToNotExist["SearchElementIndex"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementIndex);
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
                    browserWaitForElementToNotExist["SearchElementMatchValue"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMatchValue);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMatchText != null)
                {
                    browserWaitForElementToNotExist["SearchElementMatchText"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMatchText);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementType != null)
                {
                    browserWaitForElementToNotExist["SearchElementType"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementType);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                {
                    if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMinimumWidth"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMinimumWidth);
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
                        browserWaitForElementToNotExist["SearchElementMinimumHeight"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMinimumHeight);
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
                        browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxLeft);
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
                        browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxRight);
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
                        browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxTop);
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
                        browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxBottom);
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
                        browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox);
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
                browserWaitForElementToNotExist["SecondsToWait"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsecondsToWait);
                if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistraiseExceptionIfElementStillExists);
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
                        browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMustBeDisplayed);
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
                browserWaitForElementToNotExist["Workflow"] = SourceExpressionConverter.ConvertToken(browserWaitForElementToNotExistworkflow);
                if (browserWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = browserWaitForElementToNotExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> BrowserGetWebElementAtScreenCoordinates([WorkflowExpression] Func<string> browserGetWebElementAtScreenCoordinatesworkflow, [WorkflowExpression] Func<int> browserGetWebElementAtScreenCoordinatesxCoord = null, [WorkflowExpression] Func<int> browserGetWebElementAtScreenCoordinatesyCoord = null, [WorkflowExpression] Func<bool> browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = null)
        {
            SourceExpression.Validate(browserGetWebElementAtScreenCoordinatesworkflow, nameof(browserGetWebElementAtScreenCoordinatesworkflow), required: true);
            SourceExpression.Validate(browserGetWebElementAtScreenCoordinatesxCoord, nameof(browserGetWebElementAtScreenCoordinatesxCoord), required: false);
            SourceExpression.Validate(browserGetWebElementAtScreenCoordinatesyCoord, nameof(browserGetWebElementAtScreenCoordinatesyCoord), required: false);
            SourceExpression.Validate(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound, nameof(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        browserGetWebElementAtScreenCoordinates["XCoord"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesxCoord);
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
                        browserGetWebElementAtScreenCoordinates["YCoord"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesyCoord);
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
                        browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound);
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
                browserGetWebElementAtScreenCoordinates["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesworkflow);
                if (browserGetWebElementAtScreenCoordinatespropCount > 0)
                {
                    callPayload.Body = browserGetWebElementAtScreenCoordinates;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> BrowserGetWebElementAtBrowserDocumentWindowCoordinates([WorkflowExpression] Func<string> browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, [WorkflowExpression] Func<int> browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = null, [WorkflowExpression] Func<int> browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = null, [WorkflowExpression] Func<bool> browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = null)
        {
            SourceExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow), required: true);
            SourceExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord), required: false);
            SourceExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord), required: false);
            SourceExpression.Validate(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord);
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
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord);
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
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound);
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
                browserGetWebElementAtBrowserDocumentWindowCoordinates["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow);
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount > 0)
                {
                    callPayload.Body = browserGetWebElementAtBrowserDocumentWindowCoordinates;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> BrowserGetWebElementPropertiesAsList([WorkflowExpression] Func<int> browserGetWebElementPropertiesAsListelementHandle, [WorkflowExpression] Func<string> browserGetWebElementPropertiesAsListworkflow, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListgetHTMLCode = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnValue = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnText = null, [WorkflowExpression] Func<int> browserGetWebElementPropertiesAsListmaxValueLength = null, [WorkflowExpression] Func<int> browserGetWebElementPropertiesAsListmaxTextLength = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnCoordinates = null, [WorkflowExpression] Func<bool> browserGetWebElementPropertiesAsListreturnParentTag = null)
        {
            SourceExpression.Validate(browserGetWebElementPropertiesAsListelementHandle, nameof(browserGetWebElementPropertiesAsListelementHandle), required: true);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListworkflow, nameof(browserGetWebElementPropertiesAsListworkflow), required: true);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListgetHTMLCode, nameof(browserGetWebElementPropertiesAsListgetHTMLCode), required: false);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListreturnValue, nameof(browserGetWebElementPropertiesAsListreturnValue), required: false);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListreturnText, nameof(browserGetWebElementPropertiesAsListreturnText), required: false);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListmaxValueLength, nameof(browserGetWebElementPropertiesAsListmaxValueLength), required: false);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListmaxTextLength, nameof(browserGetWebElementPropertiesAsListmaxTextLength), required: false);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListreturnCoordinates, nameof(browserGetWebElementPropertiesAsListreturnCoordinates), required: false);
            SourceExpression.Validate(browserGetWebElementPropertiesAsListreturnParentTag, nameof(browserGetWebElementPropertiesAsListreturnParentTag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementPropertiesAsList = new JObject();
                var browserGetWebElementPropertiesAsListpropCount = 0;
                browserGetWebElementPropertiesAsListpropCount++;
                browserGetWebElementPropertiesAsList["ElementHandle"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListelementHandle);
                if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
                {
                    if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
                    {
                        browserGetWebElementPropertiesAsList["GetHTMLCode"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListgetHTMLCode);
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
                        browserGetWebElementPropertiesAsList["ReturnValue"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnValue);
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
                        browserGetWebElementPropertiesAsList["ReturnText"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnText);
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
                        browserGetWebElementPropertiesAsList["MaxValueLength"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListmaxValueLength);
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
                        browserGetWebElementPropertiesAsList["MaxTextLength"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListmaxTextLength);
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
                        browserGetWebElementPropertiesAsList["ReturnCoordinates"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnCoordinates);
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
                        browserGetWebElementPropertiesAsList["ReturnParentTag"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnParentTag);
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
                browserGetWebElementPropertiesAsList["Workflow"] = SourceExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListworkflow);
                if (browserGetWebElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = browserGetWebElementPropertiesAsList;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> IsBrowserInstanceOpen([WorkflowExpression] Func<string> isBrowserInstanceOpenworkflow)
        {
            SourceExpression.Validate(isBrowserInstanceOpenworkflow, nameof(isBrowserInstanceOpenworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isBrowserInstanceOpen = new JObject();
                var isBrowserInstanceOpenpropCount = 0;
                isBrowserInstanceOpenpropCount++;
                isBrowserInstanceOpen["Workflow"] = SourceExpressionConverter.ConvertToken(isBrowserInstanceOpenworkflow);
                if (isBrowserInstanceOpenpropCount > 0)
                {
                    callPayload.Body = isBrowserInstanceOpen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsBrowserInstanceOpenResponse>(BuildSourceInput);
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