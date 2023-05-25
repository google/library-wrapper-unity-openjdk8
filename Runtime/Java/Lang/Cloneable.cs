using System;

using UnityEngine;

namespace Java.Lang
{
    public interface Cloneable : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class Cloneable

    public class CloneableAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Cloneable
    {
        private static readonly IntPtr _classObject;

        static CloneableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Cloneable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public CloneableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of CloneableAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(CloneableAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator CloneableAnonymousImplementation(IntPtr rawObject)
        {
            return new CloneableAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class CloneableAnonymousImplementation

    public abstract class CloneableCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Cloneable
    {
        public CloneableCallbackHelper() : base("java.lang.Cloneable") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class CloneableCallbackHelper
} // end namespace Java.Lang
