using System;

using UnityEngine;

namespace Java.Util
{
    public interface Comparator<T> : global::Google.LibraryWrapper.Java.JavaInterface where T : class
    {

        int Compare(T o1, T o2);

        bool Equals(global::Google.LibraryWrapper.Java.JavaObject obj);
    } // end class Comparator

    public class ComparatorAnonymousImplementation<T> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Comparator<T> where T : class
    {
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
        private static readonly IntPtr _cachedMethodId17;

        static ComparatorAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Comparator");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "reversed", "()Ljava/util/Comparator;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "thenComparing", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "thenComparing", "(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "thenComparing", "(Ljava/util/function/Function;)Ljava/util/Comparator;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "thenComparingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "thenComparingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "thenComparingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "reverseOrder", "()Ljava/util/Comparator;");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "naturalOrder", "()Ljava/util/Comparator;");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "nullsFirst", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "nullsLast", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "comparing", "(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "comparing", "(Ljava/util/function/Function;)Ljava/util/Comparator;");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "comparingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;");
            _cachedMethodId16 = AndroidJNI.GetStaticMethodID(_classObject, "comparingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "comparingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;");
        }

        public ComparatorAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ComparatorAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Compare(T o1, T o2)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(o1),
                            ToJvalue(o2)
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId0, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> Reversed()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> ThenComparing(global::Java.Util.Comparator<T> other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = other.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> ThenComparing<U>(global::Java.ExternalType.Java.Util.Function.Function<T, U> keyExtractor, global::Java.Util.Comparator<U> keyComparator) where U : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = keyExtractor.GetRawObject() },
                            new jvalue { l = keyComparator.GetRawObject() }
                        };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> ThenComparing<U>(global::Java.ExternalType.Java.Util.Function.Function<T, U> keyExtractor) where U : class, global::Java.ExternalType.Java.Lang.Comparable<U>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> ThenComparingInt(global::Java.ExternalType.Java.Util.Function.ToIntFunction<T> keyExtractor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> ThenComparingLong(global::Java.ExternalType.Java.Util.Function.ToLongFunction<T> keyExtractor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<T> ThenComparingDouble(global::Java.ExternalType.Java.Util.Function.ToDoubleFunction<T> keyExtractor)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> ReverseOrder<T2>() where T2 : class, global::Java.ExternalType.Java.Lang.Comparable<T2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> NaturalOrder<T2>() where T2 : class, global::Java.ExternalType.Java.Lang.Comparable<T2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId10, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> NullsFirst<T2>(global::Java.Util.Comparator<T2> comparator) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = comparator.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> NullsLast<T2>(global::Java.Util.Comparator<T2> comparator) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = comparator.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> Comparing<T2, U>(global::Java.ExternalType.Java.Util.Function.Function<T2, U> keyExtractor, global::Java.Util.Comparator<U> keyComparator) where T2 : class where U : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = keyExtractor.GetRawObject() },
                            new jvalue { l = keyComparator.GetRawObject() }
                        };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> Comparing<T2, U>(global::Java.ExternalType.Java.Util.Function.Function<T2, U> keyExtractor) where T2 : class where U : class, global::Java.ExternalType.Java.Lang.Comparable<U>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> ComparingInt<T2>(global::Java.ExternalType.Java.Util.Function.ToIntFunction<T2> keyExtractor) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> ComparingLong<T2>(global::Java.ExternalType.Java.Util.Function.ToLongFunction<T2> keyExtractor) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Comparator<T2> ComparingDouble<T2>(global::Java.ExternalType.Java.Util.Function.ToDoubleFunction<T2> keyExtractor) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = keyExtractor.GetRawObject() } };
                return new global::Java.Util.ComparatorAnonymousImplementation<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ComparatorAnonymousImplementation<T> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ComparatorAnonymousImplementation<T>(IntPtr rawObject)
        {
            return new ComparatorAnonymousImplementation<T>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ComparatorAnonymousImplementation

    public abstract class ComparatorCallbackHelper<T> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Comparator<T> where T : class
    {
        public ComparatorCallbackHelper() : base("java.util.Comparator") {}

        public abstract int Compare(T o1, T o2);

        public abstract bool Equals(global::Google.LibraryWrapper.Java.JavaObject obj);

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "compare" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Compare(args[0] is global::System.String ? (T) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(((AndroidJavaObject) args[0]).GetRawObject()), args[1] is global::System.String ? (T) (global::System.Object) args[1] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(((AndroidJavaObject) args[1]).GetRawObject())));
        }
        else if (methodName == "equals" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Equals(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        return base.Invoke(methodName, args);
        }
    } // end class ComparatorCallbackHelper
} // end namespace Java.Util
