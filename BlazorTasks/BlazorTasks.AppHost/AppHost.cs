var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorTasks_Api>("blazortasks-api");

builder.Build().Run();
