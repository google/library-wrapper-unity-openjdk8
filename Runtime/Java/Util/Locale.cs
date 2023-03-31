using System;

using UnityEngine;

namespace Java.Util
{
    public class Locale : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Io.Serializable
    {
        public class Builder : global::Google.LibraryWrapper.Java.JavaObject
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

            static Builder()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Locale$Builder");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "setLocale", "(Ljava/util/Locale;)Ljava/util/Locale$Builder;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "setLanguageTag", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "setLanguage", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "setScript", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "setRegion", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "setVariant", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "setExtension", "(CLjava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "setUnicodeLocaleKeyword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "addUnicodeLocaleAttribute", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "removeUnicodeLocaleAttribute", "(Ljava/lang/String;)Ljava/util/Locale$Builder;");
                _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "clear", "()Ljava/util/Locale$Builder;");
                _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "clearExtensions", "()Ljava/util/Locale$Builder;");
                _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "build", "()Ljava/util/Locale;");
            }

            public Builder() : base(IntPtr.Zero)
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

            public Builder(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Builder.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetLocale(global::Java.Util.Locale locale)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = locale.GetRawObject() } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetLanguageTag(global::System.String languageTag)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(languageTag) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetLanguage(global::System.String language)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(language) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetScript(global::System.String script)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(script) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetRegion(global::System.String region)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(region) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetVariant(global::System.String variant)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(variant) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetExtension(char key, global::System.String value)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { c = key },
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(value) }
                            };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder SetUnicodeLocaleKeyword(global::System.String key, global::System.String type)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) },
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(type) }
                            };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder AddUnicodeLocaleAttribute(global::System.String attribute)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(attribute) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder RemoveUnicodeLocaleAttribute(global::System.String attribute)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(attribute) } };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder Clear()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale.Builder ClearExtensions()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.Locale.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Locale Build()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.Locale(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Builder wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Builder(IntPtr rawObject)
            {
                return new Builder(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Builder

        public class Category : global::Java.Lang.Enum<global::Java.Util.Locale.Category>
        {
            public static global::Java.Util.Locale.Category DISPLAY
            {
                get
                {
                    return new global::Java.Util.Locale.Category(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.Locale.Category FORMAT
            {
                get
                {
                    return new global::Java.Util.Locale.Category(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
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

            static Category()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Locale$Category");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "DISPLAY", "Ljava/util/Locale$Category;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "FORMAT", "Ljava/util/Locale$Category;");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/util/Locale$Category;");
            }

            public Category(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Category.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Locale.Category ValueOf(global::System.String name)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                    return new global::Java.Util.Locale.Category(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Category wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Category(IntPtr rawObject)
            {
                return new Category(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Category

        public class FilteringMode : global::Java.Lang.Enum<global::Java.Util.Locale.FilteringMode>
        {
            public static global::Java.Util.Locale.FilteringMode AUTOSELECT_FILTERING
            {
                get
                {
                    return new global::Java.Util.Locale.FilteringMode(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.Locale.FilteringMode EXTENDED_FILTERING
            {
                get
                {
                    return new global::Java.Util.Locale.FilteringMode(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.Locale.FilteringMode IGNORE_EXTENDED_RANGES
            {
                get
                {
                    return new global::Java.Util.Locale.FilteringMode(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.Locale.FilteringMode MAP_EXTENDED_RANGES
            {
                get
                {
                    return new global::Java.Util.Locale.FilteringMode(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId3));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId3, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Util.Locale.FilteringMode REJECT_EXTENDED_RANGES
            {
                get
                {
                    return new global::Java.Util.Locale.FilteringMode(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId4));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId4, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }

            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedFieldId0;
            private static readonly IntPtr _cachedFieldId1;
            private static readonly IntPtr _cachedFieldId2;
            private static readonly IntPtr _cachedFieldId3;
            private static readonly IntPtr _cachedFieldId4;
            private static readonly IntPtr _cachedMethodId0;

            static FilteringMode()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Locale$FilteringMode");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "AUTOSELECT_FILTERING", "Ljava/util/Locale$FilteringMode;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "EXTENDED_FILTERING", "Ljava/util/Locale$FilteringMode;");
                _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "IGNORE_EXTENDED_RANGES", "Ljava/util/Locale$FilteringMode;");
                _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "MAP_EXTENDED_RANGES", "Ljava/util/Locale$FilteringMode;");
                _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "REJECT_EXTENDED_RANGES", "Ljava/util/Locale$FilteringMode;");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/util/Locale$FilteringMode;");
            }

            public FilteringMode(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of FilteringMode.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Locale.FilteringMode ValueOf(global::System.String name)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                    return new global::Java.Util.Locale.FilteringMode(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(FilteringMode wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator FilteringMode(IntPtr rawObject)
            {
                return new FilteringMode(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class FilteringMode

        public class LanguageRange : global::Google.LibraryWrapper.Java.JavaObject
        {
            public static double MAX_WEIGHT
            {
                get
                {
                    return AndroidJNI.GetStaticDoubleField(_classObject, _cachedFieldId0);
                }
                set
                {
                    AndroidJNI.SetStaticDoubleField(_classObject, _cachedFieldId0, value);
                }
            }
            public static double MIN_WEIGHT
            {
                get
                {
                    return AndroidJNI.GetStaticDoubleField(_classObject, _cachedFieldId1);
                }
                set
                {
                    AndroidJNI.SetStaticDoubleField(_classObject, _cachedFieldId1, value);
                }
            }

            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedFieldId0;
            private static readonly IntPtr _cachedFieldId1;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedConstructorId1;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;
            private static readonly IntPtr _cachedMethodId3;
            private static readonly IntPtr _cachedMethodId4;
            private static readonly IntPtr _cachedMethodId5;
            private static readonly IntPtr _cachedMethodId6;

            static LanguageRange()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Locale$LanguageRange");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_WEIGHT", "D");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_WEIGHT", "D");
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
                _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;D)V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getRange", "()Ljava/lang/String;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getWeight", "()D");
                _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "parse", "(Ljava/lang/String;)Ljava/util/List;");
                _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "parse", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/List;");
                _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "mapEquivalents", "(Ljava/util/List;Ljava/util/Map;)Ljava/util/List;");
                _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
                _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            }

            public LanguageRange(global::System.String range) : base(IntPtr.Zero)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(range) } };
                    IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public LanguageRange(global::System.String range, double weight) : base(IntPtr.Zero)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(range) },
                                new jvalue { d = weight }
                            };
                    IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public LanguageRange(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of LanguageRange.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::System.String GetRange()
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

            public double GetWeight()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return AndroidJNI.CallDoubleMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.List<global::Java.Util.Locale.LanguageRange> Parse(global::System.String ranges)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ranges) } };
                    return new global::Java.Util.ListAnonymousImplementation<global::Java.Util.Locale.LanguageRange>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.List<global::Java.Util.Locale.LanguageRange> Parse(global::System.String ranges, global::Java.Util.Map<global::System.String, global::Java.Util.List<global::System.String>> map)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ranges) },
                                new jvalue { l = map.GetRawObject() }
                            };
                    return new global::Java.Util.ListAnonymousImplementation<global::Java.Util.Locale.LanguageRange>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.List<global::Java.Util.Locale.LanguageRange> MapEquivalents(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Map<global::System.String, global::Java.Util.List<global::System.String>> map)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = priorityList.GetRawObject() },
                                new jvalue { l = map.GetRawObject() }
                            };
                    return new global::Java.Util.ListAnonymousImplementation<global::Java.Util.Locale.LanguageRange>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public int HashCode()
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

            public bool Equals(global::Google.LibraryWrapper.Java.JavaObject obj)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                    return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId6, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(LanguageRange wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator LanguageRange(IntPtr rawObject)
            {
                return new LanguageRange(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class LanguageRange

        public static global::Java.Util.Locale ENGLISH
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale FRENCH
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale GERMAN
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale ITALIAN
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId3));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId3, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale JAPANESE
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId4));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId4, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale KOREAN
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId5));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId5, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale CHINESE
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId6));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId6, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale SIMPLIFIED_CHINESE
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId7));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId7, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale TRADITIONAL_CHINESE
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId8));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId8, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale FRANCE
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId9));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId9, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale GERMANY
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId10));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId10, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale ITALY
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId11));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId11, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale JAPAN
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId12));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId12, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale KOREA
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId13));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId13, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale CHINA
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId14));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId14, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale PRC
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId15));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId15, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale TAIWAN
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId16));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId16, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale UK
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId17));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId17, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale US
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId18));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId18, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale CANADA
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId19));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId19, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale CANADA_FRENCH
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId20));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId20, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Util.Locale ROOT
        {
            get
            {
                return new global::Java.Util.Locale(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId21));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId21, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static char PRIVATE_USE_EXTENSION
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId22);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId22, value);
            }
        }
        public static char UNICODE_LOCALE_EXTENSION
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId23);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId23, value);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
        private static readonly IntPtr _cachedFieldId2;
        private static readonly IntPtr _cachedFieldId3;
        private static readonly IntPtr _cachedFieldId4;
        private static readonly IntPtr _cachedFieldId5;
        private static readonly IntPtr _cachedFieldId6;
        private static readonly IntPtr _cachedFieldId7;
        private static readonly IntPtr _cachedFieldId8;
        private static readonly IntPtr _cachedFieldId9;
        private static readonly IntPtr _cachedFieldId10;
        private static readonly IntPtr _cachedFieldId11;
        private static readonly IntPtr _cachedFieldId12;
        private static readonly IntPtr _cachedFieldId13;
        private static readonly IntPtr _cachedFieldId14;
        private static readonly IntPtr _cachedFieldId15;
        private static readonly IntPtr _cachedFieldId16;
        private static readonly IntPtr _cachedFieldId17;
        private static readonly IntPtr _cachedFieldId18;
        private static readonly IntPtr _cachedFieldId19;
        private static readonly IntPtr _cachedFieldId20;
        private static readonly IntPtr _cachedFieldId21;
        private static readonly IntPtr _cachedFieldId22;
        private static readonly IntPtr _cachedFieldId23;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
        private static readonly IntPtr _cachedConstructorId2;
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
        private static readonly IntPtr _cachedMethodId27;
        private static readonly IntPtr _cachedMethodId28;
        private static readonly IntPtr _cachedMethodId29;
        private static readonly IntPtr _cachedMethodId30;
        private static readonly IntPtr _cachedMethodId31;
        private static readonly IntPtr _cachedMethodId32;
        private static readonly IntPtr _cachedMethodId33;
        private static readonly IntPtr _cachedMethodId34;
        private static readonly IntPtr _cachedMethodId35;
        private static readonly IntPtr _cachedMethodId36;
        private static readonly IntPtr _cachedMethodId37;

        static Locale()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Locale");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "ENGLISH", "Ljava/util/Locale;");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "FRENCH", "Ljava/util/Locale;");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "GERMAN", "Ljava/util/Locale;");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "ITALIAN", "Ljava/util/Locale;");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "JAPANESE", "Ljava/util/Locale;");
            _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "KOREAN", "Ljava/util/Locale;");
            _cachedFieldId6 = AndroidJNI.GetStaticFieldID(_classObject, "CHINESE", "Ljava/util/Locale;");
            _cachedFieldId7 = AndroidJNI.GetStaticFieldID(_classObject, "SIMPLIFIED_CHINESE", "Ljava/util/Locale;");
            _cachedFieldId8 = AndroidJNI.GetStaticFieldID(_classObject, "TRADITIONAL_CHINESE", "Ljava/util/Locale;");
            _cachedFieldId9 = AndroidJNI.GetStaticFieldID(_classObject, "FRANCE", "Ljava/util/Locale;");
            _cachedFieldId10 = AndroidJNI.GetStaticFieldID(_classObject, "GERMANY", "Ljava/util/Locale;");
            _cachedFieldId11 = AndroidJNI.GetStaticFieldID(_classObject, "ITALY", "Ljava/util/Locale;");
            _cachedFieldId12 = AndroidJNI.GetStaticFieldID(_classObject, "JAPAN", "Ljava/util/Locale;");
            _cachedFieldId13 = AndroidJNI.GetStaticFieldID(_classObject, "KOREA", "Ljava/util/Locale;");
            _cachedFieldId14 = AndroidJNI.GetStaticFieldID(_classObject, "CHINA", "Ljava/util/Locale;");
            _cachedFieldId15 = AndroidJNI.GetStaticFieldID(_classObject, "PRC", "Ljava/util/Locale;");
            _cachedFieldId16 = AndroidJNI.GetStaticFieldID(_classObject, "TAIWAN", "Ljava/util/Locale;");
            _cachedFieldId17 = AndroidJNI.GetStaticFieldID(_classObject, "UK", "Ljava/util/Locale;");
            _cachedFieldId18 = AndroidJNI.GetStaticFieldID(_classObject, "US", "Ljava/util/Locale;");
            _cachedFieldId19 = AndroidJNI.GetStaticFieldID(_classObject, "CANADA", "Ljava/util/Locale;");
            _cachedFieldId20 = AndroidJNI.GetStaticFieldID(_classObject, "CANADA_FRENCH", "Ljava/util/Locale;");
            _cachedFieldId21 = AndroidJNI.GetStaticFieldID(_classObject, "ROOT", "Ljava/util/Locale;");
            _cachedFieldId22 = AndroidJNI.GetStaticFieldID(_classObject, "PRIVATE_USE_EXTENSION", "C");
            _cachedFieldId23 = AndroidJNI.GetStaticFieldID(_classObject, "UNICODE_LOCALE_EXTENSION", "C");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "getDefault", "()Ljava/util/Locale;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "getDefault", "(Ljava/util/Locale$Category;)Ljava/util/Locale;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "setDefault", "(Ljava/util/Locale;)V");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "setDefault", "(Ljava/util/Locale$Category;Ljava/util/Locale;)V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "getLanguage", "()Ljava/lang/String;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "getScript", "()Ljava/lang/String;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "getCountry", "()Ljava/lang/String;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "getVariant", "()Ljava/lang/String;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "hasExtensions", "()Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "stripExtensions", "()Ljava/util/Locale;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "getExtension", "(C)Ljava/lang/String;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "getExtensionKeys", "()Ljava/util/Set;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "getUnicodeLocaleAttributes", "()Ljava/util/Set;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "getUnicodeLocaleType", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "getUnicodeLocaleKeys", "()Ljava/util/Set;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "toLanguageTag", "()Ljava/lang/String;");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "forLanguageTag", "(Ljava/lang/String;)Ljava/util/Locale;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "getISO3Language", "()Ljava/lang/String;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "getISO3Country", "()Ljava/lang/String;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "getDisplayLanguage", "()Ljava/lang/String;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "getDisplayScript", "()Ljava/lang/String;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "getDisplayScript", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "getDisplayCountry", "()Ljava/lang/String;");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "getDisplayVariant", "()Ljava/lang/String;");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "()Ljava/lang/String;");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId32 = AndroidJNI.GetStaticMethodID(_classObject, "filter", "(Ljava/util/List;Ljava/util/Collection;Ljava/util/Locale$FilteringMode;)Ljava/util/List;");
            _cachedMethodId33 = AndroidJNI.GetStaticMethodID(_classObject, "filter", "(Ljava/util/List;Ljava/util/Collection;)Ljava/util/List;");
            _cachedMethodId34 = AndroidJNI.GetStaticMethodID(_classObject, "filterTags", "(Ljava/util/List;Ljava/util/Collection;Ljava/util/Locale$FilteringMode;)Ljava/util/List;");
            _cachedMethodId35 = AndroidJNI.GetStaticMethodID(_classObject, "filterTags", "(Ljava/util/List;Ljava/util/Collection;)Ljava/util/List;");
            _cachedMethodId36 = AndroidJNI.GetStaticMethodID(_classObject, "lookup", "(Ljava/util/List;Ljava/util/Collection;)Ljava/util/Locale;");
            _cachedMethodId37 = AndroidJNI.GetStaticMethodID(_classObject, "lookupTag", "(Ljava/util/List;Ljava/util/Collection;)Ljava/lang/String;");
        }

        public Locale(global::System.String language, global::System.String country, global::System.String variant) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(language) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(country) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(variant) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Locale(global::System.String language, global::System.String country) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(language) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(country) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Locale(global::System.String language) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(language) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Locale(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Locale.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Locale GetDefault()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Locale(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Locale GetDefault(global::Java.Util.Locale.Category category)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = category.GetRawObject() } };
                return new global::Java.Util.Locale(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetDefault(global::Java.Util.Locale newLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = newLocale.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetDefault(global::Java.Util.Locale.Category category, global::Java.Util.Locale newLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = category.GetRawObject() },
                            new jvalue { l = newLocale.GetRawObject() }
                        };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetLanguage()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetScript()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetCountry()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetVariant()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool HasExtensions()
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

        public global::Java.Util.Locale StripExtensions()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Locale(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetExtension(char key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = key } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<global::Java.Lang.Character> GetExtensionKeys()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.SetAnonymousImplementation<global::Java.Lang.Character>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<global::System.String> GetUnicodeLocaleAttributes()
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

        public global::System.String GetUnicodeLocaleType(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<global::System.String> GetUnicodeLocaleKeys()
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

        public global::System.String ToLanguageTag()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Locale ForLanguageTag(global::System.String languageTag)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(languageTag) } };
                return new global::Java.Util.Locale(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetISO3Language()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetISO3Country()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayLanguage()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayLanguage(global::Java.Util.Locale inLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = inLocale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayScript()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayScript(global::Java.Util.Locale inLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = inLocale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayCountry()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayCountry(global::Java.Util.Locale inLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = inLocale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayVariant()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayVariant(global::Java.Util.Locale inLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = inLocale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName(global::Java.Util.Locale inLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = inLocale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Google.LibraryWrapper.Java.JavaObject Clone()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId29, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int HashCode()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Equals(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.List<global::Java.Util.Locale> Filter(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Collection<global::Java.Util.Locale> locales, global::Java.Util.Locale.FilteringMode mode)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = priorityList.GetRawObject() },
                            new jvalue { l = locales.GetRawObject() },
                            new jvalue { l = mode.GetRawObject() }
                        };
                return new global::Java.Util.ListAnonymousImplementation<global::Java.Util.Locale>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId32, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.List<global::Java.Util.Locale> Filter(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Collection<global::Java.Util.Locale> locales)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = priorityList.GetRawObject() },
                            new jvalue { l = locales.GetRawObject() }
                        };
                return new global::Java.Util.ListAnonymousImplementation<global::Java.Util.Locale>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId33, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.List<global::System.String> FilterTags(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Collection<global::System.String> tags, global::Java.Util.Locale.FilteringMode mode)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = priorityList.GetRawObject() },
                            new jvalue { l = tags.GetRawObject() },
                            new jvalue { l = mode.GetRawObject() }
                        };
                return new global::Java.Util.ListAnonymousImplementation<global::System.String>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId34, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.List<global::System.String> FilterTags(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Collection<global::System.String> tags)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = priorityList.GetRawObject() },
                            new jvalue { l = tags.GetRawObject() }
                        };
                return new global::Java.Util.ListAnonymousImplementation<global::System.String>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId35, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Locale Lookup(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Collection<global::Java.Util.Locale> locales)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = priorityList.GetRawObject() },
                            new jvalue { l = locales.GetRawObject() }
                        };
                return new global::Java.Util.Locale(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId36, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String LookupTag(global::Java.Util.List<global::Java.Util.Locale.LanguageRange> priorityList, global::Java.Util.Collection<global::System.String> tags)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = priorityList.GetRawObject() },
                            new jvalue { l = tags.GetRawObject() }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId37, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Locale wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Locale(IntPtr rawObject)
        {
            return new Locale(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Locale
} // end namespace Java.Util
