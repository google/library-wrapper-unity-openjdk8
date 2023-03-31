using System;

using UnityEngine;

namespace Java.Lang
{
    public interface Readable : global::Google.LibraryWrapper.Java.JavaInterface
    {

        int Read(global::Java.ExternalType.Java.Nio.CharBuffer cb);
    } // end class Readable

    public class ReadableAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Readable
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;

        static ReadableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Readable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "read", "(Ljava/nio/CharBuffer;)I");
        }

        public ReadableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ReadableAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Read(global::Java.ExternalType.Java.Nio.CharBuffer cb)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = cb.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ReadableAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ReadableAnonymousImplementation(IntPtr rawObject)
        {
            return new ReadableAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ReadableAnonymousImplementation

    public abstract class ReadableCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Readable
    {
        public ReadableCallbackHelper() : base("java.lang.Readable") {}

        public abstract int Read(global::Java.ExternalType.Java.Nio.CharBuffer cb);

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "read" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Read(new global::Java.ExternalType.Java.Nio.CharBuffer(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        return base.Invoke(methodName, args);
        }
    } // end class ReadableCallbackHelper
} // end namespace Java.Lang
