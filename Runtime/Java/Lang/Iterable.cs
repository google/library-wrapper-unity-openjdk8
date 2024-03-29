using System;

using UnityEngine;

namespace Java.Lang
{
    public interface Iterable<T> : global::Google.LibraryWrapper.Java.JavaInterface where T : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;

        static Iterable()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Iterable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "forEach", "(Ljava/util/function/Consumer;)V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "spliterator", "()Ljava/util/Spliterator;");
        }

        global::Java.Util.Iterator<T> Iterator();

        void ForEach(global::Java.ExternalType.Java.Util.Function.Consumer<T> action)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = action.GetRawObject() } };
                AndroidJNI.CallVoidMethod(GetRawObject(), _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        global::Java.ExternalType.Java.Util.Spliterator<T> Spliterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(GetRawObject(), _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }
    } // end class Iterable

    public class IterableAnonymousImplementation<T> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Iterable<T> where T : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;

        static IterableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Iterable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "iterator", "()Ljava/util/Iterator;");
        }

        public IterableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of IterableAnonymousImplementation.");
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
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.IteratorAnonymousImplementation<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(IterableAnonymousImplementation<T> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator IterableAnonymousImplementation<T>(IntPtr rawObject)
        {
            return new IterableAnonymousImplementation<T>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class IterableAnonymousImplementation

    public abstract class IterableCallbackHelper<T> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Iterable<T> where T : class
    {
        public IterableCallbackHelper() : base("java.lang.Iterable") {}

        public abstract global::Java.Util.Iterator<T> Iterator();

        public abstract void ForEach(global::Java.ExternalType.Java.Util.Function.Consumer<T> action);

        public abstract global::Java.ExternalType.Java.Util.Spliterator<T> Spliterator();

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
            if (methodName == "iterator" && args.Length == 0)
            {
                return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Iterator());
            }
            else if (methodName == "forEach" && args.Length == 1)
            {
                ForEach(new global::Java.ExternalType.Java.Util.Function.Consumer<T>(((AndroidJavaObject) args[0]).GetRawObject()));
                return null;
            }
            else if (methodName == "spliterator" && args.Length == 0)
            {
                return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Spliterator());
            }
            return base.Invoke(methodName, args);
        }
    } // end class IterableCallbackHelper
} // end namespace Java.Lang
