/*
 * API V1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using FormApi.Client.Client;
using FormApi.Client.Api;
using FormApi.Client.Model;

namespace FormApi.Client.Test
{
    /// <summary>
    ///  Class for testing PDFApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PDFApiTests
    {
        private PDFApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            Configuration.Default.Username = "api_token123";
            Configuration.Default.Password = "testsecret123";
            Configuration.Default.BasePath = "http://api.formapi.local:31337/api/v1";
            instance = new PDFApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PDFApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PDFApi
            //Assert.IsInstanceOfType(typeof(PDFApi), instance, "instance is a PDFApi");
        }

        /// <summary>
        /// Test BatchGeneratePDF
        /// </summary>
        [Test]
        public void BatchGeneratePdfsTest()
        {
            string templateId = "tpl_000000000000000001";
            var submissionBatchData = new SubmissionBatchData(
              test: false,
              templateId: templateId,
              submissions: new List<SubmissionDataBatchRequest>(
                new SubmissionDataBatchRequest[] {
                  new SubmissionDataBatchRequest(
                    templateId: templateId,
                    test: false,
                    data: new {
                      title = "Test PDF",
                      description = "This PDF is great!"
                    }
                  ),
                  new SubmissionDataBatchRequest(
                    templateId: templateId,
                    test: false,
                    data: new {
                      title = "Test PDF 2",
                      description = "This PDF is also great!"
                    }
                  )
                }
              )
            );

            CreateSubmissionBatchResponse response = instance.BatchGeneratePdfs(submissionBatchData);

            Assert.IsInstanceOf<CreateSubmissionBatchResponse> (response, "response is CreateSubmissionBatchResponse");
            Assert.AreEqual(
              CreateSubmissionBatchResponse.StatusEnum.Success,
              response.Status);

            var submissionResponses = response.Submissions;
            Assert.IsInstanceOf<List<CreateSubmissionBatchSubmissionsResponse>> (submissionResponses, "response.submissions is List<CreateSubmissionBatchSubmissionsResponse>");
            Assert.That(submissionResponses, Has.Count.EqualTo(2));

            var firstResponse = submissionResponses.First();
            Assert.AreEqual(
              CreateSubmissionBatchSubmissionsResponse.StatusEnum.Success,
              firstResponse.Status);
            var firstSubmission = firstResponse.Submission;

            Assert.IsInstanceOf<Submission> (firstSubmission, "submission is Submission");
            StringAssert.StartsWith("sub_", firstSubmission.Id);
            Assert.AreEqual(false, firstSubmission.Expired);
            Assert.AreEqual(
              Submission.StateEnum.Pending,
              firstSubmission.State);

            // We don't need to test every single thing here. We have enough
            // coverage in the other API client tests.
        }

        /// <summary>
        /// Test CombineSubmissions
        /// </summary>
        [Test]
        public void CombineSubmissionsTest()
        {
            var combinedSubmissionData = new CombinedSubmissionData(
              false,
              new List<string>(new string[] {
                "sub_000000000000000001",
                "sub_000000000000000002"
              })
            );
            var response = instance.CombineSubmissions(combinedSubmissionData);
            Assert.IsInstanceOf<CreateCombinedSubmissionResponse> (response, "response is CreateCombinedSubmissionResponse");
            Assert.AreEqual(
              CreateCombinedSubmissionResponse.StatusEnum.Success,
              response.Status);
            var combinedSubmission = response.CombinedSubmission;
            StringAssert.StartsWith("com_", combinedSubmission.Id);
            Assert.AreEqual(
              CombinedSubmission.StateEnum.Pending,
              combinedSubmission.State);
        }

        /// <summary>
        /// Test CombinePdfs
        /// </summary>
        [Test]
        public void CombinePdfsTest()
        {
          // {% BeginCodeExample combinePdfs %}
            var combinedSubmissionData = new CombinePdfsData(
              test: false,
              sourcePdfs: new List<Object>(new Object[] {
                new {
                  type = "submission",
                  id = "sub_000000000000000001",
                },
                new {
                  type = "submission",
                  id = "sub_000000000000000002",
                },
              })
            );
            var response = instance.CombinePdfs(combinedSubmissionData);
            var combinedSubmission = response.CombinedSubmission;
          // {% EndCodeExample combinePdfs %}
            Assert.IsInstanceOf<CreateCombinedSubmissionResponse> (response, "response is CreateCombinedSubmissionResponse");
            Assert.AreEqual(
              CreateCombinedSubmissionResponse.StatusEnum.Success,
              response.Status);
            StringAssert.StartsWith("com_", combinedSubmission.Id);
            Assert.AreEqual(
              CombinedSubmission.StateEnum.Pending,
              combinedSubmission.State);
        }

        /// TODO: Set up Minio test server before running these tests
        // /// <summary>
        // /// Test CombinePdfs
        // /// </summary>
        // [Test]
        // public void GetPresignUrlAndCreateCustomFileTest()
        // {
        //   // Path is relative to clients/csharp/src/FormApi.Client.Test/bin/Debug
        //   var pdfFixturePath = Path.Combine(
        //     Directory.GetCurrentDirectory(),
        //     "../../../../../../test_fixtures/first_last_signature.pdf");

        //   var presignUrlResponse = instance.GetPresignUrl();

        //   var baseUrl = (string) presignUrlResponse["url"];
        //   var presignFields = (JObject) presignUrlResponse["fields"];

        //   var baseUri = new UriBuilder(baseUrl);
        //   var path = baseUri.Path;
        //   baseUri.Path = null;
        //   var client = new RestClient(baseUri.ToString());

        //   // Use POST when submitting as form data
        //   // See: https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectPOST.html
        //   var request = new RestRequest(path, Method.POST);
        //   request.AddHeader("Content-Type", "multipart/form-data");
        //   request.AlwaysMultipartFormData = true;
        //   foreach (JProperty field in (JToken)presignFields)
        //   {
        //     request.AddParameter(field.Name, (string) field.Value);
        //   }
        //   request.AddFile("file", pdfFixturePath);

        //   var response = client.Execute(request);

        //   Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

        //   var customFileResponse = instance.CreateCustomFileFromUpload(
        //     new CreateCustomFileData(
        //       cacheId: (string) presignFields["key"]
        //     )
        //   );
        //   Assert.IsInstanceOf<CreateCustomFileResponse> (customFileResponse, "response is CreateCustomFileResponse");
        //   Assert.AreEqual(
        //     CreateCustomFileResponse.StatusEnum.Success,
        //     customFileResponse.Status);

        //   var customFile = customFileResponse.CustomFile;
        //   StringAssert.StartsWith("cfi_", customFile.Id);
        // }

        /// <summary>
        /// Test ExpireCombinedSubmission
        /// </summary>
        [Test]
        public void ExpireCombinedSubmissionTest()
        {
            string combinedSubmissionId = "com_000000000000000001";
            var combinedSubmission = instance.ExpireCombinedSubmission(combinedSubmissionId);
            Assert.IsInstanceOf<CombinedSubmission> (combinedSubmission, "response is CombinedSubmission");
            Assert.AreEqual(
              true, combinedSubmission.Expired);
        }

        /// <summary>
        /// Test ExpireSubmission
        /// </summary>
        [Test]
        public void ExpireSubmissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string submissionId = "sub_000000000000000001";
            var submission = instance.ExpireSubmission(submissionId);
            Assert.IsInstanceOf<Submission> (submission, "response is Submission");
            Assert.AreEqual(
              true, submission.Expired);
        }

        /// <summary>
        /// Test GeneratePDF
        /// </summary>
        [Test]
        public void GeneratePDFTest()
        {
            string templateId = "tpl_000000000000000001";
            var submissionData = new SubmissionData(
              test: false,
              data: new {
                title = "Test PDF",
                description = "This PDF is great!"
              }
            );

            var response = instance.GeneratePDF(templateId, submissionData);
            Assert.IsInstanceOf<CreateSubmissionResponse> (response, "response is CreateSubmissionResponse");
            Assert.AreEqual(
              CreateSubmissionResponse.StatusEnum.Success,
              response.Status);
            var submission = response.Submission;
            StringAssert.StartsWith("sub_", submission.Id);
            Assert.AreEqual(false, submission.Expired);
            Assert.AreEqual(
              Submission.StateEnum.Pending,
              submission.State);
        }

        /// <summary>
        /// Test GeneratePDF
        /// </summary>
        [Test]
        public void GeneratePDFWithDataRequestsTest()
        {
            string templateId = "tpl_000000000000000001";
            var submissionData = new SubmissionData(
              test: false,
              data: new {
                title = "Test PDF",
              },
              dataRequests: new List<CreateSubmissionDataRequestData>{
                new CreateSubmissionDataRequestData(
                  name: "John Smith",
                  email: "jsmith@example.com",
                  fields: new List<string>{ "description" },
                  order: 1,
                  authType: CreateSubmissionDataRequestData.AuthTypeEnum.Emaillink
                )
              }
            );

            var response = instance.GeneratePDF(templateId, submissionData);
            Assert.IsInstanceOf<CreateSubmissionResponse> (response, "response is CreateSubmissionResponse");
            Assert.AreEqual(
              CreateSubmissionResponse.StatusEnum.Success,
              response.Status);
            var submission = response.Submission;
            StringAssert.StartsWith("sub_", submission.Id);
            Assert.AreEqual(submission.Expired, false);
            Assert.AreEqual(
              submission.State,
              Submission.StateEnum.Waitingfordatarequests);

            var dataRequests = submission.DataRequests;
            Assert.That(dataRequests, Has.Count.EqualTo(1));

            var dataRequest = dataRequests.First();
            Assert.IsInstanceOf<SubmissionDataRequest> (dataRequest, "dataRequest is SubmissionDataRequest");

            StringAssert.StartsWith("drq_", dataRequest.Id);
            Assert.AreEqual(
              dataRequest.State,
              SubmissionDataRequest.StateEnum.Pending);
            CollectionAssert.AreEqual(
              new List<string>{ "description" },
              dataRequest.Fields);
            Assert.AreEqual(1, dataRequest.Order);
            Assert.AreEqual("John Smith", dataRequest.Name);
            Assert.AreEqual("jsmith@example.com", dataRequest.Email);
        }

        /// <summary>
        /// Test GetCombinedSubmission
        /// </summary>
        [Test]
        public void GetCombinedSubmissionTest()
        {
            string combinedSubmissionId = "com_000000000000000001";
            var response = instance.GetCombinedSubmission(combinedSubmissionId);
            Assert.IsInstanceOf<CombinedSubmission> (response, "response is CombinedSubmission");
            StringAssert.StartsWith("com_", response.Id);
        }

        /// <summary>
        /// Test GetSubmission
        /// </summary>
        [Test]
        public void GetSubmissionTest()
        {
            string submissionId = "sub_000000000000000001";
            var response = instance.GetSubmission(submissionId);
            Assert.IsInstanceOf<Submission> (response, "response is Submission");
            StringAssert.StartsWith("sub_", response.Id);
        }

        /// <summary>
        /// Test ListTemplates
        /// </summary>
        [Test]
        public void ListTemplatesTest()
        {
            int? page = 1;
            int? perPage = 10;
            var response = instance.ListTemplates("API Client Test Template 2", page, perPage);
            Assert.IsInstanceOf<List<Template>> (response, "response is List<Template>");
            Assert.That(response, Has.Count.EqualTo(1));
            Assert.AreEqual("tpl_000000000000000002", response.First().Id);
        }

        /// <summary>
        /// Test GetTemplate
        /// </summary>
        [Test]
        public void GetTemplateTest()
        {
            string templateId = "tpl_000000000000000001";
            var template = instance.GetTemplate(templateId);
            Assert.IsInstanceOf<Template> (template, "template is Template");
            Assert.AreEqual(template.Id, "tpl_000000000000000001");
        }

        /// <summary>
        /// Test GetTemplateSchema
        /// </summary>
        [Test]
        public void GetTemplateSchemaTest()
        {
            string templateId = "tpl_000000000000000001";
            var schema = instance.GetTemplateSchema(templateId);
            Assert.IsInstanceOf<Dictionary<string, Object>> (
              schema, "schema is Dictionary<string, Object>");
            Assert.AreEqual(schema["id"],
              "https://api.formapi.io/api/v1/templates/tpl_000000000000000001/schema.json");

            Assert.AreEqual("API Client Test Template 1", schema["title"]);
            Assert.AreEqual("JSON Schema generated by FormAPI.io", schema["description"]);
            Assert.IsInstanceOf<Newtonsoft.Json.Linq.JObject> (
              schema["properties"], "schema[\"properties\"] is Dictionary<string, Object>");

            var properties = schema["properties"] as Newtonsoft.Json.Linq.JObject;
            Assert.AreEqual(2, properties.Count);
        }

        /// <summary>
        /// Test GetTemplate
        /// </summary>
        [Test]
        public void CreateTemplateTest()
        {
            // Path is relative to clients/csharp/src/FormApi.Client.Test/bin/Debug
            var pdfFixturePath = Path.Combine(
              Directory.GetCurrentDirectory(),
              "../../../../../../test_fixtures/first_last_signature.pdf");
            Stream templateDocument = File.OpenRead(pdfFixturePath);
            var templateName = "Test PDF Template from C Sharp";
            var template = instance.CreateTemplate(templateDocument, templateName);

            Assert.IsInstanceOf<PendingTemplate> (template, "template is PendingTemplate");
            StringAssert.StartsWith("tpl_", template.Id);
            Assert.AreEqual(template.Name, "Test PDF Template from C Sharp");
        }

        /// <summary>
        /// Test TestAuthentication
        /// </summary>
        [Test]
        public void TestAuthenticationTest()
        {
            var response = instance.TestAuthentication();
            Assert.IsInstanceOf<AuthenticationSuccessResponse> (response, "response is AuthenticationSuccessResponse");
            Assert.AreEqual(
              AuthenticationSuccessResponse.StatusEnum.Success,
              response.Status);
        }
    }
}
