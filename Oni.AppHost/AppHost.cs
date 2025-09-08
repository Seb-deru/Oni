var builder = DistributedApplication.CreateBuilder(args);

var applicationservice = builder.AddProject<Projects.Oni_Application>("applicationservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.Oni_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(applicationservice)
    .WaitFor(applicationservice);

builder.Build().Run();
