using System;

using UnityEngine;

namespace Java.Util
{
    public class EventListenerProxy<T> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.EventListener where T : class, global::Java.Util.EventListener
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;

        static EventListenerProxy()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/EventListenerProxy");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/EventListener;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getListener", "()Ljava/util/EventListener;");
        }

        public EventListenerProxy(T listener) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(listener) };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public EventListenerProxy(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of EventListenerProxy.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T GetListener()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId0, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(EventListenerProxy<T> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator EventListenerProxy<T>(IntPtr rawObject)
        {
            return new EventListenerProxy<T>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class EventListenerProxy
} // end namespace Java.Util
