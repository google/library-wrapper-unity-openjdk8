using System;

using UnityEngine;

namespace Java.Util
{
    public interface ListIterator<E> : global::Google.LibraryWrapper.Java.JavaInterface, global::Java.Util.Iterator<E> where E : class
    {

        bool HasPrevious();

        E Previous();

        int NextIndex();

        int PreviousIndex();

        void Remove();

        void Set(E e);

        void Add(E e);
    } // end class ListIterator

    public class ListIteratorAnonymousImplementation<E> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.ListIterator<E> where E : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;
        private static readonly IntPtr _cachedMethodId5;
        private static readonly IntPtr _cachedMethodId6;
        private static readonly IntPtr _cachedMethodId7;
        private static readonly IntPtr _cachedMethodId8;

        static ListIteratorAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/ListIterator");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "hasNext", "()Z");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "next", "()Ljava/lang/Object;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "hasPrevious", "()Z");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "previous", "()Ljava/lang/Object;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "nextIndex", "()I");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "previousIndex", "()I");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "remove", "()V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "set", "(Ljava/lang/Object;)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "add", "(Ljava/lang/Object;)V");
        }

        public ListIteratorAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of ListIteratorAnonymousImplementation.");
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

        public bool HasPrevious()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Previous()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId3, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int NextIndex()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int PreviousIndex()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Remove()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Set(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Add(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(ListIteratorAnonymousImplementation<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator ListIteratorAnonymousImplementation<E>(IntPtr rawObject)
        {
            return new ListIteratorAnonymousImplementation<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class ListIteratorAnonymousImplementation

    public abstract class ListIteratorCallbackHelper<E> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.ListIterator<E> where E : class
    {
        public ListIteratorCallbackHelper() : base("java.util.ListIterator") {}

        public abstract bool HasNext();

        public abstract E Next();

        public abstract bool HasPrevious();

        public abstract E Previous();

        public abstract int NextIndex();

        public abstract int PreviousIndex();

        public abstract void Remove();

        public abstract void Set(E e);

        public abstract void Add(E e);

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
        else if (methodName == "hasPrevious" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HasPrevious());
        }
        else if (methodName == "previous" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Previous());
        }
        else if (methodName == "nextIndex" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(NextIndex());
        }
        else if (methodName == "previousIndex" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PreviousIndex());
        }
        else if (methodName == "remove" && args.Length == 0)
        {
        Remove();
        return null;
        }
        else if (methodName == "set" && args.Length == 1)
        {
        Set(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()));
        return null;
        }
        else if (methodName == "add" && args.Length == 1)
        {
        Add(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()));
        return null;
        }
        return base.Invoke(methodName, args);
        }
    } // end class ListIteratorCallbackHelper
} // end namespace Java.Util
