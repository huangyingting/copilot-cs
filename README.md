## Quicksort algorithm
Sorts an array of integers using quicksort algorithm
Let's think step by step

help me complete the rest part of QuickSort

## Quicksort test cases
please reference CopilotCsharp.Library, Sort.QuickSort, generate xunit test cases

could you add more test cases

could you generate a few of xunit test cases for function QuickSort, the test case function name should start with QuickSort, then use _ to concat test case, for example, if the test case is empty array, then the function name is QuickSort_EmptyArray

## Webapi
what is the command line to create a dotnet 7.0 webapi project named "Api"

dotnet new webapi -n Api -f net7.0

dotnet sln add ./Api/Api.csproj
dotnet sln copilot-cs.sln add Api/Api.csproj 
dotnet sln add ./Api/Api.csproj

what is the dotnet command to reference Library project from Api project
dotnet add Api/Api.csproj reference Library/Library.cspibrary.csproj
dotnet add reference ../Library/Library.csproj

create an asp.net core 7.0 webapi project, and expose QuickSort as a REST API

can you rewrite to use json input?

how to use curl to test SortController?

curl -X POST -H "Content-Type: application/json" -d '{"values": [5, 2, 1, 8, 4]}' http://localhost:5160/sort/quicksort

## Regex
function that validates the format of URL

highlight JustARegex, then "make the code readable"

## IaC
Use bicep to deploy an Azure app service
generate a bicep file to deploy Api project into app service

## Docker image
Create a Dockerfile in Api folder, use the official dotnet core 7.0 sdk image to build Api project

can you use dotnet core 7.0 sdk image?

I need to reference Library project as Api has dependency on it

## Github workflow
Build docker image by using Api/Dockerfile and push to github repository

can you use the latest github actions and use docker action?

I need to reference Dockerfile at Api directory

I need to reference root folder as the context and use Api/Dockerfile to build the image

## Add comments
///

## Fault
Is there any issues with the code?

## Markdown editing

## Translate code

## Github Copilot CLI
gh copilot suggest "how to find all files less than 1MB"

gh copilot suggest "how to get bitrate of mp4 file"

## Azure Copilot
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
how can I make this storage account more secure

### App service/functio app
what's wrong with my function app

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
