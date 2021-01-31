1. Already have manifest file created
1. Run `dotnet cake --info`
1. Create argument for target, add RunTarget, and stub out top level tasks for Clean, Restore, Build, Test, Package and Default
1. Add dependency for Default task
  1. Show how you can create variables for tasks and add them as dependencies
  1. Run `dotnet cake`
1. Add dependencies for all other tasks
  1. Run `dotnet cake`
  1. Run `dotnet cake --target=test`
  1. Run `dotnet cake --target=test --exclusive`
1. Complete the Restore Task
  1. Create solutionFolder variable set to `./src`
  1. Run `dotnet cake --target=restore`
1. Complete the Build Task
  1. Augment how this is invoked by setting NoRestore to true in settings
  1. Run `dotnet cake --target=build`
1. Complete the Test Task
  1. Copy/paste from Build task
  1. Additionally set the NoBuild option to true
  1. Run `dotnet cake --target=test`
1. Complete the Package Task
  1. Copy/paste from Package task
  1. Create variable for outputFolder = ".artifacts" and set this in settings
  1. Run `dotnet cake --target=package`
1. Complete the Clean task
  1. Run `dotnet cake --target=clean`
  1. Delete the empty artifacts folder
  1. Run `dotnet cake --target=clean` again
1. Run the overall build `dotnet cake`
1. Set breakpoint in the Clean task and show how debugging works