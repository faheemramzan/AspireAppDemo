var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireAppDemo_ApiService>("apiservice");

var redis = builder.AddRedis("redis");

builder.AddProject<Projects.AspireAppDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WithReference(redis);

builder.Build().Run();
