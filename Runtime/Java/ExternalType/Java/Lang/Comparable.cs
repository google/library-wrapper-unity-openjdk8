using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang
{
    public interface Comparable<T0> : global::Google.LibraryWrapper.Java.JavaInterface where T0 : class
    {
    } // end class Comparable

    public class ComparableAnonymousImplementation<T0> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Lang.Comparable<T0> where T0 : class
    {
        private static readonly IntPtr _classObject;

        static ComparableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Comparable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public ComparableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ComparableAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ComparableAnonymousImplementation<T0> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ComparableAnonymousImplementation<T0>(IntPtr rawObject)
        {
            return new ComparableAnonymousImplementation<T0>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ComparableAnonymousImplementation

    public abstract class ComparableCallbackHelper<T0> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Lang.Comparable<T0> where T0 : class
    {
        public ComparableCallbackHelper() : base("java.lang.Comparable") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class ComparableCallbackHelper
} // end namespace Java.ExternalType.Java.Lang
