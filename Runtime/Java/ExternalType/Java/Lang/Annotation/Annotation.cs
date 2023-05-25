using System;

using UnityEngine;

namespace Java.ExternalType.Java.Lang.Annotation
{
    public interface Annotation : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class Annotation

    public class AnnotationAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Lang.Annotation.Annotation
    {
        private static readonly IntPtr _classObject;

        static AnnotationAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/annotation/Annotation");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public AnnotationAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of AnnotationAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(AnnotationAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator AnnotationAnonymousImplementation(IntPtr rawObject)
        {
            return new AnnotationAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class AnnotationAnonymousImplementation

    public abstract class AnnotationCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Lang.Annotation.Annotation
    {
        public AnnotationCallbackHelper() : base("java.lang.annotation.Annotation") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class AnnotationCallbackHelper
} // end namespace Java.ExternalType.Java.Lang.Annotation
