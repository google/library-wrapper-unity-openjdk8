using System;

using UnityEngine;

namespace Java.Util
{
    public interface NavigableSet<E> : global::Google.LibraryWrapper.Java.JavaInterface, global::Java.Util.SortedSet<E> where E : class
    {

        E Lower(E e);

        E Floor(E e);

        E Ceiling(E e);

        E Higher(E e);

        E PollFirst();

        E PollLast();

        global::Java.Util.NavigableSet<E> DescendingSet();

        global::Java.Util.Iterator<E> DescendingIterator();

        global::Java.Util.NavigableSet<E> SubSet(E fromElement, bool fromInclusive, E toElement, bool toInclusive);

        global::Java.Util.NavigableSet<E> HeadSet(E toElement, bool inclusive);

        global::Java.Util.NavigableSet<E> TailSet(E fromElement, bool inclusive);
    } // end class NavigableSet

    public class NavigableSetAnonymousImplementation<E> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.NavigableSet<E> where E : class
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

        static NavigableSetAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/NavigableSet");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "pollFirst", "()Ljava/lang/Object;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "pollLast", "()Ljava/lang/Object;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "iterator", "()Ljava/util/Iterator;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "descendingSet", "()Ljava/util/NavigableSet;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "descendingIterator", "()Ljava/util/Iterator;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "comparator", "()Ljava/util/Comparator;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "first", "()Ljava/lang/Object;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "last", "()Ljava/lang/Object;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "size", "()I");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "contains", "(Ljava/lang/Object;)Z");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "add", "(Ljava/lang/Object;)Z");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;)Z");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "containsAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "addAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "retainAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "removeAll", "(Ljava/util/Collection;)Z");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
        }

        public NavigableSetAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of NavigableSetAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Lower(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId0, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Floor(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
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

        public E Ceiling(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId2, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E Higher(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
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

        public E PollFirst()
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

        public E PollLast()
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

        public global::Java.Util.Iterator<E> Iterator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.IteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableSet<E> DescendingSet()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
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
                return new global::Java.Util.IteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableSet<E> SubSet(E fromElement, bool fromInclusive, E toElement, bool toInclusive)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(fromElement),
                            new jvalue { z = fromInclusive },
                            ToJvalue(toElement),
                            new jvalue { z = toInclusive }
                        };
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableSet<E> HeadSet(E toElement, bool inclusive)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(toElement),
                            new jvalue { z = inclusive }
                        };
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableSet<E> TailSet(E fromElement, bool inclusive)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(fromElement),
                            new jvalue { z = inclusive }
                        };
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.SortedSet<E> SubSet(E fromElement, E toElement)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(fromElement),
                            ToJvalue(toElement)
                        };
                return new global::Java.Util.SortedSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.SortedSet<E> HeadSet(E toElement)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(toElement) };
                return new global::Java.Util.SortedSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.SortedSet<E> TailSet(E fromElement)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(fromElement) };
                return new global::Java.Util.SortedSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<E> Comparator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.ComparatorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E First()
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

        public E Last()
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

        public int Size()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId18, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId19, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId20, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId21, args_);
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

        public bool ContainsAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId23, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId24, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId25, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId26, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId27, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId28, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(NavigableSetAnonymousImplementation<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator NavigableSetAnonymousImplementation<E>(IntPtr rawObject)
        {
            return new NavigableSetAnonymousImplementation<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class NavigableSetAnonymousImplementation

    public abstract class NavigableSetCallbackHelper<E> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.NavigableSet<E> where E : class
    {
        public NavigableSetCallbackHelper() : base("java.util.NavigableSet") {}

        public abstract E Lower(E e);

        public abstract E Floor(E e);

        public abstract E Ceiling(E e);

        public abstract E Higher(E e);

        public abstract E PollFirst();

        public abstract E PollLast();

        public abstract global::Java.Util.Iterator<E> Iterator();

        public abstract global::Java.Util.NavigableSet<E> DescendingSet();

        public abstract global::Java.Util.Iterator<E> DescendingIterator();

        public abstract global::Java.Util.NavigableSet<E> SubSet(E fromElement, bool fromInclusive, E toElement, bool toInclusive);

        public abstract global::Java.Util.NavigableSet<E> HeadSet(E toElement, bool inclusive);

        public abstract global::Java.Util.NavigableSet<E> TailSet(E fromElement, bool inclusive);

        public abstract global::Java.Util.SortedSet<E> SubSet(E fromElement, E toElement);

        public abstract global::Java.Util.SortedSet<E> HeadSet(E toElement);

        public abstract global::Java.Util.SortedSet<E> TailSet(E fromElement);

        public abstract global::Java.Util.Comparator<E> Comparator();

        public abstract E First();

        public abstract E Last();

        public abstract int Size();

        public abstract bool IsEmpty();

        public abstract bool Contains(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract bool Add(E e);

        public abstract bool Remove(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract bool ContainsAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract bool AddAll(global::Java.Util.Collection<E> c);

        public abstract bool RetainAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract bool RemoveAll(global::Java.Util.Collection<global::Google.LibraryWrapper.Java.JavaObject> c);

        public abstract void Clear();

        public abstract bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract int HashCode();

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "lower" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Lower(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "floor" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Floor(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "ceiling" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Ceiling(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "higher" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Higher(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "pollFirst" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PollFirst());
        }
        else if (methodName == "pollLast" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PollLast());
        }
        else if (methodName == "iterator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Iterator());
        }
        else if (methodName == "descendingSet" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(DescendingSet());
        }
        else if (methodName == "descendingIterator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(DescendingIterator());
        }
        else if (methodName == "subSet" && args.Length == 4)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(SubSet(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()), (bool) args[1], args[2] is global::System.String ? (E) (global::System.Object) args[2] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[2]).GetRawObject()), (bool) args[3]));
        }
        else if (methodName == "headSet" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HeadSet(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()), (bool) args[1]));
        }
        else if (methodName == "tailSet" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(TailSet(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()), (bool) args[1]));
        }
        else if (methodName == "subSet" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(SubSet(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject()), args[1] is global::System.String ? (E) (global::System.Object) args[1] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[1]).GetRawObject())));
        }
        else if (methodName == "headSet" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HeadSet(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "tailSet" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(TailSet(args[0] is global::System.String ? (E) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<E>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "comparator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Comparator());
        }
        else if (methodName == "first" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(First());
        }
        else if (methodName == "last" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Last());
        }
        else if (methodName == "size" && args.Length == 0)
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
        else if (methodName == "retainAll" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RetainAll(new global::Java.Util.CollectionAnonymousImplementation<global::Google.LibraryWrapper.Java.JavaObject>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "removeAll" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(RemoveAll(new global::Java.Util.CollectionAnonymousImplementation<global::Google.LibraryWrapper.Java.JavaObject>(((AndroidJavaObject) args[0]).GetRawObject())));
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
    } // end class NavigableSetCallbackHelper
} // end namespace Java.Util
