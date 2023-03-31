using System;

using UnityEngine;

namespace Java.Util
{
    public class ListResourceBundle : global::Java.Util.ResourceBundle
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;

        static ListResourceBundle()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/ListResourceBundle");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
        }

        public ListResourceBundle() : base(IntPtr.Zero)
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

        public ListResourceBundle(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ListResourceBundle.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Google.LibraryWrapper.Java.JavaObject HandleGetObject(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ListResourceBundle wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ListResourceBundle(IntPtr rawObject)
        {
            return new ListResourceBundle(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ListResourceBundle
} // end namespace Java.Util
