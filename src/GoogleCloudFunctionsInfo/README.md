# Deploy to Google Cloud Functions

```cmd
gcloud functions deploy GoogleCloudFunctionsInfo-Assemblies --runtime dotnet3 --trigger-http --entry-point GoogleCloudFunctionsInfo.Assemblies
gcloud functions deploy GoogleCloudFunctionsInfo-Type --runtime dotnet3 --trigger-http --entry-point GoogleCloudFunctionsInfo.Type
```
