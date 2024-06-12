## Github Copilot Demo Scripts

### Install copilot
- Extension, search "github copilot", install

### Basic usage
- Comments
- Right click
- Generate commit message

### Diagnostic
- Show Diagnostics...
- Open Logs...

### Explain the code
- Github copilot web, Sort.cs, explain this file

### Quicksort algorithm
- Implement the quicksort algorithm in C#, input is an array of integers, output is a sorted array of integers
- Let's think step by step
- Complete the rest part of QuickSort algorithm in C#

### Quicksort test cases
- Reference CopilotCsharp.Library, Sort.QuickSort, generate xunit framework based test cases
- Add more xunit test cases
- Please generate a few of xunit test cases for member function QuickSort, the test case function name should start with QuickSort, use '_' to concat test case scenario, for example, if the test case is empty array, then the function name is QuickSort_EmptyArray

### Webapi
- Show me command line to create a dotnet 7.0 webapi project named "Api"
  `dotnet new webapi -n Api -f net7.0`
- How to add Api project to the solution file?
  `dotnet sln add Api/Api.csproj`
- How to reference Library project from Api project?
  `dotnet add ./Api/Api.csproj reference ./Library/Library.csproj`
- Create an asp.net core 7.0 webapi project, expose QuickSort from project Library as a REST API
- Can you rewrite to use json input?
- How to use curl to test SortController?
  `curl -X POST -H "Content-Type: application/json" -d '{"values": [5, 2, 1, 8, 4]}' http://localhost:5160/sort/quicksort`

### Regex
Regex.cs
- Create a function that use regex validates the format of URL
- Highlight JustARegex, type "make the code readable"

### IaC
- How to use bicep to deploy an Azure app service
- Generate a bicep file to deploy Api project into Azure app service

### Docker image
- Create a Dockerfile in Api folder, use the official dotnet core 7.0 sdk image to build Api project
- Please use dotnet core 7.0 sdk image?
- The docketfile needs to reference Library project as Api has dependency on it

### Github workflow
- Create a github workflow that builds docker image by using Api/Dockerfile and push the image to github repository
- Please use the latest github actions and use docker action?
- Please reference Dockerfile at Api directory
- Please reference root folder as the context and use Api/Dockerfile to build the image

### Add comments
- ///

### Fault
- Is there any issues within the highlighted code?

### Markdown editing
- Edit README.md file

### Translate code

### Enterprise features
- Knowledge base
- Skills
  `What skills are available?`
  `Use the Bing skill to find the latest AI news`
  `What does this repository do?`
  `Explain the changes in the code of this commit`
  `What are the advantages of the Go programming language?`
  
### Pull request summary
- Open a pull request, base:demo <- compare:main, click copilot button to generate PR summary

## Github copilot CLI
- gh copilot suggest "how to find all files less than 1MB"
- gh copilot suggest "how to get bitrate of mp4 file"

## Azure Copilot Demo Scripts

### Get resource information
"Show me all resources that are noncompliant"
"List all virtual machines lacking enabled replication resources"
"List all the updates applied to my Linux virtual machines"
"List all storage accounts that are accessible from the internet"
"List all virtual machines that are not running now"
"Write a query that finds all changes for last 7 days."
"Help me write an ARG query that looks up all virtual machines scale sets, sorted by creation date descending"
"What are the public IPs of my VMs?"
"Show me all my storage accounts in East US?"
"List all my Resource Groups and its subscription."
"Write a query that finds all resources that were created yesterday."

### VM
How do I reduce the cost of my virtual machine?
Help me create a cost-efficient virtual machine
Help me create a low cost VM

### Build infrastructure and deploy workloads 
https://portal.azure.com/#view/Microsoft_Azure_SolutionCenter/SolutionGroup.ReactView/groupid/defaultLandingVmBrowse

I want to deploy a website on Azure

.NET, no specific performance needs, I need autoscale, no security requiremnet, I need website available 24x7, yes, I have monthly budget for 100$

minimum instance: 1, maximum instance: 10, no company policies, I need full control, I need ARM deployment template, southeast region, no data store needed, please move ahead

### Storage account
How can I make this storage account more secure

### App service/functio app
What's wrong with my function app

### Generate Azure CLI scripts
I want to use Azure CLI to create a web application

### Author API Management policies
Generate a policy to configure rate limiting with 5 requests per second.
Generate a policy to remove a 'X-AspNet-Version' header from the response.

### Understand service health
Am I impacted by any service health events?
Is there any outage impacting me?

### Analyze, estimate and optimize cloud costs
Summarize my costs for the last 6 months.
Can you provide an estimate of our expected expenses for the next 6 months?
Show me the resource group with the highest spending in the last 6 months.
