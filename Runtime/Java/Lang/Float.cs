using System;

using UnityEngine;

namespace Java.Lang
{
    public class Float : global::Java.Lang.Number, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Lang.Float>
    {
        public static float POSITIVE_INFINITY
        {
            get
            {
                return AndroidJNI.GetStaticFloatField(_classObject, _cachedFieldId0);
            }
            set
            {
                AndroidJNI.SetStaticFloatField(_classObject, _cachedFieldId0, value);
            }
        }
        public static float NEGATIVE_INFINITY
        {
            get
            {
                return AndroidJNI.GetStaticFloatField(_classObject, _cachedFieldId1);
            }
            set
            {
                AndroidJNI.SetStaticFloatField(_classObject, _cachedFieldId1, value);
            }
        }
        public static float NaN
        {
            get
            {
                return AndroidJNI.GetStaticFloatField(_classObject, _cachedFieldId2);
            }
            set
            {
                AndroidJNI.SetStaticFloatField(_classObject, _cachedFieldId2, value);
            }
        }
        public static float MAX_VALUE
        {
            get
            {
                return AndroidJNI.GetStaticFloatField(_classObject, _cachedFieldId3);
            }
            set
            {
                AndroidJNI.SetStaticFloatField(_classObject, _cachedFieldId3, value);
            }
        }
        public static float MIN_NORMAL
        {
            get
            {
                return AndroidJNI.GetStaticFloatField(_classObject, _cachedFieldId4);
            }
            set
            {
                AndroidJNI.SetStaticFloatField(_classObject, _cachedFieldId4, value);
            }
        }
        public static float MIN_VALUE
        {
            get
            {
                return AndroidJNI.GetStaticFloatField(_classObject, _cachedFieldId5);
            }
            set
            {
                AndroidJNI.SetStaticFloatField(_classObject, _cachedFieldId5, value);
            }
        }
        public static int MAX_EXPONENT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId6);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId6, value);
            }
        }
        public static int MIN_EXPONENT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId7);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId7, value);
            }
        }
        public static int SIZE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId8);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId8, value);
            }
        }
        public static int BYTES
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId9);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId9, value);
            }
        }
        public static global::Java.Lang.Class<global::Java.Lang.Float> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Float>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId10));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId10, valueRef);
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

        static Float()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Float");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "POSITIVE_INFINITY", "F");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "NEGATIVE_INFINITY", "F");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "NaN", "F");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_VALUE", "F");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_NORMAL", "F");
            _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_VALUE", "F");
            _cachedFieldId6 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_EXPONENT", "I");
            _cachedFieldId7 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_EXPONENT", "I");
            _cachedFieldId8 = AndroidJNI.GetStaticFieldID(_classObject, "SIZE", "I");
            _cachedFieldId9 = AndroidJNI.GetStaticFieldID(_classObject, "BYTES", "I");
            _cachedFieldId10 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(F)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(D)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(F)Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "toHexString", "(F)Ljava/lang/String;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(F)Ljava/lang/Float;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "parseFloat", "(Ljava/lang/String;)F");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "isNaN", "(F)Z");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "isInfinite", "(F)Z");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "isFinite", "(F)Z");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "isNaN", "()Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "isInfinite", "()Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(F)I");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "floatToIntBits", "(F)I");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "floatToRawIntBits", "(F)I");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "intBitsToFloat", "(I)F");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Float;)I");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(FF)I");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "sum", "(FF)F");
            _cachedMethodId19 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(FF)F");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(FF)F");
        }

        public Float(float value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = value } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Float(double value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = value } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Float(global::System.String s) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Float(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Float.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToHexString(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Float ValueOf(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return new global::Java.Lang.Float(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Float ValueOf(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return new global::Java.Lang.Float(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float ParseFloat(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsNaN(float v)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = v } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsInfinite(float v)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = v } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsFinite(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsNaN()
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

        public bool IsInfinite()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(float value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId11, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int FloatToIntBits(float value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int FloatToRawIntBits(float value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float IntBitsToFloat(int bits)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = bits } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Lang.Float anotherFloat)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anotherFloat.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare(float f1, float f2)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = f1 },
                            new jvalue { f = f2 }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Sum(float a, float b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = a },
                            new jvalue { f = b }
                        };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Max(float a, float b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = a },
                            new jvalue { f = b }
                        };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Min(float a, float b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = a },
                            new jvalue { f = b }
                        };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Float wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Float(IntPtr rawObject)
        {
            return new Float(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Float
} // end namespace Java.Lang
