using System;

using UnityEngine;

namespace Java.Util
{
    public interface Deque<E> : global::Google.LibraryWrapper.Java.JavaInterface, global::Java.Util.Queue<E> where E : class
    {

        void AddFirst(E e);

        void AddLast(E e);

        bool OfferFirst(E e);

        bool OfferLast(E e);

        E RemoveFirst();

        E RemoveLast();

        E PollFirst();

        E PollLast();

        E GetFirst();

        E GetLast();

        E PeekFirst();

        E PeekLast();

        bool RemoveFirstOccurrence(global::Google.LibraryWrapper.Java.JavaObject o);

        bool RemoveLastOccurrence(global::Google.LibraryWrapper.Java.JavaObject o);

        void Push(E e);

        E Pop();

        global::Java.Util.Iterator<E> DescendingIterator();
    } // end class Deque

    public class DequeAnonymousImplementation<E> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Deque<E> where E : class
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
        private static readonly IntPtr _cachedMethodId17;
        private static readonly IntPtr _cachedMethodId18;
        private static readonly IntPtr _cachedMethodId19;
        private static readonly IntPtr _cachedMethodId20;
        private static readonly IntPtr _cachedMethodId21;
        private static readonly IntPtr _cachedMethodId22;
        private static readonly IntPtr _cachedMethodId23;
        private static readonly IntPtr _cachedMethodId24;
        private static readonly IntPtr _cachedMethodId25;
        private static readonly IntPtr _cachedMethodId26;
        private static readonly IntPtr _cachedMethodId27;
        private static readonly IntPtr _cachedMethodId28;
        private static readonly IntPtr _cachedMethodId29;
        private static readonly IntPtr _cachedMethodId30;
        private static readonly IntPtr _cachedMethodId31;
        private static readonly IntPtr _cachedMethodId32;
        private static readonly IntPtr _cachedMethodId33;
        private static readonly IntPtr _cachedMethodId34;

        static DequeAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Deque");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "addFirst", "(Ljava/lang/Object;)V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "addLast", "(Ljava/lang/Object;)V");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "offerFirst", "(Ljava/lang/Object;)Z");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "offerLast", "(Ljava/lang/Object;)Z");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "removeFirst", "()Ljava/lang/Object;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "removeLast", "()Ljava/lang/Object;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "pollFirst", "()Ljava/lang/Object;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "pollLast", "()Ljava/lang/Object;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "getFirst", "()Ljava/lang/Object;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "getLast", "()Ljava/lang/Object;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "peekFirst", "()Ljava/lang/Object;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "peekLast", "()Ljava/lang/Object;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "removeLastOccurrence", "(Ljava/lang/Object;)Z");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "add", "(Ljava/lang/Object;)Z");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "offer", "(Ljava/lang/Object;)Z");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "remove", "()Ljava/lang/Object;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "poll", "()Ljava/lang/Object;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "element", "()Ljava/lang/Object;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "peek", "()Ljava/lang/Object;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "push", "(Ljava/lang/Object;)V");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "pop", "()Ljava/lang/Object;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;)Z");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "contains", "(Ljava/lang/Object;)Z");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "size", "()I");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "iterator", "()Ljava/util/Iterator;");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "descendingIterator", "()Ljava/util/Iterator;");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "containsAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "addAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "removeAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "retainAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
        }

        public DequeAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of DequeAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void AddFirst(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void AddLast(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool OfferFirst(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool OfferLast(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E RemoveFirst()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId4, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E RemoveLast()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId5, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E PollFirst()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId6, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E PollLast()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId7, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E GetFirst()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId8, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E GetLast()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId9, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E PeekFirst()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId10, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E PeekLast()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId11, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RemoveFirstOccurrence(global::Google.LibraryWrapper.Java.JavaObject o)
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

        public bool RemoveLastOccurrence(global::Google.LibraryWrapper.Java.JavaObject o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = o.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId13, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Offer(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Remove()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId16, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Poll()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId17, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Element()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId18, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Peek()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId19, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Push(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Pop()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId21, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId22, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId23, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId24, args_);
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
                return new global::Java.Util.IteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId25, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Iterator<E> DescendingIterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.IteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId26, args_));
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId27, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId28, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId29, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId30, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId31, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId32, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId33, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(DequeAnonymousImplementation<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator DequeAnonymousImplementation<E>(IntPtr rawObject)
        {
            return new DequeAnonymousImplementation<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class DequeAnonymousImplementation

    public abstract class DequeCallbackHelper<E> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Deque<E> where E : class
    {
        public DequeCallbackHelper() : base("java.util.Deque") {}

        public abstract void AddFirst(E e);

        public abstract void AddLast(E e);

        public abstract bool OfferFirst(E e);

        public abstract bool OfferLast(E e);

        public abstract E RemoveFirst();

        public abstract E RemoveLast();

        public abstract E PollFirst();

        public abstract E PollLast();

        public abstract E GetFirst();

        public abstract E GetLast();

        public abstract E PeekFirst();

        public abstract E PeekLast();

        public abstract bool RemoveFirstOccurrence(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract bool RemoveLastOccurrence(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract bool Add(E e);

        public abstract bool Offer(E e);

        public abstract E Remove();

        public abstract E Poll();

        public abstract E Element();

        public abstract E Peek();

        public abstract void Push(E e);

        public abstract E Pop();

        public abstract bool Remove(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract bool Contains(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract int Size();

        public abstract global::Java.Util.Iterator<E> Iterator();

        public abstract global::Java.Util.Iterator<E> DescendingIterator();

        public abstract bool IsEmpty();

        public abstract bool ContainsAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract bool AddAll(global::Java.Util.Collection<E> c);

        public abstract bool RemoveAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract bool RetainAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract void Clear();

        public abstract bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract int HashCode();

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "addFirst" && args.Length == 1)
        {
        AddFirst(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()));
        return null;
        }
        else if (methodName == "addLast" && args.Length == 1)
        {
        AddLast(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()));
        return null;
        }
        else if (methodName == "offerFirst" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(OfferFirst(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "offerLast" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(OfferLast(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "removeFirst" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RemoveFirst());
        }
        else if (methodName == "removeLast" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RemoveLast());
        }
        else if (methodName == "pollFirst" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PollFirst());
        }
        else if (methodName == "pollLast" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PollLast());
        }
        else if (methodName == "getFirst" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(GetFirst());
        }
        else if (methodName == "getLast" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(GetLast());
        }
        else if (methodName == "peekFirst" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PeekFirst());
        }
        else if (methodName == "peekLast" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PeekLast());
        }
        else if (methodName == "removeFirstOccurrence" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RemoveFirstOccurrence(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "removeLastOccurrence" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RemoveLastOccurrence(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "add" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Add(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "offer" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Offer(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "remove" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Remove());
        }
        else if (methodName == "poll" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Poll());
        }
        else if (methodName == "element" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Element());
        }
        else if (methodName == "peek" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Peek());
        }
        else if (methodName == "push" && args.Length == 1)
        {
        Push(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()));
        return null;
        }
        else if (methodName == "pop" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Pop());
        }
        else if (methodName == "remove" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Remove(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "contains" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Contains(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "size" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Size());
        }
        else if (methodName == "iterator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Iterator());
        }
        else if (methodName == "descendingIterator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(DescendingIterator());
        }
        else if (methodName == "isEmpty" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(IsEmpty());
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
    } // end class DequeCallbackHelper
} // end namespace Java.Util
