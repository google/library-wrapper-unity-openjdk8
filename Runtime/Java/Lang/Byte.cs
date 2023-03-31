using System;

using UnityEngine;

namespace Java.Lang
{
    public class Byte : global::Java.Lang.Number, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Lang.Byte>
    {
        public static sbyte MIN_VALUE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId0);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId0, value);
            }
        }
        public static sbyte MAX_VALUE
        {
            get
            {
                return global::Google.LibraryWrapper.Java.Utils.GetStaticSByteField(_classObject, _cachedFieldId1);
            }
            set
            {
                global::Google.LibraryWrapper.Java.Utils.SetStaticSByteField(_classObject, _cachedFieldId1, value);
            }
        }
        public static global::Java.Lang.Class<global::Java.Lang.Byte> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Byte>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static int SIZE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId3);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId3, value);
            }
        }
        public static int BYTES
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId4);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId4, value);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
        private static readonly IntPtr _cachedFieldId2;
        private static readonly IntPtr _cachedFieldId3;
        private static readonly IntPtr _cachedFieldId4;
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

        static Byte()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Byte");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_VALUE", "B");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_VALUE", "B");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "SIZE", "I");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "BYTES", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(B)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(B)Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(B)Ljava/lang/Byte;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "parseByte", "(Ljava/lang/String;I)B");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "parseByte", "(Ljava/lang/String;)B");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(B)I");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Byte;)I");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(BB)I");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedInt", "(B)I");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedLong", "(B)J");
        }

        public Byte(sbyte value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = value
                                #else
                                b = (byte)value
                                #endif
                            }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Byte(global::System.String s) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Byte(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Byte.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(sbyte b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = b
                                #else
                                b = (byte)b
                                #endif
                            }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Byte ValueOf(sbyte b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = b
                                #else
                                b = (byte)b
                                #endif
                            }
                        };
                return new global::Java.Lang.Byte(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static sbyte ParseByte(global::System.String s, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) },
                            new jvalue { i = radix }
                        };
                return global::Google.LibraryWrapper.Java.Utils.CallStaticSByteMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static sbyte ParseByte(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return global::Google.LibraryWrapper.Java.Utils.CallStaticSByteMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Byte ValueOf(global::System.String s, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) },
                            new jvalue { i = radix }
                        };
                return new global::Java.Lang.Byte(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Byte ValueOf(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return new global::Java.Lang.Byte(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Byte Decode(global::System.String nm)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) } };
                return new global::Java.Lang.Byte(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(sbyte value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = value
                                #else
                                b = (byte)value
                                #endif
                            }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId8, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Lang.Byte anotherByte)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anotherByte.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare(sbyte x, sbyte y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = x
                                #else
                                b = (byte)x
                                #endif
                            },
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = y
                                #else
                                b = (byte)y
                                #endif
                            }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ToUnsignedInt(sbyte x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = x
                                #else
                                b = (byte)x
                                #endif
                            }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ToUnsignedLong(sbyte x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = x
                                #else
                                b = (byte)x
                                #endif
                            }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Byte wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Byte(IntPtr rawObject)
        {
            return new Byte(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Byte
} // end namespace Java.Lang
