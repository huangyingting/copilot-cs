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
