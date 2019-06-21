# FormApi.Client - the C# library for the API v1

FormAPI is a service that helps you fill out and sign PDF templates.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.10.0
- Build package: io.formapi.codegen.FormApiCSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out FormApi.Client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var templateId = tpl_000000000000000001;  // string | 
            var requestBody = new List<Object>(); // List<Object> | 

            try
            {
                // Generates multiple PDFs
                List<CreateSubmissionResponse> result = apiInstance.BatchGeneratePdfV1(templateId, requestBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.BatchGeneratePdfV1: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.formapi.io/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PDFApi* | [**BatchGeneratePdfV1**](docs/PDFApi.md#batchgeneratepdfv1) | **POST** /templates/{template_id}/submissions/batch | Generates multiple PDFs
*PDFApi* | [**BatchGeneratePdfs**](docs/PDFApi.md#batchgeneratepdfs) | **POST** /submissions/batches | Generates multiple PDFs
*PDFApi* | [**CombinePdfs**](docs/PDFApi.md#combinepdfs) | **POST** /combined_submissions?v&#x3D;2 | Merge submission PDFs, template PDFs, or custom files
*PDFApi* | [**CombineSubmissions**](docs/PDFApi.md#combinesubmissions) | **POST** /combined_submissions | Merge generated PDFs together
*PDFApi* | [**CreateCustomFileFromUpload**](docs/PDFApi.md#createcustomfilefromupload) | **POST** /custom_files | Create a new custom file from a cached presign upload
*PDFApi* | [**CreateDataRequestToken**](docs/PDFApi.md#createdatarequesttoken) | **POST** /data_requests/{data_request_id}/tokens | Creates a new data request token for form authentication
*PDFApi* | [**CreateTemplate**](docs/PDFApi.md#createtemplate) | **POST** /templates | Upload a new PDF template with a file upload
*PDFApi* | [**CreateTemplateFromUpload**](docs/PDFApi.md#createtemplatefromupload) | **POST** /templates?v&#x3D;2 | Create a new PDF template from a cached presign upload
*PDFApi* | [**ExpireCombinedSubmission**](docs/PDFApi.md#expirecombinedsubmission) | **DELETE** /combined_submissions/{combined_submission_id} | Expire a combined submission
*PDFApi* | [**ExpireSubmission**](docs/PDFApi.md#expiresubmission) | **DELETE** /submissions/{submission_id} | Expire a PDF submission
*PDFApi* | [**GeneratePDF**](docs/PDFApi.md#generatepdf) | **POST** /templates/{template_id}/submissions | Generates a new PDF
*PDFApi* | [**GetCombinedSubmission**](docs/PDFApi.md#getcombinedsubmission) | **GET** /combined_submissions/{combined_submission_id} | Check the status of a combined submission (merged PDFs)
*PDFApi* | [**GetDataRequest**](docs/PDFApi.md#getdatarequest) | **GET** /data_requests/{data_request_id} | Look up a submission data request
*PDFApi* | [**GetPresignUrl**](docs/PDFApi.md#getpresignurl) | **GET** /uploads/presign | Get a presigned URL so that you can upload a file to our AWS S3 bucket
*PDFApi* | [**GetSubmission**](docs/PDFApi.md#getsubmission) | **GET** /submissions/{submission_id} | Check the status of a PDF
*PDFApi* | [**GetSubmissionBatch**](docs/PDFApi.md#getsubmissionbatch) | **GET** /submissions/batches/{submission_batch_id} | Check the status of a submission batch job
*PDFApi* | [**GetTemplate**](docs/PDFApi.md#gettemplate) | **GET** /templates/{template_id} | Check the status of an uploaded template
*PDFApi* | [**GetTemplateSchema**](docs/PDFApi.md#gettemplateschema) | **GET** /templates/{template_id}/schema | Fetch the JSON schema for a template
*PDFApi* | [**ListTemplates**](docs/PDFApi.md#listtemplates) | **GET** /templates | Get a list of all templates
*PDFApi* | [**TestAuthentication**](docs/PDFApi.md#testauthentication) | **GET** /authentication | Test Authentication
*PDFApi* | [**UpdateDataRequest**](docs/PDFApi.md#updatedatarequest) | **PUT** /data_requests/{data_request_id} | Update a submission data request


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AuthenticationError](docs/AuthenticationError.md)
 - [Model.AuthenticationSuccessResponse](docs/AuthenticationSuccessResponse.md)
 - [Model.CombinePdfsData](docs/CombinePdfsData.md)
 - [Model.CombinedSubmission](docs/CombinedSubmission.md)
 - [Model.CombinedSubmissionAction](docs/CombinedSubmissionAction.md)
 - [Model.CombinedSubmissionData](docs/CombinedSubmissionData.md)
 - [Model.CreateCombinedSubmissionResponse](docs/CreateCombinedSubmissionResponse.md)
 - [Model.CreateCustomFileData](docs/CreateCustomFileData.md)
 - [Model.CreateCustomFileResponse](docs/CreateCustomFileResponse.md)
 - [Model.CreateSubmissionBatchResponse](docs/CreateSubmissionBatchResponse.md)
 - [Model.CreateSubmissionBatchSubmissionsResponse](docs/CreateSubmissionBatchSubmissionsResponse.md)
 - [Model.CreateSubmissionDataRequestData](docs/CreateSubmissionDataRequestData.md)
 - [Model.CreateSubmissionDataRequestTokenResponse](docs/CreateSubmissionDataRequestTokenResponse.md)
 - [Model.CreateSubmissionDataRequestTokenResponseToken](docs/CreateSubmissionDataRequestTokenResponseToken.md)
 - [Model.CreateSubmissionResponse](docs/CreateSubmissionResponse.md)
 - [Model.CreateTemplateData](docs/CreateTemplateData.md)
 - [Model.CustomFile](docs/CustomFile.md)
 - [Model.Error](docs/Error.md)
 - [Model.InvalidRequest](docs/InvalidRequest.md)
 - [Model.PendingTemplate](docs/PendingTemplate.md)
 - [Model.Submission](docs/Submission.md)
 - [Model.SubmissionAction](docs/SubmissionAction.md)
 - [Model.SubmissionBatch](docs/SubmissionBatch.md)
 - [Model.SubmissionBatchData](docs/SubmissionBatchData.md)
 - [Model.SubmissionData](docs/SubmissionData.md)
 - [Model.SubmissionDataBatchRequest](docs/SubmissionDataBatchRequest.md)
 - [Model.SubmissionDataRequest](docs/SubmissionDataRequest.md)
 - [Model.Template](docs/Template.md)
 - [Model.Templatesv2Template](docs/Templatesv2Template.md)
 - [Model.Templatesv2TemplateDocument](docs/Templatesv2TemplateDocument.md)
 - [Model.Templatesv2TemplateDocumentMetadata](docs/Templatesv2TemplateDocumentMetadata.md)
 - [Model.UpdateDataRequestResponse](docs/UpdateDataRequestResponse.md)
 - [Model.UpdateSubmissionDataRequestData](docs/UpdateSubmissionDataRequestData.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_token_basic"></a>
### api_token_basic

- **Type**: HTTP basic authentication

