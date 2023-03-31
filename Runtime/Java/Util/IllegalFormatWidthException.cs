using System;

using UnityEngine;

namespace Java.Util
{
    public class IllegalFormatWidthException : global::Java.Util.IllegalFormatException
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;

        static IllegalFormatWidthException()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/IllegalFormatWidthException");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(I)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getWidth", "()I");
        }

        public IllegalFormatWidthException(int w) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = w } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public IllegalFormatWidthException(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of IllegalFormatWidthException.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetWidth()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(IllegalFormatWidthException wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator IllegalFormatWidthException(IntPtr rawObject)
        {
            return new IllegalFormatWidthException(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class IllegalFormatWidthException
} // end namespace Java.Util
