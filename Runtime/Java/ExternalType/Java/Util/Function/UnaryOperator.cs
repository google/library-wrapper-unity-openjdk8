using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public class UnaryOperator<T0> : global::Google.LibraryWrapper.Java.JavaObject where T0 : class
    {
        private static readonly IntPtr _classObject;

        static UnaryOperator()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/UnaryOperator");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public UnaryOperator(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of UnaryOperator.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(UnaryOperator<T0> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator UnaryOperator<T0>(IntPtr rawObject)
        {
            return new UnaryOperator<T0>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class UnaryOperator
} // end namespace Java.ExternalType.Java.Util.Function
