using System;

using UnityEngine;

namespace Java.Lang
{
    public class System : global::Google.LibraryWrapper.Java.JavaObject
    {
        public static global::Java.ExternalType.Java.Io.InputStream In
        {
            get
            {
                return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.ExternalType.Java.Io.PrintStream Out
        {
            get
            {
                return new global::Java.ExternalType.Java.Io.PrintStream(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.ExternalType.Java.Io.PrintStream Err
        {
            get
            {
                return new global::Java.ExternalType.Java.Io.PrintStream(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
        private static readonly IntPtr _cachedFieldId2;
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
        private static readonly IntPtr _cachedMethodId9;
        private static readonly IntPtr _cachedMethodId10;
        private static readonly IntPtr _cachedMethodId11;
        private static readonly IntPtr _cachedMethodId12;
        private static readonly IntPtr _cachedMethodId13;
        private static readonly IntPtr _cachedMethodId14;
        private static readonly IntPtr _cachedMethodId15;
        private static readonly IntPtr _cachedMethodId16;
        private static readonly IntPtr _cachedMethodId17;
        private static readonly IntPtr _cachedMethodId18;
        private static readonly IntPtr _cachedMethodId19;
        private static readonly IntPtr _cachedMethodId20;
        private static readonly IntPtr _cachedMethodId21;
        private static readonly IntPtr _cachedMethodId22;
        private static readonly IntPtr _cachedMethodId23;
        private static readonly IntPtr _cachedMethodId24;
        private static readonly IntPtr _cachedMethodId25;
        private static readonly IntPtr _cachedMethodId26;

        static System()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/System");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "in", "Ljava/io/InputStream;");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "out", "Ljava/io/PrintStream;");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "err", "Ljava/io/PrintStream;");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "setIn", "(Ljava/io/InputStream;)V");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "setOut", "(Ljava/io/PrintStream;)V");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "setErr", "(Ljava/io/PrintStream;)V");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "console", "()Ljava/io/Console;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "inheritedChannel", "()Ljava/nio/channels/Channel;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "getSecurityManager", "()Ljava/lang/SecurityManager;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "currentTimeMillis", "()J");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "nanoTime", "()J");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "identityHashCode", "(Ljava/lang/Object;)I");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "getProperties", "()Ljava/util/Properties;");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "lineSeparator", "()Ljava/lang/String;");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "setProperties", "(Ljava/util/Properties;)V");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId19 = AndroidJNI.GetStaticMethodID(_classObject, "getenv", "()Ljava/util/Map;");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "exit", "(I)V");
            _cachedMethodId21 = AndroidJNI.GetStaticMethodID(_classObject, "gc", "()V");
            _cachedMethodId22 = AndroidJNI.GetStaticMethodID(_classObject, "runFinalization", "()V");
            _cachedMethodId23 = AndroidJNI.GetStaticMethodID(_classObject, "runFinalizersOnExit", "(Z)V");
            _cachedMethodId24 = AndroidJNI.GetStaticMethodID(_classObject, "load", "(Ljava/lang/String;)V");
            _cachedMethodId25 = AndroidJNI.GetStaticMethodID(_classObject, "loadLibrary", "(Ljava/lang/String;)V");
            _cachedMethodId26 = AndroidJNI.GetStaticMethodID(_classObject, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
        }

        public System() : base(IntPtr.Zero)
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

        public System(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of System.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetIn(global::Java.ExternalType.Java.Io.InputStream @in)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = @in.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetOut(global::Java.ExternalType.Java.Io.PrintStream @out)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = @out.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetErr(global::Java.ExternalType.Java.Io.PrintStream err)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = err.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Io.Console Console()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Io.Console(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Nio.Channels.Channel InheritedChannel()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Nio.Channels.Channel(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetSecurityManager(global::Java.Lang.SecurityManager s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.SecurityManager GetSecurityManager()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.SecurityManager(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long CurrentTimeMillis()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long NanoTime()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Arraycopy(global::Google.LibraryWrapper.Java.JavaObject src, int srcPos, global::Google.LibraryWrapper.Java.JavaObject dest, int destPos, int length)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = src.GetRawObject() },
                            new jvalue { i = srcPos },
                            new jvalue { l = dest.GetRawObject() },
                            new jvalue { i = destPos },
                            new jvalue { i = length }
                        };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int IdentityHashCode(global::Google.LibraryWrapper.Java.JavaObject x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = x.GetRawObject() } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Properties GetProperties()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Properties(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String LineSeparator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetProperties(global::Java.Util.Properties props)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = props.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String GetProperty(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String GetProperty(global::System.String key, global::System.String def)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(def) }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String SetProperty(global::System.String key, global::System.String value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(value) }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ClearProperty(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String Getenv(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Map<global::System.String, global::System.String> Getenv()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.MapAnonymousImplementation<global::System.String, global::System.String>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Exit(int status)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = status } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Gc()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void RunFinalization()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void RunFinalizersOnExit(bool value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = value } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Load(global::System.String filename)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(filename) } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void LoadLibrary(global::System.String libname)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(libname) } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String MapLibraryName(global::System.String libname)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(libname) } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(System wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator System(IntPtr rawObject)
        {
            return new System(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class System
} // end namespace Java.Lang
