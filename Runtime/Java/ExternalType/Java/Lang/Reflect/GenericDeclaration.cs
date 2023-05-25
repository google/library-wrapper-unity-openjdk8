using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang.Reflect
{
    public interface GenericDeclaration : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class GenericDeclaration

    public class GenericDeclarationAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Lang.Reflect.GenericDeclaration
    {
        private static readonly IntPtr _classObject;

        static GenericDeclarationAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/reflect/GenericDeclaration");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public GenericDeclarationAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of GenericDeclarationAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(GenericDeclarationAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator GenericDeclarationAnonymousImplementation(IntPtr rawObject)
        {
            return new GenericDeclarationAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class GenericDeclarationAnonymousImplementation

    public abstract class GenericDeclarationCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Lang.Reflect.GenericDeclaration
    {
        public GenericDeclarationCallbackHelper() : base("java.lang.reflect.GenericDeclaration") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class GenericDeclarationCallbackHelper
} // end namespace Java.ExternalType.Java.Lang.Reflect
