Install or update the Azure Developer CLI:

winget install microsoft.azd

https://learn.microsoft.com/en-us/azure/developer/azure-developer-cli/install-azd?tabs=winget-windows%2Cbrew-mac%2Cscript-linux&pivots=os-windows

Login:
azd auth login

Go to the project directory and use the following command:

azd init

Upload and deploy the resurces to Azure subscription. It will ask for the subscription if not already selected:

azd up
