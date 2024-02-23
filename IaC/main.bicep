// Use bicep to deploy an Azure app service

// Create a resource group
const resourceGroup = new azure.core.ResourceGroup("rg", {
    location: "West US"
});

// Create an app service plan
const plan = new azure.appservice.Plan("plan", {
    resourceGroupName: resourceGroup.name,
    location: resourceGroup.location,
    sku: {
        tier: "Basic",
        size: "B1",
    },
});

// Create an app service
const app = new azure.appservice.AppService("app", {
    resourceGroupName: resourceGroup.name,
    location: resourceGroup.location,
    appServicePlanId: plan.id,
    appSettings: {
        "WEBSITES_ENABLE_APP_SERVICE_STORAGE": "false",
        "WEBSITE_NODE_DEFAULT_VERSION": "10.14.1",
    },
    siteConfig: {
        alwaysOn: true,
        appCommandLine: "",
        ftpsState: "Disabled",
        http20Enabled: true,
        ipRestrictions: [],
        linuxFxVersion: "",
        localMySqlEnabled: false,
        managedPipelineMode: "Integrated",
        minTlsVersion: "1.2",
        phpVersion: "",
        pythonVersion: "",
        remoteDebuggingEnabled: false,
        remoteDebuggingVersion: "",
        requestTracingEnabled: false,
        requestTracingExpirationTime: "",
        scmType: "None",
        use32BitWorkerProcess: true,
        webSocketsEnabled: true,
        windowsFxVersion: "",
    },
});

// Export the endpoint
export const endpoint = app.defaultSiteHostname.apply(h => `https://${h}`);






