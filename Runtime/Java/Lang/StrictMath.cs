using System;

using UnityEngine;

namespace Java.Lang
{
    public class StrictMath : global::Google.LibraryWrapper.Java.JavaObject
    {
        public static double E
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
        public static double PI
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

        static StrictMath()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/StrictMath");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "E", "D");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "PI", "D");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "sin", "(D)D");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "cos", "(D)D");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "tan", "(D)D");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "asin", "(D)D");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "acos", "(D)D");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "atan", "(D)D");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "toRadians", "(D)D");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "toDegrees", "(D)D");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "exp", "(D)D");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "log", "(D)D");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "log10", "(D)D");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "sqrt", "(D)D");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "cbrt", "(D)D");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "IEEEremainder", "(DD)D");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "ceil", "(D)D");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "floor", "(D)D");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "rint", "(D)D");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "atan2", "(DD)D");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "pow", "(DD)D");
            _cachedMethodId19 = AndroidJNI.GetStaticMethodID(_classObject, "round", "(F)I");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "round", "(D)J");
            _cachedMethodId21 = AndroidJNI.GetStaticMethodID(_classObject, "random", "()D");
            _cachedMethodId22 = AndroidJNI.GetStaticMethodID(_classObject, "addExact", "(II)I");
            _cachedMethodId23 = AndroidJNI.GetStaticMethodID(_classObject, "addExact", "(JJ)J");
            _cachedMethodId24 = AndroidJNI.GetStaticMethodID(_classObject, "subtractExact", "(II)I");
            _cachedMethodId25 = AndroidJNI.GetStaticMethodID(_classObject, "subtractExact", "(JJ)J");
            _cachedMethodId26 = AndroidJNI.GetStaticMethodID(_classObject, "multiplyExact", "(II)I");
            _cachedMethodId27 = AndroidJNI.GetStaticMethodID(_classObject, "multiplyExact", "(JJ)J");
            _cachedMethodId28 = AndroidJNI.GetStaticMethodID(_classObject, "toIntExact", "(J)I");
            _cachedMethodId29 = AndroidJNI.GetStaticMethodID(_classObject, "floorDiv", "(II)I");
            _cachedMethodId30 = AndroidJNI.GetStaticMethodID(_classObject, "floorDiv", "(JJ)J");
            _cachedMethodId31 = AndroidJNI.GetStaticMethodID(_classObject, "floorMod", "(II)I");
            _cachedMethodId32 = AndroidJNI.GetStaticMethodID(_classObject, "floorMod", "(JJ)J");
            _cachedMethodId33 = AndroidJNI.GetStaticMethodID(_classObject, "abs", "(I)I");
            _cachedMethodId34 = AndroidJNI.GetStaticMethodID(_classObject, "abs", "(J)J");
            _cachedMethodId35 = AndroidJNI.GetStaticMethodID(_classObject, "abs", "(F)F");
            _cachedMethodId36 = AndroidJNI.GetStaticMethodID(_classObject, "abs", "(D)D");
            _cachedMethodId37 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(II)I");
            _cachedMethodId38 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(JJ)J");
            _cachedMethodId39 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(FF)F");
            _cachedMethodId40 = AndroidJNI.GetStaticMethodID(_classObject, "max", "(DD)D");
            _cachedMethodId41 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(II)I");
            _cachedMethodId42 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(JJ)J");
            _cachedMethodId43 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(FF)F");
            _cachedMethodId44 = AndroidJNI.GetStaticMethodID(_classObject, "min", "(DD)D");
            _cachedMethodId45 = AndroidJNI.GetStaticMethodID(_classObject, "ulp", "(D)D");
            _cachedMethodId46 = AndroidJNI.GetStaticMethodID(_classObject, "ulp", "(F)F");
            _cachedMethodId47 = AndroidJNI.GetStaticMethodID(_classObject, "signum", "(D)D");
            _cachedMethodId48 = AndroidJNI.GetStaticMethodID(_classObject, "signum", "(F)F");
            _cachedMethodId49 = AndroidJNI.GetStaticMethodID(_classObject, "sinh", "(D)D");
            _cachedMethodId50 = AndroidJNI.GetStaticMethodID(_classObject, "cosh", "(D)D");
            _cachedMethodId51 = AndroidJNI.GetStaticMethodID(_classObject, "tanh", "(D)D");
            _cachedMethodId52 = AndroidJNI.GetStaticMethodID(_classObject, "hypot", "(DD)D");
            _cachedMethodId53 = AndroidJNI.GetStaticMethodID(_classObject, "expm1", "(D)D");
            _cachedMethodId54 = AndroidJNI.GetStaticMethodID(_classObject, "log1p", "(D)D");
            _cachedMethodId55 = AndroidJNI.GetStaticMethodID(_classObject, "copySign", "(DD)D");
            _cachedMethodId56 = AndroidJNI.GetStaticMethodID(_classObject, "copySign", "(FF)F");
            _cachedMethodId57 = AndroidJNI.GetStaticMethodID(_classObject, "getExponent", "(F)I");
            _cachedMethodId58 = AndroidJNI.GetStaticMethodID(_classObject, "getExponent", "(D)I");
            _cachedMethodId59 = AndroidJNI.GetStaticMethodID(_classObject, "nextAfter", "(DD)D");
            _cachedMethodId60 = AndroidJNI.GetStaticMethodID(_classObject, "nextAfter", "(FD)F");
            _cachedMethodId61 = AndroidJNI.GetStaticMethodID(_classObject, "nextUp", "(D)D");
            _cachedMethodId62 = AndroidJNI.GetStaticMethodID(_classObject, "nextUp", "(F)F");
            _cachedMethodId63 = AndroidJNI.GetStaticMethodID(_classObject, "nextDown", "(D)D");
            _cachedMethodId64 = AndroidJNI.GetStaticMethodID(_classObject, "nextDown", "(F)F");
            _cachedMethodId65 = AndroidJNI.GetStaticMethodID(_classObject, "scalb", "(DI)D");
            _cachedMethodId66 = AndroidJNI.GetStaticMethodID(_classObject, "scalb", "(FI)F");
        }

        public StrictMath(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of StrictMath.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Sin(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Cos(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Tan(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Asin(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Acos(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Atan(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double ToRadians(double angdeg)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = angdeg } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double ToDegrees(double angrad)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = angrad } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Exp(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Log(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Log10(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Sqrt(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Cbrt(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double IEEEremainder(double f1, double f2)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = f1 },
                            new jvalue { d = f2 }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Ceil(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Floor(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Rint(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Atan2(double y, double x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = y },
                            new jvalue { d = x }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Pow(double a, double b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = a },
                            new jvalue { d = b }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Round(float a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = a } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long Round(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Random()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int AddExact(int x, int y)
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

        public static long AddExact(long x, long y)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int SubtractExact(int x, int y)
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long SubtractExact(long x, long y)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int MultiplyExact(int x, int y)
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long MultiplyExact(long x, long y)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ToIntExact(long value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int FloorDiv(int x, int y)
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long FloorDiv(long x, long y)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int FloorMod(int x, int y)
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long FloorMod(long x, long y)
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId32, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Abs(int a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = a } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static long Abs(long a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = a } };
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Abs(float a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = a } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Abs(double a)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = a } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId36, args_);
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId37, args_);
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId38, args_);
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
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId39, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Max(double a, double b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = a },
                            new jvalue { d = b }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId40, args_);
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
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId41, args_);
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
                return AndroidJNI.CallStaticLongMethod(_classObject, _cachedMethodId42, args_);
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
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId43, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Min(double a, double b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = a },
                            new jvalue { d = b }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId44, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Ulp(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId45, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Ulp(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId46, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Signum(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId47, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Signum(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId48, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Sinh(double x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = x } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId49, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Cosh(double x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = x } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId50, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Tanh(double x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = x } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId51, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Hypot(double x, double y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = x },
                            new jvalue { d = y }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId52, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Expm1(double x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = x } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId53, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Log1p(double x)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = x } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId54, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double CopySign(double magnitude, double sign)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = magnitude },
                            new jvalue { d = sign }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId55, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float CopySign(float magnitude, float sign)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = magnitude },
                            new jvalue { f = sign }
                        };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId56, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int GetExponent(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId57, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int GetExponent(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId58, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double NextAfter(double start, double direction)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = start },
                            new jvalue { d = direction }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId59, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float NextAfter(float start, double direction)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = start },
                            new jvalue { d = direction }
                        };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId60, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double NextUp(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId61, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float NextUp(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId62, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double NextDown(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId63, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float NextDown(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId64, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static double Scalb(double d, int scaleFactor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = d },
                            new jvalue { i = scaleFactor }
                        };
                return AndroidJNI.CallStaticDoubleMethod(_classObject, _cachedMethodId65, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static float Scalb(float f, int scaleFactor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { f = f },
                            new jvalue { i = scaleFactor }
                        };
                return AndroidJNI.CallStaticFloatMethod(_classObject, _cachedMethodId66, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(StrictMath wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator StrictMath(IntPtr rawObject)
        {
            return new StrictMath(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class StrictMath
} // end namespace Java.Lang
