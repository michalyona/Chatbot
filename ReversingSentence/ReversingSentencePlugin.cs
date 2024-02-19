using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
namespace ReversingSentence
{
    public class ReversingSentencePlugin: IPlugin
    {
        public static string _Id => "ReversingSentence";
        public string Id => _Id;
        public PluginOutput Execute(PluginInput input)
        {
           if (input.Message == "")
            {
                input.Callbacks.StartSession();
                return new PluginOutput("ReversingSentence started. Enter 'Exit' to stop.");
            }
            else if (input.Message.ToLower() == "exit")
            {
                input.Callbacks.EndSession();
                return new PluginOutput("ReversingSentence stopped.");
            }
            else
            {
                string sentence=input.Message;
                string result = "";
                for (int i= sentence.Length-1; i>=0; i--)
                    result += sentence[i];
                

                return new PluginOutput(result);
            }
        }
    }
}