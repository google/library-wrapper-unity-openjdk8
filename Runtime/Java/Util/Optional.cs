using System;

using UnityEngine;

namespace Java.Util
{
    public class Optional<T> : global::Google.LibraryWrapper.Java.JavaObject where T : class
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

        static Optional()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Optional");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "empty", "()Ljava/util/Optional;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(Ljava/lang/Object;)Ljava/util/Optional;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "ofNullable", "(Ljava/lang/Object;)Ljava/util/Optional;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "get", "()Ljava/lang/Object;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "isPresent", "()Z");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "ifPresent", "(Ljava/util/function/Consumer;)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "filter", "(Ljava/util/function/Predicate;)Ljava/util/Optional;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "map", "(Ljava/util/function/Function;)Ljava/util/Optional;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "flatMap", "(Ljava/util/function/Function;)Ljava/util/Optional;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "orElse", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "orElseGet", "(Ljava/util/function/Supplier;)Ljava/lang/Object;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "orElseThrow", "(Ljava/util/function/Supplier;)Ljava/lang/Object;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
        }

        public Optional(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Optional.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Optional<T2> Empty<T2>() where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Optional<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Optional<T2> Of<T2>(T2 value) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(value) };
                return new global::Java.Util.Optional<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Optional<T2> OfNullable<T2>(T2 value) where T2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(value) };
                return new global::Java.Util.Optional<T2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T Get()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId3, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsPresent()
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

        public void IfPresent(global::Java.ExternalType.Java.Util.Function.Consumer<T> consumer)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = consumer.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Optional<T> Filter(global::Java.ExternalType.Java.Util.Function.Predicate<T> predicate)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = predicate.GetRawObject() } };
                return new global::Java.Util.Optional<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Optional<U> Map<U>(global::Java.ExternalType.Java.Util.Function.Function<T, U> mapper) where U : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = mapper.GetRawObject() } };
                return new global::Java.Util.Optional<U>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Optional<U> FlatMap<U>(global::Java.ExternalType.Java.Util.Function.Function<T, global::Java.Util.Optional<U>> mapper) where U : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = mapper.GetRawObject() } };
                return new global::Java.Util.Optional<U>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T OrElse(T other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(other) };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId9, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T OrElseGet(global::Java.ExternalType.Java.Util.Function.Supplier<T> other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = other.GetRawObject() } };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId10, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T OrElseThrow<X>(global::Java.ExternalType.Java.Util.Function.Supplier<X> exceptionSupplier) where X : global::Java.Lang.Throwable
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = exceptionSupplier.GetRawObject() } };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId11, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
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

        public int HashCode()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Optional<T> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Optional<T>(IntPtr rawObject)
        {
            return new Optional<T>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Optional
} // end namespace Java.Util
