//  -------------------------------------------------------------------------
//  <copyright file="Program.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       Main Entry Point For Print and Extract Debug Logs 
//  </summary>
//  -------------------------------------------------------------------------

namespace PrintDebugLogs
{
    using PrintDebugLogs.Class;
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            new Startup().Initiate();
            Console.ReadKey();
        }
        
    }
}
