using System;

using UnityEngine;

namespace Java.ExternalType.Java.Time
{
    public class ZonedDateTime : global::Google.LibraryWrapper.Java.JavaObject
    {
        private static readonly IntPtr _classObject;

        static ZonedDateTime()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/time/ZonedDateTime");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public ZonedDateTime(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ZonedDateTime.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ZonedDateTime wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ZonedDateTime(IntPtr rawObject)
        {
            return new ZonedDateTime(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ZonedDateTime
} // end namespace Java.ExternalType.Java.Time
