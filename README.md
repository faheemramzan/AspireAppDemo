Install or update the Azure Developer CLI:

winget install microsoft.azd

Login:

azd auth login

Go to the project directory and use the following command:

azd init

Upload and deploy the resurces to Azure subscription. It will ask for the subscription if not already selected:

azd up


Resources:

https://learn.microsoft.com/en-us/azure/developer/azure-developer-cli/install-azd?tabs=winget-windows%2Cbrew-mac%2Cscript-linux&pivots=os-windows

https://learn.microsoft.com/en-us/dotnet/aspire/deployment/azure/aca-deployment
