// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InTheHandForms.cs" company="In The Hand Ltd">
//   Copyright (c) 2017-20 In The Hand Ltd, All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Reflection;
using Xamarin.Forms;

[assembly: ResolutionGroupName("InTheHand.Forms")]

#if __ANDROID__
namespace InTheHand.Forms.Platform.Android
#elif __MACOS__
namespace InTheHand.Forms.Platform.MacOS
#elif __IOS__
namespace InTheHand.Forms.Platform.iOS
#elif WINDOWS_UWP || WINDOWS_APP || WINDOWS_PHONE_APP
namespace InTheHand.Forms.Platform.WinRT
#elif WPF
namespace InTheHand.Forms.Platform.WPF
#endif
{
    public static class InTheHandForms
    {
        public static void Init()
        {
#if WINDOWS_UWP
            var t = typeof(MediaElementRenderer).GetTypeInfo().Assembly.GetTypes();
#else
            //this call is necessary just to ensure the platform library is loaded so the renderers will be used.
            var t = typeof(MediaElementRenderer).Assembly.GetTypes();
#endif
        }
    }
}