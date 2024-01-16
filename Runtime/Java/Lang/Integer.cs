using System;

using UnityEngine;

namespace Java.Lang
{
    public class Integer : global::Java.Lang.Number, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Lang.Integer>
    {
        public static int MIN_VALUE
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
        public static int MAX_VALUE
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
        public static global::Java.Lang.Class<global::Java.Lang.Integer> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Integer>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
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

        static Integer()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Integer");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_VALUE", "I");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_VALUE", "I");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "SIZE", "I");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "BYTES", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(I)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(II)Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedString", "(II)Ljava/lang/String;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "toHexString", "(I)Ljava/lang/String;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "toOctalString", "(I)Ljava/lang/String;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "toBinaryString", "(I)Ljava/lang/String;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(I)Ljava/lang/String;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedString", "(I)Ljava/lang/String;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "parseInt", "(Ljava/lang/String;I)I");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "parseInt", "(Ljava/lang/String;)I");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "parseUnsignedInt", "(Ljava/lang/String;I)I");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "parseUnsignedInt", "(Ljava/lang/String;)I");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(I)Ljava/lang/Integer;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(I)I");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
            _cachedMethodId19 = AndroidJNI.GetStaticMethodID(_classObject, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Integer;)I");
            _cachedMethodId22 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(II)I");
            _cachedMethodId23 = AndroidJNI.GetStaticMethodID(_classObject, "compareUnsigned", "(II)I");
            _cachedMethodId24 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedLong", "(I)J");
            _cachedMethodId25 = AndroidJNI.GetStaticMethodID(_classObject, "divideUnsigned", "(II)I");
            _cachedMethodId26 = AndroidJNI.GetStaticMethodID(_classObject, "remainderUnsigned", "(II)I");
            _cachedMethodId27 = AndroidJNI.GetStaticMethodID(_classObject, "highestOneBit", "(I)I");
            _cachedMethodId28 = AndroidJNI.GetStaticMethodID(_classObject, "lowestOneBit", "(I)I");
            _cachedMethodId29 = AndroidJNI.GetStaticMethodID(_classObject, "numberOfLeadingZeros", "(I)I");
            _cachedMethodId30 = AndroidJNI.GetStaticMethodID(_classObject, "numberOfTrailingZeros", "(I)I");
            _cachedMethodId31 = AndroidJNI.GetStaticMethodID(_classObject, "bitCount", "(I)I");
            _cachedMethodId32 = AndroidJNI.GetStaticMethodID(_classObject, "rotateLeft", "(II)I");
            _cachedMethodId33 = AndroidJNI.GetStaticMethodID(_classObject, "rotateRight", "(II)I");
            _cachedMethodId34 = AndroidJNI.GetStaticMethodID(_classObject, "reverse", "(I)I");
            _cachedMethodId35 = AndroidJNI.GetStaticMethodID(_classObject, "signum", "(I)I");
            _cachedMethodId36 = AndroidJNI.GetStaticMethodID(_classObject, "reverseBytes", "(I)I");
            _cachedMethodId37 = AndroidJNI.GetStaticMethodID(_classObject, "sum", "(II)I");
            _cachedMethodId38 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(II)I");
            _cachedMethodId39 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(II)I");
        }

        public Integer(int value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = value } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Integer(global::System.String s) : base(IntPtr.Zero)
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

        public Integer(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Integer.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(int i, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = i },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToUnsignedString(int i, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = i },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToHexString(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToOctalString(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToBinaryString(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToUnsignedString(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ParseInt(global::System.String s, int radix)
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ParseInt(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ParseUnsignedInt(global::System.String s, int radix)
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ParseUnsignedInt(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer ValueOf(global::System.String s, int radix)
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
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer ValueOf(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer ValueOf(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId13, args_));
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(int value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId15, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer GetInteger(global::System.String nm)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) } };
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer GetInteger(global::System.String nm, int val)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) },
                            new jvalue { i = val }
                        };
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer GetInteger(global::System.String nm, global::Java.Lang.Integer val)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) },
                            new jvalue { l = val.GetRawObject() }
                        };
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Integer Decode(global::System.String nm)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) } };
                return new global::Java.Lang.Integer(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId20, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Lang.Integer anotherInteger)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anotherInteger.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare(int x, int y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = x },
                            new jvalue { i = y }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int CompareUnsigned(int x, int y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = x },
                            new jvalue { i = y }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ToUnsignedLong(int x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = x } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int DivideUnsigned(int dividend, int divisor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = dividend },
                            new jvalue { i = divisor }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int RemainderUnsigned(int dividend, int divisor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = dividend },
                            new jvalue { i = divisor }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HighestOneBit(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int LowestOneBit(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int NumberOfLeadingZeros(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int NumberOfTrailingZeros(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int BitCount(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int RotateLeft(int i, int distance)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = i },
                            new jvalue { i = distance }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId32, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int RotateRight(int i, int distance)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = i },
                            new jvalue { i = distance }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Reverse(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Signum(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ReverseBytes(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId36, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Sum(int a, int b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = a },
                            new jvalue { i = b }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId37, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Max(int a, int b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = a },
                            new jvalue { i = b }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Min(int a, int b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = a },
                            new jvalue { i = b }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId39, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Integer wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Integer(IntPtr rawObject)
        {
            return new Integer(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Integer
} // end namespace Java.Lang
