using System;

using UnityEngine;

namespace Java.Util
{
    public class ResourceBundle : global::Google.LibraryWrapper.Java.JavaObject
    {
        public class Control : global::Google.LibraryWrapper.Java.JavaObject
        {
            public static global::Java.Util.List<global::System.String> FORMAT_DEFAULT
            {
                get
                {
                    return new global::Java.Util.ListAnonymousImplementation<global::System.String>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.List<global::System.String> FORMAT_CLASS
            {
                get
                {
                    return new global::Java.Util.ListAnonymousImplementation<global::System.String>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.List<global::System.String> FORMAT_PROPERTIES
            {
                get
                {
                    return new global::Java.Util.ListAnonymousImplementation<global::System.String>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static long TTL_DONT_CACHE
            {
                get
                {
                    return AndroidJNI.GetStaticLongField(_classObject, _cachedFieldId3);
                }
                set
                {
                    AndroidJNI.SetStaticLongField(_classObject, _cachedFieldId3, value);
                }
            }
            public static long TTL_NO_EXPIRATION_CONTROL
            {
                get
                {
                    return AndroidJNI.GetStaticLongField(_classObject, _cachedFieldId4);
                }
                set
                {
                    AndroidJNI.SetStaticLongField(_classObject, _cachedFieldId4, value);
                }
            }

            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedFieldId0;
            private static readonly IntPtr _cachedFieldId1;
            private static readonly IntPtr _cachedFieldId2;
            private static readonly IntPtr _cachedFieldId3;
            private static readonly IntPtr _cachedFieldId4;
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

            static Control()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/ResourceBundle$Control");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "FORMAT_DEFAULT", "Ljava/util/List;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "FORMAT_CLASS", "Ljava/util/List;");
                _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "FORMAT_PROPERTIES", "Ljava/util/List;");
                _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "TTL_DONT_CACHE", "J");
                _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "TTL_NO_EXPIRATION_CONTROL", "J");
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "getControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;");
                _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "getNoFallbackControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "getFormats", "(Ljava/lang/String;)Ljava/util/List;");
                _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "getCandidateLocales", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;");
                _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "getFallbackLocale", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/Locale;");
                _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "newBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Z)Ljava/util/ResourceBundle;");
                _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "getTimeToLive", "(Ljava/lang/String;Ljava/util/Locale;)J");
                _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "needsReload", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/util/ResourceBundle;J)Z");
                _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "toBundleName", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;");
                _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "toResourceName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            }

            public Control() : base(IntPtr.Zero)
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

            public Control(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Control.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.ResourceBundle.Control GetControl(global::Java.Util.List<global::System.String> formats)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = formats.GetRawObject() } };
                    return new global::Java.Util.ResourceBundle.Control(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.ResourceBundle.Control GetNoFallbackControl(global::Java.Util.List<global::System.String> formats)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = formats.GetRawObject() } };
                    return new global::Java.Util.ResourceBundle.Control(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.List<global::System.String> GetFormats(global::System.String baseName)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) } };
                    return new global::Java.Util.ListAnonymousImplementation<global::System.String>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.List<global::Java.Util.Locale> GetCandidateLocales(global::System.String baseName, global::Java.Util.Locale locale)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                                new jvalue { l = locale.GetRawObject() }
                            };
                    return new global::Java.Util.ListAnonymousImplementation<global::Java.Util.Locale>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale GetFallbackLocale(global::System.String baseName, global::Java.Util.Locale locale)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                                new jvalue { l = locale.GetRawObject() }
                            };
                    return new global::Java.Util.Locale(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.ResourceBundle NewBundle(global::System.String baseName, global::Java.Util.Locale locale, global::System.String format, global::Java.Lang.ClassLoader loader, bool reload)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                                new jvalue { l = locale.GetRawObject() },
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(format) },
                                new jvalue { l = loader.GetRawObject() },
                                new jvalue { z = reload }
                            };
                    return new global::Java.Util.ResourceBundle(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public long GetTimeToLive(global::System.String baseName, global::Java.Util.Locale locale)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                                new jvalue { l = locale.GetRawObject() }
                            };
                    return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId6, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public bool NeedsReload(global::System.String baseName, global::Java.Util.Locale locale, global::System.String format, global::Java.Lang.ClassLoader loader, global::Java.Util.ResourceBundle bundle, long loadTime)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                                new jvalue { l = locale.GetRawObject() },
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(format) },
                                new jvalue { l = loader.GetRawObject() },
                                new jvalue { l = bundle.GetRawObject() },
                                new jvalue { j = loadTime }
                            };
                    return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId7, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::System.String ToBundleName(global::System.String baseName, global::Java.Util.Locale locale)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                                new jvalue { l = locale.GetRawObject() }
                            };
                    return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId8, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::System.String ToResourceName(global::System.String bundleName, global::System.String suffix)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(bundleName) },
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(suffix) }
                            };
                    return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId9, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Control wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Control(IntPtr rawObject)
            {
                return new Control(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Control

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
        private static readonly IntPtr _cachedMethodId13;
        private static readonly IntPtr _cachedMethodId14;

        static ResourceBundle()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/ResourceBundle");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getBaseBundleName", "()Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "getLocale", "()Ljava/util/Locale;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "getBundle", "(Ljava/lang/String;Ljava/util/ResourceBundle$Control;)Ljava/util/ResourceBundle;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/ResourceBundle$Control;)Ljava/util/ResourceBundle;");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;Ljava/util/ResourceBundle$Control;)Ljava/util/ResourceBundle;");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "clearCache", "()V");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "clearCache", "(Ljava/lang/ClassLoader;)V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "getKeys", "()Ljava/util/Enumeration;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "containsKey", "(Ljava/lang/String;)Z");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "keySet", "()Ljava/util/Set;");
        }

        public ResourceBundle() : base(IntPtr.Zero)
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

        public ResourceBundle(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ResourceBundle.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetBaseBundleName()
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

        public global::System.String GetString(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Google.LibraryWrapper.Java.JavaObject GetObject(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Locale GetLocale()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Locale(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ResourceBundle GetBundle(global::System.String baseName)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) } };
                return new global::Java.Util.ResourceBundle(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ResourceBundle GetBundle(global::System.String baseName, global::Java.Util.ResourceBundle.Control control)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                            new jvalue { l = control.GetRawObject() }
                        };
                return new global::Java.Util.ResourceBundle(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ResourceBundle GetBundle(global::System.String baseName, global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                            new jvalue { l = locale.GetRawObject() }
                        };
                return new global::Java.Util.ResourceBundle(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ResourceBundle GetBundle(global::System.String baseName, global::Java.Util.Locale targetLocale, global::Java.Util.ResourceBundle.Control control)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                            new jvalue { l = targetLocale.GetRawObject() },
                            new jvalue { l = control.GetRawObject() }
                        };
                return new global::Java.Util.ResourceBundle(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ResourceBundle GetBundle(global::System.String baseName, global::Java.Util.Locale locale, global::Java.Lang.ClassLoader loader)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                            new jvalue { l = locale.GetRawObject() },
                            new jvalue { l = loader.GetRawObject() }
                        };
                return new global::Java.Util.ResourceBundle(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ResourceBundle GetBundle(global::System.String baseName, global::Java.Util.Locale targetLocale, global::Java.Lang.ClassLoader loader, global::Java.Util.ResourceBundle.Control control)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(baseName) },
                            new jvalue { l = targetLocale.GetRawObject() },
                            new jvalue { l = loader.GetRawObject() },
                            new jvalue { l = control.GetRawObject() }
                        };
                return new global::Java.Util.ResourceBundle(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void ClearCache()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void ClearCache(global::Java.Lang.ClassLoader loader)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = loader.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Enumeration<global::System.String> GetKeys()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.EnumerationAnonymousImplementation<global::System.String>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ContainsKey(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<global::System.String> KeySet()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.SetAnonymousImplementation<global::System.String>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ResourceBundle wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ResourceBundle(IntPtr rawObject)
        {
            return new ResourceBundle(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ResourceBundle
} // end namespace Java.Util
