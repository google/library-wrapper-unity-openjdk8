using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Stream
{
    public class LongStream : global::Google.LibraryWrapper.Java.JavaObject
    {
        private static readonly IntPtr _classObject;

        static LongStream()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/stream/LongStream");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public LongStream(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of LongStream.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(LongStream wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator LongStream(IntPtr rawObject)
        {
            return new LongStream(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class LongStream
} // end namespace Java.ExternalType.Java.Util.Stream
