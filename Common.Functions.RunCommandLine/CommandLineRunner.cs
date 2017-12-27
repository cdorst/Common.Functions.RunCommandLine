using static Common.Functions.JoinCommandLineArguments.CommandLineArgumentsJoiner;
using static Common.Functions.PromptCommandInGivenDirectory.CommandInGivenDirectoryPrompter;

namespace Common.Functions.RunCommandLine
{
    public static class CommandLineRunner
    {
        public static void Run(string workingDirectory, string command, params string[] arguments)
        {
            var cmd = PromptIn(workingDirectory);
            cmd.StandardInput.WriteLine(Join(command, arguments));
            cmd.WaitForExit();
        }
    }
}
