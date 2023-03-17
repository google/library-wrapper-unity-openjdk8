using System;

using UnityEngine;

namespace Java.Lang
{
    public interface Iterable<T> : global::Google.LibraryWrapper.Java.JavaInterface where T : class
    {
        public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Iterable<T>
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static AnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/Iterable");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "iterator", "()Ljava/util/Iterator;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "forEach", "(Ljava/util/function/Consumer;)V");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "spliterator", "()Ljava/util/Spliterator;");
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

            public global::Java.Util.Iterator<T> Iterator()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {};
                    return new global::Java.Util.Iterator<T>.AnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public void ForEach(global::Java.ExternalType.Java.Util.Function.Consumer<T> action)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {new jvalue { l = action.GetRawObject() }};
                    AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId1, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Util.Spliterator<T> Spliterator()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {};
                    return new global::Java.ExternalType.Java.Util.Spliterator<T>.AnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
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

        public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Iterable<T>
        {
            public CallbackHelper() : base("java.lang.Iterable") {}

            public abstract global::Java.Util.Iterator<T> Iterator();

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            if (methodName == "iterator" && args.Length == 0)
            {
            return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Iterator());
            }
            return base.Invoke(methodName, args);
            }
        } // end class CallbackHelper

        global::Java.Util.Iterator<T> Iterator();
    } // end class Iterable
} // end namespace Java.Lang
