// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HelpWriter.cs" company="CatenaLogic">
//   Copyright (c) 2014 - 2014 CatenaLogic. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace GitHubLink
{
    using System;
    using Catel.Reflection;

    public static class HelpWriter
    {
        public static void WriteAppHeader(Action<string> writer)
        {
            var assembly = typeof (HelpWriter).Assembly;

            writer(string.Format("{0} v{1}", assembly.Title(), assembly.Version()));
            writer("===================");
            writer(string.Empty);
        }

        public static void WriteHelp(Action<string> writer)
        {
            var message =
                @"Update pdb files to link all sources. This will allow anyone to step through the source code while debugging without a symbol source server.

Note that the solution must be built because this application will update existing pdb files.

GitHubLink [solutionPath] -u [urlToRepository]

    solutionPath       The directory containing the solution with the pdb files.
    -u [url]           Url to remote git repository.
    -c [config]        Name of the configuration, default value is 'Release'.
    -b [branch]        Name of the branch to use on the remote repository.
    -l [file]          The log file to write to.
";
            writer(message);
        }
    }
}