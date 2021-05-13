//  -------------------------------------------------------------------------
//  <copyright file="IHelper.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       IHelper Contract For DebugLog
//  </summary>
//  -------------------------------------------------------------------------

namespace PrintDebugLogs.Interface
{
    public interface IHelper
    {
        void PrintDebugLogs(
            string Message,
            [System.Runtime.CompilerServices.CallerLineNumber] int LineNumber = 0,
            [System.Runtime.CompilerServices.CallerMemberName] string CallerMemberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string CalledFilePath = null,
            bool IsPrintStackTrace = false);
    }
}
