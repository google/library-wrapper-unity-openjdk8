using System;

using UnityEngine;

namespace Java.Util
{
    public class IllegalFormatConversionException : global::Java.Util.IllegalFormatException
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;

        static IllegalFormatConversionException()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/IllegalFormatConversionException");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(CLjava/lang/Class;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getConversion", "()C");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getArgumentClass", "()Ljava/lang/Class;");
        }

        public IllegalFormatConversionException(char c, global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> arg) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { c = c },
                            new jvalue { l = arg.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public IllegalFormatConversionException(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of IllegalFormatConversionException.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public char GetConversion()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallCharMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> GetArgumentClass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(IllegalFormatConversionException wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator IllegalFormatConversionException(IntPtr rawObject)
        {
            return new IllegalFormatConversionException(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class IllegalFormatConversionException
} // end namespace Java.Util
