using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang.Reflect
{
    public interface AnnotatedElement : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class AnnotatedElement

    public class AnnotatedElementAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Lang.Reflect.AnnotatedElement
    {
        private static readonly IntPtr _classObject;

        static AnnotatedElementAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/reflect/AnnotatedElement");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public AnnotatedElementAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of AnnotatedElementAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(AnnotatedElementAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator AnnotatedElementAnonymousImplementation(IntPtr rawObject)
        {
            return new AnnotatedElementAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class AnnotatedElementAnonymousImplementation

    public abstract class AnnotatedElementCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Lang.Reflect.AnnotatedElement
    {
        public AnnotatedElementCallbackHelper() : base("java.lang.reflect.AnnotatedElement") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class AnnotatedElementCallbackHelper
} // end namespace Java.ExternalType.Java.Lang.Reflect
