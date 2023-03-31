using System;

using UnityEngine;

namespace Java.ExternalType.Java.Io
{
    public interface Flushable : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class Flushable

    public class FlushableAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Flushable
    {
        private static readonly IntPtr _classObject;

        static FlushableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/io/Flushable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public FlushableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of FlushableAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(FlushableAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator FlushableAnonymousImplementation(IntPtr rawObject)
        {
            return new FlushableAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class FlushableAnonymousImplementation

    public abstract class FlushableCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Io.Flushable
    {
        public FlushableCallbackHelper() : base("java.io.Flushable") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class FlushableCallbackHelper
} // end namespace Java.ExternalType.Java.Io
