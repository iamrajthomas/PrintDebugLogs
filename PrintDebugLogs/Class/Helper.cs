//  -------------------------------------------------------------------------
//  <copyright file="Helper.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       Helper Implementation For DebugLog
//  </summary>
//  -------------------------------------------------------------------------

namespace PrintDebugLogs.Class
{
    using PrintDebugLogs.Interface;
    using System;
    public class Helper : IHelper
    {
        public void PrintDebugLogs(
            string Message,
            [System.Runtime.CompilerServices.CallerLineNumber] int LineNumber = 0,
            [System.Runtime.CompilerServices.CallerMemberName] string CallerMemberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string CalledFilePath = null,
            bool IsPrintStackTrace = false)
        {
            try
            {
                string MessageToBePrinted = string.Empty;
                string Star = string.Format("{0}******************************************************************************************************{0}", System.Environment.NewLine);

                MessageToBePrinted = string.Format("{1} [TimeStamp]: {2}{0} [Message]: {3},{0} [At Line Number]: {4},{0} [CallerMemberName]: {5},{0} [CalledFilePath]: {6},{0} {7}{0}",
                                                    Environment.NewLine,
                                                    Star,
                                                    DateTime.Now.ToString(),
                                                    Message ?? "<<< The Pssed Value As Message Is Null >>>",
                                                    LineNumber,
                                                    CallerMemberName,
                                                    CalledFilePath,
                                                    IsPrintStackTrace ? string.Format("[StackTrace]: {0}", Environment.StackTrace) : string.Empty);

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
