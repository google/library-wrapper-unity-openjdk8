using System;

using UnityEngine;

namespace Java.Util
{
    public class UnknownFormatFlagsException : global::Java.Util.IllegalFormatException
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedMethodId0;

        static UnknownFormatFlagsException()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/UnknownFormatFlagsException");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getFlags", "()Ljava/lang/String;");
        }

        public UnknownFormatFlagsException(global::System.String f) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(f) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public UnknownFormatFlagsException(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of UnknownFormatFlagsException.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetFlags()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(UnknownFormatFlagsException wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator UnknownFormatFlagsException(IntPtr rawObject)
        {
            return new UnknownFormatFlagsException(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class UnknownFormatFlagsException
} // end namespace Java.Util
