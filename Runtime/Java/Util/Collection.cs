using System;

using UnityEngine;

namespace Java.Util
{
    public interface Collection<E> : global::Google.LibraryWrapper.Java.JavaInterface, global::Java.Lang.Iterable<E> where E : class
    {

        int Size();

        bool IsEmpty();

        bool Contains(global::Google.LibraryWrapper.Java.JavaObject o);

        bool Add(E e);

        bool Remove(global::Google.LibraryWrapper.Java.JavaObject o);

        bool ContainsAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        bool AddAll(global::Java.Util.Collection<E> c);

        bool RemoveAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        bool RetainAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        void Clear();

        bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

        int HashCode();
    } // end class Collection

    public class CollectionAnonymousImplementation<E> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Collection<E> where E : class
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
        private static readonly IntPtr _cachedMethodId9;
        private static readonly IntPtr _cachedMethodId10;
        private static readonly IntPtr _cachedMethodId11;
        private static readonly IntPtr _cachedMethodId12;
        private static readonly IntPtr _cachedMethodId13;
        private static readonly IntPtr _cachedMethodId14;
        private static readonly IntPtr _cachedMethodId15;
        private static readonly IntPtr _cachedMethodId16;

        static CollectionAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Collection");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "size", "()I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "contains", "(Ljava/lang/Object;)Z");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "iterator", "()Ljava/util/Iterator;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "add", "(Ljava/lang/Object;)Z");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;)Z");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "containsAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "addAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "removeAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "removeIf", "(Ljava/util/function/Predicate;)Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "retainAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "spliterator", "()Ljava/util/Spliterator;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "stream", "()Ljava/util/stream/Stream;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "parallelStream", "()Ljava/util/stream/Stream;");
        }

        public CollectionAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of CollectionAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Size()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsEmpty()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Contains(global::Google.LibraryWrapper.Java.JavaObject o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = o.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Iterator<E> Iterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.IteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Add(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Remove(global::Google.LibraryWrapper.Java.JavaObject o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = o.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ContainsAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool AddAll(global::Java.Util.Collection<E> c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RemoveAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RemoveIf(global::Java.ExternalType.Java.Util.Function.Predicate<E> filter)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = filter.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RetainAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Clear()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Equals(global::Google.LibraryWrapper.Java.JavaObject o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = o.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int HashCode()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Spliterator<E> Spliterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.Stream<E> Stream()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.Stream<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.Stream<E> ParallelStream()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.Stream<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(CollectionAnonymousImplementation<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator CollectionAnonymousImplementation<E>(IntPtr rawObject)
        {
            return new CollectionAnonymousImplementation<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class CollectionAnonymousImplementation

    public abstract class CollectionCallbackHelper<E> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Collection<E> where E : class
    {
        public CollectionCallbackHelper() : base("java.util.Collection") {}

        public abstract int Size();

        public abstract bool IsEmpty();

        public abstract bool Contains(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract global::Java.Util.Iterator<E> Iterator();

        public abstract bool Add(E e);

        public abstract bool Remove(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract bool ContainsAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract bool AddAll(global::Java.Util.Collection<E> c);

        public abstract bool RemoveAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract bool RetainAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract void Clear();

        public abstract bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract int HashCode();

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "size" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Size());
        }
        else if (methodName == "isEmpty" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(IsEmpty());
        }
        else if (methodName == "contains" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Contains(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "iterator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Iterator());
        }
        else if (methodName == "add" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Add(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "remove" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Remove(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "containsAll" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(ContainsAll(new global::Java.Util.CollectionAnonymousImplementation<global::Google.LibraryWrapper.Java.JavaObject>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "addAll" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(AddAll(new global::Java.Util.CollectionAnonymousImplementation<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "removeAll" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RemoveAll(new global::Java.Util.CollectionAnonymousImplementation<global::Google.LibraryWrapper.Java.JavaObject>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "retainAll" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RetainAll(new global::Java.Util.CollectionAnonymousImplementation<global::Google.LibraryWrapper.Java.JavaObject>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "clear" && args.Length == 0)
        {
        Clear();
        return null;
        }
        else if (methodName == "equals" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Equals(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "hashCode" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HashCode());
        }
        return base.Invoke(methodName, args);
        }
    } // end class CollectionCallbackHelper
} // end namespace Java.Util
