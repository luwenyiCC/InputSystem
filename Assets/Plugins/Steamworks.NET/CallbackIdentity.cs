// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2018 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if UNITY_ANDROID || UNITY_IOS || UNITY_TIZEN || UNITY_TVOS || UNITY_WEBGL || UNITY_WSA || UNITY_PS4 || UNITY_WII || UNITY_XBOXONE || UNITY_SWITCH
#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

namespace Steamworks
{
    class CallbackIdentities
    {
        public static int GetCallbackIdentity(System.Type callbackStruct)
        {
#if UNITY_EDITOR || UNITY_STANDALONE || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX
            foreach (CallbackIdentityAttribute attribute in callbackStruct.GetCustomAttributes(typeof(CallbackIdentityAttribute), false))
            {
                return attribute.Identity;
            }
#endif
            throw new System.Exception("Callback number not found for struct " + callbackStruct);
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
    internal class CallbackIdentityAttribute : System.Attribute
    {
        public int Identity { get; set; }
        public CallbackIdentityAttribute(int callbackNum)
        {
            Identity = callbackNum;
        }
    }
}

#endif // !DISABLESTEAMWORKS