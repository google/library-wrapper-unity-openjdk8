using System;

using UnityEngine;

namespace Java.Lang
{
    public class ExceptionInInitializerError : global::Java.Lang.LinkageError
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
        private static readonly IntPtr _cachedConstructorId2;
        private static readonly IntPtr _cachedMethodId0;

        static ExceptionInInitializerError()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/ExceptionInInitializerError");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Throwable;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getException", "()Ljava/lang/Throwable;");
        }

        public ExceptionInInitializerError() : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {};
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public ExceptionInInitializerError(global::Java.Lang.Throwable thrown) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {new jvalue { l = thrown.GetRawObject() }};
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public ExceptionInInitializerError(global::System.String s) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {new jvalue { l = AndroidJNI.NewString(s) }};
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public ExceptionInInitializerError(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ExceptionInInitializerError.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Throwable GetException()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {};
                return new global::Java.Lang.Throwable(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ExceptionInInitializerError wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ExceptionInInitializerError(IntPtr rawObject)
        {
            return new ExceptionInInitializerError(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ExceptionInInitializerError
} // end namespace Java.Lang
