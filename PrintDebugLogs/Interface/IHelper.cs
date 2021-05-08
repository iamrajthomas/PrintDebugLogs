//  -------------------------------------------------------------------------
//  <copyright file="IHelper.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       IHelper Contract For DebugLog
//  </summary>
//  -------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace PrintDebugLogs.Interface
{
    public interface IHelper
    {
        void PrintDebugLogs(
            string Message,
            [CallerLineNumber] int LineNumber = 0,
            [CallerMemberName] string CallerMemberName = null,
            [CallerFilePath] string CalledFilePath = null,
            bool IsPrintStackTrace = false);
    }
}
