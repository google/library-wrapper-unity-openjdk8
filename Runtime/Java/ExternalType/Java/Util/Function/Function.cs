using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public class Function<T0, T1> : global::Google.LibraryWrapper.Java.JavaObject where T0 : class where T1 : class
    {
        private static readonly IntPtr _classObject;

        static Function()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/Function");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public Function(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Function.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Function<T0, T1> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Function<T0, T1>(IntPtr rawObject)
        {
            return new Function<T0, T1>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Function
} // end namespace Java.ExternalType.Java.Util.Function
