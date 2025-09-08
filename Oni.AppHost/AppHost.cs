IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.Oni_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health");

builder.Build().Run();
