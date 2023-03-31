using System;

using UnityEngine;

namespace Java.Lang
{
    public class ClassLoader : global::Google.LibraryWrapper.Java.JavaObject
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
        private static readonly IntPtr _cachedMethodId9;
        private static readonly IntPtr _cachedMethodId10;
        private static readonly IntPtr _cachedMethodId11;
        private static readonly IntPtr _cachedMethodId12;

        static ClassLoader()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/ClassLoader");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "getParent", "()Ljava/lang/ClassLoader;");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "setDefaultAssertionStatus", "(Z)V");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "setClassAssertionStatus", "(Ljava/lang/String;Z)V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "clearAssertionStatus", "()V");
        }

        public ClassLoader() : base(IntPtr.Zero)
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

        public ClassLoader(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ClassLoader.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> LoadClass(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Net.URL GetResource(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Net.URL(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Enumeration<global::Java.ExternalType.Java.Net.URL> GetResources(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.Util.EnumerationAnonymousImplementation<global::Java.ExternalType.Java.Net.URL>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Net.URL GetSystemResource(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Net.URL(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Enumeration<global::Java.ExternalType.Java.Net.URL> GetSystemResources(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.Util.EnumerationAnonymousImplementation<global::Java.ExternalType.Java.Net.URL>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Io.InputStream GetResourceAsStream(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Io.InputStream GetSystemResourceAsStream(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.ClassLoader GetParent()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.ClassLoader(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.ClassLoader GetSystemClassLoader()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.ClassLoader(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetDefaultAssertionStatus(bool enabled)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = enabled } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetPackageAssertionStatus(global::System.String packageName, bool enabled)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(packageName) },
                            new jvalue { z = enabled }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetClassAssertionStatus(global::System.String className, bool enabled)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(className) },
                            new jvalue { z = enabled }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void ClearAssertionStatus()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ClassLoader wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ClassLoader(IntPtr rawObject)
        {
            return new ClassLoader(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ClassLoader
} // end namespace Java.Lang
