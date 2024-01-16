using System;

using UnityEngine;

namespace Java.Util
{
    public class Properties : global::Java.Util.Hashtable<global::Google.LibraryWrapper.Java.JavaObject, global::Google.LibraryWrapper.Java.JavaObject>
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
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

        static Properties()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Properties");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Properties;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "load", "(Ljava/io/Reader;)V");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "load", "(Ljava/io/InputStream;)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "save", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "store", "(Ljava/io/Writer;Ljava/lang/String;)V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "store", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "loadFromXML", "(Ljava/io/InputStream;)V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "propertyNames", "()Ljava/util/Enumeration;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "stringPropertyNames", "()Ljava/util/Set;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "list", "(Ljava/io/PrintStream;)V");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "list", "(Ljava/io/PrintWriter;)V");
        }

        public Properties() : base(IntPtr.Zero)
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

        public Properties(global::Java.Util.Properties defaults) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = defaults.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Properties(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Properties.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Google.LibraryWrapper.Java.JavaObject SetProperty(global::System.String key, global::System.String value)
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
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Load(global::Java.ExternalType.Java.Io.Reader reader)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = reader.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Load(global::Java.ExternalType.Java.Io.InputStream inStream)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = inStream.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Save(global::Java.ExternalType.Java.Io.OutputStream @out, global::System.String comments)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = @out.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(comments) }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Store(global::Java.ExternalType.Java.Io.Writer writer, global::System.String comments)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = writer.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(comments) }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Store(global::Java.ExternalType.Java.Io.OutputStream @out, global::System.String comments)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = @out.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(comments) }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void LoadFromXML(global::Java.ExternalType.Java.Io.InputStream @in)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = @in.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void StoreToXML(global::Java.ExternalType.Java.Io.OutputStream os, global::System.String comment)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = os.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(comment) }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void StoreToXML(global::Java.ExternalType.Java.Io.OutputStream os, global::System.String comment, global::System.String encoding)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = os.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(comment) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(encoding) }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetProperty(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetProperty(global::System.String key, global::System.String defaultValue)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(defaultValue) }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Enumeration<global::Google.LibraryWrapper.Java.JavaObject> PropertyNames()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.EnumerationAnonymousImplementation<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<global::System.String> StringPropertyNames()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.SetAnonymousImplementation<global::System.String>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void List(global::Java.ExternalType.Java.Io.PrintStream @out)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = @out.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void List(global::Java.ExternalType.Java.Io.PrintWriter @out)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = @out.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Properties wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Properties(IntPtr rawObject)
        {
            return new Properties(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Properties
} // end namespace Java.Util
