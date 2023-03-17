using System;

using UnityEngine;

namespace Java.Lang
{
    public interface AutoCloseable : global::Google.LibraryWrapper.Java.JavaInterface
    {
        public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.AutoCloseable
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedMethodId0;

            static AnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/AutoCloseable");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "close", "()V");
            }

            public AnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public void Close()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {};
                    AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(AnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AnonymousImplementation(IntPtr rawObject)
            {
                return new AnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AnonymousImplementation

        public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.AutoCloseable
        {
            public CallbackHelper() : base("java.lang.AutoCloseable") {}

            public abstract void Close();

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            if (methodName == "close" && args.Length == 0)
            {
            Close();
            return null;
            }
            return base.Invoke(methodName, args);
            }
        } // end class CallbackHelper

        void Close();
    } // end class AutoCloseable
} // end namespace Java.Lang