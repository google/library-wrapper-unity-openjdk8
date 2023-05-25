using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang.Reflect
{
    public class Constructor<T0> : global::Google.LibraryWrapper.Java.JavaObject where T0 : class
    {
        private static readonly IntPtr _classObject;

        static Constructor()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/reflect/Constructor");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public Constructor(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Constructor.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Constructor<T0> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Constructor<T0>(IntPtr rawObject)
        {
            return new Constructor<T0>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Constructor
} // end namespace Java.ExternalType.Java.Lang.Reflect
