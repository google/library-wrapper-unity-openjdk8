using System;

using UnityEngine;

namespace Java.Util
{
    public class Formatter : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Closeable, global::Java.ExternalType.Java.Io.Flushable
    {
        public class BigDecimalLayoutForm : global::Java.Lang.Enum<global::Java.Util.Formatter.BigDecimalLayoutForm>
        {
            public static global::Java.Util.Formatter.BigDecimalLayoutForm SCIENTIFIC
            {
                get
                {
                    return new global::Java.Util.Formatter.BigDecimalLayoutForm(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT
            {
                get
                {
                    return new global::Java.Util.Formatter.BigDecimalLayoutForm(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }

            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedFieldId0;
            private static readonly IntPtr _cachedFieldId1;
            private static readonly IntPtr _cachedMethodId0;

            static BigDecimalLayoutForm()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Formatter$BigDecimalLayoutForm");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "SCIENTIFIC", "Ljava/util/Formatter$BigDecimalLayoutForm;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "DECIMAL_FLOAT", "Ljava/util/Formatter$BigDecimalLayoutForm;");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;");
            }

            public BigDecimalLayoutForm(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of BigDecimalLayoutForm.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Formatter.BigDecimalLayoutForm ValueOf(global::System.String name)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                    return new global::Java.Util.Formatter.BigDecimalLayoutForm(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(BigDecimalLayoutForm wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator BigDecimalLayoutForm(IntPtr rawObject)
            {
                return new BigDecimalLayoutForm(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class BigDecimalLayoutForm

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
        private static readonly IntPtr _cachedConstructorId9;
        private static readonly IntPtr _cachedConstructorId10;
        private static readonly IntPtr _cachedConstructorId11;
        private static readonly IntPtr _cachedConstructorId12;
        private static readonly IntPtr _cachedConstructorId13;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;

        static Formatter()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Formatter");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Appendable;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Locale;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
            _cachedConstructorId4 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedConstructorId5 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
            _cachedConstructorId6 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
            _cachedConstructorId7 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/File;)V");
            _cachedConstructorId8 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
            _cachedConstructorId9 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
            _cachedConstructorId10 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/PrintStream;)V");
            _cachedConstructorId11 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/OutputStream;)V");
            _cachedConstructorId12 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            _cachedConstructorId13 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "locale", "()Ljava/util/Locale;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "out", "()Ljava/lang/Appendable;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "flush", "()V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "close", "()V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "ioException", "()Ljava/io/IOException;");
        }

        public Formatter() : base(IntPtr.Zero)
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

        public Formatter(global::Java.Lang.Appendable a) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = a.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.Util.Locale l) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = l.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.Lang.Appendable a, global::Java.Util.Locale l) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = a.GetRawObject() },
                            new jvalue { l = l.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::System.String fileName) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(fileName) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId4, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::System.String fileName, global::System.String csn) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(fileName) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(csn) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId5, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::System.String fileName, global::System.String csn, global::Java.Util.Locale l) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(fileName) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(csn) },
                            new jvalue { l = l.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId6, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.File file) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = file.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId7, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.File file, global::System.String csn) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = file.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(csn) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId8, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.File file, global::System.String csn, global::Java.Util.Locale l) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = file.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(csn) },
                            new jvalue { l = l.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId9, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.PrintStream ps) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = ps.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId10, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.OutputStream os) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = os.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId11, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.OutputStream os, global::System.String csn) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = os.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(csn) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId12, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(global::Java.ExternalType.Java.Io.OutputStream os, global::System.String csn, global::Java.Util.Locale l) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = os.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(csn) },
                            new jvalue { l = l.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId13, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Formatter(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Formatter.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Locale Locale()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Locale(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Appendable Out()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.AppendableAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Flush()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
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
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Io.IOException IoException()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Io.IOException(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Formatter wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Formatter(IntPtr rawObject)
        {
            return new Formatter(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Formatter
} // end namespace Java.Util
