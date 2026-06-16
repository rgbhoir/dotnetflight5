using System.Reflection.PortableExecutable;

namespace MvcWebAppFlight.NewFolder
{
    public class CICD
    {
    }
}

//Set up a CI/CD pipeline for a .NET application using YAML and virtual machine in Azure DevOps:

//https://azure.microsoft.com/en-us/get-started/azure-portal

//Step 1) First Create a VM - VM4
//Username: __________(rgbhoir)
//Password: __________

//Subscription 4
//ResourceGroup: RG4
//Region - Central India
//Security Type: Standard
//Image: Windows Server 2025 Datacenter 
//RDP 3389
//Delete with VM - Tick marked
//Public IP-VM4-ip
//Delete public Ip and NIC when VM is deleted - Tick marked
//Tags- Owner-Rupesh

//VM - OS Disk, Public IP, NIC,
//Public IP: 20.244.81.11
//135.235.137.158
//98.70.43.248
//135.235.139.242
//98.70.26.35
//==============================================
//Step 2) Log in VM4
//Access VM4 from RDC, Remote Desktop Connection
//Enter VM Login credentials

//Open github.com - https://github.com/
//Username: __________ (rgbhoir)
//Password: __________ 
//==============================================

//Step 3) Download and Install Dotnet sdk, Visual Studio Community 2022  and git

//https://dotnet.microsoft.com/en-us/download
//https://git-scm.com/downloads

//dotnet-sdk-9.0.305-win-x64.exe
//dotnet-sdk-10.0.301-win-x64.exe
//Install DotNet 9.0/ 10.0 SDK in VM
//dotnet --version
//9.0.305
//10.0.301

//dotnet --list-sdks
//10.0.301 [C:\Program Files\dotnet\sdk]

//Download and Install Git in VM
//Git-2.54.0-64-bit.exe

//Download and install Visual Studio Community 2022
//https://visualstudio.microsoft.com/vs/community/

//During installation:
//Workloads:
//Tick marked - ASP.NET & web development 
//Tick marked - Azure & AI development

//Install (Approx size 10.79 GB)

//After installation - 
//Signed with Microsoft account - rgbhoir1984@outlook.com (Tried this option)


//==============================================
//Step 4) Create a ASP.NET Core Web App (Model-View-Controller)  Project Using IDE:
//Project Name: MvcWebAppFlight
//Location:...\Projects\dotnet\
//Solution name: MvcWebAppFlight
//Untick - Place solution and project in the same directory
//Project will be created in "C:\Projects\....\dotnet\MvcWebAppFlight\MvcWebAppFlight"

//Framework: .NET 9.0/ 10.0(Standard Term Support) (Long Term Support)
//Tick- Configure for HTTPS
//Tick- Do not use top-level statements

//Project will be created and then run the project.
//Open it on browser -> https://localhost:7009   / 7263
//If any security issues, then open in Private browser window

//Save all and close the IDE (Otherwise during git add . command, it throws error)

//Another way to create a project, using CLI:
//dotnet new mvc -n MvcWebAppFlight
//cd MvcWebAppRGB
//dotnet run
//http://localhost:5228/
//==============================================
//Step 5) Log in Github account from VM. Already logged in.
//Username: __________ (rgbhoir)
//Password: __________

//Create a New repository - dotnetflight2  / dotnetflight5
//Choose Visibility - Public

//Open local repo of MvcWebAppFlight in cmd and run below commands:

//C:\Projects\dotnet\MvcWebAppFlight> 
//git config --global user.email rgbhoir@gmail.com

//git init
//git add .
//git commit -m "Initial commit"
//git branch -M main
//git remote add origin https://github.com/rgbhoir/dotnetflight5.git
//git push -u origin main

//Sign in with your browser -> Authentication Succeeded
//Use chrome browser 
//Open or refresh the browser https://github.com/rgbhoir/dotnetflight5

//You will see 3 folders/files as below:
//.vs folder, MvcWebAppFlight folder, MvcWebAppFlight.slnx

//========
//…or push an existing repository from the command line
//git remote add origin https://github.com/rgbhoir/dotnetflight2.git
//git branch -M main
//git push -u origin main

//==============================================

//Step 6) Create New Organization in Azure DevOps

//Three ways to access DevOps:
//https://azure.microsoft.com/en-us/get-started/azure-portal
//https://portal.azure.com/#view/Microsoft_Azure_Resources/AzureDevOps.ReactView (I tried this URL)
//https://aex.dev.azure.com/me?mkt=en-US

//Create new organization (Blue color button)
//rgbhoir1984@outlook.com -> Continue button 
//dev.azure.com/ rgbhoir1984
//We will host your projects in Europe (Select from drop down)

//If it throws error as "You reached max number of organization created or deleted"

//VS850036: Maximum number of organizations reached.

//Then come back to home page from where it asks "create new organization"
//There at down side it shows all the created or deleted organization.
//Restore the deleted organization by entering new name for the deleted organization:
//rgbhoir1984new - Enter it manually for the organization name

//==============================================
//Step 7) Open newly created organization
//dev.azure.com/rgbhoir1984new 

//https://dev.azure.com/rgbhoir1984new/

//Create a project to get started
//Project name(required field)* - MVCFirstApp (Type it manually) / MVCThirdApp
//Visibility - Private (By default)
//+ Create Project - Click on blue color button

//==============================================

//Step 8) Create YAML Pipeline in Azure DevOps Using GitHub Repo

//1. Go to your Azure DevOps project.
//https://dev.azure.com/rgbhoir1984new/MVCFirstApp
//https://dev.azure.com/rgbhoir1984new/MVCThirdApp

//2. Navigate to Pipelines (Left menu) > Create Pipeline button
//Create your first pipeline
//It will show 4 tabs connect-> Select-> Configure -> Review

//First tab, Connect
//New pipeline
//Where is your code?
//3 options - 1.Azure Repos Git(YAML), 2. GitHub (YAML), 3, Bitbucket Cloud (YAML)
//Choose GitHub (YAML)

//Second tab, Select
//New pipeline
//Select a repository
//dotnetflight2 / dotnetflight5

//Note: At a down side, if it shows, Selected 2 repositories. Delete other repo, and keep only one repo.
//Click on "Approve & Install" green color button
//It will ask pick an account: rgbhoir1984@outlook.com

//Third tab, Configure
//New pipeline
//Configure your pipeline
//Choose the first one i.e. Starter Pipeline

//( Note:
//Azure portal was modified and previousbly it was showing multiple options 
//1.ASP.NET, 2. ASP.NET Core (.NET Framework), 3. .NET Desktop, 4. Universal Windows Platform, 4. Xamarin.Android, 5. Xamarin.iOS, 6. Starter pipeline, 7. Existing Azure Pipelines YAML file

//I selected 6th option Starter pipeline
//)

//Fouth tab, Review
//New pipeline
//Review your pipeline YAML

//It will show you .yml file as below: 

//rgbhoir/dotnetflight5/azure-pipelines.yml

//# Starter pipeline
//# Start with a minimal pipeline that you can customize to build and deploy your code.
//# Add steps that build, run tests, deploy, and more:
//# https://aka.ms/yaml

//trigger:
//- main

//pool:
//  vmImage: ubuntu-latest

//steps:
//- script: echo Hello, world!
//  displayName: 'Run a one-line script'

//- script: |
//    echo Add other tasks to build, test, and deploy your project.
//    echo See https://aka.ms/yaml
//  displayName: 'Run a multi-line script'



//============================================ Start: Correct Version V1 of .yml file after successful CI stage =============================


//I modified the yml file as below:

//Correct Version V1: 

//# Starter pipeline
//# Start with a minimal pipeline that you can customize to build and deploy your code.
//# Add steps that build, run tests, deploy, and more:
//# https://aka.ms/yaml

//trigger:
//- main

//pool:
//  name: Default
//  demands:
//    - agent.name -equals VM4

//variables:
//  buildConfiguration: 'Release'

//steps:
//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'restore'
//    projects: '**/*.csproj'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'build'
//    projects: '**/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'test'
//    projects: '**/*Tests/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'publish'
//    publishWebProjects: true
//    arguments: '--configuration $(buildConfiguration) --output $(Build.ArtifactStagingDirectory)'
//    zipAfterPublish: true

//- task: PublishBuildArtifacts@1
//  inputs:
//    pathToPublish: '$(Build.ArtifactStagingDirectory)'
//    artifactName: 'drop'
//    publishLocation: 'Container'


//============================================ End: Correct version of .yml file after successful CI stage ================================
//Step 9) Now you are in a last stage of create Pipeline  
//- Click on Save and Run (Blue color button)

//Another window: Save and Run 
//Saving will commit azure-pipelines.yml to the repository.

//Commit message: Set up CI with Azure Pipelines

//Select radio button - Commit directly to the main branch

//Click on Save and Run (Blue color button)


//Stages option will be visible Click that Stages box.


//This pipeline needs permission to access a resource before this run can continue
//Job is pending...
//Clcik on "View" button 


//Check and manual validations for Stage 0
//Permission - "Permit" blue color button -> Click that Permit button
//Granting permission here will permit the use of Agent pool 'Default' for all waiting and future runs of this pipeline.
//Click "Permit" button
//On Black screen it will show Job - Job preparation parameters

//Go back and then again Stages option will be visible Click that Stages box.

//Pool: Default
//Queued: Just now [manage parallel jobs]
//The agent request is not running because all potential agents are running other requests. Current position in queue: 1
//Job preparation parameters

//Right now (15 June 2026), The following error msg is not shown.


//It will show "creating piplines..." (for few seconds) ->
//#20251005.1 • Set up CI with Azure Pipelines
//rgbhoir.dotnetflight2

//After few seconds it will show error as
//##[error]No hosted parallelism has been purchased or granted. To request a free parallelism grant, please fill out the following form https://aka.ms/azpipelines-parallelism-request
//Pool: Azure Pipelines
//Image: ubuntu-latest
//Started: Just now
//Duration: 1m 36s

//Job preparation parameters

//==========================================
//Step 10) Download vsts agent (Visual Studio Technology)

//[error]No hosted parallelism has been purchased or granted. To request a free parallelism grant, please fill out the following form https://aka.ms/azpipelines-parallelism-request

//PAT
//Download vsts agent (Visual Studio Technology)

//https://download.agent.dev.azure.com/agent/4.261.0/vsts-agent-win-x64-4.261.0.zip
//Extract the .zip folder and paste it into c:\agent\ folder
//C:\agent\vsts-agent-win-x64-4.261.0>
//C:\agent\vsts-agent-win-x64-4.261.0>config.cmd
//and then take pause here. Create PAT first, because PAT is required here.

//==========================================
//Step 11) Create PAT:
//Go to Azure DevOps (https://dev.azure.com/rgbhoir1984new/) 
//	-> User Settings (Top right side near blue color circular profile logo) -> Choose second last option i.e. "PAT"
//Create a new pat by clicking "+ New Token" blue color button.
//	Name: PAT2 (type it manually)
//     	Organization name: rgbhoir1984new
//	Scopes: Full access
//Then clcik on "Create" button.

//Copy and paste the token when prompted


//==========================================
//Step 12) Come to existing CMD agent\config.cmd   (I have not followed on 15th June)

//C:\agent\vsts-agent-win-x64-4.261.0>config.cmd



//Then I came to existing CMD prompt where I have already run agent\config.cmd 

//>> Connect:

//Enter server URL > https://dev.azure.com/rgbhoir1984new/
//Enter authentication type (press enter for PAT) > Press Enter button
//Enter pat > 
//Copy the above PAT2 and Paste here manually

//************************************************************************************
//Connecting to server ...

//>> Register Agent:

//Enter agent pool (press enter for default) >
//Enter agent name (press enter for VM4)(For me it shows TALW42NLPC2783 when I didn't use VM) >  
//Enter replace? (Y/N) (press enter for N) >
//Scanning for tool capabilities.
//Connecting to the server.
//Successfully added the agent
//Testing agent connection.
//Enter work folder (press enter for _work) >
//2025-09-27 15:01:13Z: Settings Saved.
//Enter run agent as service? (Y/N) (press enter for N) > Y
//Enter enable SERVICE_SID_TYPE_UNRESTRICTED for agent service (Y/N) (press enter for N) >
//Enter User account to use for the service (press enter for NT AUTHORITY\NETWORK SERVICE) >
//Granting file permissions to 'NT AUTHORITY\NETWORK SERVICE'.
//Service vstsagent.rgbhoir1984.Default.VM4 successfully installed
//Service vstsagent.rgbhoir1984.Default.VM4 successfully set recovery option
//Service vstsagent.rgbhoir1984.Default.VM4 successfully set to delayed auto start
//Service vstsagent.rgbhoir1984.Default.VM4 successfully configured
//Enter whether to prevent service starting immediately after configuration is finished? (Y/N) (press enter for N) > Y

//==========Start E1: I got error so again tried the same ========
//>> Connect:

//Enter server URL > https://dev.azure.com/rgbhoir1984new/
//Enter authentication type (press enter for PAT) >
//Enter pat > ************************************************************************************
//Connecting to server ...

//>> Register Agent:

//Enter agent pool (press enter for default) >
//Enter agent name (press enter for VM4) >
//Enter replace? (Y/N) (press enter for N) >
//Scanning for tool capabilities.
//Connecting to the server.
//Pool Default already contains an agent with name VM4.
//Enter replace? (Y/N) (press enter for N) >
//Enter agent name (press enter for VM4) >
//Enter replace? (Y/N) (press enter for N) >
//Scanning for tool capabilities.
//Connecting to the server.
//Pool Default already contains an agent with name VM4.
//Enter replace? (Y/N) (press enter for N) > Y    -------------- (Manually typed)
//Successfully replaced the agent
//Testing agent connection.
//Enter work folder (press enter for _work) >
//2025-10-05 09:24:20Z: Settings Saved.
//Enter run agent as service? (Y/N) (press enter for N) > Y    -------------- (Manually typed)
//Enter enable SERVICE_SID_TYPE_UNRESTRICTED for agent service (Y/N) (press enter for N) >
//Enter User account to use for the service (press enter for NT AUTHORITY\NETWORK SERVICE) >
//Granting file permissions to 'NT AUTHORITY\NETWORK SERVICE'.
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully installed
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully set recovery option
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully set to delayed auto start
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully configured
//Enter whether to prevent service starting immediately after configuration is finished? (Y/N) (press enter for N) > Y    -------------- (Manually typed)

//========== End E1 =============================================


//=========== Start 15 June 2026 

//Step 12) Come to existing CMD agent\config.cmd   (I have not followed on 15th June)

//C:\agent\vsts-agent-win-x64-4.261.0>config.cmd



//>> Connect:

//Enter server URL > https://dev.azure.com/rgbhoir1984new/
//Enter authentication type (press enter for PAT) >
//Enter pat > ************************************************************************************


//Connecting to server ...

//>> Register Agent:

//Enter agent pool (press enter for default) >
//Enter agent name (press enter for VM4) >
//Enter replace? (Y/N) (press enter for N) >
//Scanning for tool capabilities.
//Connecting to the server.
//Pool Default already contains an agent with name VM4.
//Enter replace? (Y/N) (press enter for N) > Y
//Successfully replaced the agent
//Testing agent connection.
//Enter work folder (press enter for _work) >
//2026-06-15 06:46:32Z: Settings Saved.
//Enter run agent as service? (Y/N) (press enter for N) > Y
//Enter enable SERVICE_SID_TYPE_UNRESTRICTED for agent service (Y/N) (press enter for N) >
//Enter User account to use for the service (press enter for NT AUTHORITY\NETWORK SERVICE) >
//Granting file permissions to 'NT AUTHORITY\NETWORK SERVICE'.
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully installed
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully set recovery option
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully set to delayed auto start
//Service vstsagent.rgbhoir1984new.Default.VM4 successfully configured
//Enter whether to prevent service starting immediately after configuration is finished? (Y/N) (press enter for N) > Y

//=========== End 15 June 2026

//==========================================
//Step 13) Start the Agent Service Manually

//CMD:
//C:\agent> net start vstsagent.rgbhoir1984new.Default.VM4

//C:\agent> sc query vstsagent.rgbhoir1984new.Default.VM4   (NA)

//If it shows `STATE: STOPPED`, the service exists but isn’t running.


//===================== Start NA3 =============
//You can now go to Azure DevOps and:

//Navigate to your organization: https://dev.azure.com/rgbhoir1984new
//Go to Project → Project Settings → Agent Pools → Default
//You should see your agent VM4 listed and online.
//===================== End NA3 =============

//==========================================
//Step 13) Modify the .yml file as Correct Version V1 from github portal

//I tried this github push from local repo
//Alternative steps 
//1. Save this YAML as `azure-pipelines.yml` in your project root.
//2. Commit and push to your GitHub repo:
//   git pull   / git pull origin main
//   git add azure-pipelines.yml
//   git commit -m "Update pipeline to use self-hosted agent"
//   git push


//I tried below one, .yml is same as above mentioned at Correct Version V1:
//azure-pipelines.yml file:   (I edited .yml file from github portal)

//trigger:
//- main

//pool:
//  name: Default
//  demands:
//    - agent.name -equals VM4

//variables:
//  buildConfiguration: 'Release'

//steps:
//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'restore'
//    projects: '**/*.csproj'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'build'
//    projects: '**/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'test'
//    projects: '**/*Tests/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'publish'
//    publishWebProjects: true
//    arguments: '--configuration $(buildConfiguration) --output $(Build.ArtifactStagingDirectory)'
//    zipAfterPublish: true

//- task: PublishBuildArtifacts@1
//  inputs:
//    pathToPublish: '$(Build.ArtifactStagingDirectory)'
//    artifactName: 'drop'
//    publishLocation: 'Container'

//==========================================
//Step 14) Verify Agent Status

//Go to:
//- **Azure DevOps > Project Settings > Agent Pools > Default**
//- You should see your agent `VM4` listed as **Online**
//https://dev.azure.com/rgbhoir1984new/MVCFirstApp/_build
//---- Alternative explanation - Once done, go to Azure DevOps > Project Settings > Agent Pools > Default and confirm that your agent VM4 is Online.

//==========================================
//Step 15) Select the recent pipeline (#20251005.2 • Update azure-pipelines.yml) to run 

//It shows Warning as :
//"This pipeline needs permission to access a resource before this run can continue"

//Then on same window -> Jobs Permission Needed (Red color text) -> Checks (New window) -> Click on Permit (Blue color button)

//It shows dialog box as below:
//Permit access?
//Granting permission here will permit the use of Agent pool 'Default' for all waiting and future runs of this pipeline.

//Click on Permit/OK button


//I got below errors:
//Errors
//2
//Error: Unable to locate executable file: 'dotnet'. Please verify either the file path exists or the file can be found within a directory specified by the PATH environment variable. Also verify the file has a valid extension for an executable file.
//DotNetCoreCLI
//Packages failed to restore
//DotNetCoreCLI

//===== Resolution for above error:
//Unable to locate executable file: 'dotnet'

//means that your **self-hosted agent VM does not have the .NET 9 SDK installed or properly configured in the system PATH**.

//Fix the Issue: Install .NET 9 SDK on Your Agent VM
//1. Download and Install .NET 9 SDK
//Go to the official .NET download page:
//https://dotnet.microsoft.com/en-us/download/dotnet/9.0

//Download the .NET 9 SDK for Windows x64 and install it.

//2. Verify Installation
//cmd:
//dotnet --version
//9.0.x
//If this works, your agent will now be able to run `dotnet` commands.

//Optional: Add .NET SDK to System PATH (if needed)

//If `dotnet` is still not recognized, manually add the SDK path to your system environment variables:

//1. Go to **System Properties → Environment Variables**
//2. Under **System Variables**, find `Path` → Edit
//3. Add the path where .NET SDK is installed, typically:

//```
//C:\Program Files\dotnet\
//```

//Then restart the agent service:

//```cmd
//net stop vstsagent.rgbhoir1984new.Default.VM4
//net start vstsagent.rgbhoir1984new.Default.VM4

//Re-run the Pipeline

//Once the SDK is installed and recognized:

//- Go to Azure DevOps → Pipelines → Run the pipeline again.
//- It should now successfully restore, build, test, and publish your .NET 9 MVC project.


//==========================================
//Step 15) Select the recent pipeline to run #20251005.2 • Update azure-pipelines.yml

//CI Pipeline is running successfully.


//==========================================
//Step 16) Take git pull in local repo, modify the code, and push it and check the pipeline running

//C:\Projects\dotnet\MvcWebAppFlight>git pull
//git add .
//git commit -m "modified index.cshtml"
//git branch -M main
//git push -u origin main

//Go to Azure DevOps -> recent pipeline 
//CI Pipeline is running successfully.


//*******************************After successful CI stages, CD Started 5-Oct-2025 *************************************
//********************************Create Web App ************************************



//##  Step-by-Step: Fresh CD Pipeline Setup
//=================================================
//CD Step 1) Create Azure App Service (if not already done)

//In Azure Portal:
//Resource -> Web App (Blue color circle icon)-> Create Web App
//1. Go to **App Services > + Create**
//2. Fill in:
//Project Details:
//    Subscription 2
//   - **Resource Group**:  I selected as RG5 (on 5-Oct2025) - DefaultResourceGroup-CID (OLD) (or create a new one) 
//Instance Details
//   - **Name**: `mvcwebapp-rgbhoir-new`  (Type it manually)
//(Automatically it shows as below:

//mvcwebapp-rgbhoir-new
//-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net (16-June-2026)

//mvcwebapp-rgbhoir-new
//-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net  (on 5-Oct-2025)

//mvcwebapp-rgbhoir-new
//-brawbgfzcqbvekdw.germanywestcentral-01.azurewebsites.net) (Old)

//   - **Runtime Stack**: `.NET 9 (STS)
//   - **OS**: Windows
//   - **Region**: Canada Central (5-Oct-2025), Germany West Central (old)
//   - **Pricing Plan**: Free (F1) or Basic (B1) - 
//   	- Windows Plan (Canada Central) - ASP-RG5-a327
//	- Pricing Plan - Premium V4 P0V4 (4 GB memory, 1 vCPU)
//3. Click **Review + Create**, then **Create**

//After deployment

//Properties:
//Web app
//Name
//mvcwebapp-rgbhoir-new

//Domains: 
//Default domain:
//mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net

//mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net (new)

//mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net (16-June-2026)

//Hosting:
//Name
//ASP-RG5-a327

//Application Insights
//Name
//mvcwebapp-rgbhoir-new
//Region
//Canada Central

//Networking
//Virtual IP address
//20.116.42.0

//=================================================
//CD Step 2) Try below two urls from browser:
//20.116.42.0   ====> 404 Web Site not found.

//https://mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net/
//              ====> Your web app is running and waiting for your content


//============== Start: Not required below steps: ===========

//WARN-R101 Shows warning as : Basic authetication to this app is disabled

//Deployment name:Microsoft.Web-WebApp-Portal-ad4cd7f3-9ba8
//Subscription:Subscription 2
//Resource group:DefaultResourceGroup-CID
//Start time:9/27/2025, 8:00:27 PM
//Correlation ID:
//be41c90d-7041-424a-9c4b-3d47bb2be1fb


//New Deployed 01: 
//mvcwebapp-rgbhoir-new
//Web App


//>  Confirm that the App Service is **successfully created** and visible in Azure Portal.

//============== End: Not required below steps: ===========



//=================================================
//CD Step 2) Confirm Azure Service Connection

//In Azure DevOps-> Organization-> Project-> Settings (Left menu bottom side)
//https://dev.azure.com/rgbhoir1984new/MVCThirdApp/_settings/adminservices

//-> Pipelines-> Service Connections 

//1. Go to Service Connections -> Top Right corner -> New service connection button (grey color button) 
//-> It opens another dialog box
//There are many options as below:

//New service connection
//Choose a service or connection type

//Follow below steps:
//Select Azure Resource Manager -> Next -> Open new dialog


//But here, it asks to sign in 
//Sign in using rgbhoir1984@outlook.com

//New Azure service connection
//Azure Resource Manager
//Identity type: App registration (automatic)

//Credential: Workload identity federation

//Scope level: Subscription (First radio button) 

//Subscription: Select Subscription 2 (3ec3cbc5...................)
//Resource Group: Select RG5
//Service connection name: AzureConnection-RGB-new

//Check - Grant access permission to all pipelines

//Click Save

//2. Confirm:
//   - Service Connection Name: `AzureConnection-RGB-new`
//   - Subscription: `Subscription 2`
//   - Resource Group: `DefaultResourceGroup-CID`
//   -  **Grant access permission to all pipelines** is checked
//******************************* Final-R1-Copy *************************************
//***********************************************************************************


//=================================================
//CD Step 3) Update Your YAML Pipeline**

//Final-R1-Copy of .yml file - 5-Oct-2025

//Here’s the **correct YAML** for your scenario:

//# Starter pipeline
//# Start with a minimal pipeline that you can customize to build and deploy your code.
//# Add steps that build, run tests, deploy, and more:
//# https://aka.ms/yaml

//trigger:
//- main

//pool:
//  name: Default
//  demands:
//    - agent.name -equals VM4

//variables:
//  buildConfiguration: 'Release'

//steps:
//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'restore'
//    projects: '**/*.csproj'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'build'
//    projects: '**/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'test'
//    projects: '**/*Tests/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'publish'
//    publishWebProjects: true
//    arguments: '--configuration $(buildConfiguration) --output $(Build.ArtifactStagingDirectory)/publish'
//    zipAfterPublish: true

//- task: PublishBuildArtifacts@1
//  inputs:
//    pathToPublish: '$(Build.ArtifactStagingDirectory)/publish'
//    artifactName: 'drop'
//    publishLocation: 'Container'

//- task: AzureWebApp@1
//  inputs:
//    azureSubscription: 'AzureConnection-RGB-new'
//    appType: 'webApp'
//    appName: 'mvcwebapp-rgbhoir-new'
//    package: '$(Build.ArtifactStagingDirectory)/publish/**/*.zip'


//=================================================

//IF CD doesn't work then replace .yml file as below:

//trigger:
//- main

//pool:
//  name: Default
//  demands:
//    - agent.name -equals VM4

//variables:
//  buildConfiguration: 'Release'

//steps:

//# Restore
//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'restore'
//    projects: '**/*.csproj'

//# Build
//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'build'
//    projects: '**/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'

//# Test (optional if no test project)
//- task: DotNetCoreCLI@2
//  inputs:
//    command: 'test'
//    projects: '**/*Tests/*.csproj'
//    arguments: '--configuration $(buildConfiguration)'
//  continueOnError: true

//# Publish (IMPORTANT)
//- task: DotNetCoreCLI@2
//  displayName: Publish App
//  inputs:
//    command: 'publish'
//    publishWebProjects: true
//    arguments: '--configuration $(buildConfiguration) --output $(Build.ArtifactStagingDirectory)'
//    zipAfterPublish: true

//# DEBUG STEP (VERY IMPORTANT )
//- script: |
//    echo "Listing files..."
//    dir $(Build.ArtifactStagingDirectory)
//  displayName: "Check Published Files"

//# Deploy
//- task: AzureWebApp@1
//  inputs:
//    azureSubscription: 'AzureConnection-RGB-new'
//    appType: 'webApp'
//    appName: 'mvcwebapp-rgbhoir-new'
//    package: '$(Build.ArtifactStagingDirectory)/**/*.zip'

//=================================================
//CD Step 4) Take git pull in local repo, modify the code, and push it and check the pipeline running

//C:\Projects\dotnet\MvcWebAppFlight>git pull
//git add .
//git commit -m "modified yml file v3 for CD"
//git branch -M main
//git push -u origin main

//=================================================
//CD Step 5) Run the Pipeline

//1. Go to Azure DevOps > Organization > Project> Settings> Pipelines > Agent pools > Default -> Select the pipeline (Recent one) -> 
//Job will show "Running" status -> Wait for few minutes (3-5 minutes) -> Job will show "Success" status
//2. Monitor the job — it should now:
//   - Build your app
//   - Publish artifacts
//   - Deploy to `mvcwebapp-rgbhoir`


//=================================================
//CD Step 6) Run on browser

//Final-R1-Copy-Run the app on browser

//Go to Azure Portal -> 
//mvcwebapp-rgbhoir-new
//Web App

//Copy Default domain value and paste it into browser URL

//mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net

//mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.canadacentral-01.azurewebsites.net    (5-Oct-2025)

//https://mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.germanywestcentral-01.azurewebsites.net/  (Old)

//mvcwebapp-rgbhoir-new-brawbgfzcqbvekdw.germanywestcentral-01.azurewebsites.net    (Old)



//=============
