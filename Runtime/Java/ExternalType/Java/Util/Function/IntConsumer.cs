using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public interface IntConsumer : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class IntConsumer

    public class IntConsumerAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Function.IntConsumer
    {
        private static readonly IntPtr _classObject;

        static IntConsumerAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/IntConsumer");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public IntConsumerAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of IntConsumerAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(IntConsumerAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator IntConsumerAnonymousImplementation(IntPtr rawObject)
        {
            return new IntConsumerAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class IntConsumerAnonymousImplementation

    public abstract class IntConsumerCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Function.IntConsumer
    {
        public IntConsumerCallbackHelper() : base("java.util.function.IntConsumer") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class IntConsumerCallbackHelper
} // end namespace Java.ExternalType.Java.Util.Function
