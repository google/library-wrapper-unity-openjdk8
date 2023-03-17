using System;

using UnityEngine;

namespace Java.Util
{
    public interface Formattable : global::Google.LibraryWrapper.Java.JavaInterface
    {
        public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Formattable
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedMethodId0;

            static AnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Formattable");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "formatTo", "(Ljava/util/Formatter;III)V");
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

            public void FormatTo(global::Java.Util.Formatter formatter, int flags, int width, int precision)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {new jvalue { l = formatter.GetRawObject() }, new jvalue { i = flags }, new jvalue { i = width }, new jvalue { i = precision }};
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

        public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Formattable
        {
            public CallbackHelper() : base("java.util.Formattable") {}

            public abstract void FormatTo(global::Java.Util.Formatter formatter, int flags, int width, int precision);

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            if (methodName == "formatTo" && args.Length == 4)
            {
            FormatTo(new global::Java.Util.Formatter(((AndroidJavaObject) args[0]).GetRawObject()), (int) args[1], (int) args[2], (int) args[3]);
            return null;
            }
            return base.Invoke(methodName, args);
            }
        } // end class CallbackHelper

        void FormatTo(global::Java.Util.Formatter formatter, int flags, int width, int precision);
    } // end class Formattable
} // end namespace Java.Util
