using System;

using UnityEngine;

namespace Java.Lang
{
    public class Void : global::Google.LibraryWrapper.Java.JavaObject
    {
        public static global::Java.Lang.Class<global::Java.Lang.Void> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Void>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedConstructorId0;

        static Void()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Void");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
        }

        public Void() : base(IntPtr.Zero)
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

        public Void(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Void.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Void wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Void(IntPtr rawObject)
        {
            return new Void(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Void
} // end namespace Java.Lang
