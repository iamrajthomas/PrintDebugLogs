//  -------------------------------------------------------------------------
//  <copyright file="Startup.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       Startup Implementation For Print and Extract Debug Logs
//       This Utility will help log TimeStamp, Message, Line Number, CallerMemberName, CalledFilePath, StackTrace to Console As Well As To A Log File
//  </summary>
//  -------------------------------------------------------------------------

using PrintDebugLogs.Interface;

namespace PrintDebugLogs.Class
{
    using System;
    using System.Runtime.CompilerServices;
    public class Startup : IStartup
    {
        public void Initiate()
        {
            SomeMethodSomewhere();
        }

        static void SomeMethodSomewhere()
        {
            PrintDebugLogs("A PORTRAIT OF THE ARTIST AS A YOUNG MAN");
            PrintDebugLogs("THE SOUND AND THE FURY");
            PrintDebugLogs("DARKNESS AT NOON");
            PrintDebugLogs("THE HEART IS A LONELY HUNTER");

            AgainSomeMethodSomewhere();
        }

        static void AgainSomeMethodSomewhere()
        {
            PrintDebugLogs("THE WINGS OF THE DOVE", IsPrintStackTrace: true);
            PrintDebugLogs("A DANCE TO THE MUSIC OF TIME", IsPrintStackTrace: true);
            PrintDebugLogs("THE RAINBOW", IsPrintStackTrace: true);
            PrintDebugLogs("THE DEATH OF THE HEART", IsPrintStackTrace: true);
        }

        static void PrintDebugLogs(
            string Message,
            [CallerLineNumber] int LineNumber = 0,
            [CallerMemberName] string CallerMemberName = null,
            [CallerFilePath] string CalledFilePath = null,
            bool IsPrintStackTrace = false)
        {
            try
            {
                string MessageToBePrinted = string.Empty;
                string Star = string.Format("{0}******************************************************************************************************{0}", System.Environment.NewLine);

                MessageToBePrinted = string.Format("{1} [TimeStamp]: {2}{0} [Message]: {3},{0} [At Line Number]: {4},{0} [CallerMemberName]: {5},{0} [CalledFilePath]: {6},{0} {7}",
                                                    Environment.NewLine,
                                                    Star,
                                                    DateTime.Now.ToString(),
                                                    Message,
                                                    LineNumber,
                                                    CallerMemberName,
                                                    CalledFilePath,
                                                    IsPrintStackTrace ? "[StackTrace]:  " + Environment.StackTrace : "");

                Console.WriteLine(MessageToBePrinted);
                System.IO.File.AppendAllText(@"C:\\DebugCode.log", MessageToBePrinted);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
