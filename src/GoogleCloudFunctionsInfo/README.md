# Deploy to Google Cloud Functions

```cmd
gcloud functions deploy GoogleCloudFunctionsInfo-Assemblies --runtime dotnet6 --trigger-http --entry-point GoogleCloudFunctionsInfo.Assemblies
gcloud functions deploy GoogleCloudFunctionsInfo-Type --runtime dotnet6 --trigger-http --entry-point GoogleCloudFunctionsInfo.Type
```
