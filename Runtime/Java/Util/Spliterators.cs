using System;

using UnityEngine;

namespace Java.Util
{
    public class Spliterators : global::Google.LibraryWrapper.Java.JavaObject
    {
        public class AbstractDoubleSpliterator : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfDouble
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static AbstractDoubleSpliterator()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterators$AbstractDoubleSpliterator");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "trySplit", "()Ljava/util/Spliterator$OfDouble;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "estimateSize", "()J");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "characteristics", "()I");
            }

            public AbstractDoubleSpliterator() : base(IntPtr.Zero)
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

            public AbstractDoubleSpliterator(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AbstractDoubleSpliterator.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Util.Spliterator.OfDouble TrySplit()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.ExternalType.Java.Util.Spliterator.OfDoubleAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public long EstimateSize()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public int Characteristics()
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

            public static explicit operator IntPtr(AbstractDoubleSpliterator wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AbstractDoubleSpliterator(IntPtr rawObject)
            {
                return new AbstractDoubleSpliterator(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AbstractDoubleSpliterator

        public class AbstractIntSpliterator : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfInt
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static AbstractIntSpliterator()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterators$AbstractIntSpliterator");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "trySplit", "()Ljava/util/Spliterator$OfInt;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "estimateSize", "()J");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "characteristics", "()I");
            }

            public AbstractIntSpliterator() : base(IntPtr.Zero)
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

            public AbstractIntSpliterator(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AbstractIntSpliterator.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Util.Spliterator.OfInt TrySplit()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.ExternalType.Java.Util.Spliterator.OfIntAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public long EstimateSize()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public int Characteristics()
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

            public static explicit operator IntPtr(AbstractIntSpliterator wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AbstractIntSpliterator(IntPtr rawObject)
            {
                return new AbstractIntSpliterator(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AbstractIntSpliterator

        public class AbstractLongSpliterator : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfLong
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static AbstractLongSpliterator()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterators$AbstractLongSpliterator");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "trySplit", "()Ljava/util/Spliterator$OfLong;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "estimateSize", "()J");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "characteristics", "()I");
            }

            public AbstractLongSpliterator() : base(IntPtr.Zero)
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

            public AbstractLongSpliterator(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AbstractLongSpliterator.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Util.Spliterator.OfLong TrySplit()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.ExternalType.Java.Util.Spliterator.OfLongAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public long EstimateSize()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public int Characteristics()
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

            public static explicit operator IntPtr(AbstractLongSpliterator wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AbstractLongSpliterator(IntPtr rawObject)
            {
                return new AbstractLongSpliterator(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AbstractLongSpliterator

        public class AbstractSpliterator<T> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator<T> where T : class
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static AbstractSpliterator()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterators$AbstractSpliterator");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "trySplit", "()Ljava/util/Spliterator;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "estimateSize", "()J");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "characteristics", "()I");
            }

            public AbstractSpliterator() : base(IntPtr.Zero)
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

            public AbstractSpliterator(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AbstractSpliterator.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Util.Spliterator<T> TrySplit()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public long EstimateSize()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public int Characteristics()
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

            public static explicit operator IntPtr(AbstractSpliterator<T> wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AbstractSpliterator<T>(IntPtr rawObject)
            {
                return new AbstractSpliterator<T>(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AbstractSpliterator

        private static readonly IntPtr _classObject;
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

        static Spliterators()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterators");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "emptySpliterator", "()Ljava/util/Spliterator;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "emptyIntSpliterator", "()Ljava/util/Spliterator$OfInt;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "emptyLongSpliterator", "()Ljava/util/Spliterator$OfLong;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "emptyDoubleSpliterator", "()Ljava/util/Spliterator$OfDouble;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "spliterator", "(Ljava/util/Collection;I)Ljava/util/Spliterator;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "spliterator", "(Ljava/util/Iterator;JI)Ljava/util/Spliterator;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "spliteratorUnknownSize", "(Ljava/util/Iterator;I)Ljava/util/Spliterator;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "spliterator", "(Ljava/util/PrimitiveIterator$OfInt;JI)Ljava/util/Spliterator$OfInt;");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "spliteratorUnknownSize", "(Ljava/util/PrimitiveIterator$OfInt;I)Ljava/util/Spliterator$OfInt;");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "spliterator", "(Ljava/util/PrimitiveIterator$OfLong;JI)Ljava/util/Spliterator$OfLong;");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "spliteratorUnknownSize", "(Ljava/util/PrimitiveIterator$OfLong;I)Ljava/util/Spliterator$OfLong;");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "spliterator", "(Ljava/util/PrimitiveIterator$OfDouble;JI)Ljava/util/Spliterator$OfDouble;");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "spliteratorUnknownSize", "(Ljava/util/PrimitiveIterator$OfDouble;I)Ljava/util/Spliterator$OfDouble;");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "iterator", "(Ljava/util/Spliterator;)Ljava/util/Iterator;");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "iterator", "(Ljava/util/Spliterator$OfInt;)Ljava/util/PrimitiveIterator$OfInt;");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "iterator", "(Ljava/util/Spliterator$OfLong;)Ljava/util/PrimitiveIterator$OfLong;");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "iterator", "(Ljava/util/Spliterator$OfDouble;)Ljava/util/PrimitiveIterator$OfDouble;");
        }

        public Spliterators(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Spliterators.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator<T> EmptySpliterator<T>() where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<T>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfInt EmptyIntSpliterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfIntAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfLong EmptyLongSpliterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfLongAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfDouble EmptyDoubleSpliterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfDoubleAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator<T> Spliterator<T>(global::Java.Util.Collection<T> c, int characteristics) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = c.GetRawObject() },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<T>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator<T> Spliterator<T>(global::Java.Util.Iterator<T> iterator, long size, int characteristics) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { j = size },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<T>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator<T> SpliteratorUnknownSize<T>(global::Java.Util.Iterator<T> iterator, int characteristics) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<T>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfInt Spliterator(global::Java.ExternalType.Java.Util.PrimitiveIterator.OfInt iterator, long size, int characteristics)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { j = size },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfIntAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfInt SpliteratorUnknownSize(global::Java.ExternalType.Java.Util.PrimitiveIterator.OfInt iterator, int characteristics)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfIntAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfLong Spliterator(global::Java.ExternalType.Java.Util.PrimitiveIterator.OfLong iterator, long size, int characteristics)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { j = size },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfLongAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfLong SpliteratorUnknownSize(global::Java.ExternalType.Java.Util.PrimitiveIterator.OfLong iterator, int characteristics)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfLongAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId10, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfDouble Spliterator(global::Java.ExternalType.Java.Util.PrimitiveIterator.OfDouble iterator, long size, int characteristics)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { j = size },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfDoubleAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.Spliterator.OfDouble SpliteratorUnknownSize(global::Java.ExternalType.Java.Util.PrimitiveIterator.OfDouble iterator, int characteristics)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = iterator.GetRawObject() },
                            new jvalue { i = characteristics }
                        };
                return new global::Java.ExternalType.Java.Util.Spliterator.OfDoubleAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Iterator<T> Iterator<T>(global::Java.ExternalType.Java.Util.Spliterator<T> spliterator) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = spliterator.GetRawObject() } };
                return new global::Java.Util.IteratorAnonymousImplementation<T>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.PrimitiveIterator.OfInt Iterator(global::Java.ExternalType.Java.Util.Spliterator.OfInt spliterator)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = spliterator.GetRawObject() } };
                return new global::Java.ExternalType.Java.Util.PrimitiveIterator.OfInt(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.PrimitiveIterator.OfLong Iterator(global::Java.ExternalType.Java.Util.Spliterator.OfLong spliterator)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = spliterator.GetRawObject() } };
                return new global::Java.ExternalType.Java.Util.PrimitiveIterator.OfLong(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.ExternalType.Java.Util.PrimitiveIterator.OfDouble Iterator(global::Java.ExternalType.Java.Util.Spliterator.OfDouble spliterator)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = spliterator.GetRawObject() } };
                return new global::Java.ExternalType.Java.Util.PrimitiveIterator.OfDouble(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Spliterators wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Spliterators(IntPtr rawObject)
        {
            return new Spliterators(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Spliterators
} // end namespace Java.Util
