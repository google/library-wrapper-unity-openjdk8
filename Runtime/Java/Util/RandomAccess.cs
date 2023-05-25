using System;

using UnityEngine;

namespace Java.Util
{
    public interface RandomAccess : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class RandomAccess

    public class RandomAccessAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.RandomAccess
    {
        private static readonly IntPtr _classObject;

        static RandomAccessAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/RandomAccess");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public RandomAccessAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of RandomAccessAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(RandomAccessAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator RandomAccessAnonymousImplementation(IntPtr rawObject)
        {
            return new RandomAccessAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class RandomAccessAnonymousImplementation

    public abstract class RandomAccessCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.RandomAccess
    {
        public RandomAccessCallbackHelper() : base("java.util.RandomAccess") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class RandomAccessCallbackHelper
} // end namespace Java.Util
