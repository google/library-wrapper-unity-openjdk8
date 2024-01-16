using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public class BiConsumer<T0, T1> : global::Google.LibraryWrapper.Java.JavaObject where T0 : class where T1 : class
    {
        private static readonly IntPtr _classObject;

        static BiConsumer()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/BiConsumer");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public BiConsumer(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of BiConsumer.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(BiConsumer<T0, T1> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator BiConsumer<T0, T1>(IntPtr rawObject)
        {
            return new BiConsumer<T0, T1>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class BiConsumer
} // end namespace Java.ExternalType.Java.Util.Function
