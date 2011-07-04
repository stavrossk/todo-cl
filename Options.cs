﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;

namespace Todo
{
    class Options
    {
        [Option("u", "UserId", Required = false, HelpText = "UserId")]
        public string username = null;

        [Option("p", "password", HelpText = "password")]
        public string password = null;

        [OptionList("t", "tags", Separator = ',', HelpText = "Specify tags, separated by a comma")]
        public IList<string> tags = null;

        [Option("f", "folder", HelpText = "Specify Folder")]
        public string folder = null;

        [Option("c", "context", HelpText = "Specify Context")]
        public string context = null;

        [Option("d", "duedate", HelpText = "Specify Due Date")]
        public string duedate = null;

        [Option("l", "length", HelpText = "Specify Length in minutes")]
        public string length = null;

        [Option("s", "set", HelpText = "Specify default folder or context in the format -s Folder:Inbox")]
        public string settings = null;

        [ValueList(typeof(List<string>), MaximumElements = -1)]
        public IList<string> task = null;

        [HelpOption(HelpText = "Display this help screen.")]
        public string GetUsage()
        {
            var usage = new StringBuilder();
            usage.AppendLine("Todo Command Line");
            usage.AppendLine("use -u or -p to enter username and password");
            usage.AppendLine("or just enter a todo");
            return usage.ToString();
        }
    }
}
