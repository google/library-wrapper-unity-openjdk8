using System;

using UnityEngine;

namespace Java.Lang
{
    public class Process : global::Google.LibraryWrapper.Java.JavaObject
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;
        private static readonly IntPtr _cachedMethodId5;
        private static readonly IntPtr _cachedMethodId6;
        private static readonly IntPtr _cachedMethodId7;
        private static readonly IntPtr _cachedMethodId8;

        static Process()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Process");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getOutputStream", "()Ljava/io/OutputStream;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getInputStream", "()Ljava/io/InputStream;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "getErrorStream", "()Ljava/io/InputStream;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "waitFor", "()I");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "waitFor", "(JLjava/util/concurrent/TimeUnit;)Z");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "exitValue", "()I");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "destroy", "()V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "destroyForcibly", "()Ljava/lang/Process;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "isAlive", "()Z");
        }

        public Process() : base(IntPtr.Zero)
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

        public Process(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Process.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Io.OutputStream GetOutputStream()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Io.OutputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Io.InputStream GetInputStream()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Io.InputStream GetErrorStream()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int WaitFor()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool WaitFor(long timeout, global::Java.ExternalType.Java.Util.Concurrent.TimeUnit unit)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = timeout },
                            new jvalue { l = unit.GetRawObject() }
                        };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int ExitValue()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Destroy()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Process DestroyForcibly()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Process(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsAlive()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Process wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Process(IntPtr rawObject)
        {
            return new Process(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Process
} // end namespace Java.Lang
