using System;

using UnityEngine;

namespace Java.Lang
{
    public class Long : global::Java.Lang.Number, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Lang.Long>
    {
        public static long MIN_VALUE
        {
            get
            {
                return AndroidJNI.GetStaticLongField(_classObject, _cachedFieldId0);
            }
            set
            {
                AndroidJNI.SetStaticLongField(_classObject, _cachedFieldId0, value);
            }
        }
        public static long MAX_VALUE
        {
            get
            {
                return AndroidJNI.GetStaticLongField(_classObject, _cachedFieldId1);
            }
            set
            {
                AndroidJNI.SetStaticLongField(_classObject, _cachedFieldId1, value);
            }
        }
        public static global::Java.Lang.Class<global::Java.Lang.Long> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Long>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
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

        static Long()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Long");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_VALUE", "J");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_VALUE", "J");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "SIZE", "I");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "BYTES", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(J)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(JI)Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedString", "(JI)Ljava/lang/String;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "toHexString", "(J)Ljava/lang/String;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "toOctalString", "(J)Ljava/lang/String;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "toBinaryString", "(J)Ljava/lang/String;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(J)Ljava/lang/String;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "toUnsignedString", "(J)Ljava/lang/String;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "parseLong", "(Ljava/lang/String;I)J");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "parseLong", "(Ljava/lang/String;)J");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "parseUnsignedLong", "(Ljava/lang/String;I)J");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "parseUnsignedLong", "(Ljava/lang/String;)J");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(J)Ljava/lang/Long;");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(J)I");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
            _cachedMethodId19 = AndroidJNI.GetStaticMethodID(_classObject, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Long;)I");
            _cachedMethodId22 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(JJ)I");
            _cachedMethodId23 = AndroidJNI.GetStaticMethodID(_classObject, "compareUnsigned", "(JJ)I");
            _cachedMethodId24 = AndroidJNI.GetStaticMethodID(_classObject, "divideUnsigned", "(JJ)J");
            _cachedMethodId25 = AndroidJNI.GetStaticMethodID(_classObject, "remainderUnsigned", "(JJ)J");
            _cachedMethodId26 = AndroidJNI.GetStaticMethodID(_classObject, "highestOneBit", "(J)J");
            _cachedMethodId27 = AndroidJNI.GetStaticMethodID(_classObject, "lowestOneBit", "(J)J");
            _cachedMethodId28 = AndroidJNI.GetStaticMethodID(_classObject, "numberOfLeadingZeros", "(J)I");
            _cachedMethodId29 = AndroidJNI.GetStaticMethodID(_classObject, "numberOfTrailingZeros", "(J)I");
            _cachedMethodId30 = AndroidJNI.GetStaticMethodID(_classObject, "bitCount", "(J)I");
            _cachedMethodId31 = AndroidJNI.GetStaticMethodID(_classObject, "rotateLeft", "(JI)J");
            _cachedMethodId32 = AndroidJNI.GetStaticMethodID(_classObject, "rotateRight", "(JI)J");
            _cachedMethodId33 = AndroidJNI.GetStaticMethodID(_classObject, "reverse", "(J)J");
            _cachedMethodId34 = AndroidJNI.GetStaticMethodID(_classObject, "signum", "(J)I");
            _cachedMethodId35 = AndroidJNI.GetStaticMethodID(_classObject, "reverseBytes", "(J)J");
            _cachedMethodId36 = AndroidJNI.GetStaticMethodID(_classObject, "sum", "(JJ)J");
            _cachedMethodId37 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(JJ)J");
            _cachedMethodId38 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(JJ)J");
        }

        public Long(long value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = value } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Long(global::System.String s) : base(IntPtr.Zero)
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

        public Long(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Long.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(long i, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = i },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToUnsignedString(long i, int radix)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = i },
                            new jvalue { i = radix }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToHexString(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToOctalString(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToBinaryString(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToUnsignedString(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ParseLong(global::System.String s, int radix)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ParseLong(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ParseUnsignedLong(global::System.String s, int radix)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ParseUnsignedLong(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long ValueOf(global::System.String s, int radix)
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
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long ValueOf(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long ValueOf(long l)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = l } };
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long Decode(global::System.String nm)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) } };
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId14, args_));
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(long value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId16, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long GetLong(global::System.String nm)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) } };
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long GetLong(global::System.String nm, long val)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nm) },
                            new jvalue { j = val }
                        };
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Long GetLong(global::System.String nm, global::Java.Lang.Long val)
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
                return new global::Java.Lang.Long(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId20, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Lang.Long anotherLong)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anotherLong.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare(long x, long y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = x },
                            new jvalue { j = y }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int CompareUnsigned(long x, long y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = x },
                            new jvalue { j = y }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long DivideUnsigned(long dividend, long divisor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = dividend },
                            new jvalue { j = divisor }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long RemainderUnsigned(long dividend, long divisor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = dividend },
                            new jvalue { j = divisor }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long HighestOneBit(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long LowestOneBit(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int NumberOfLeadingZeros(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int NumberOfTrailingZeros(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int BitCount(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long RotateLeft(long i, int distance)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = i },
                            new jvalue { i = distance }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long RotateRight(long i, int distance)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = i },
                            new jvalue { i = distance }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId32, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long Reverse(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Signum(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long ReverseBytes(long i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = i } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long Sum(long a, long b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = a },
                            new jvalue { j = b }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId36, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long Max(long a, long b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = a },
                            new jvalue { j = b }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId37, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long Min(long a, long b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = a },
                            new jvalue { j = b }
                        };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Long wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Long(IntPtr rawObject)
        {
            return new Long(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Long
} // end namespace Java.Lang
