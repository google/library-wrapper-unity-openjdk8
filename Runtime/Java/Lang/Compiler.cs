using System;

using UnityEngine;

namespace Java.Lang
{
    public class Compiler : global::Google.LibraryWrapper.Java.JavaObject
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;

        static Compiler()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Compiler");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "compileClass", "(Ljava/lang/Class;)Z");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "compileClasses", "(Ljava/lang/String;)Z");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "command", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "enable", "()V");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "disable", "()V");
        }

        public Compiler(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Compiler.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool CompileClass(global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> clazz)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = clazz.GetRawObject() } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool CompileClasses(global::System.String @string)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(@string) } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Google.LibraryWrapper.Java.JavaObject Command(global::Google.LibraryWrapper.Java.JavaObject any)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = any.GetRawObject() } };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Enable()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Disable()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Compiler wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Compiler(IntPtr rawObject)
        {
            return new Compiler(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Compiler
} // end namespace Java.Lang
