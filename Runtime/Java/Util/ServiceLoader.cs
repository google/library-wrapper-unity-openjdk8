using System;

using UnityEngine;

namespace Java.Util
{
    public class ServiceLoader<S> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Iterable<S> where S : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;

        static ServiceLoader()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/ServiceLoader");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "reload", "()V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "iterator", "()Ljava/util/Iterator;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "load", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/ServiceLoader;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "load", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "loadInstalled", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;");
        }

        public ServiceLoader(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ServiceLoader.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Reload()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Iterator<S> Iterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.IteratorAnonymousImplementation<S>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ServiceLoader<S2> Load<S2>(global::Java.Lang.Class<S2> service, global::Java.Lang.ClassLoader loader) where S2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = service.GetRawObject() },
                            new jvalue { l = loader.GetRawObject() }
                        };
                return new global::Java.Util.ServiceLoader<S2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ServiceLoader<S2> Load<S2>(global::Java.Lang.Class<S2> service) where S2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = service.GetRawObject() } };
                return new global::Java.Util.ServiceLoader<S2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.ServiceLoader<S2> LoadInstalled<S2>(global::Java.Lang.Class<S2> service) where S2 : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = service.GetRawObject() } };
                return new global::Java.Util.ServiceLoader<S2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ServiceLoader<S> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ServiceLoader<S>(IntPtr rawObject)
        {
            return new ServiceLoader<S>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ServiceLoader
} // end namespace Java.Util
