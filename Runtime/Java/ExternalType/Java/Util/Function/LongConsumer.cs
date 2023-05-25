using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util.Function
{
    public interface LongConsumer : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class LongConsumer

    public class LongConsumerAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Function.LongConsumer
    {
        private static readonly IntPtr _classObject;

        static LongConsumerAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/function/LongConsumer");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public LongConsumerAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of LongConsumerAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(LongConsumerAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator LongConsumerAnonymousImplementation(IntPtr rawObject)
        {
            return new LongConsumerAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class LongConsumerAnonymousImplementation

    public abstract class LongConsumerCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Function.LongConsumer
    {
        public LongConsumerCallbackHelper() : base("java.util.function.LongConsumer") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class LongConsumerCallbackHelper
} // end namespace Java.ExternalType.Java.Util.Function
