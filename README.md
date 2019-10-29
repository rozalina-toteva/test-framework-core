Progress Sitefinity Test Framework Samples
==========================================

# Overview

As a [Sitefinity CMS](https://www.progress.com/documentation/sitefinity-cms) developer, you need to ensure that the backend functionality is working correctly. This is especially important after upgrading Sitefinity instances. A basic sanity check verifies that all the CRUD operations of content types that support ODATA Services work properly. 

The sample code in this repository uses Sitefinity ODATA services to validate that CRUD operations work for all built-in content types. You can use this code to perform sanity checks for the built-in content types. You can also build upon it and test your custom content types. You can find how to do this below.

# Getting Started

This tutorial will guide you through configuring it to enable the execution of ODATA WCF services and create and execute integration tests using these services. It assumes you already have a working Sitefinity CMS instance.

## System Requirements

To successfully use the sample code we provide, you need:

* .Net Framework 4.8 Developer Pack
* Visual Studio 2017 or later
* Sitefinity CMS 12.2 or later

## The sample code

## Description

This GitHub repository contains two projects. 

### TestFrameworkCore\TestFrameworkCore.csproj

This project contains the infrastructure code, which enables writing tests using the Sitefinity WCF RESTful services. It also includes wrappers to expose data for the built-in content types to the tests you write.

In _ContentTypes_ project folder, you can find wrappers around the built-in Sitefinity CMS content types. The Sitefinity team provides and supports them. You can model wrappers you write for your own content types based on the code contained here.

### Tests\Tests.csproj

This is the project where the actual tests reside. You should add your tests either to this project or to a new one, which depends on _TestFrameworkCore.csproj_.

## Getting started

To execute the provided tests, follow this procedure:

1. Ensure your Sitefinity instance is set up to enable access through ODATA Web services.
   1. We recommend you not to run tests against Production environment and use a copy of it instead.
   2. Log in Sitefinity CMS backend with an administrative account
   3. Go to _Administration_ » _Web services_.
   4. Ensure that the "Default" web service is installed and active for all content types. To find more information about Sitefinity CMS RESTful WCF Services, see [here](https://www.progress.com/documentation/sitefinity-cms/72/for-developers-restful-wcf-services-in-sitefinity).
   5. Create a request access token for the web services to authenticate the test framework requests. Follow the setup guideline from [the documentation](https://www.progress.com/documentation/sitefinity-cms/request-access-token-for-calling-web-services) with the additional step outlined below.
   6. Navigate to _Administration_ » _Settings_ » _Advanced_ » _Authentication_ » _SecurityTokenService_ »  _IdentityServer_ » _Clients_ » <The client you have just created>. Ensure that the _Allowed scopes_ field contains "**openid**".
2. Clone the repository.
3. Open _TestFrameworkCore.sln_ in Visual Studio.
4. To configure the connection to a running Sitefinity instance open _App.config_ file in _Tests_ project and set these properties:
   * baseUrl - the root Url of the website that the tests are going to run against, for example, localhost.
   * username - the **email** of the user account. This must be a valid user account for the website you are testing against.
   * password - the password of the user account. This must be a valid user account for the website you are testing against.
   * grant_type - the grant type. The default value "password" suffices.
   * scope - the scope you have set up in step 1.6. The default value "openid" suffice.
   * client_id - the client_id you have created in step 1.5.
   * client_secret - the client secret you have created in step 1.5.
5. Restore NuGet packages and Build the solution.
6. Open the "Test Explorer" window and run the tests.

# Writing integration tests

When you have created additional dynamic content types, the provided tests won't be enough. You should develop tests that cover the extra functionality you've built in Sitefinity CMS.

## General guidelines

* Tests need to be atomic. Do not rely on the order in which tests are run.
* Do not expect anything from Sitefinity CMS except the initial state with which it has been installed.
* Always have in mind what do you want to test. Write one scenario per test function
* Tests must be deterministic

## A sample test

Let's go through an example test and use it as a template for writing additional tests.

```C#
// [TestClass] attribute signifies that the class contains test code to the testing framework
[TestClass]
public class NewsTests
{
    // [TestInitialize] signifies a method which executes before each test. Use it to connect and authenticate to the Sitefinity CMS instance
    [TestInitialize]
    public void TestInitialize()
    {
        AuthenticationHelper.Authenticate();
    }

    /// Each [TestMethod} should contain a concrete, self-contained test scenario.
    // This one creates a draft news item and validates the successful creation.
    [TestMethod]
    public void CreateNews()
    {
        var operations = new ContentOperations<News>();

        newsTitle = TestContentPrefix + Guid.NewGuid().ToString();
        var newsItem = new News
        {
            Title = newsTitle,
            Content = NewsContent
        };

        var response = operations.CreateDraft(newsItem);
        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

        var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
        Assert.AreEqual(newsItem.Title, results.Title.ToString());

        newsId = results.Id;
        Assert.IsNotNull(newsId);
    }

    // The [TestCleanup] attribute signifies code, which is executed after every test method. Use it to clean up the state in the Sitefinity CMS instance and ensure that no tests alter the state of Sitefinity after their completion.
    [TestCleanup]
    public void CleanUp()
    {
        var operations = new ContentOperations<News>();
        News newsItem = new News();
        newsItem.ID = newsId;
        if (operations.GetItem(newsItem).StatusCode == HttpStatusCode.OK)
        {
            operations.Delete(newsItem);
        }
    }

    private const string NewsContent = "The quick brown fox jumps over the lazy dog";
    private const string TestContentPrefix = "sf_test";
    private static Guid newsId;
    private static string newsTitle;
}
```

# More information

To find more information, see:

* [Develop: Use and extend Sitefinity CMS functionality](http://docs.sitefinity.com/develop-create-and-manage-website-content)
* [Synamic modules in Sitefinity CSM](https://www.progress.com/documentation/sitefinity-cms/for-developers-dynamic-modules)
* [Testing custom Sitefinity CMS code](https://www.progress.com/documentation/sitefinity-cms/best-practices-testing)
