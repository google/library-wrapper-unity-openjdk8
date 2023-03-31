using System;

using UnityEngine;

namespace Java.Util
{
    public class Random : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable
    {
        private static readonly IntPtr _classObject;
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

        static Random()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Random");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(J)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "setSeed", "(J)V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "nextInt", "()I");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "nextInt", "(I)I");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "nextLong", "()J");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "nextBoolean", "()Z");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "nextFloat", "()F");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "nextDouble", "()D");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "nextGaussian", "()D");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "ints", "(J)Ljava/util/stream/IntStream;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "ints", "()Ljava/util/stream/IntStream;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "ints", "(JII)Ljava/util/stream/IntStream;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "ints", "(II)Ljava/util/stream/IntStream;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "longs", "(J)Ljava/util/stream/LongStream;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "longs", "()Ljava/util/stream/LongStream;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "longs", "(JJJ)Ljava/util/stream/LongStream;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "longs", "(JJ)Ljava/util/stream/LongStream;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "doubles", "(J)Ljava/util/stream/DoubleStream;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "doubles", "()Ljava/util/stream/DoubleStream;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "doubles", "(JDD)Ljava/util/stream/DoubleStream;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "doubles", "(DD)Ljava/util/stream/DoubleStream;");
        }

        public Random() : base(IntPtr.Zero)
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

        public Random(long seed) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = seed } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Random(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Random.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetSeed(long seed)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = seed } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int NextInt()
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

        public int NextInt(int bound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = bound } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long NextLong()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool NextBoolean()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public float NextFloat()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallFloatMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public double NextDouble()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallDoubleMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public double NextGaussian()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallDoubleMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.IntStream Ints(long streamSize)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = streamSize } };
                return new global::Java.ExternalType.Java.Util.Stream.IntStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.IntStream Ints()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.IntStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.IntStream Ints(long streamSize, int randomNumberOrigin, int randomNumberBound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = streamSize },
                            new jvalue { i = randomNumberOrigin },
                            new jvalue { i = randomNumberBound }
                        };
                return new global::Java.ExternalType.Java.Util.Stream.IntStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.IntStream Ints(int randomNumberOrigin, int randomNumberBound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = randomNumberOrigin },
                            new jvalue { i = randomNumberBound }
                        };
                return new global::Java.ExternalType.Java.Util.Stream.IntStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.LongStream Longs(long streamSize)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = streamSize } };
                return new global::Java.ExternalType.Java.Util.Stream.LongStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.LongStream Longs()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.LongStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.LongStream Longs(long streamSize, long randomNumberOrigin, long randomNumberBound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = streamSize },
                            new jvalue { j = randomNumberOrigin },
                            new jvalue { j = randomNumberBound }
                        };
                return new global::Java.ExternalType.Java.Util.Stream.LongStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.LongStream Longs(long randomNumberOrigin, long randomNumberBound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = randomNumberOrigin },
                            new jvalue { j = randomNumberBound }
                        };
                return new global::Java.ExternalType.Java.Util.Stream.LongStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.DoubleStream Doubles(long streamSize)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = streamSize } };
                return new global::Java.ExternalType.Java.Util.Stream.DoubleStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.DoubleStream Doubles()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.DoubleStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.DoubleStream Doubles(long streamSize, double randomNumberOrigin, double randomNumberBound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = streamSize },
                            new jvalue { d = randomNumberOrigin },
                            new jvalue { d = randomNumberBound }
                        };
                return new global::Java.ExternalType.Java.Util.Stream.DoubleStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.DoubleStream Doubles(double randomNumberOrigin, double randomNumberBound)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { d = randomNumberOrigin },
                            new jvalue { d = randomNumberBound }
                        };
                return new global::Java.ExternalType.Java.Util.Stream.DoubleStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Random wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Random(IntPtr rawObject)
        {
            return new Random(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Random
} // end namespace Java.Util
