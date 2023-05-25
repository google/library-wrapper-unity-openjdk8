using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang.Reflect
{
    public interface Type : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class Type

    public class TypeAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Lang.Reflect.Type
    {
        private static readonly IntPtr _classObject;

        static TypeAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/reflect/Type");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public TypeAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of TypeAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(TypeAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator TypeAnonymousImplementation(IntPtr rawObject)
        {
            return new TypeAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class TypeAnonymousImplementation

    public abstract class TypeCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Lang.Reflect.Type
    {
        public TypeCallbackHelper() : base("java.lang.reflect.Type") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class TypeCallbackHelper
} // end namespace Java.ExternalType.Java.Lang.Reflect
