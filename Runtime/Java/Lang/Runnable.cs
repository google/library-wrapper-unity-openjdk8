using System;

using UnityEngine;

namespace Java.Lang
{
    public interface Runnable : global::Google.LibraryWrapper.Java.JavaInterface
    {

        void Run();
    } // end class Runnable

    public class RunnableAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Runnable
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;

        static RunnableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Runnable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "run", "()V");
        }

        public RunnableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of RunnableAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Run()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(RunnableAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator RunnableAnonymousImplementation(IntPtr rawObject)
        {
            return new RunnableAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class RunnableAnonymousImplementation

    public abstract class RunnableCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Runnable
    {
        public RunnableCallbackHelper() : base("java.lang.Runnable") {}

        public abstract void Run();

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "run" && args.Length == 0)
        {
        Run();
        return null;
        }
        return base.Invoke(methodName, args);
        }
    } // end class RunnableCallbackHelper
} // end namespace Java.Lang
