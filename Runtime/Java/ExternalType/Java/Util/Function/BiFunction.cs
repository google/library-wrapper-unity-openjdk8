using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public class BiFunction<T0, T1, T2> : global::Google.LibraryWrapper.Java.JavaObject where T0 : class where T1 : class where T2 : class
    {
        private static readonly IntPtr _classObject;

        static BiFunction()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/BiFunction");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public BiFunction(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of BiFunction.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(BiFunction<T0, T1, T2> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator BiFunction<T0, T1, T2>(IntPtr rawObject)
        {
            return new BiFunction<T0, T1, T2>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class BiFunction
} // end namespace Java.ExternalType.Java.Util.Function
