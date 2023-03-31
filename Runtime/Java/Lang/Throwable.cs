using System;

using UnityEngine;

namespace Java.Lang
{
    public class Throwable : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
        private static readonly IntPtr _cachedConstructorId2;
        private static readonly IntPtr _cachedConstructorId3;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;
        private static readonly IntPtr _cachedMethodId5;
        private static readonly IntPtr _cachedMethodId6;
        private static readonly IntPtr _cachedMethodId7;
        private static readonly IntPtr _cachedMethodId8;

        static Throwable()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Throwable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Throwable;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getMessage", "()Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getLocalizedMessage", "()Ljava/lang/String;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "getCause", "()Ljava/lang/Throwable;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "printStackTrace", "()V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "printStackTrace", "(Ljava/io/PrintStream;)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "printStackTrace", "(Ljava/io/PrintWriter;)V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "fillInStackTrace", "()Ljava/lang/Throwable;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "addSuppressed", "(Ljava/lang/Throwable;)V");
        }

        public Throwable() : base(IntPtr.Zero)
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

        public Throwable(global::System.String message) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(message) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Throwable(global::System.String message, global::Java.Lang.Throwable cause) : base(IntPtr.Zero)
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
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Throwable(global::Java.Lang.Throwable cause) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = cause.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Throwable(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Throwable.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetMessage()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetLocalizedMessage()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Throwable GetCause()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Throwable(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Throwable InitCause(global::Java.Lang.Throwable cause)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = cause.GetRawObject() } };
                return new global::Java.Lang.Throwable(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void PrintStackTrace()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void PrintStackTrace(global::Java.ExternalType.Java.Io.PrintStream s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void PrintStackTrace(global::Java.ExternalType.Java.Io.PrintWriter s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Throwable FillInStackTrace()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Throwable(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void AddSuppressed(global::Java.Lang.Throwable exception)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = exception.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Throwable wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Throwable(IntPtr rawObject)
        {
            return new Throwable(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Throwable
} // end namespace Java.Lang
