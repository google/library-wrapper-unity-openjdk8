using System;

using UnityEngine;

namespace Java.Util
{
    public interface Observer : global::Google.LibraryWrapper.Java.JavaInterface
    {
        public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Observer
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedMethodId0;

            static AnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Observer");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V");
            }

            public AnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public void Update(global::Java.Util.Observable o, global::Google.LibraryWrapper.Java.JavaObject arg)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {new jvalue { l = o.GetRawObject() }, new jvalue { l = arg.GetRawObject() }};
                    AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(AnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AnonymousImplementation(IntPtr rawObject)
            {
                return new AnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AnonymousImplementation

        public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Observer
        {
            public CallbackHelper() : base("java.util.Observer") {}

            public abstract void Update(global::Java.Util.Observable o, global::Google.LibraryWrapper.Java.JavaObject arg);

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            if (methodName == "update" && args.Length == 2)
            {
            Update(new global::Java.Util.Observable(((AndroidJavaObject) args[0]).GetRawObject()), new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[1]).GetRawObject()));
            return null;
            }
            return base.Invoke(methodName, args);
            }
        } // end class CallbackHelper

        void Update(global::Java.Util.Observable o, global::Google.LibraryWrapper.Java.JavaObject arg);
    } // end class Observer
} // end namespace Java.Util
