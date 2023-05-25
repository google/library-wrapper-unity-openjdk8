using System;

using UnityEngine;

namespace Java.Lang
{
    public class String : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable, global::Java.ExternalType.Java.Lang.Comparable<global::System.String>, global::Java.Lang.CharSequence
    {
        public static global::Java.Util.Comparator<global::System.String> CASE_INSENSITIVE_ORDER
        {
            get
            {
                return new global::Java.Util.ComparatorAnonymousImplementation<global::System.String>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
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
        private static readonly IntPtr _cachedMethodId38;
        private static readonly IntPtr _cachedMethodId39;
        private static readonly IntPtr _cachedMethodId40;
        private static readonly IntPtr _cachedMethodId41;
        private static readonly IntPtr _cachedMethodId42;
        private static readonly IntPtr _cachedMethodId43;
        private static readonly IntPtr _cachedMethodId44;
        private static readonly IntPtr _cachedMethodId45;
        private static readonly IntPtr _cachedMethodId46;
        private static readonly IntPtr _cachedMethodId47;
        private static readonly IntPtr _cachedMethodId48;
        private static readonly IntPtr _cachedMethodId49;
        private static readonly IntPtr _cachedMethodId50;

        static String()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/String");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/StringBuffer;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/StringBuilder;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "length", "()I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "charAt", "(I)C");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "codePointAt", "(I)I");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "codePointBefore", "(I)I");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "codePointCount", "(II)I");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "offsetByCodePoints", "(II)I");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "contentEquals", "(Ljava/lang/StringBuffer;)Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "contentEquals", "(Ljava/lang/CharSequence;)Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "equalsIgnoreCase", "(Ljava/lang/String;)Z");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/String;)I");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "compareToIgnoreCase", "(Ljava/lang/String;)I");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "regionMatches", "(ILjava/lang/String;II)Z");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "regionMatches", "(ZILjava/lang/String;II)Z");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "startsWith", "(Ljava/lang/String;I)Z");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "startsWith", "(Ljava/lang/String;)Z");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "endsWith", "(Ljava/lang/String;)Z");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(I)I");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(II)I");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(I)I");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(II)I");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(Ljava/lang/String;)I");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(Ljava/lang/String;I)I");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(Ljava/lang/String;)I");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(Ljava/lang/String;I)I");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "substring", "(I)Ljava/lang/String;");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "substring", "(II)Ljava/lang/String;");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "subSequence", "(II)Ljava/lang/CharSequence;");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "concat", "(Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "replace", "(CC)Ljava/lang/String;");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "matches", "(Ljava/lang/String;)Z");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "contains", "(Ljava/lang/CharSequence;)Z");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId35 = AndroidJNI.GetMethodID(_classObject, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId36 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;");
            _cachedMethodId37 = AndroidJNI.GetStaticMethodID(_classObject, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;");
            _cachedMethodId38 = AndroidJNI.GetMethodID(_classObject, "toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId39 = AndroidJNI.GetMethodID(_classObject, "toLowerCase", "()Ljava/lang/String;");
            _cachedMethodId40 = AndroidJNI.GetMethodID(_classObject, "toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId41 = AndroidJNI.GetMethodID(_classObject, "toUpperCase", "()Ljava/lang/String;");
            _cachedMethodId42 = AndroidJNI.GetMethodID(_classObject, "trim", "()Ljava/lang/String;");
            _cachedMethodId43 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;");
            _cachedMethodId44 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Z)Ljava/lang/String;");
            _cachedMethodId45 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(C)Ljava/lang/String;");
            _cachedMethodId46 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(I)Ljava/lang/String;");
            _cachedMethodId47 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(J)Ljava/lang/String;");
            _cachedMethodId48 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(F)Ljava/lang/String;");
            _cachedMethodId49 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(D)Ljava/lang/String;");
            _cachedMethodId50 = AndroidJNI.GetMethodID(_classObject, "intern", "()Ljava/lang/String;");
        }

        public String() : base(IntPtr.Zero)
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

        public String(global::System.String original) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(original) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public String(global::Java.Lang.StringBuffer buffer) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = buffer.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public String(global::Java.ExternalType.Java.Lang.StringBuilder builder) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = builder.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public String(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of String.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Length()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsEmpty()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public char CharAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallCharMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CodePointAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CodePointBefore(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CodePointCount(int beginIndex, int endIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = beginIndex },
                            new jvalue { i = endIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int OffsetByCodePoints(int index, int codePointOffset)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = index },
                            new jvalue { i = codePointOffset }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Equals(global::Google.LibraryWrapper.Java.JavaObject anObject)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anObject.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ContentEquals(global::Java.Lang.StringBuffer sb)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = sb.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ContentEquals(global::Java.Lang.CharSequence cs)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = cs.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool EqualsIgnoreCase(global::System.String anotherString)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(anotherString) } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::System.String anotherString)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(anotherString) } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareToIgnoreCase(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RegionMatches(int toffset, global::System.String other, int ooffset, int len)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = toffset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(other) },
                            new jvalue { i = ooffset },
                            new jvalue { i = len }
                        };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RegionMatches(bool ignoreCase, int toffset, global::System.String other, int ooffset, int len)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = ignoreCase },
                            new jvalue { i = toffset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(other) },
                            new jvalue { i = ooffset },
                            new jvalue { i = len }
                        };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool StartsWith(global::System.String prefix, int toffset)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(prefix) },
                            new jvalue { i = toffset }
                        };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool StartsWith(global::System.String prefix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(prefix) } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool EndsWith(global::System.String suffix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(suffix) } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId17, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(int ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = ch } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(int ch, int fromIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = ch },
                            new jvalue { i = fromIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(int ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = ch } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(int ch, int fromIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = ch },
                            new jvalue { i = fromIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(global::System.String str, int fromIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) },
                            new jvalue { i = fromIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(global::System.String str, int fromIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) },
                            new jvalue { i = fromIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Substring(int beginIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = beginIndex } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Substring(int beginIndex, int endIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = beginIndex },
                            new jvalue { i = endIndex }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.CharSequence SubSequence(int beginIndex, int endIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = beginIndex },
                            new jvalue { i = endIndex }
                        };
                return new global::Java.Lang.CharSequenceAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId29, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Concat(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Replace(char oldChar, char newChar)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { c = oldChar },
                            new jvalue { c = newChar }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Matches(global::System.String regex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(regex) } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId32, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Contains(global::Java.Lang.CharSequence s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ReplaceFirst(global::System.String regex, global::System.String replacement)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(regex) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(replacement) }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ReplaceAll(global::System.String regex, global::System.String replacement)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(regex) },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(replacement) }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Replace(global::Java.Lang.CharSequence target, global::Java.Lang.CharSequence replacement)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = target.GetRawObject() },
                            new jvalue { l = replacement.GetRawObject() }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId36, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String Join(global::Java.Lang.CharSequence delimiter, global::Java.Lang.Iterable<global::Java.Lang.CharSequence> elements)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = delimiter.GetRawObject() },
                            new jvalue { l = elements.GetRawObject() }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId37, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ToLowerCase(global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = locale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ToLowerCase()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId39, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ToUpperCase(global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = locale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId40, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ToUpperCase()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId41, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Trim()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId42, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId43, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = b } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId44, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(char c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = c } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId45, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId46, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(long l)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = l } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId47, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId48, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ValueOf(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId49, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Intern()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId50, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(String wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator String(IntPtr rawObject)
        {
            return new String(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class String
} // end namespace Java.Lang
