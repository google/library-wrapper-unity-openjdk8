using System;

using UnityEngine;

namespace Java.Util
{
    public interface Iterator<E> : global::Google.LibraryWrapper.Java.JavaInterface where E : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;

        static Iterator()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Iterator");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "remove", "()V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "forEachRemaining", "(Ljava/util/function/Consumer;)V");
        }

        bool HasNext();

        E Next();

        void Remove()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(GetRawObject(), _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        void ForEachRemaining(global::Java.ExternalType.Java.Util.Function.Consumer<E> action)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = action.GetRawObject() } };
                AndroidJNI.CallVoidMethod(GetRawObject(), _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }
    } // end class Iterator

    public class IteratorAnonymousImplementation<E> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Iterator<E> where E : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;

        static IteratorAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Iterator");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "hasNext", "()Z");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "next", "()Ljava/lang/Object;");
        }

        public IteratorAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of IteratorAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool HasNext()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Next()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId1, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(IteratorAnonymousImplementation<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator IteratorAnonymousImplementation<E>(IntPtr rawObject)
        {
            return new IteratorAnonymousImplementation<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class IteratorAnonymousImplementation

    public abstract class IteratorCallbackHelper<E> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Iterator<E> where E : class
    {
        public IteratorCallbackHelper() : base("java.util.Iterator") {}

        public abstract bool HasNext();

        public abstract E Next();

        public abstract void Remove();

        public abstract void ForEachRemaining(global::Java.ExternalType.Java.Util.Function.Consumer<E> action);

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
            if (methodName == "hasNext" && args.Length == 0)
            {
                return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HasNext());
            }
            else if (methodName == "next" && args.Length == 0)
            {
                return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Next());
            }
            else if (methodName == "remove" && args.Length == 0)
            {
                Remove();
                return null;
            }
            else if (methodName == "forEachRemaining" && args.Length == 1)
            {
                ForEachRemaining(new global::Java.ExternalType.Java.Util.Function.Consumer<E>(((AndroidJavaObject) args[0]).GetRawObject()));
                return null;
            }
            return base.Invoke(methodName, args);
        }
    } // end class IteratorCallbackHelper
} // end namespace Java.Util
