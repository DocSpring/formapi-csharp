# FormApi.Client.Api.PDFApi

All URIs are relative to *https://api.formapi.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchGeneratePdfV1**](PDFApi.md#batchgeneratepdfv1) | **POST** /templates/{template_id}/submissions/batch | Generates multiple PDFs
[**BatchGeneratePdfs**](PDFApi.md#batchgeneratepdfs) | **POST** /submissions/batches | Generates multiple PDFs
[**CombinePdfs**](PDFApi.md#combinepdfs) | **POST** /combined_submissions?v&#x3D;2 | Merge submission PDFs, template PDFs, or custom files
[**CombineSubmissions**](PDFApi.md#combinesubmissions) | **POST** /combined_submissions | Merge generated PDFs together
[**CreateCustomFileFromUpload**](PDFApi.md#createcustomfilefromupload) | **POST** /custom_files | Create a new custom file from a cached presign upload
[**CreateDataRequestToken**](PDFApi.md#createdatarequesttoken) | **POST** /data_requests/{data_request_id}/tokens | Creates a new data request token for form authentication
[**CreateTemplate**](PDFApi.md#createtemplate) | **POST** /templates | Upload a new PDF template with a file upload
[**CreateTemplateFromUpload**](PDFApi.md#createtemplatefromupload) | **POST** /templates?v&#x3D;2 | Create a new PDF template from a cached presign upload
[**ExpireCombinedSubmission**](PDFApi.md#expirecombinedsubmission) | **DELETE** /combined_submissions/{combined_submission_id} | Expire a combined submission
[**ExpireSubmission**](PDFApi.md#expiresubmission) | **DELETE** /submissions/{submission_id} | Expire a PDF submission
[**GeneratePDF**](PDFApi.md#generatepdf) | **POST** /templates/{template_id}/submissions | Generates a new PDF
[**GetCombinedSubmission**](PDFApi.md#getcombinedsubmission) | **GET** /combined_submissions/{combined_submission_id} | Check the status of a combined submission (merged PDFs)
[**GetDataRequest**](PDFApi.md#getdatarequest) | **GET** /data_requests/{data_request_id} | Look up a submission data request
[**GetPresignUrl**](PDFApi.md#getpresignurl) | **GET** /uploads/presign | Get a presigned URL so that you can upload a file to our AWS S3 bucket
[**GetSubmission**](PDFApi.md#getsubmission) | **GET** /submissions/{submission_id} | Check the status of a PDF
[**GetSubmissionBatch**](PDFApi.md#getsubmissionbatch) | **GET** /submissions/batches/{submission_batch_id} | Check the status of a submission batch job
[**GetTemplate**](PDFApi.md#gettemplate) | **GET** /templates/{template_id} | Check the status of an uploaded template
[**GetTemplateSchema**](PDFApi.md#gettemplateschema) | **GET** /templates/{template_id}/schema | Fetch the JSON schema for a template
[**GetTemplates**](PDFApi.md#gettemplates) | **GET** /templates | Get a list of all templates
[**TestAuthentication**](PDFApi.md#testauthentication) | **GET** /authentication | Test Authentication
[**UpdateDataRequest**](PDFApi.md#updatedatarequest) | **PUT** /data_requests/{data_request_id} | Update a submission data request


<a name="batchgeneratepdfv1"></a>
# **BatchGeneratePdfV1**
> List<CreateSubmissionResponse> BatchGeneratePdfV1 (string templateId, List<Object> requestBody)

Generates multiple PDFs

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class BatchGeneratePdfV1Example
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
                List&lt;CreateSubmissionResponse&gt; result = apiInstance.BatchGeneratePdfV1(templateId, requestBody);
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **requestBody** | [**List&lt;Object&gt;**](List.md)|  | 

### Return type

[**List<CreateSubmissionResponse>**](CreateSubmissionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchgeneratepdfs"></a>
# **BatchGeneratePdfs**
> CreateSubmissionBatchResponse BatchGeneratePdfs (SubmissionBatchData submissionBatchData)

Generates multiple PDFs

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class BatchGeneratePdfsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var submissionBatchData = new SubmissionBatchData(); // SubmissionBatchData | 

            try
            {
                // Generates multiple PDFs
                CreateSubmissionBatchResponse result = apiInstance.BatchGeneratePdfs(submissionBatchData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.BatchGeneratePdfs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionBatchData** | [**SubmissionBatchData**](SubmissionBatchData.md)|  | 

### Return type

[**CreateSubmissionBatchResponse**](CreateSubmissionBatchResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="combinepdfs"></a>
# **CombinePdfs**
> CreateCombinedSubmissionResponse CombinePdfs (CombinePdfsData combinePdfsData)

Merge submission PDFs, template PDFs, or custom files

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class CombinePdfsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var combinePdfsData = new CombinePdfsData(); // CombinePdfsData | 

            try
            {
                // Merge submission PDFs, template PDFs, or custom files
                CreateCombinedSubmissionResponse result = apiInstance.CombinePdfs(combinePdfsData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.CombinePdfs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **combinePdfsData** | [**CombinePdfsData**](CombinePdfsData.md)|  | 

### Return type

[**CreateCombinedSubmissionResponse**](CreateCombinedSubmissionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="combinesubmissions"></a>
# **CombineSubmissions**
> CreateCombinedSubmissionResponse CombineSubmissions (CombinedSubmissionData combinedSubmissionData)

Merge generated PDFs together

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class CombineSubmissionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var combinedSubmissionData = new CombinedSubmissionData(); // CombinedSubmissionData | 

            try
            {
                // Merge generated PDFs together
                CreateCombinedSubmissionResponse result = apiInstance.CombineSubmissions(combinedSubmissionData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.CombineSubmissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **combinedSubmissionData** | [**CombinedSubmissionData**](CombinedSubmissionData.md)|  | 

### Return type

[**CreateCombinedSubmissionResponse**](CreateCombinedSubmissionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomfilefromupload"></a>
# **CreateCustomFileFromUpload**
> CreateCustomFileResponse CreateCustomFileFromUpload (CreateCustomFileData createCustomFileData)

Create a new custom file from a cached presign upload

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class CreateCustomFileFromUploadExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var createCustomFileData = new CreateCustomFileData(); // CreateCustomFileData | 

            try
            {
                // Create a new custom file from a cached presign upload
                CreateCustomFileResponse result = apiInstance.CreateCustomFileFromUpload(createCustomFileData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.CreateCustomFileFromUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCustomFileData** | [**CreateCustomFileData**](CreateCustomFileData.md)|  | 

### Return type

[**CreateCustomFileResponse**](CreateCustomFileResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdatarequesttoken"></a>
# **CreateDataRequestToken**
> CreateSubmissionDataRequestTokenResponse CreateDataRequestToken (string dataRequestId)

Creates a new data request token for form authentication

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class CreateDataRequestTokenExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var dataRequestId = drq_000000000000000001;  // string | 

            try
            {
                // Creates a new data request token for form authentication
                CreateSubmissionDataRequestTokenResponse result = apiInstance.CreateDataRequestToken(dataRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.CreateDataRequestToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataRequestId** | **string**|  | 

### Return type

[**CreateSubmissionDataRequestTokenResponse**](CreateSubmissionDataRequestTokenResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplate"></a>
# **CreateTemplate**
> PendingTemplate CreateTemplate (System.IO.Stream templateDocument, string templateName)

Upload a new PDF template with a file upload

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class CreateTemplateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var templateDocument = BINARY_DATA_HERE;  // System.IO.Stream | 
            var templateName = templateName_example;  // string | 

            try
            {
                // Upload a new PDF template with a file upload
                PendingTemplate result = apiInstance.CreateTemplate(templateDocument, templateName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.CreateTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateDocument** | **System.IO.Stream**|  | 
 **templateName** | **string**|  | 

### Return type

[**PendingTemplate**](PendingTemplate.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplatefromupload"></a>
# **CreateTemplateFromUpload**
> PendingTemplate CreateTemplateFromUpload (CreateTemplateData createTemplateData)

Create a new PDF template from a cached presign upload

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class CreateTemplateFromUploadExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var createTemplateData = new CreateTemplateData(); // CreateTemplateData | 

            try
            {
                // Create a new PDF template from a cached presign upload
                PendingTemplate result = apiInstance.CreateTemplateFromUpload(createTemplateData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.CreateTemplateFromUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createTemplateData** | [**CreateTemplateData**](CreateTemplateData.md)|  | 

### Return type

[**PendingTemplate**](PendingTemplate.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expirecombinedsubmission"></a>
# **ExpireCombinedSubmission**
> CombinedSubmission ExpireCombinedSubmission (string combinedSubmissionId)

Expire a combined submission

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class ExpireCombinedSubmissionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var combinedSubmissionId = com_000000000000000001;  // string | 

            try
            {
                // Expire a combined submission
                CombinedSubmission result = apiInstance.ExpireCombinedSubmission(combinedSubmissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.ExpireCombinedSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **combinedSubmissionId** | **string**|  | 

### Return type

[**CombinedSubmission**](CombinedSubmission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expiresubmission"></a>
# **ExpireSubmission**
> Submission ExpireSubmission (string submissionId)

Expire a PDF submission

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class ExpireSubmissionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var submissionId = sub_000000000000000001;  // string | 

            try
            {
                // Expire a PDF submission
                Submission result = apiInstance.ExpireSubmission(submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.ExpireSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionId** | **string**|  | 

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatepdf"></a>
# **GeneratePDF**
> CreateSubmissionResponse GeneratePDF (string templateId, SubmissionData submissionData)

Generates a new PDF

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GeneratePDFExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var templateId = tpl_000000000000000001;  // string | 
            var submissionData = new SubmissionData(); // SubmissionData | 

            try
            {
                // Generates a new PDF
                CreateSubmissionResponse result = apiInstance.GeneratePDF(templateId, submissionData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GeneratePDF: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **submissionData** | [**SubmissionData**](SubmissionData.md)|  | 

### Return type

[**CreateSubmissionResponse**](CreateSubmissionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcombinedsubmission"></a>
# **GetCombinedSubmission**
> CombinedSubmission GetCombinedSubmission (string combinedSubmissionId)

Check the status of a combined submission (merged PDFs)

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetCombinedSubmissionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var combinedSubmissionId = com_000000000000000001;  // string | 

            try
            {
                // Check the status of a combined submission (merged PDFs)
                CombinedSubmission result = apiInstance.GetCombinedSubmission(combinedSubmissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetCombinedSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **combinedSubmissionId** | **string**|  | 

### Return type

[**CombinedSubmission**](CombinedSubmission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatarequest"></a>
# **GetDataRequest**
> SubmissionDataRequest GetDataRequest (string dataRequestId)

Look up a submission data request

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetDataRequestExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var dataRequestId = drq_000000000000000001;  // string | 

            try
            {
                // Look up a submission data request
                SubmissionDataRequest result = apiInstance.GetDataRequest(dataRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetDataRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataRequestId** | **string**|  | 

### Return type

[**SubmissionDataRequest**](SubmissionDataRequest.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpresignurl"></a>
# **GetPresignUrl**
> Dictionary<string, Object> GetPresignUrl ()

Get a presigned URL so that you can upload a file to our AWS S3 bucket

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetPresignUrlExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();

            try
            {
                // Get a presigned URL so that you can upload a file to our AWS S3 bucket
                Dictionary&lt;string, Object&gt; result = apiInstance.GetPresignUrl();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetPresignUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, Object>**

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubmission"></a>
# **GetSubmission**
> Submission GetSubmission (string submissionId)

Check the status of a PDF

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetSubmissionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var submissionId = sub_000000000000000001;  // string | 

            try
            {
                // Check the status of a PDF
                Submission result = apiInstance.GetSubmission(submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionId** | **string**|  | 

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubmissionbatch"></a>
# **GetSubmissionBatch**
> SubmissionBatch GetSubmissionBatch (string submissionBatchId, bool? includeSubmissions = null)

Check the status of a submission batch job

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetSubmissionBatchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var submissionBatchId = sbb_000000000000000001;  // string | 
            var includeSubmissions = true;  // bool? |  (optional) 

            try
            {
                // Check the status of a submission batch job
                SubmissionBatch result = apiInstance.GetSubmissionBatch(submissionBatchId, includeSubmissions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetSubmissionBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionBatchId** | **string**|  | 
 **includeSubmissions** | **bool?**|  | [optional] 

### Return type

[**SubmissionBatch**](SubmissionBatch.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplate"></a>
# **GetTemplate**
> Template GetTemplate (string templateId)

Check the status of an uploaded template

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var templateId = tpl_000000000000000001;  // string | 

            try
            {
                // Check the status of an uploaded template
                Template result = apiInstance.GetTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplateschema"></a>
# **GetTemplateSchema**
> Dictionary<string, Object> GetTemplateSchema (string templateId)

Fetch the JSON schema for a template

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetTemplateSchemaExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var templateId = tpl_000000000000000001;  // string | 

            try
            {
                // Fetch the JSON schema for a template
                Dictionary&lt;string, Object&gt; result = apiInstance.GetTemplateSchema(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetTemplateSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 

### Return type

**Dictionary<string, Object>**

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplates"></a>
# **GetTemplates**
> List<Template> GetTemplates (int? page = null, int? perPage = null)

Get a list of all templates

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class GetTemplatesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var page = 2;  // int? | Default: 1 (optional) 
            var perPage = 1;  // int? | Default: 50 (optional) 

            try
            {
                // Get a list of all templates
                List&lt;Template&gt; result = apiInstance.GetTemplates(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.GetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Default: 1 | [optional] 
 **perPage** | **int?**| Default: 50 | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testauthentication"></a>
# **TestAuthentication**
> AuthenticationSuccessResponse TestAuthentication ()

Test Authentication

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class TestAuthenticationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();

            try
            {
                // Test Authentication
                AuthenticationSuccessResponse result = apiInstance.TestAuthentication();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.TestAuthentication: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthenticationSuccessResponse**](AuthenticationSuccessResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedatarequest"></a>
# **UpdateDataRequest**
> UpdateDataRequestResponse UpdateDataRequest (string dataRequestId, UpdateSubmissionDataRequestData updateSubmissionDataRequestData)

Update a submission data request

### Example
```csharp
using System;
using System.Diagnostics;
using FormApi.Client.Api;
using FormApi.Client.Client;
using FormApi.Client.Model;

namespace Example
{
    public class UpdateDataRequestExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: api_token_basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi();
            var dataRequestId = drq_000000000000000001;  // string | 
            var updateSubmissionDataRequestData = new UpdateSubmissionDataRequestData(); // UpdateSubmissionDataRequestData | 

            try
            {
                // Update a submission data request
                UpdateDataRequestResponse result = apiInstance.UpdateDataRequest(dataRequestId, updateSubmissionDataRequestData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PDFApi.UpdateDataRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataRequestId** | **string**|  | 
 **updateSubmissionDataRequestData** | [**UpdateSubmissionDataRequestData**](UpdateSubmissionDataRequestData.md)|  | 

### Return type

[**UpdateDataRequestResponse**](UpdateDataRequestResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

