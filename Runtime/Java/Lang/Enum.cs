using System;

using UnityEngine;

namespace Java.Lang
{
    public class Enum<E> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Lang.Comparable<E>, global::Java.ExternalType.Java.Io.Serializable where E : global::Java.Lang.Enum<E>
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;
        private static readonly IntPtr _cachedMethodId5;
        private static readonly IntPtr _cachedMethodId6;

        static Enum()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Enum");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "name", "()Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "ordinal", "()I");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Enum;)I");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "getDeclaringClass", "()Ljava/lang/Class;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
        }

        public Enum(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Enum.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Name()
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

        public int Ordinal()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Equals(global::Google.LibraryWrapper.Java.JavaObject other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = other.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId2, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(E o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(o) };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<E> GetDeclaringClass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Class<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static T ValueOf<T>(global::Java.Lang.Class<T> enumType, global::System.String name) where T : global::Java.Lang.Enum<T>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = enumType.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) }
                        };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId6, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Enum<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Enum<E>(IntPtr rawObject)
        {
            return new Enum<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Enum
} // end namespace Java.Lang
