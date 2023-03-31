using System;

using UnityEngine;

namespace Java.Lang
{
    public class Character : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Lang.Character>
    {
        public class Subset : global::Google.LibraryWrapper.Java.JavaObject
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;

            static Subset()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/Character$Subset");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            }

            public Subset() : base(IntPtr.Zero)
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

            public Subset(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Subset.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
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
                    return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId0, args_);
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
                    return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Subset wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Subset(IntPtr rawObject)
            {
                return new Subset(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Subset

        public class UnicodeBlock : global::Java.Lang.Character.Subset
        {
            public static global::Java.Lang.Character.UnicodeBlock BASIC_LATIN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LATIN_EXTENDED_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LATIN_EXTENDED_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId3));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId3, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock IPA_EXTENSIONS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId4));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId4, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId5));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId5, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId6));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId6, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GREEK
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId7));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId7, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CYRILLIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId8));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId8, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARMENIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId9));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId9, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HEBREW
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId10));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId10, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARABIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId11));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId11, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock DEVANAGARI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId12));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId12, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BENGALI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId13));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId13, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GURMUKHI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId14));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId14, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GUJARATI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId15));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId15, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ORIYA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId16));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId16, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAMIL
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId17));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId17, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TELUGU
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId18));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId18, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KANNADA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId19));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId19, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MALAYALAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId20));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId20, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock THAI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId21));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId21, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LAO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId22));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId22, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TIBETAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId23));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId23, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GEORGIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId24));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId24, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HANGUL_JAMO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId25));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId25, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId26));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId26, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GREEK_EXTENDED
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId27));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId27, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GENERAL_PUNCTUATION
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId28));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId28, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId29));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId29, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CURRENCY_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId30));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId30, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId31));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId31, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId32));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId32, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock NUMBER_FORMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId33));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId33, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARROWS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId34));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId34, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId35));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId35, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId36));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId36, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CONTROL_PICTURES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId37));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId37, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId38));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId38, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId39));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId39, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BOX_DRAWING
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId40));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId40, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BLOCK_ELEMENTS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId41));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId41, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GEOMETRIC_SHAPES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId42));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId42, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId43));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId43, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock DINGBATS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId44));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId44, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId45));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId45, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HIRAGANA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId46));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId46, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KATAKANA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId47));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId47, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BOPOMOFO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId48));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId48, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId49));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId49, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KANBUN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId50));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId50, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId51));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId51, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_COMPATIBILITY
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId52));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId52, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId53));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId53, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HANGUL_SYLLABLES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId54));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId54, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PRIVATE_USE_AREA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId55));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId55, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId56));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId56, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId57));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId57, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId58));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId58, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COMBINING_HALF_MARKS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId59));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId59, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId60));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId60, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SMALL_FORM_VARIANTS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId61));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId61, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId62));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId62, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId63));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId63, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SPECIALS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId64));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId64, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SURROGATES_AREA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId65));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId65, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SYRIAC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId66));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId66, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock THAANA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId67));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId67, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SINHALA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId68));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId68, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MYANMAR
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId69));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId69, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ETHIOPIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId70));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId70, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CHEROKEE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId71));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId71, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId72));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId72, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OGHAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId73));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId73, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock RUNIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId74));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId74, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KHMER
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId75));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId75, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MONGOLIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId76));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId76, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BRAILLE_PATTERNS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId77));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId77, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId78));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId78, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KANGXI_RADICALS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId79));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId79, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId80));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId80, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BOPOMOFO_EXTENDED
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId81));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId81, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId82));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId82, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock YI_SYLLABLES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId83));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId83, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock YI_RADICALS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId84));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId84, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId85));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId85, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAGALOG
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId86));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId86, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HANUNOO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId87));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId87, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BUHID
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId88));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId88, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAGBANWA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId89));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId89, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LIMBU
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId90));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId90, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAI_LE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId91));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId91, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KHMER_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId92));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId92, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PHONETIC_EXTENSIONS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId93));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId93, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId94));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId94, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId95));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId95, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId96));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId96, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId97));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId97, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId98));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId98, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId99));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId99, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId100));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId100, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId101));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId101, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock VARIATION_SELECTORS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId102));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId102, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LINEAR_B_SYLLABARY
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId103));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId103, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId104));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId104, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock AEGEAN_NUMBERS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId105));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId105, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OLD_ITALIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId106));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId106, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GOTHIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId107));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId107, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock UGARITIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId108));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId108, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock DESERET
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId109));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId109, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SHAVIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId110));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId110, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OSMANYA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId111));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId111, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CYPRIOT_SYLLABARY
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId112));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId112, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId113));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId113, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MUSICAL_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId114));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId114, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId115));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId115, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId116));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId116, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId117));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId117, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId118));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId118, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAGS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId119));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId119, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId120));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId120, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId121));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId121, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId122));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId122, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HIGH_SURROGATES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId123));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId123, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId124));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId124, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LOW_SURROGATES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId125));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId125, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARABIC_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId126));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId126, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock NKO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId127));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId127, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SAMARITAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId128));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId128, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MANDAIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId129));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId129, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ETHIOPIC_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId130));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId130, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_EXTENDED
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId131));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId131, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock NEW_TAI_LUE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId132));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId132, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BUGINESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId133));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId133, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAI_THAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId134));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId134, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BALINESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId135));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId135, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUNDANESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId136));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId136, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BATAK
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId137));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId137, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LEPCHA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId138));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId138, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OL_CHIKI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId139));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId139, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock VEDIC_EXTENSIONS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId140));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId140, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PHONETIC_EXTENSIONS_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId141));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId141, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId142));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId142, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GLAGOLITIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId143));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId143, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LATIN_EXTENDED_C
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId144));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId144, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COPTIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId145));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId145, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock GEORGIAN_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId146));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId146, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TIFINAGH
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId147));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId147, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ETHIOPIC_EXTENDED
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId148));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId148, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CYRILLIC_EXTENDED_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId149));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId149, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUPPLEMENTAL_PUNCTUATION
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId150));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId150, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_STROKES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId151));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId151, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LISU
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId152));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId152, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock VAI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId153));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId153, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CYRILLIC_EXTENDED_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId154));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId154, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BAMUM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId155));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId155, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MODIFIER_TONE_LETTERS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId156));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId156, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LATIN_EXTENDED_D
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId157));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId157, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SYLOTI_NAGRI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId158));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId158, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COMMON_INDIC_NUMBER_FORMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId159));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId159, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PHAGS_PA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId160));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId160, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SAURASHTRA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId161));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId161, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock DEVANAGARI_EXTENDED
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId162));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId162, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KAYAH_LI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId163));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId163, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock REJANG
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId164));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId164, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HANGUL_JAMO_EXTENDED_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId165));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId165, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock JAVANESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId166));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId166, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CHAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId167));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId167, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MYANMAR_EXTENDED_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId168));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId168, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAI_VIET
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId169));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId169, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ETHIOPIC_EXTENDED_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId170));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId170, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MEETEI_MAYEK
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId171));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId171, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock HANGUL_JAMO_EXTENDED_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId172));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId172, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock VERTICAL_FORMS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId173));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId173, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ANCIENT_GREEK_NUMBERS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId174));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId174, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ANCIENT_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId175));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId175, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PHAISTOS_DISC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId176));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId176, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LYCIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId177));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId177, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CARIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId178));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId178, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OLD_PERSIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId179));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId179, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock IMPERIAL_ARAMAIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId180));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId180, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PHOENICIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId181));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId181, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock LYDIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId182));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId182, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KHAROSHTHI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId183));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId183, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OLD_SOUTH_ARABIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId184));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId184, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock AVESTAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId185));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId185, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock INSCRIPTIONAL_PARTHIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId186));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId186, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock INSCRIPTIONAL_PAHLAVI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId187));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId187, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock OLD_TURKIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId188));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId188, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock RUMI_NUMERAL_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId189));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId189, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BRAHMI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId190));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId190, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KAITHI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId191));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId191, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CUNEIFORM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId192));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId192, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CUNEIFORM_NUMBERS_AND_PUNCTUATION
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId193));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId193, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock EGYPTIAN_HIEROGLYPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId194));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId194, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock BAMUM_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId195));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId195, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock KANA_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId196));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId196, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ANCIENT_GREEK_MUSICAL_NOTATION
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId197));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId197, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock COUNTING_ROD_NUMERALS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId198));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId198, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MAHJONG_TILES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId199));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId199, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock DOMINO_TILES
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId200));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId200, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock PLAYING_CARDS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId201));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId201, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERIC_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId202));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId202, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ENCLOSED_IDEOGRAPHIC_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId203));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId203, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_PICTOGRAPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId204));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId204, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock EMOTICONS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId205));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId205, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TRANSPORT_AND_MAP_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId206));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId206, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ALCHEMICAL_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId207));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId207, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_C
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId208));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId208, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_D
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId209));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId209, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARABIC_EXTENDED_A
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId210));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId210, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SUNDANESE_SUPPLEMENT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId211));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId211, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MEETEI_MAYEK_EXTENSIONS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId212));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId212, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MEROITIC_HIEROGLYPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId213));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId213, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MEROITIC_CURSIVE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId214));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId214, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SORA_SOMPENG
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId215));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId215, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock CHAKMA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId216));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId216, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock SHARADA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId217));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId217, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock TAKRI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId218));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId218, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock MIAO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId219));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId219, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeBlock ARABIC_MATHEMATICAL_ALPHABETIC_SYMBOLS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId220));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId220, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
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
            private static readonly IntPtr _cachedFieldId24;
            private static readonly IntPtr _cachedFieldId25;
            private static readonly IntPtr _cachedFieldId26;
            private static readonly IntPtr _cachedFieldId27;
            private static readonly IntPtr _cachedFieldId28;
            private static readonly IntPtr _cachedFieldId29;
            private static readonly IntPtr _cachedFieldId30;
            private static readonly IntPtr _cachedFieldId31;
            private static readonly IntPtr _cachedFieldId32;
            private static readonly IntPtr _cachedFieldId33;
            private static readonly IntPtr _cachedFieldId34;
            private static readonly IntPtr _cachedFieldId35;
            private static readonly IntPtr _cachedFieldId36;
            private static readonly IntPtr _cachedFieldId37;
            private static readonly IntPtr _cachedFieldId38;
            private static readonly IntPtr _cachedFieldId39;
            private static readonly IntPtr _cachedFieldId40;
            private static readonly IntPtr _cachedFieldId41;
            private static readonly IntPtr _cachedFieldId42;
            private static readonly IntPtr _cachedFieldId43;
            private static readonly IntPtr _cachedFieldId44;
            private static readonly IntPtr _cachedFieldId45;
            private static readonly IntPtr _cachedFieldId46;
            private static readonly IntPtr _cachedFieldId47;
            private static readonly IntPtr _cachedFieldId48;
            private static readonly IntPtr _cachedFieldId49;
            private static readonly IntPtr _cachedFieldId50;
            private static readonly IntPtr _cachedFieldId51;
            private static readonly IntPtr _cachedFieldId52;
            private static readonly IntPtr _cachedFieldId53;
            private static readonly IntPtr _cachedFieldId54;
            private static readonly IntPtr _cachedFieldId55;
            private static readonly IntPtr _cachedFieldId56;
            private static readonly IntPtr _cachedFieldId57;
            private static readonly IntPtr _cachedFieldId58;
            private static readonly IntPtr _cachedFieldId59;
            private static readonly IntPtr _cachedFieldId60;
            private static readonly IntPtr _cachedFieldId61;
            private static readonly IntPtr _cachedFieldId62;
            private static readonly IntPtr _cachedFieldId63;
            private static readonly IntPtr _cachedFieldId64;
            private static readonly IntPtr _cachedFieldId65;
            private static readonly IntPtr _cachedFieldId66;
            private static readonly IntPtr _cachedFieldId67;
            private static readonly IntPtr _cachedFieldId68;
            private static readonly IntPtr _cachedFieldId69;
            private static readonly IntPtr _cachedFieldId70;
            private static readonly IntPtr _cachedFieldId71;
            private static readonly IntPtr _cachedFieldId72;
            private static readonly IntPtr _cachedFieldId73;
            private static readonly IntPtr _cachedFieldId74;
            private static readonly IntPtr _cachedFieldId75;
            private static readonly IntPtr _cachedFieldId76;
            private static readonly IntPtr _cachedFieldId77;
            private static readonly IntPtr _cachedFieldId78;
            private static readonly IntPtr _cachedFieldId79;
            private static readonly IntPtr _cachedFieldId80;
            private static readonly IntPtr _cachedFieldId81;
            private static readonly IntPtr _cachedFieldId82;
            private static readonly IntPtr _cachedFieldId83;
            private static readonly IntPtr _cachedFieldId84;
            private static readonly IntPtr _cachedFieldId85;
            private static readonly IntPtr _cachedFieldId86;
            private static readonly IntPtr _cachedFieldId87;
            private static readonly IntPtr _cachedFieldId88;
            private static readonly IntPtr _cachedFieldId89;
            private static readonly IntPtr _cachedFieldId90;
            private static readonly IntPtr _cachedFieldId91;
            private static readonly IntPtr _cachedFieldId92;
            private static readonly IntPtr _cachedFieldId93;
            private static readonly IntPtr _cachedFieldId94;
            private static readonly IntPtr _cachedFieldId95;
            private static readonly IntPtr _cachedFieldId96;
            private static readonly IntPtr _cachedFieldId97;
            private static readonly IntPtr _cachedFieldId98;
            private static readonly IntPtr _cachedFieldId99;
            private static readonly IntPtr _cachedFieldId100;
            private static readonly IntPtr _cachedFieldId101;
            private static readonly IntPtr _cachedFieldId102;
            private static readonly IntPtr _cachedFieldId103;
            private static readonly IntPtr _cachedFieldId104;
            private static readonly IntPtr _cachedFieldId105;
            private static readonly IntPtr _cachedFieldId106;
            private static readonly IntPtr _cachedFieldId107;
            private static readonly IntPtr _cachedFieldId108;
            private static readonly IntPtr _cachedFieldId109;
            private static readonly IntPtr _cachedFieldId110;
            private static readonly IntPtr _cachedFieldId111;
            private static readonly IntPtr _cachedFieldId112;
            private static readonly IntPtr _cachedFieldId113;
            private static readonly IntPtr _cachedFieldId114;
            private static readonly IntPtr _cachedFieldId115;
            private static readonly IntPtr _cachedFieldId116;
            private static readonly IntPtr _cachedFieldId117;
            private static readonly IntPtr _cachedFieldId118;
            private static readonly IntPtr _cachedFieldId119;
            private static readonly IntPtr _cachedFieldId120;
            private static readonly IntPtr _cachedFieldId121;
            private static readonly IntPtr _cachedFieldId122;
            private static readonly IntPtr _cachedFieldId123;
            private static readonly IntPtr _cachedFieldId124;
            private static readonly IntPtr _cachedFieldId125;
            private static readonly IntPtr _cachedFieldId126;
            private static readonly IntPtr _cachedFieldId127;
            private static readonly IntPtr _cachedFieldId128;
            private static readonly IntPtr _cachedFieldId129;
            private static readonly IntPtr _cachedFieldId130;
            private static readonly IntPtr _cachedFieldId131;
            private static readonly IntPtr _cachedFieldId132;
            private static readonly IntPtr _cachedFieldId133;
            private static readonly IntPtr _cachedFieldId134;
            private static readonly IntPtr _cachedFieldId135;
            private static readonly IntPtr _cachedFieldId136;
            private static readonly IntPtr _cachedFieldId137;
            private static readonly IntPtr _cachedFieldId138;
            private static readonly IntPtr _cachedFieldId139;
            private static readonly IntPtr _cachedFieldId140;
            private static readonly IntPtr _cachedFieldId141;
            private static readonly IntPtr _cachedFieldId142;
            private static readonly IntPtr _cachedFieldId143;
            private static readonly IntPtr _cachedFieldId144;
            private static readonly IntPtr _cachedFieldId145;
            private static readonly IntPtr _cachedFieldId146;
            private static readonly IntPtr _cachedFieldId147;
            private static readonly IntPtr _cachedFieldId148;
            private static readonly IntPtr _cachedFieldId149;
            private static readonly IntPtr _cachedFieldId150;
            private static readonly IntPtr _cachedFieldId151;
            private static readonly IntPtr _cachedFieldId152;
            private static readonly IntPtr _cachedFieldId153;
            private static readonly IntPtr _cachedFieldId154;
            private static readonly IntPtr _cachedFieldId155;
            private static readonly IntPtr _cachedFieldId156;
            private static readonly IntPtr _cachedFieldId157;
            private static readonly IntPtr _cachedFieldId158;
            private static readonly IntPtr _cachedFieldId159;
            private static readonly IntPtr _cachedFieldId160;
            private static readonly IntPtr _cachedFieldId161;
            private static readonly IntPtr _cachedFieldId162;
            private static readonly IntPtr _cachedFieldId163;
            private static readonly IntPtr _cachedFieldId164;
            private static readonly IntPtr _cachedFieldId165;
            private static readonly IntPtr _cachedFieldId166;
            private static readonly IntPtr _cachedFieldId167;
            private static readonly IntPtr _cachedFieldId168;
            private static readonly IntPtr _cachedFieldId169;
            private static readonly IntPtr _cachedFieldId170;
            private static readonly IntPtr _cachedFieldId171;
            private static readonly IntPtr _cachedFieldId172;
            private static readonly IntPtr _cachedFieldId173;
            private static readonly IntPtr _cachedFieldId174;
            private static readonly IntPtr _cachedFieldId175;
            private static readonly IntPtr _cachedFieldId176;
            private static readonly IntPtr _cachedFieldId177;
            private static readonly IntPtr _cachedFieldId178;
            private static readonly IntPtr _cachedFieldId179;
            private static readonly IntPtr _cachedFieldId180;
            private static readonly IntPtr _cachedFieldId181;
            private static readonly IntPtr _cachedFieldId182;
            private static readonly IntPtr _cachedFieldId183;
            private static readonly IntPtr _cachedFieldId184;
            private static readonly IntPtr _cachedFieldId185;
            private static readonly IntPtr _cachedFieldId186;
            private static readonly IntPtr _cachedFieldId187;
            private static readonly IntPtr _cachedFieldId188;
            private static readonly IntPtr _cachedFieldId189;
            private static readonly IntPtr _cachedFieldId190;
            private static readonly IntPtr _cachedFieldId191;
            private static readonly IntPtr _cachedFieldId192;
            private static readonly IntPtr _cachedFieldId193;
            private static readonly IntPtr _cachedFieldId194;
            private static readonly IntPtr _cachedFieldId195;
            private static readonly IntPtr _cachedFieldId196;
            private static readonly IntPtr _cachedFieldId197;
            private static readonly IntPtr _cachedFieldId198;
            private static readonly IntPtr _cachedFieldId199;
            private static readonly IntPtr _cachedFieldId200;
            private static readonly IntPtr _cachedFieldId201;
            private static readonly IntPtr _cachedFieldId202;
            private static readonly IntPtr _cachedFieldId203;
            private static readonly IntPtr _cachedFieldId204;
            private static readonly IntPtr _cachedFieldId205;
            private static readonly IntPtr _cachedFieldId206;
            private static readonly IntPtr _cachedFieldId207;
            private static readonly IntPtr _cachedFieldId208;
            private static readonly IntPtr _cachedFieldId209;
            private static readonly IntPtr _cachedFieldId210;
            private static readonly IntPtr _cachedFieldId211;
            private static readonly IntPtr _cachedFieldId212;
            private static readonly IntPtr _cachedFieldId213;
            private static readonly IntPtr _cachedFieldId214;
            private static readonly IntPtr _cachedFieldId215;
            private static readonly IntPtr _cachedFieldId216;
            private static readonly IntPtr _cachedFieldId217;
            private static readonly IntPtr _cachedFieldId218;
            private static readonly IntPtr _cachedFieldId219;
            private static readonly IntPtr _cachedFieldId220;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static UnicodeBlock()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/Character$UnicodeBlock");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId6 = AndroidJNI.GetStaticFieldID(_classObject, "COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId7 = AndroidJNI.GetStaticFieldID(_classObject, "GREEK", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId8 = AndroidJNI.GetStaticFieldID(_classObject, "CYRILLIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId9 = AndroidJNI.GetStaticFieldID(_classObject, "ARMENIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId10 = AndroidJNI.GetStaticFieldID(_classObject, "HEBREW", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId11 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId12 = AndroidJNI.GetStaticFieldID(_classObject, "DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId13 = AndroidJNI.GetStaticFieldID(_classObject, "BENGALI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId14 = AndroidJNI.GetStaticFieldID(_classObject, "GURMUKHI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId15 = AndroidJNI.GetStaticFieldID(_classObject, "GUJARATI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId16 = AndroidJNI.GetStaticFieldID(_classObject, "ORIYA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId17 = AndroidJNI.GetStaticFieldID(_classObject, "TAMIL", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId18 = AndroidJNI.GetStaticFieldID(_classObject, "TELUGU", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId19 = AndroidJNI.GetStaticFieldID(_classObject, "KANNADA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId20 = AndroidJNI.GetStaticFieldID(_classObject, "MALAYALAM", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId21 = AndroidJNI.GetStaticFieldID(_classObject, "THAI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId22 = AndroidJNI.GetStaticFieldID(_classObject, "LAO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId23 = AndroidJNI.GetStaticFieldID(_classObject, "TIBETAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId24 = AndroidJNI.GetStaticFieldID(_classObject, "GEORGIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId25 = AndroidJNI.GetStaticFieldID(_classObject, "HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId26 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId27 = AndroidJNI.GetStaticFieldID(_classObject, "GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId28 = AndroidJNI.GetStaticFieldID(_classObject, "GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId29 = AndroidJNI.GetStaticFieldID(_classObject, "SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId30 = AndroidJNI.GetStaticFieldID(_classObject, "CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId31 = AndroidJNI.GetStaticFieldID(_classObject, "COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId32 = AndroidJNI.GetStaticFieldID(_classObject, "LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId33 = AndroidJNI.GetStaticFieldID(_classObject, "NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId34 = AndroidJNI.GetStaticFieldID(_classObject, "ARROWS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId35 = AndroidJNI.GetStaticFieldID(_classObject, "MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId36 = AndroidJNI.GetStaticFieldID(_classObject, "MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId37 = AndroidJNI.GetStaticFieldID(_classObject, "CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId38 = AndroidJNI.GetStaticFieldID(_classObject, "OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId39 = AndroidJNI.GetStaticFieldID(_classObject, "ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId40 = AndroidJNI.GetStaticFieldID(_classObject, "BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId41 = AndroidJNI.GetStaticFieldID(_classObject, "BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId42 = AndroidJNI.GetStaticFieldID(_classObject, "GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId43 = AndroidJNI.GetStaticFieldID(_classObject, "MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId44 = AndroidJNI.GetStaticFieldID(_classObject, "DINGBATS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId45 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId46 = AndroidJNI.GetStaticFieldID(_classObject, "HIRAGANA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId47 = AndroidJNI.GetStaticFieldID(_classObject, "KATAKANA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId48 = AndroidJNI.GetStaticFieldID(_classObject, "BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId49 = AndroidJNI.GetStaticFieldID(_classObject, "HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId50 = AndroidJNI.GetStaticFieldID(_classObject, "KANBUN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId51 = AndroidJNI.GetStaticFieldID(_classObject, "ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId52 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId53 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId54 = AndroidJNI.GetStaticFieldID(_classObject, "HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId55 = AndroidJNI.GetStaticFieldID(_classObject, "PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId56 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId57 = AndroidJNI.GetStaticFieldID(_classObject, "ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId58 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId59 = AndroidJNI.GetStaticFieldID(_classObject, "COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId60 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId61 = AndroidJNI.GetStaticFieldID(_classObject, "SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId62 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId63 = AndroidJNI.GetStaticFieldID(_classObject, "HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId64 = AndroidJNI.GetStaticFieldID(_classObject, "SPECIALS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId65 = AndroidJNI.GetStaticFieldID(_classObject, "SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId66 = AndroidJNI.GetStaticFieldID(_classObject, "SYRIAC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId67 = AndroidJNI.GetStaticFieldID(_classObject, "THAANA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId68 = AndroidJNI.GetStaticFieldID(_classObject, "SINHALA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId69 = AndroidJNI.GetStaticFieldID(_classObject, "MYANMAR", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId70 = AndroidJNI.GetStaticFieldID(_classObject, "ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId71 = AndroidJNI.GetStaticFieldID(_classObject, "CHEROKEE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId72 = AndroidJNI.GetStaticFieldID(_classObject, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId73 = AndroidJNI.GetStaticFieldID(_classObject, "OGHAM", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId74 = AndroidJNI.GetStaticFieldID(_classObject, "RUNIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId75 = AndroidJNI.GetStaticFieldID(_classObject, "KHMER", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId76 = AndroidJNI.GetStaticFieldID(_classObject, "MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId77 = AndroidJNI.GetStaticFieldID(_classObject, "BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId78 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId79 = AndroidJNI.GetStaticFieldID(_classObject, "KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId80 = AndroidJNI.GetStaticFieldID(_classObject, "IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId81 = AndroidJNI.GetStaticFieldID(_classObject, "BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId82 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId83 = AndroidJNI.GetStaticFieldID(_classObject, "YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId84 = AndroidJNI.GetStaticFieldID(_classObject, "YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId85 = AndroidJNI.GetStaticFieldID(_classObject, "CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId86 = AndroidJNI.GetStaticFieldID(_classObject, "TAGALOG", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId87 = AndroidJNI.GetStaticFieldID(_classObject, "HANUNOO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId88 = AndroidJNI.GetStaticFieldID(_classObject, "BUHID", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId89 = AndroidJNI.GetStaticFieldID(_classObject, "TAGBANWA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId90 = AndroidJNI.GetStaticFieldID(_classObject, "LIMBU", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId91 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_LE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId92 = AndroidJNI.GetStaticFieldID(_classObject, "KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId93 = AndroidJNI.GetStaticFieldID(_classObject, "PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId94 = AndroidJNI.GetStaticFieldID(_classObject, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId95 = AndroidJNI.GetStaticFieldID(_classObject, "SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId96 = AndroidJNI.GetStaticFieldID(_classObject, "SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId97 = AndroidJNI.GetStaticFieldID(_classObject, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId98 = AndroidJNI.GetStaticFieldID(_classObject, "SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId99 = AndroidJNI.GetStaticFieldID(_classObject, "MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId100 = AndroidJNI.GetStaticFieldID(_classObject, "KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId101 = AndroidJNI.GetStaticFieldID(_classObject, "YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId102 = AndroidJNI.GetStaticFieldID(_classObject, "VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId103 = AndroidJNI.GetStaticFieldID(_classObject, "LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId104 = AndroidJNI.GetStaticFieldID(_classObject, "LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId105 = AndroidJNI.GetStaticFieldID(_classObject, "AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId106 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId107 = AndroidJNI.GetStaticFieldID(_classObject, "GOTHIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId108 = AndroidJNI.GetStaticFieldID(_classObject, "UGARITIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId109 = AndroidJNI.GetStaticFieldID(_classObject, "DESERET", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId110 = AndroidJNI.GetStaticFieldID(_classObject, "SHAVIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId111 = AndroidJNI.GetStaticFieldID(_classObject, "OSMANYA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId112 = AndroidJNI.GetStaticFieldID(_classObject, "CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId113 = AndroidJNI.GetStaticFieldID(_classObject, "BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId114 = AndroidJNI.GetStaticFieldID(_classObject, "MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId115 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId116 = AndroidJNI.GetStaticFieldID(_classObject, "MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId117 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId118 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId119 = AndroidJNI.GetStaticFieldID(_classObject, "TAGS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId120 = AndroidJNI.GetStaticFieldID(_classObject, "VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId121 = AndroidJNI.GetStaticFieldID(_classObject, "SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId122 = AndroidJNI.GetStaticFieldID(_classObject, "SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId123 = AndroidJNI.GetStaticFieldID(_classObject, "HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId124 = AndroidJNI.GetStaticFieldID(_classObject, "HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId125 = AndroidJNI.GetStaticFieldID(_classObject, "LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId126 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId127 = AndroidJNI.GetStaticFieldID(_classObject, "NKO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId128 = AndroidJNI.GetStaticFieldID(_classObject, "SAMARITAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId129 = AndroidJNI.GetStaticFieldID(_classObject, "MANDAIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId130 = AndroidJNI.GetStaticFieldID(_classObject, "ETHIOPIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId131 = AndroidJNI.GetStaticFieldID(_classObject, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId132 = AndroidJNI.GetStaticFieldID(_classObject, "NEW_TAI_LUE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId133 = AndroidJNI.GetStaticFieldID(_classObject, "BUGINESE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId134 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_THAM", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId135 = AndroidJNI.GetStaticFieldID(_classObject, "BALINESE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId136 = AndroidJNI.GetStaticFieldID(_classObject, "SUNDANESE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId137 = AndroidJNI.GetStaticFieldID(_classObject, "BATAK", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId138 = AndroidJNI.GetStaticFieldID(_classObject, "LEPCHA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId139 = AndroidJNI.GetStaticFieldID(_classObject, "OL_CHIKI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId140 = AndroidJNI.GetStaticFieldID(_classObject, "VEDIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId141 = AndroidJNI.GetStaticFieldID(_classObject, "PHONETIC_EXTENSIONS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId142 = AndroidJNI.GetStaticFieldID(_classObject, "COMBINING_DIACRITICAL_MARKS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId143 = AndroidJNI.GetStaticFieldID(_classObject, "GLAGOLITIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId144 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN_EXTENDED_C", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId145 = AndroidJNI.GetStaticFieldID(_classObject, "COPTIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId146 = AndroidJNI.GetStaticFieldID(_classObject, "GEORGIAN_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId147 = AndroidJNI.GetStaticFieldID(_classObject, "TIFINAGH", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId148 = AndroidJNI.GetStaticFieldID(_classObject, "ETHIOPIC_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId149 = AndroidJNI.GetStaticFieldID(_classObject, "CYRILLIC_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId150 = AndroidJNI.GetStaticFieldID(_classObject, "SUPPLEMENTAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId151 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_STROKES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId152 = AndroidJNI.GetStaticFieldID(_classObject, "LISU", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId153 = AndroidJNI.GetStaticFieldID(_classObject, "VAI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId154 = AndroidJNI.GetStaticFieldID(_classObject, "CYRILLIC_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId155 = AndroidJNI.GetStaticFieldID(_classObject, "BAMUM", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId156 = AndroidJNI.GetStaticFieldID(_classObject, "MODIFIER_TONE_LETTERS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId157 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN_EXTENDED_D", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId158 = AndroidJNI.GetStaticFieldID(_classObject, "SYLOTI_NAGRI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId159 = AndroidJNI.GetStaticFieldID(_classObject, "COMMON_INDIC_NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId160 = AndroidJNI.GetStaticFieldID(_classObject, "PHAGS_PA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId161 = AndroidJNI.GetStaticFieldID(_classObject, "SAURASHTRA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId162 = AndroidJNI.GetStaticFieldID(_classObject, "DEVANAGARI_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId163 = AndroidJNI.GetStaticFieldID(_classObject, "KAYAH_LI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId164 = AndroidJNI.GetStaticFieldID(_classObject, "REJANG", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId165 = AndroidJNI.GetStaticFieldID(_classObject, "HANGUL_JAMO_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId166 = AndroidJNI.GetStaticFieldID(_classObject, "JAVANESE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId167 = AndroidJNI.GetStaticFieldID(_classObject, "CHAM", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId168 = AndroidJNI.GetStaticFieldID(_classObject, "MYANMAR_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId169 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_VIET", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId170 = AndroidJNI.GetStaticFieldID(_classObject, "ETHIOPIC_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId171 = AndroidJNI.GetStaticFieldID(_classObject, "MEETEI_MAYEK", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId172 = AndroidJNI.GetStaticFieldID(_classObject, "HANGUL_JAMO_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId173 = AndroidJNI.GetStaticFieldID(_classObject, "VERTICAL_FORMS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId174 = AndroidJNI.GetStaticFieldID(_classObject, "ANCIENT_GREEK_NUMBERS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId175 = AndroidJNI.GetStaticFieldID(_classObject, "ANCIENT_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId176 = AndroidJNI.GetStaticFieldID(_classObject, "PHAISTOS_DISC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId177 = AndroidJNI.GetStaticFieldID(_classObject, "LYCIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId178 = AndroidJNI.GetStaticFieldID(_classObject, "CARIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId179 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_PERSIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId180 = AndroidJNI.GetStaticFieldID(_classObject, "IMPERIAL_ARAMAIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId181 = AndroidJNI.GetStaticFieldID(_classObject, "PHOENICIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId182 = AndroidJNI.GetStaticFieldID(_classObject, "LYDIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId183 = AndroidJNI.GetStaticFieldID(_classObject, "KHAROSHTHI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId184 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_SOUTH_ARABIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId185 = AndroidJNI.GetStaticFieldID(_classObject, "AVESTAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId186 = AndroidJNI.GetStaticFieldID(_classObject, "INSCRIPTIONAL_PARTHIAN", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId187 = AndroidJNI.GetStaticFieldID(_classObject, "INSCRIPTIONAL_PAHLAVI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId188 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_TURKIC", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId189 = AndroidJNI.GetStaticFieldID(_classObject, "RUMI_NUMERAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId190 = AndroidJNI.GetStaticFieldID(_classObject, "BRAHMI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId191 = AndroidJNI.GetStaticFieldID(_classObject, "KAITHI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId192 = AndroidJNI.GetStaticFieldID(_classObject, "CUNEIFORM", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId193 = AndroidJNI.GetStaticFieldID(_classObject, "CUNEIFORM_NUMBERS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId194 = AndroidJNI.GetStaticFieldID(_classObject, "EGYPTIAN_HIEROGLYPHS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId195 = AndroidJNI.GetStaticFieldID(_classObject, "BAMUM_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId196 = AndroidJNI.GetStaticFieldID(_classObject, "KANA_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId197 = AndroidJNI.GetStaticFieldID(_classObject, "ANCIENT_GREEK_MUSICAL_NOTATION", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId198 = AndroidJNI.GetStaticFieldID(_classObject, "COUNTING_ROD_NUMERALS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId199 = AndroidJNI.GetStaticFieldID(_classObject, "MAHJONG_TILES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId200 = AndroidJNI.GetStaticFieldID(_classObject, "DOMINO_TILES", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId201 = AndroidJNI.GetStaticFieldID(_classObject, "PLAYING_CARDS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId202 = AndroidJNI.GetStaticFieldID(_classObject, "ENCLOSED_ALPHANUMERIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId203 = AndroidJNI.GetStaticFieldID(_classObject, "ENCLOSED_IDEOGRAPHIC_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId204 = AndroidJNI.GetStaticFieldID(_classObject, "MISCELLANEOUS_SYMBOLS_AND_PICTOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId205 = AndroidJNI.GetStaticFieldID(_classObject, "EMOTICONS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId206 = AndroidJNI.GetStaticFieldID(_classObject, "TRANSPORT_AND_MAP_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId207 = AndroidJNI.GetStaticFieldID(_classObject, "ALCHEMICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId208 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_C", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId209 = AndroidJNI.GetStaticFieldID(_classObject, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_D", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId210 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId211 = AndroidJNI.GetStaticFieldID(_classObject, "SUNDANESE_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId212 = AndroidJNI.GetStaticFieldID(_classObject, "MEETEI_MAYEK_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId213 = AndroidJNI.GetStaticFieldID(_classObject, "MEROITIC_HIEROGLYPHS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId214 = AndroidJNI.GetStaticFieldID(_classObject, "MEROITIC_CURSIVE", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId215 = AndroidJNI.GetStaticFieldID(_classObject, "SORA_SOMPENG", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId216 = AndroidJNI.GetStaticFieldID(_classObject, "CHAKMA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId217 = AndroidJNI.GetStaticFieldID(_classObject, "SHARADA", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId218 = AndroidJNI.GetStaticFieldID(_classObject, "TAKRI", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId219 = AndroidJNI.GetStaticFieldID(_classObject, "MIAO", "Ljava/lang/Character$UnicodeBlock;");
                _cachedFieldId220 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC_MATHEMATICAL_ALPHABETIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(C)Ljava/lang/Character$UnicodeBlock;");
                _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(I)Ljava/lang/Character$UnicodeBlock;");
                _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;");
            }

            public UnicodeBlock() : base(IntPtr.Zero)
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

            public UnicodeBlock(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of UnicodeBlock.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Character.UnicodeBlock Of(char c)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { c = c } };
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Character.UnicodeBlock Of(int codePoint)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Character.UnicodeBlock ForName(global::System.String blockName)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(blockName) } };
                    return new global::Java.Lang.Character.UnicodeBlock(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(UnicodeBlock wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator UnicodeBlock(IntPtr rawObject)
            {
                return new UnicodeBlock(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class UnicodeBlock

        public class UnicodeScript : global::Java.Lang.Enum<global::Java.Lang.Character.UnicodeScript>
        {
            public static global::Java.Lang.Character.UnicodeScript COMMON
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LATIN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript GREEK
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CYRILLIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId3));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId3, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript ARMENIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId4));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId4, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript HEBREW
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId5));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId5, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript ARABIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId6));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId6, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SYRIAC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId7));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId7, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript THAANA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId8));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId8, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript DEVANAGARI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId9));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId9, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BENGALI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId10));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId10, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript GURMUKHI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId11));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId11, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript GUJARATI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId12));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId12, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript ORIYA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId13));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId13, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAMIL
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId14));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId14, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TELUGU
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId15));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId15, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript KANNADA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId16));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId16, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MALAYALAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId17));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId17, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SINHALA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId18));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId18, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript THAI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId19));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId19, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LAO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId20));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId20, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TIBETAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId21));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId21, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MYANMAR
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId22));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId22, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript GEORGIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId23));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId23, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript HANGUL
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId24));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId24, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript ETHIOPIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId25));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId25, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CHEROKEE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId26));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId26, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CANADIAN_ABORIGINAL
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId27));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId27, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OGHAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId28));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId28, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript RUNIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId29));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId29, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript KHMER
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId30));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId30, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MONGOLIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId31));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId31, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript HIRAGANA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId32));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId32, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript KATAKANA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId33));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId33, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BOPOMOFO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId34));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId34, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript HAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId35));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId35, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript YI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId36));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId36, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OLD_ITALIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId37));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId37, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript GOTHIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId38));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId38, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript DESERET
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId39));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId39, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript INHERITED
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId40));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId40, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAGALOG
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId41));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId41, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript HANUNOO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId42));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId42, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BUHID
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId43));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId43, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAGBANWA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId44));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId44, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LIMBU
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId45));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId45, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAI_LE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId46));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId46, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LINEAR_B
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId47));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId47, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript UGARITIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId48));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId48, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SHAVIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId49));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId49, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OSMANYA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId50));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId50, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CYPRIOT
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId51));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId51, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BRAILLE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId52));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId52, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BUGINESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId53));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId53, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript COPTIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId54));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId54, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript NEW_TAI_LUE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId55));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId55, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript GLAGOLITIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId56));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId56, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TIFINAGH
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId57));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId57, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SYLOTI_NAGRI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId58));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId58, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OLD_PERSIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId59));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId59, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript KHAROSHTHI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId60));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId60, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BALINESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId61));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId61, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CUNEIFORM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId62));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId62, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript PHOENICIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId63));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId63, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript PHAGS_PA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId64));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId64, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript NKO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId65));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId65, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SUNDANESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId66));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId66, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BATAK
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId67));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId67, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LEPCHA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId68));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId68, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OL_CHIKI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId69));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId69, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript VAI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId70));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId70, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SAURASHTRA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId71));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId71, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript KAYAH_LI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId72));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId72, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript REJANG
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId73));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId73, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LYCIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId74));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId74, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CARIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId75));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId75, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LYDIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId76));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId76, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CHAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId77));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId77, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAI_THAM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId78));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId78, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAI_VIET
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId79));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId79, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript AVESTAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId80));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId80, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript EGYPTIAN_HIEROGLYPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId81));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId81, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SAMARITAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId82));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId82, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MANDAIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId83));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId83, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript LISU
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId84));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId84, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BAMUM
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId85));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId85, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript JAVANESE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId86));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId86, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MEETEI_MAYEK
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId87));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId87, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript IMPERIAL_ARAMAIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId88));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId88, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OLD_SOUTH_ARABIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId89));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId89, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript INSCRIPTIONAL_PARTHIAN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId90));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId90, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript INSCRIPTIONAL_PAHLAVI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId91));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId91, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript OLD_TURKIC
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId92));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId92, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript BRAHMI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId93));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId93, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript KAITHI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId94));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId94, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MEROITIC_HIEROGLYPHS
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId95));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId95, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MEROITIC_CURSIVE
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId96));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId96, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SORA_SOMPENG
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId97));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId97, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript CHAKMA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId98));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId98, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript SHARADA
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId99));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId99, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript TAKRI
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId100));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId100, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript MIAO
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId101));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId101, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Character.UnicodeScript UNKNOWN
            {
                get
                {
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId102));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId102, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
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
            private static readonly IntPtr _cachedFieldId24;
            private static readonly IntPtr _cachedFieldId25;
            private static readonly IntPtr _cachedFieldId26;
            private static readonly IntPtr _cachedFieldId27;
            private static readonly IntPtr _cachedFieldId28;
            private static readonly IntPtr _cachedFieldId29;
            private static readonly IntPtr _cachedFieldId30;
            private static readonly IntPtr _cachedFieldId31;
            private static readonly IntPtr _cachedFieldId32;
            private static readonly IntPtr _cachedFieldId33;
            private static readonly IntPtr _cachedFieldId34;
            private static readonly IntPtr _cachedFieldId35;
            private static readonly IntPtr _cachedFieldId36;
            private static readonly IntPtr _cachedFieldId37;
            private static readonly IntPtr _cachedFieldId38;
            private static readonly IntPtr _cachedFieldId39;
            private static readonly IntPtr _cachedFieldId40;
            private static readonly IntPtr _cachedFieldId41;
            private static readonly IntPtr _cachedFieldId42;
            private static readonly IntPtr _cachedFieldId43;
            private static readonly IntPtr _cachedFieldId44;
            private static readonly IntPtr _cachedFieldId45;
            private static readonly IntPtr _cachedFieldId46;
            private static readonly IntPtr _cachedFieldId47;
            private static readonly IntPtr _cachedFieldId48;
            private static readonly IntPtr _cachedFieldId49;
            private static readonly IntPtr _cachedFieldId50;
            private static readonly IntPtr _cachedFieldId51;
            private static readonly IntPtr _cachedFieldId52;
            private static readonly IntPtr _cachedFieldId53;
            private static readonly IntPtr _cachedFieldId54;
            private static readonly IntPtr _cachedFieldId55;
            private static readonly IntPtr _cachedFieldId56;
            private static readonly IntPtr _cachedFieldId57;
            private static readonly IntPtr _cachedFieldId58;
            private static readonly IntPtr _cachedFieldId59;
            private static readonly IntPtr _cachedFieldId60;
            private static readonly IntPtr _cachedFieldId61;
            private static readonly IntPtr _cachedFieldId62;
            private static readonly IntPtr _cachedFieldId63;
            private static readonly IntPtr _cachedFieldId64;
            private static readonly IntPtr _cachedFieldId65;
            private static readonly IntPtr _cachedFieldId66;
            private static readonly IntPtr _cachedFieldId67;
            private static readonly IntPtr _cachedFieldId68;
            private static readonly IntPtr _cachedFieldId69;
            private static readonly IntPtr _cachedFieldId70;
            private static readonly IntPtr _cachedFieldId71;
            private static readonly IntPtr _cachedFieldId72;
            private static readonly IntPtr _cachedFieldId73;
            private static readonly IntPtr _cachedFieldId74;
            private static readonly IntPtr _cachedFieldId75;
            private static readonly IntPtr _cachedFieldId76;
            private static readonly IntPtr _cachedFieldId77;
            private static readonly IntPtr _cachedFieldId78;
            private static readonly IntPtr _cachedFieldId79;
            private static readonly IntPtr _cachedFieldId80;
            private static readonly IntPtr _cachedFieldId81;
            private static readonly IntPtr _cachedFieldId82;
            private static readonly IntPtr _cachedFieldId83;
            private static readonly IntPtr _cachedFieldId84;
            private static readonly IntPtr _cachedFieldId85;
            private static readonly IntPtr _cachedFieldId86;
            private static readonly IntPtr _cachedFieldId87;
            private static readonly IntPtr _cachedFieldId88;
            private static readonly IntPtr _cachedFieldId89;
            private static readonly IntPtr _cachedFieldId90;
            private static readonly IntPtr _cachedFieldId91;
            private static readonly IntPtr _cachedFieldId92;
            private static readonly IntPtr _cachedFieldId93;
            private static readonly IntPtr _cachedFieldId94;
            private static readonly IntPtr _cachedFieldId95;
            private static readonly IntPtr _cachedFieldId96;
            private static readonly IntPtr _cachedFieldId97;
            private static readonly IntPtr _cachedFieldId98;
            private static readonly IntPtr _cachedFieldId99;
            private static readonly IntPtr _cachedFieldId100;
            private static readonly IntPtr _cachedFieldId101;
            private static readonly IntPtr _cachedFieldId102;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static UnicodeScript()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/Character$UnicodeScript");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "COMMON", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "LATIN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "GREEK", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "CYRILLIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "ARMENIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "HEBREW", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId6 = AndroidJNI.GetStaticFieldID(_classObject, "ARABIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId7 = AndroidJNI.GetStaticFieldID(_classObject, "SYRIAC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId8 = AndroidJNI.GetStaticFieldID(_classObject, "THAANA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId9 = AndroidJNI.GetStaticFieldID(_classObject, "DEVANAGARI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId10 = AndroidJNI.GetStaticFieldID(_classObject, "BENGALI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId11 = AndroidJNI.GetStaticFieldID(_classObject, "GURMUKHI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId12 = AndroidJNI.GetStaticFieldID(_classObject, "GUJARATI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId13 = AndroidJNI.GetStaticFieldID(_classObject, "ORIYA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId14 = AndroidJNI.GetStaticFieldID(_classObject, "TAMIL", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId15 = AndroidJNI.GetStaticFieldID(_classObject, "TELUGU", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId16 = AndroidJNI.GetStaticFieldID(_classObject, "KANNADA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId17 = AndroidJNI.GetStaticFieldID(_classObject, "MALAYALAM", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId18 = AndroidJNI.GetStaticFieldID(_classObject, "SINHALA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId19 = AndroidJNI.GetStaticFieldID(_classObject, "THAI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId20 = AndroidJNI.GetStaticFieldID(_classObject, "LAO", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId21 = AndroidJNI.GetStaticFieldID(_classObject, "TIBETAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId22 = AndroidJNI.GetStaticFieldID(_classObject, "MYANMAR", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId23 = AndroidJNI.GetStaticFieldID(_classObject, "GEORGIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId24 = AndroidJNI.GetStaticFieldID(_classObject, "HANGUL", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId25 = AndroidJNI.GetStaticFieldID(_classObject, "ETHIOPIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId26 = AndroidJNI.GetStaticFieldID(_classObject, "CHEROKEE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId27 = AndroidJNI.GetStaticFieldID(_classObject, "CANADIAN_ABORIGINAL", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId28 = AndroidJNI.GetStaticFieldID(_classObject, "OGHAM", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId29 = AndroidJNI.GetStaticFieldID(_classObject, "RUNIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId30 = AndroidJNI.GetStaticFieldID(_classObject, "KHMER", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId31 = AndroidJNI.GetStaticFieldID(_classObject, "MONGOLIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId32 = AndroidJNI.GetStaticFieldID(_classObject, "HIRAGANA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId33 = AndroidJNI.GetStaticFieldID(_classObject, "KATAKANA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId34 = AndroidJNI.GetStaticFieldID(_classObject, "BOPOMOFO", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId35 = AndroidJNI.GetStaticFieldID(_classObject, "HAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId36 = AndroidJNI.GetStaticFieldID(_classObject, "YI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId37 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_ITALIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId38 = AndroidJNI.GetStaticFieldID(_classObject, "GOTHIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId39 = AndroidJNI.GetStaticFieldID(_classObject, "DESERET", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId40 = AndroidJNI.GetStaticFieldID(_classObject, "INHERITED", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId41 = AndroidJNI.GetStaticFieldID(_classObject, "TAGALOG", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId42 = AndroidJNI.GetStaticFieldID(_classObject, "HANUNOO", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId43 = AndroidJNI.GetStaticFieldID(_classObject, "BUHID", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId44 = AndroidJNI.GetStaticFieldID(_classObject, "TAGBANWA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId45 = AndroidJNI.GetStaticFieldID(_classObject, "LIMBU", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId46 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_LE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId47 = AndroidJNI.GetStaticFieldID(_classObject, "LINEAR_B", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId48 = AndroidJNI.GetStaticFieldID(_classObject, "UGARITIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId49 = AndroidJNI.GetStaticFieldID(_classObject, "SHAVIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId50 = AndroidJNI.GetStaticFieldID(_classObject, "OSMANYA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId51 = AndroidJNI.GetStaticFieldID(_classObject, "CYPRIOT", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId52 = AndroidJNI.GetStaticFieldID(_classObject, "BRAILLE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId53 = AndroidJNI.GetStaticFieldID(_classObject, "BUGINESE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId54 = AndroidJNI.GetStaticFieldID(_classObject, "COPTIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId55 = AndroidJNI.GetStaticFieldID(_classObject, "NEW_TAI_LUE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId56 = AndroidJNI.GetStaticFieldID(_classObject, "GLAGOLITIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId57 = AndroidJNI.GetStaticFieldID(_classObject, "TIFINAGH", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId58 = AndroidJNI.GetStaticFieldID(_classObject, "SYLOTI_NAGRI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId59 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_PERSIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId60 = AndroidJNI.GetStaticFieldID(_classObject, "KHAROSHTHI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId61 = AndroidJNI.GetStaticFieldID(_classObject, "BALINESE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId62 = AndroidJNI.GetStaticFieldID(_classObject, "CUNEIFORM", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId63 = AndroidJNI.GetStaticFieldID(_classObject, "PHOENICIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId64 = AndroidJNI.GetStaticFieldID(_classObject, "PHAGS_PA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId65 = AndroidJNI.GetStaticFieldID(_classObject, "NKO", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId66 = AndroidJNI.GetStaticFieldID(_classObject, "SUNDANESE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId67 = AndroidJNI.GetStaticFieldID(_classObject, "BATAK", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId68 = AndroidJNI.GetStaticFieldID(_classObject, "LEPCHA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId69 = AndroidJNI.GetStaticFieldID(_classObject, "OL_CHIKI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId70 = AndroidJNI.GetStaticFieldID(_classObject, "VAI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId71 = AndroidJNI.GetStaticFieldID(_classObject, "SAURASHTRA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId72 = AndroidJNI.GetStaticFieldID(_classObject, "KAYAH_LI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId73 = AndroidJNI.GetStaticFieldID(_classObject, "REJANG", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId74 = AndroidJNI.GetStaticFieldID(_classObject, "LYCIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId75 = AndroidJNI.GetStaticFieldID(_classObject, "CARIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId76 = AndroidJNI.GetStaticFieldID(_classObject, "LYDIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId77 = AndroidJNI.GetStaticFieldID(_classObject, "CHAM", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId78 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_THAM", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId79 = AndroidJNI.GetStaticFieldID(_classObject, "TAI_VIET", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId80 = AndroidJNI.GetStaticFieldID(_classObject, "AVESTAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId81 = AndroidJNI.GetStaticFieldID(_classObject, "EGYPTIAN_HIEROGLYPHS", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId82 = AndroidJNI.GetStaticFieldID(_classObject, "SAMARITAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId83 = AndroidJNI.GetStaticFieldID(_classObject, "MANDAIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId84 = AndroidJNI.GetStaticFieldID(_classObject, "LISU", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId85 = AndroidJNI.GetStaticFieldID(_classObject, "BAMUM", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId86 = AndroidJNI.GetStaticFieldID(_classObject, "JAVANESE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId87 = AndroidJNI.GetStaticFieldID(_classObject, "MEETEI_MAYEK", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId88 = AndroidJNI.GetStaticFieldID(_classObject, "IMPERIAL_ARAMAIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId89 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_SOUTH_ARABIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId90 = AndroidJNI.GetStaticFieldID(_classObject, "INSCRIPTIONAL_PARTHIAN", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId91 = AndroidJNI.GetStaticFieldID(_classObject, "INSCRIPTIONAL_PAHLAVI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId92 = AndroidJNI.GetStaticFieldID(_classObject, "OLD_TURKIC", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId93 = AndroidJNI.GetStaticFieldID(_classObject, "BRAHMI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId94 = AndroidJNI.GetStaticFieldID(_classObject, "KAITHI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId95 = AndroidJNI.GetStaticFieldID(_classObject, "MEROITIC_HIEROGLYPHS", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId96 = AndroidJNI.GetStaticFieldID(_classObject, "MEROITIC_CURSIVE", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId97 = AndroidJNI.GetStaticFieldID(_classObject, "SORA_SOMPENG", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId98 = AndroidJNI.GetStaticFieldID(_classObject, "CHAKMA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId99 = AndroidJNI.GetStaticFieldID(_classObject, "SHARADA", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId100 = AndroidJNI.GetStaticFieldID(_classObject, "TAKRI", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId101 = AndroidJNI.GetStaticFieldID(_classObject, "MIAO", "Ljava/lang/Character$UnicodeScript;");
                _cachedFieldId102 = AndroidJNI.GetStaticFieldID(_classObject, "UNKNOWN", "Ljava/lang/Character$UnicodeScript;");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeScript;");
                _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(I)Ljava/lang/Character$UnicodeScript;");
                _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeScript;");
            }

            public UnicodeScript(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of UnicodeScript.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Character.UnicodeScript ValueOf(global::System.String name)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Character.UnicodeScript Of(int codePoint)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Character.UnicodeScript ForName(global::System.String scriptName)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(scriptName) } };
                    return new global::Java.Lang.Character.UnicodeScript(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(UnicodeScript wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator UnicodeScript(IntPtr rawObject)
            {
                return new UnicodeScript(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class UnicodeScript

        public static int MIN_RADIX
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId0);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId0, value);
            }
        }
        public static int MAX_RADIX
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId1);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId1, value);
            }
        }
        public static char MIN_VALUE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId2);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId2, value);
            }
        }
        public static char MAX_VALUE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId3);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId3, value);
            }
        }
        public static global::Java.Lang.Class<global::Java.Lang.Character> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Character>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId4));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId4, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static sbyte UNASSIGNED
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId5);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId5, value);
            }
        }
        public static sbyte UPPERCASE_LETTER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId6);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId6, value);
            }
        }
        public static sbyte LOWERCASE_LETTER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId7);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId7, value);
            }
        }
        public static sbyte TITLECASE_LETTER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId8);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId8, value);
            }
        }
        public static sbyte MODIFIER_LETTER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId9);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId9, value);
            }
        }
        public static sbyte OTHER_LETTER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId10);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId10, value);
            }
        }
        public static sbyte NON_SPACING_MARK
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId11);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId11, value);
            }
        }
        public static sbyte ENCLOSING_MARK
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId12);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId12, value);
            }
        }
        public static sbyte COMBINING_SPACING_MARK
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId13);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId13, value);
            }
        }
        public static sbyte DECIMAL_DIGIT_NUMBER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId14);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId14, value);
            }
        }
        public static sbyte LETTER_NUMBER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId15);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId15, value);
            }
        }
        public static sbyte OTHER_NUMBER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId16);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId16, value);
            }
        }
        public static sbyte SPACE_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId17);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId17, value);
            }
        }
        public static sbyte LINE_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId18);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId18, value);
            }
        }
        public static sbyte PARAGRAPH_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId19);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId19, value);
            }
        }
        public static sbyte CONTROL
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId20);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId20, value);
            }
        }
        public static sbyte FORMAT
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId21);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId21, value);
            }
        }
        public static sbyte PRIVATE_USE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId22);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId22, value);
            }
        }
        public static sbyte SURROGATE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId23);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId23, value);
            }
        }
        public static sbyte DASH_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId24);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId24, value);
            }
        }
        public static sbyte START_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId25);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId25, value);
            }
        }
        public static sbyte END_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId26);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId26, value);
            }
        }
        public static sbyte CONNECTOR_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId27);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId27, value);
            }
        }
        public static sbyte OTHER_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId28);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId28, value);
            }
        }
        public static sbyte MATH_SYMBOL
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId29);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId29, value);
            }
        }
        public static sbyte CURRENCY_SYMBOL
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId30);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId30, value);
            }
        }
        public static sbyte MODIFIER_SYMBOL
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId31);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId31, value);
            }
        }
        public static sbyte OTHER_SYMBOL
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId32);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId32, value);
            }
        }
        public static sbyte INITIAL_QUOTE_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId33);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId33, value);
            }
        }
        public static sbyte FINAL_QUOTE_PUNCTUATION
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId34);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId34, value);
            }
        }
        public static sbyte DIRECTIONALITY_UNDEFINED
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId35);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId35, value);
            }
        }
        public static sbyte DIRECTIONALITY_LEFT_TO_RIGHT
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId36);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId36, value);
            }
        }
        public static sbyte DIRECTIONALITY_RIGHT_TO_LEFT
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId37);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId37, value);
            }
        }
        public static sbyte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId38);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId38, value);
            }
        }
        public static sbyte DIRECTIONALITY_EUROPEAN_NUMBER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId39);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId39, value);
            }
        }
        public static sbyte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId40);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId40, value);
            }
        }
        public static sbyte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId41);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId41, value);
            }
        }
        public static sbyte DIRECTIONALITY_ARABIC_NUMBER
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId42);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId42, value);
            }
        }
        public static sbyte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId43);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId43, value);
            }
        }
        public static sbyte DIRECTIONALITY_NONSPACING_MARK
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId44);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId44, value);
            }
        }
        public static sbyte DIRECTIONALITY_BOUNDARY_NEUTRAL
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId45);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId45, value);
            }
        }
        public static sbyte DIRECTIONALITY_PARAGRAPH_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId46);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId46, value);
            }
        }
        public static sbyte DIRECTIONALITY_SEGMENT_SEPARATOR
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId47);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId47, value);
            }
        }
        public static sbyte DIRECTIONALITY_WHITESPACE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId48);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId48, value);
            }
        }
        public static sbyte DIRECTIONALITY_OTHER_NEUTRALS
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId49);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId49, value);
            }
        }
        public static sbyte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId50);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId50, value);
            }
        }
        public static sbyte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId51);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId51, value);
            }
        }
        public static sbyte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId52);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId52, value);
            }
        }
        public static sbyte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId53);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId53, value);
            }
        }
        public static sbyte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId54);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId54, value);
            }
        }
        public static char MIN_HIGH_SURROGATE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId55);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId55, value);
            }
        }
        public static char MAX_HIGH_SURROGATE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId56);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId56, value);
            }
        }
        public static char MIN_LOW_SURROGATE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId57);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId57, value);
            }
        }
        public static char MAX_LOW_SURROGATE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId58);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId58, value);
            }
        }
        public static char MIN_SURROGATE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId59);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId59, value);
            }
        }
        public static char MAX_SURROGATE
        {
            get
            {
                return AndroidJNI.GetStaticCharField(_classObject, _cachedFieldId60);
            }
            set
            {
                AndroidJNI.SetStaticCharField(_classObject, _cachedFieldId60, value);
            }
        }
        public static int MIN_SUPPLEMENTARY_CODE_POINT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId61);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId61, value);
            }
        }
        public static int MIN_CODE_POINT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId62);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId62, value);
            }
        }
        public static int MAX_CODE_POINT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId63);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId63, value);
            }
        }
        public static int SIZE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId64);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId64, value);
            }
        }
        public static int BYTES
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId65);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId65, value);
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
        private static readonly IntPtr _cachedFieldId24;
        private static readonly IntPtr _cachedFieldId25;
        private static readonly IntPtr _cachedFieldId26;
        private static readonly IntPtr _cachedFieldId27;
        private static readonly IntPtr _cachedFieldId28;
        private static readonly IntPtr _cachedFieldId29;
        private static readonly IntPtr _cachedFieldId30;
        private static readonly IntPtr _cachedFieldId31;
        private static readonly IntPtr _cachedFieldId32;
        private static readonly IntPtr _cachedFieldId33;
        private static readonly IntPtr _cachedFieldId34;
        private static readonly IntPtr _cachedFieldId35;
        private static readonly IntPtr _cachedFieldId36;
        private static readonly IntPtr _cachedFieldId37;
        private static readonly IntPtr _cachedFieldId38;
        private static readonly IntPtr _cachedFieldId39;
        private static readonly IntPtr _cachedFieldId40;
        private static readonly IntPtr _cachedFieldId41;
        private static readonly IntPtr _cachedFieldId42;
        private static readonly IntPtr _cachedFieldId43;
        private static readonly IntPtr _cachedFieldId44;
        private static readonly IntPtr _cachedFieldId45;
        private static readonly IntPtr _cachedFieldId46;
        private static readonly IntPtr _cachedFieldId47;
        private static readonly IntPtr _cachedFieldId48;
        private static readonly IntPtr _cachedFieldId49;
        private static readonly IntPtr _cachedFieldId50;
        private static readonly IntPtr _cachedFieldId51;
        private static readonly IntPtr _cachedFieldId52;
        private static readonly IntPtr _cachedFieldId53;
        private static readonly IntPtr _cachedFieldId54;
        private static readonly IntPtr _cachedFieldId55;
        private static readonly IntPtr _cachedFieldId56;
        private static readonly IntPtr _cachedFieldId57;
        private static readonly IntPtr _cachedFieldId58;
        private static readonly IntPtr _cachedFieldId59;
        private static readonly IntPtr _cachedFieldId60;
        private static readonly IntPtr _cachedFieldId61;
        private static readonly IntPtr _cachedFieldId62;
        private static readonly IntPtr _cachedFieldId63;
        private static readonly IntPtr _cachedFieldId64;
        private static readonly IntPtr _cachedFieldId65;
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
        private static readonly IntPtr _cachedMethodId51;
        private static readonly IntPtr _cachedMethodId52;
        private static readonly IntPtr _cachedMethodId53;
        private static readonly IntPtr _cachedMethodId54;
        private static readonly IntPtr _cachedMethodId55;
        private static readonly IntPtr _cachedMethodId56;
        private static readonly IntPtr _cachedMethodId57;
        private static readonly IntPtr _cachedMethodId58;
        private static readonly IntPtr _cachedMethodId59;
        private static readonly IntPtr _cachedMethodId60;
        private static readonly IntPtr _cachedMethodId61;
        private static readonly IntPtr _cachedMethodId62;
        private static readonly IntPtr _cachedMethodId63;
        private static readonly IntPtr _cachedMethodId64;
        private static readonly IntPtr _cachedMethodId65;
        private static readonly IntPtr _cachedMethodId66;
        private static readonly IntPtr _cachedMethodId67;
        private static readonly IntPtr _cachedMethodId68;
        private static readonly IntPtr _cachedMethodId69;
        private static readonly IntPtr _cachedMethodId70;
        private static readonly IntPtr _cachedMethodId71;
        private static readonly IntPtr _cachedMethodId72;
        private static readonly IntPtr _cachedMethodId73;
        private static readonly IntPtr _cachedMethodId74;
        private static readonly IntPtr _cachedMethodId75;
        private static readonly IntPtr _cachedMethodId76;

        static Character()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Character");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_RADIX", "I");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_RADIX", "I");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_VALUE", "C");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_VALUE", "C");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "UNASSIGNED", "B");
            _cachedFieldId6 = AndroidJNI.GetStaticFieldID(_classObject, "UPPERCASE_LETTER", "B");
            _cachedFieldId7 = AndroidJNI.GetStaticFieldID(_classObject, "LOWERCASE_LETTER", "B");
            _cachedFieldId8 = AndroidJNI.GetStaticFieldID(_classObject, "TITLECASE_LETTER", "B");
            _cachedFieldId9 = AndroidJNI.GetStaticFieldID(_classObject, "MODIFIER_LETTER", "B");
            _cachedFieldId10 = AndroidJNI.GetStaticFieldID(_classObject, "OTHER_LETTER", "B");
            _cachedFieldId11 = AndroidJNI.GetStaticFieldID(_classObject, "NON_SPACING_MARK", "B");
            _cachedFieldId12 = AndroidJNI.GetStaticFieldID(_classObject, "ENCLOSING_MARK", "B");
            _cachedFieldId13 = AndroidJNI.GetStaticFieldID(_classObject, "COMBINING_SPACING_MARK", "B");
            _cachedFieldId14 = AndroidJNI.GetStaticFieldID(_classObject, "DECIMAL_DIGIT_NUMBER", "B");
            _cachedFieldId15 = AndroidJNI.GetStaticFieldID(_classObject, "LETTER_NUMBER", "B");
            _cachedFieldId16 = AndroidJNI.GetStaticFieldID(_classObject, "OTHER_NUMBER", "B");
            _cachedFieldId17 = AndroidJNI.GetStaticFieldID(_classObject, "SPACE_SEPARATOR", "B");
            _cachedFieldId18 = AndroidJNI.GetStaticFieldID(_classObject, "LINE_SEPARATOR", "B");
            _cachedFieldId19 = AndroidJNI.GetStaticFieldID(_classObject, "PARAGRAPH_SEPARATOR", "B");
            _cachedFieldId20 = AndroidJNI.GetStaticFieldID(_classObject, "CONTROL", "B");
            _cachedFieldId21 = AndroidJNI.GetStaticFieldID(_classObject, "FORMAT", "B");
            _cachedFieldId22 = AndroidJNI.GetStaticFieldID(_classObject, "PRIVATE_USE", "B");
            _cachedFieldId23 = AndroidJNI.GetStaticFieldID(_classObject, "SURROGATE", "B");
            _cachedFieldId24 = AndroidJNI.GetStaticFieldID(_classObject, "DASH_PUNCTUATION", "B");
            _cachedFieldId25 = AndroidJNI.GetStaticFieldID(_classObject, "START_PUNCTUATION", "B");
            _cachedFieldId26 = AndroidJNI.GetStaticFieldID(_classObject, "END_PUNCTUATION", "B");
            _cachedFieldId27 = AndroidJNI.GetStaticFieldID(_classObject, "CONNECTOR_PUNCTUATION", "B");
            _cachedFieldId28 = AndroidJNI.GetStaticFieldID(_classObject, "OTHER_PUNCTUATION", "B");
            _cachedFieldId29 = AndroidJNI.GetStaticFieldID(_classObject, "MATH_SYMBOL", "B");
            _cachedFieldId30 = AndroidJNI.GetStaticFieldID(_classObject, "CURRENCY_SYMBOL", "B");
            _cachedFieldId31 = AndroidJNI.GetStaticFieldID(_classObject, "MODIFIER_SYMBOL", "B");
            _cachedFieldId32 = AndroidJNI.GetStaticFieldID(_classObject, "OTHER_SYMBOL", "B");
            _cachedFieldId33 = AndroidJNI.GetStaticFieldID(_classObject, "INITIAL_QUOTE_PUNCTUATION", "B");
            _cachedFieldId34 = AndroidJNI.GetStaticFieldID(_classObject, "FINAL_QUOTE_PUNCTUATION", "B");
            _cachedFieldId35 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_UNDEFINED", "B");
            _cachedFieldId36 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_LEFT_TO_RIGHT", "B");
            _cachedFieldId37 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_RIGHT_TO_LEFT", "B");
            _cachedFieldId38 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B");
            _cachedFieldId39 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_EUROPEAN_NUMBER", "B");
            _cachedFieldId40 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B");
            _cachedFieldId41 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B");
            _cachedFieldId42 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_ARABIC_NUMBER", "B");
            _cachedFieldId43 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B");
            _cachedFieldId44 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_NONSPACING_MARK", "B");
            _cachedFieldId45 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_BOUNDARY_NEUTRAL", "B");
            _cachedFieldId46 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B");
            _cachedFieldId47 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_SEGMENT_SEPARATOR", "B");
            _cachedFieldId48 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_WHITESPACE", "B");
            _cachedFieldId49 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_OTHER_NEUTRALS", "B");
            _cachedFieldId50 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B");
            _cachedFieldId51 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B");
            _cachedFieldId52 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B");
            _cachedFieldId53 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B");
            _cachedFieldId54 = AndroidJNI.GetStaticFieldID(_classObject, "DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B");
            _cachedFieldId55 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_HIGH_SURROGATE", "C");
            _cachedFieldId56 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_HIGH_SURROGATE", "C");
            _cachedFieldId57 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_LOW_SURROGATE", "C");
            _cachedFieldId58 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_LOW_SURROGATE", "C");
            _cachedFieldId59 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_SURROGATE", "C");
            _cachedFieldId60 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_SURROGATE", "C");
            _cachedFieldId61 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_SUPPLEMENTARY_CODE_POINT", "I");
            _cachedFieldId62 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_CODE_POINT", "I");
            _cachedFieldId63 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_CODE_POINT", "I");
            _cachedFieldId64 = AndroidJNI.GetStaticFieldID(_classObject, "SIZE", "I");
            _cachedFieldId65 = AndroidJNI.GetStaticFieldID(_classObject, "BYTES", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(C)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(C)Ljava/lang/Character;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "charValue", "()C");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(C)I");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(C)Ljava/lang/String;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "isValidCodePoint", "(I)Z");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "isBmpCodePoint", "(I)Z");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "isSupplementaryCodePoint", "(I)Z");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "isHighSurrogate", "(C)Z");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "isLowSurrogate", "(C)Z");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "isSurrogate", "(C)Z");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "isSurrogatePair", "(CC)Z");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "charCount", "(I)I");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "toCodePoint", "(CC)I");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "codePointAt", "(Ljava/lang/CharSequence;I)I");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "codePointBefore", "(Ljava/lang/CharSequence;I)I");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "highSurrogate", "(I)C");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "lowSurrogate", "(I)C");
            _cachedMethodId19 = AndroidJNI.GetStaticMethodID(_classObject, "codePointCount", "(Ljava/lang/CharSequence;II)I");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I");
            _cachedMethodId21 = AndroidJNI.GetStaticMethodID(_classObject, "isLowerCase", "(C)Z");
            _cachedMethodId22 = AndroidJNI.GetStaticMethodID(_classObject, "isLowerCase", "(I)Z");
            _cachedMethodId23 = AndroidJNI.GetStaticMethodID(_classObject, "isUpperCase", "(C)Z");
            _cachedMethodId24 = AndroidJNI.GetStaticMethodID(_classObject, "isUpperCase", "(I)Z");
            _cachedMethodId25 = AndroidJNI.GetStaticMethodID(_classObject, "isTitleCase", "(C)Z");
            _cachedMethodId26 = AndroidJNI.GetStaticMethodID(_classObject, "isTitleCase", "(I)Z");
            _cachedMethodId27 = AndroidJNI.GetStaticMethodID(_classObject, "isDigit", "(C)Z");
            _cachedMethodId28 = AndroidJNI.GetStaticMethodID(_classObject, "isDigit", "(I)Z");
            _cachedMethodId29 = AndroidJNI.GetStaticMethodID(_classObject, "isDefined", "(C)Z");
            _cachedMethodId30 = AndroidJNI.GetStaticMethodID(_classObject, "isDefined", "(I)Z");
            _cachedMethodId31 = AndroidJNI.GetStaticMethodID(_classObject, "isLetter", "(C)Z");
            _cachedMethodId32 = AndroidJNI.GetStaticMethodID(_classObject, "isLetter", "(I)Z");
            _cachedMethodId33 = AndroidJNI.GetStaticMethodID(_classObject, "isLetterOrDigit", "(C)Z");
            _cachedMethodId34 = AndroidJNI.GetStaticMethodID(_classObject, "isLetterOrDigit", "(I)Z");
            _cachedMethodId35 = AndroidJNI.GetStaticMethodID(_classObject, "isJavaLetter", "(C)Z");
            _cachedMethodId36 = AndroidJNI.GetStaticMethodID(_classObject, "isJavaLetterOrDigit", "(C)Z");
            _cachedMethodId37 = AndroidJNI.GetStaticMethodID(_classObject, "isAlphabetic", "(I)Z");
            _cachedMethodId38 = AndroidJNI.GetStaticMethodID(_classObject, "isIdeographic", "(I)Z");
            _cachedMethodId39 = AndroidJNI.GetStaticMethodID(_classObject, "isJavaIdentifierStart", "(C)Z");
            _cachedMethodId40 = AndroidJNI.GetStaticMethodID(_classObject, "isJavaIdentifierStart", "(I)Z");
            _cachedMethodId41 = AndroidJNI.GetStaticMethodID(_classObject, "isJavaIdentifierPart", "(C)Z");
            _cachedMethodId42 = AndroidJNI.GetStaticMethodID(_classObject, "isJavaIdentifierPart", "(I)Z");
            _cachedMethodId43 = AndroidJNI.GetStaticMethodID(_classObject, "isUnicodeIdentifierStart", "(C)Z");
            _cachedMethodId44 = AndroidJNI.GetStaticMethodID(_classObject, "isUnicodeIdentifierStart", "(I)Z");
            _cachedMethodId45 = AndroidJNI.GetStaticMethodID(_classObject, "isUnicodeIdentifierPart", "(C)Z");
            _cachedMethodId46 = AndroidJNI.GetStaticMethodID(_classObject, "isUnicodeIdentifierPart", "(I)Z");
            _cachedMethodId47 = AndroidJNI.GetStaticMethodID(_classObject, "isIdentifierIgnorable", "(C)Z");
            _cachedMethodId48 = AndroidJNI.GetStaticMethodID(_classObject, "isIdentifierIgnorable", "(I)Z");
            _cachedMethodId49 = AndroidJNI.GetStaticMethodID(_classObject, "toLowerCase", "(C)C");
            _cachedMethodId50 = AndroidJNI.GetStaticMethodID(_classObject, "toLowerCase", "(I)I");
            _cachedMethodId51 = AndroidJNI.GetStaticMethodID(_classObject, "toUpperCase", "(C)C");
            _cachedMethodId52 = AndroidJNI.GetStaticMethodID(_classObject, "toUpperCase", "(I)I");
            _cachedMethodId53 = AndroidJNI.GetStaticMethodID(_classObject, "toTitleCase", "(C)C");
            _cachedMethodId54 = AndroidJNI.GetStaticMethodID(_classObject, "toTitleCase", "(I)I");
            _cachedMethodId55 = AndroidJNI.GetStaticMethodID(_classObject, "digit", "(CI)I");
            _cachedMethodId56 = AndroidJNI.GetStaticMethodID(_classObject, "digit", "(II)I");
            _cachedMethodId57 = AndroidJNI.GetStaticMethodID(_classObject, "getNumericValue", "(C)I");
            _cachedMethodId58 = AndroidJNI.GetStaticMethodID(_classObject, "getNumericValue", "(I)I");
            _cachedMethodId59 = AndroidJNI.GetStaticMethodID(_classObject, "isSpace", "(C)Z");
            _cachedMethodId60 = AndroidJNI.GetStaticMethodID(_classObject, "isSpaceChar", "(C)Z");
            _cachedMethodId61 = AndroidJNI.GetStaticMethodID(_classObject, "isSpaceChar", "(I)Z");
            _cachedMethodId62 = AndroidJNI.GetStaticMethodID(_classObject, "isWhitespace", "(C)Z");
            _cachedMethodId63 = AndroidJNI.GetStaticMethodID(_classObject, "isWhitespace", "(I)Z");
            _cachedMethodId64 = AndroidJNI.GetStaticMethodID(_classObject, "isISOControl", "(C)Z");
            _cachedMethodId65 = AndroidJNI.GetStaticMethodID(_classObject, "isISOControl", "(I)Z");
            _cachedMethodId66 = AndroidJNI.GetStaticMethodID(_classObject, "getType", "(C)I");
            _cachedMethodId67 = AndroidJNI.GetStaticMethodID(_classObject, "getType", "(I)I");
            _cachedMethodId68 = AndroidJNI.GetStaticMethodID(_classObject, "forDigit", "(II)C");
            _cachedMethodId69 = AndroidJNI.GetStaticMethodID(_classObject, "getDirectionality", "(C)B");
            _cachedMethodId70 = AndroidJNI.GetStaticMethodID(_classObject, "getDirectionality", "(I)B");
            _cachedMethodId71 = AndroidJNI.GetStaticMethodID(_classObject, "isMirrored", "(C)Z");
            _cachedMethodId72 = AndroidJNI.GetStaticMethodID(_classObject, "isMirrored", "(I)Z");
            _cachedMethodId73 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Character;)I");
            _cachedMethodId74 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(CC)I");
            _cachedMethodId75 = AndroidJNI.GetStaticMethodID(_classObject, "reverseBytes", "(C)C");
            _cachedMethodId76 = AndroidJNI.GetStaticMethodID(_classObject, "getName", "(I)Ljava/lang/String;");
        }

        public Character(char value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = value } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Character(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Character.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Character ValueOf(char c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = c } };
                return new global::Java.Lang.Character(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public char CharValue()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallCharMethod(_rawObject, _cachedMethodId1, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(char value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId3, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(char c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = c } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsValidCodePoint(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsBmpCodePoint(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsSupplementaryCodePoint(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsHighSurrogate(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLowSurrogate(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsSurrogate(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsSurrogatePair(char high, char low)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { c = high },
                            new jvalue { c = low }
                        };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int CharCount(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ToCodePoint(char high, char low)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { c = high },
                            new jvalue { c = low }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int CodePointAt(global::Java.Lang.CharSequence seq, int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = seq.GetRawObject() },
                            new jvalue { i = index }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int CodePointBefore(global::Java.Lang.CharSequence seq, int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = seq.GetRawObject() },
                            new jvalue { i = index }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char HighSurrogate(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char LowSurrogate(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int CodePointCount(global::Java.Lang.CharSequence seq, int beginIndex, int endIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = seq.GetRawObject() },
                            new jvalue { i = beginIndex },
                            new jvalue { i = endIndex }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int OffsetByCodePoints(global::Java.Lang.CharSequence seq, int index, int codePointOffset)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = seq.GetRawObject() },
                            new jvalue { i = index },
                            new jvalue { i = codePointOffset }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLowerCase(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLowerCase(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsUpperCase(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsUpperCase(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsTitleCase(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsTitleCase(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsDigit(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsDigit(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsDefined(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsDefined(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLetter(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLetter(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId32, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLetterOrDigit(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsLetterOrDigit(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsJavaLetter(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsJavaLetterOrDigit(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId36, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsAlphabetic(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId37, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsIdeographic(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsJavaIdentifierStart(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId39, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsJavaIdentifierStart(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId40, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsJavaIdentifierPart(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId41, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsJavaIdentifierPart(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId42, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsUnicodeIdentifierStart(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId43, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsUnicodeIdentifierStart(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId44, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsUnicodeIdentifierPart(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId45, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsUnicodeIdentifierPart(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId46, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsIdentifierIgnorable(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId47, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsIdentifierIgnorable(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId48, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char ToLowerCase(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId49, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ToLowerCase(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId50, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char ToUpperCase(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId51, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ToUpperCase(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId52, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char ToTitleCase(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId53, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ToTitleCase(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId54, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Digit(char ch, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { c = ch },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId55, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Digit(int codePoint, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = codePoint },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId56, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int GetNumericValue(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId57, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int GetNumericValue(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId58, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsSpace(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId59, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsSpaceChar(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId60, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsSpaceChar(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId61, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsWhitespace(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId62, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsWhitespace(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId63, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsISOControl(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId64, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsISOControl(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId65, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int GetType(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId66, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int GetType(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId67, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char ForDigit(int digit, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = digit },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId68, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static sbyte GetDirectionality(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return global::Google.LibraryWrapper.Java.Utils.CallStaticSByteMethod(_classObject, _cachedMethodId69, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static sbyte GetDirectionality(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return global::Google.LibraryWrapper.Java.Utils.CallStaticSByteMethod(_classObject, _cachedMethodId70, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsMirrored(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId71, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsMirrored(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId72, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Lang.Character anotherCharacter)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anotherCharacter.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId73, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare(char x, char y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { c = x },
                            new jvalue { c = y }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId74, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static char ReverseBytes(char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = ch } };
                return AndroidJNI.CallStaticCharMethod(_classObject, _cachedMethodId75, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String GetName(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId76, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Character wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Character(IntPtr rawObject)
        {
            return new Character(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Character
} // end namespace Java.Lang
