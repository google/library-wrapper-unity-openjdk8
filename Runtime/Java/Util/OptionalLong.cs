using System;

using UnityEngine;

namespace Java.Util
{
    public class OptionalLong : global::Google.LibraryWrapper.Java.JavaObject
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

        static OptionalLong()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/OptionalLong");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "empty", "()Ljava/util/OptionalLong;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(J)Ljava/util/OptionalLong;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "getAsLong", "()J");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "isPresent", "()Z");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "ifPresent", "(Ljava/util/function/LongConsumer;)V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "orElse", "(J)J");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "orElseGet", "(Ljava/util/function/LongSupplier;)J");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "orElseThrow", "(Ljava/util/function/Supplier;)J");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
        }

        public OptionalLong(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of OptionalLong.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.OptionalLong Empty()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.OptionalLong(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.OptionalLong Of(long value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = value } };
                return new global::Java.Util.OptionalLong(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long GetAsLong()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId2, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void IfPresent(global::Java.ExternalType.Java.Util.Function.LongConsumer consumer)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = consumer.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long OrElse(long other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = other } };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long OrElseGet(global::Java.ExternalType.Java.Util.Function.LongSupplier other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = other.GetRawObject() } };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long OrElseThrow<X>(global::Java.ExternalType.Java.Util.Function.Supplier<X> exceptionSupplier) where X : global::Java.Lang.Throwable
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = exceptionSupplier.GetRawObject() } };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId7, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId8, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(OptionalLong wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator OptionalLong(IntPtr rawObject)
        {
            return new OptionalLong(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class OptionalLong
} // end namespace Java.Util
