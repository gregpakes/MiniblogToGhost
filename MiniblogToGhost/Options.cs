using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace MiniblogToGhost
{
    public class Options
    {

        [Option('f', "Input Directory", DefaultValue = @"")]
        public string InputDirectory { get; set; }

        [Option('o', "Output Path", DefaultValue = @"")]
        public string OutputPath { get; set; }

        [Option('v', "verbose", DefaultValue = true, HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [Option('c', "cloudinarycloudname", Required = true, DefaultValue = "", HelpText = "Prints all messages to standard output.")]
        public string CloudinaryCloudName { get; set; }

        [Option('n', "cloudinaryapikey", Required = true, DefaultValue = "", HelpText = "ApiKey")]
        public string CloudinaryApiKey { get; set; }

        [Option('a', "cloudinaryapisecret", Required = true, DefaultValue = "", HelpText = "Api Secret.")]
        public string CloudinaryApiSecret { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
