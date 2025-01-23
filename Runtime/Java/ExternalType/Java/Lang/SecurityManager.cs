using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang
{
    public class SecurityManager : global::Google.LibraryWrapper.Java.JavaObject
    {
        private static readonly IntPtr _classObject;

        static SecurityManager()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/SecurityManager");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public SecurityManager(IntPtr rawObject) : base(IntPtr.Zero)
        {
            if (rawObject == IntPtr.Zero)
            {
                return;
            }
            try
            {
                AndroidJNI.PushLocalFrame(0);
                IntPtr instanceClassObject_ = AndroidJNI.GetObjectClass(rawObject);
                if (!AndroidJNI.IsAssignableFrom(instanceClassObject_, _classObject))
                {
                    throw new ArgumentException("The provided reference is not an instance of SecurityManager.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(SecurityManager wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator SecurityManager(IntPtr rawObject)
        {
            return new SecurityManager(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class SecurityManager
} // end namespace Java.ExternalType.Java.Lang
