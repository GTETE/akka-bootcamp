using System;
using System.Configuration;
using System.Windows.Forms;
using Akka.Actor;
using Akka.Configuration.Hocon;

namespace GithubActors
{
    static class Program
    {
        /// <summary>
        /// ActorSystem we'llbe using to collect and process data
        /// from Github using their official .NET SDK, Octokit
        /// </summary>
        public static ActorSystem GithubActors;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // db3d21d86e0b081b4f7a147769a6c88343a47e38

            GithubActors = ActorSystem.Create("GithubActors");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GithubAuth());
        }
    }
}
