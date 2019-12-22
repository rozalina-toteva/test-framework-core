Progress® Sitefinity® CMS test framework samples
================================================

>**Latest supported version**: Sitefinity CMS 12.2.7200.0

## Overview

The sample code in this repository uses Sitefinity CMS OData services to validate that CRUD operations work for all built-in content types. You can use this code to perform sanity checks for the built-in content types. You can also build upon it and test your custom content types. You can find how to do this below.

This GitHub repository contains the following projects:

### `TestFrameworkCore\TestFrameworkCore.csproj`

This project contains the infrastructure code, which enables writing tests using the Sitefinity WCF RESTful services. It also includes wrappers to expose data for the built-in content types to the tests you write.

In `ContentTypes` project folder, you can find wrappers around the built-in Sitefinity CMS content types. The Sitefinity team provides and supports them. You can model wrappers you write for your content types based on the code contained here.

### `Tests\Tests.csproj`

This is the project where the actual tests reside. You should add your tests either to this project or to a new one, which depends on `TestFrameworkCore.csproj`.

## Prerequisites

To use the sample, you need:

* You must have a Sitefinity CMS license.
* Your setup must comply with the system requirements.  
 For more information, see the [System requirements](https://docs.sitefinity.com/system-requirements) for the respective Sitefinity CMS version.
* .NET Framework 4.8 Developer Pack
* Visual Studio 2017 or later
* Sitefinity CMS 12.2 or later

## Installation

>**RECOMMENDATION**: We do not recommend running tests against your production environment. Use a copy of it instead.

To execute the provided tests, perform the following:

1. Setup Sitefinity CMS with OData web services. To do this, perform the following:
   a. Log in Sitefinity CMS backend with an administrative account.
   b. In Sitefinity CMS backend, navigate to _Administration_ » _Settings_ » _Advanced_ » _Web services_.
   c. Ensure that the _Default_ web service is installed and active for all content types. For more information, see [Configure the Types of a service](https://www.progress.com/documentation/sitefinity-cms/configure-the-types).
   d. To authenticate the test framework requests, create a request access token for the web services. For more information, see [Request access token for calling web services](https://www.progress.com/documentation/sitefinity-cms/request-access-token-for-calling-web-services) with the additional step outlined below.
   e. In Sitefinity CMS backend, navigate to _Administration_ » _Settings_ » _Advanced_ » _Authentication_ » _SecurityTokenService_ »  _IdentityServer_ » _Clients_ » <The client you have just created>. 
   f. Ensure that the _Allowed scopes_ field contains **openid**.
2. Clone this repository.
3. Open _TestFrameworkCore.sln_ in Visual Studio.
4. To configure the connection to a running Sitefinity instance, in _Tests_ project, open _App.config_ file, and set the following properties:
   * `baseUrl` - the root URL of the website that the tests are going to run against. For example, `localhost`.
   * `username` - the **email** of the user account. This must be a valid user account for the website you are using for testing.
   * `password` - the password of the user account. This must be a valid user account for the website you are using for testing.
   * `grant_type` - the grant type. This tutorial assumes that you are using the `password` grant type.
   * `scope` - leave the default value - `openid`.
   * `client_id` - the client_id you have created in step 1.4.
   * `client_secret` - the client secret you have created in step 1.4.
5. Restore the NuGet packages and Build the solution.
6. In Visual Studio, open the _Test Explorer_ window and run the tests.

>**NOTE**: When you have created additional dynamic content types, the provided tests aren't enough. You should develop tests that cover the extra functionality you've built in Sitefinity CMS.

## General guidelines

* Tests need to be atomic. They should not rely on the order in which they are run.
* Tests should not expect anything from Sitefinity CMS except the initial state with which it has been installed.
* Always have in mind what you want to test. Write one scenario per test function.
* Tests must be deterministic.

## Sample test

Use the following sample as a template for writing additional tests:
https://github.com/Sitefinity/test-framework-core/blob/master/Tests/Tests/News/NewsTests.cs


## More information

For more information, see:

* [Dynamic modules API](https://www.progress.com/documentation/sitefinity-cms/for-developers-dynamic-modules)
* [Best practices for testing](https://www.progress.com/documentation/sitefinity-cms/best-practices-testing)
