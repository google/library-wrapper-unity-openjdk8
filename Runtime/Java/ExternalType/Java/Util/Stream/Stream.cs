using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Stream
{
    public class Stream<T0> : global::Google.LibraryWrapper.Java.JavaObject where T0 : class
    {
        private static readonly IntPtr _classObject;

        static Stream()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/stream/Stream");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public Stream(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Stream.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Stream<T0> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Stream<T0>(IntPtr rawObject)
        {
            return new Stream<T0>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Stream
} // end namespace Java.ExternalType.Java.Util.Stream
