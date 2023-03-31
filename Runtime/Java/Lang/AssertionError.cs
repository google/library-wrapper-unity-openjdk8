using System;

using UnityEngine;

namespace Java.Lang
{
    public class AssertionError : global::Java.Lang.Error
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
        private static readonly IntPtr _cachedConstructorId2;
        private static readonly IntPtr _cachedConstructorId3;
        private static readonly IntPtr _cachedConstructorId4;
        private static readonly IntPtr _cachedConstructorId5;
        private static readonly IntPtr _cachedConstructorId6;
        private static readonly IntPtr _cachedConstructorId7;
        private static readonly IntPtr _cachedConstructorId8;

        static AssertionError()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/AssertionError");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Object;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Z)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(C)V");
            _cachedConstructorId4 = AndroidJNI.GetMethodID(_classObject, "<init>", "(I)V");
            _cachedConstructorId5 = AndroidJNI.GetMethodID(_classObject, "<init>", "(J)V");
            _cachedConstructorId6 = AndroidJNI.GetMethodID(_classObject, "<init>", "(F)V");
            _cachedConstructorId7 = AndroidJNI.GetMethodID(_classObject, "<init>", "(D)V");
            _cachedConstructorId8 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
        }

        public AssertionError() : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(global::Google.LibraryWrapper.Java.JavaObject detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = detailMessage.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(bool detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = detailMessage } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(char detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = detailMessage } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(int detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = detailMessage } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId4, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(long detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = detailMessage } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId5, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(float detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = detailMessage } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId6, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(double detailMessage) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = detailMessage } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId7, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(global::System.String message, global::Java.Lang.Throwable cause) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(message) },
                            new jvalue { l = cause.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId8, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public AssertionError(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of AssertionError.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(AssertionError wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator AssertionError(IntPtr rawObject)
        {
            return new AssertionError(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class AssertionError
} // end namespace Java.Lang
