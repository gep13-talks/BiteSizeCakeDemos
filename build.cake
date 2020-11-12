var target = Argument("target", "Default");
var solutionFolder = "./src";
var outputFolder = "./artifacts";

Task("Clean")
  .Does(() => {
    CleanDirectory(outputFolder);
  });

Task("Restore")
  .Does(() => {
    DotNetCoreRestore(solutionFolder);
  });

Task("Build")
  .IsDependentOn("Clean")
  .IsDependentOn("Restore")
  .Does(() => {
    DotNetCoreBuild(solutionFolder, new DotNetCoreBuildSettings{
      NoRestore = true
    });
  });

Task("Test")
  .IsDependentOn("Build")
  .Does(() => {
    DotNetCoreTest(solutionFolder, new DotNetCoreTestSettings{
      NoRestore = true,
      NoBuild = true
    });
  });

var packageTask = Task("Package")
  .IsDependentOn("Test")
  .Does(() => {
    DotNetCorePack(solutionFolder, new DotNetCorePackSettings{
      NoRestore = true,
      NoBuild = true,
      OutputDirectory = outputFolder
    });
  });

Task("Default")
  .IsDependentOn(packageTask);

RunTarget(target);