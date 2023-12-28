# Deploy to Google Cloud Functions

```cmd
gcloud functions deploy GoogleCloudFunctionsInfo-Assemblies --runtime dotnet6 --trigger-http --entry-point GoogleCloudFunctionsInfo.Assemblies --docker-registry=artifact-registry
gcloud functions deploy GoogleCloudFunctionsInfo-Types --runtime dotnet6 --trigger-http --entry-point GoogleCloudFunctionsInfo.Types --docker-registry=artifact-registry
```
