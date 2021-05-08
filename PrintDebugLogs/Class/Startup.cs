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

namespace PrintDebugLogs.Class
{
    using PrintDebugLogs.Interface;
    public class Startup : IStartup
    {
        private readonly Helper helper = null;
        public Startup()
        {
            if(helper == null) helper = new Helper();
        }

        public void Initiate()
        {
            SomeMethodSomewhere();
        }

        private void SomeMethodSomewhere()
        {
            helper.PrintDebugLogs("A PORTRAIT OF THE ARTIST AS A YOUNG MAN");
            helper.PrintDebugLogs("THE SOUND AND THE FURY");
            helper.PrintDebugLogs("DARKNESS AT NOON");
            helper.PrintDebugLogs("THE HEART IS A LONELY HUNTER");

            AgainSomeMethodSomewhere();
        }

        private void AgainSomeMethodSomewhere()
        {
            helper.PrintDebugLogs("THE WINGS OF THE DOVE", IsPrintStackTrace: true);
            helper.PrintDebugLogs("A DANCE TO THE MUSIC OF TIME", IsPrintStackTrace: true);
            helper.PrintDebugLogs("THE RAINBOW", IsPrintStackTrace: true);
            helper.PrintDebugLogs("THE DEATH OF THE HEART", IsPrintStackTrace: true);
        }
        
    }
}
