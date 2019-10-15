Executing the tests on your website:
1. Make sure the Web services module is installed (Administration -> Modules And Services)
2. Create a request access token for the web services to authenticate the test framework requests by following the documentation: https://www.progress.com/documentation/sitefinity-cms/request-access-token-for-calling-web-services
3. Clone the github repository
4. Restore NuGet packages and Build the solution
5. In the App.config file of the solution set the following properties:
* baseUrl - the root Url of the website that the tests are going to run against (e.g. localhost)
* username - the username of the user
* password - the password of the user
* grant_type - the grant type
* scope - the scope
* client_id - the client_id you have created in step 2
* client_secret - the client_id you have created in step 2
6. Run the tests.
