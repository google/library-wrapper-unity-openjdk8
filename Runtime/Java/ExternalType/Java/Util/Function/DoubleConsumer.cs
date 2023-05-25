using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public interface DoubleConsumer : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class DoubleConsumer

    public class DoubleConsumerAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Function.DoubleConsumer
    {
        private static readonly IntPtr _classObject;

        static DoubleConsumerAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/DoubleConsumer");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public DoubleConsumerAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of DoubleConsumerAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(DoubleConsumerAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator DoubleConsumerAnonymousImplementation(IntPtr rawObject)
        {
            return new DoubleConsumerAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class DoubleConsumerAnonymousImplementation

    public abstract class DoubleConsumerCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Function.DoubleConsumer
    {
        public DoubleConsumerCallbackHelper() : base("java.util.function.DoubleConsumer") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class DoubleConsumerCallbackHelper
} // end namespace Java.ExternalType.Java.Util.Function
