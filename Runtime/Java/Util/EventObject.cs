using System;

using UnityEngine;

namespace Java.Util
{
    public class EventObject : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;

        static EventObject()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/EventObject");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Object;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getSource", "()Ljava/lang/Object;");
        }

        public EventObject(global::Google.LibraryWrapper.Java.JavaObject source) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = source.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public EventObject(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of EventObject.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Google.LibraryWrapper.Java.JavaObject GetSource()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(EventObject wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator EventObject(IntPtr rawObject)
        {
            return new EventObject(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class EventObject
} // end namespace Java.Util
