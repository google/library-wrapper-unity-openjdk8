using System;

using UnityEngine;

namespace Java.Util
{
    public interface EventListener : global::Google.LibraryWrapper.Java.JavaInterface
    {
    } // end class EventListener

    public class EventListenerAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.EventListener
    {
        private static readonly IntPtr _classObject;

        static EventListenerAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/EventListener");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public EventListenerAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of EventListenerAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(EventListenerAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator EventListenerAnonymousImplementation(IntPtr rawObject)
        {
            return new EventListenerAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class EventListenerAnonymousImplementation

    public abstract class EventListenerCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.EventListener
    {
        public EventListenerCallbackHelper() : base("java.util.EventListener") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class EventListenerCallbackHelper
} // end namespace Java.Util
