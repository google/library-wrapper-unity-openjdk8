using System;

using UnityEngine;

namespace Java.Lang
{
    public class ThreadLocal<T> : global::Google.LibraryWrapper.Java.JavaObject where T : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;

        static ThreadLocal()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/ThreadLocal");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "withInitial", "(Ljava/util/function/Supplier;)Ljava/lang/ThreadLocal;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "get", "()Ljava/lang/Object;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "set", "(Ljava/lang/Object;)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "remove", "()V");
        }

        public ThreadLocal() : base(IntPtr.Zero)
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

        public ThreadLocal(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ThreadLocal.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.ThreadLocal<S> WithInitial<S>(global::Java.ExternalType.Java.Util.Function.Supplier<S> supplier) where S : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = supplier.GetRawObject() } };
                return new global::Java.Lang.ThreadLocal<S>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
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
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId1, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Set(T value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(value) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Remove()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ThreadLocal<T> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ThreadLocal<T>(IntPtr rawObject)
        {
            return new ThreadLocal<T>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ThreadLocal
} // end namespace Java.Lang
