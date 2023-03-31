using System;

using UnityEngine;

namespace Java.Util
{
    public class TreeSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.NavigableSet<E>, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Io.Serializable where E : class
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
        private static readonly IntPtr _cachedConstructorId2;
        private static readonly IntPtr _cachedConstructorId3;
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

        static TreeSet()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/TreeSet");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Comparator;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Collection;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/SortedSet;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "descendingIterator", "()Ljava/util/Iterator;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "descendingSet", "()Ljava/util/NavigableSet;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "comparator", "()Ljava/util/Comparator;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "first", "()Ljava/lang/Object;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "last", "()Ljava/lang/Object;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "pollFirst", "()Ljava/lang/Object;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "pollLast", "()Ljava/lang/Object;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "spliterator", "()Ljava/util/Spliterator;");
        }

        public TreeSet() : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public TreeSet(global::Java.Util.Comparator<E> comparator) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = comparator.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public TreeSet(global::Java.Util.Collection<E> c) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public TreeSet(global::Java.Util.SortedSet<E> s) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public TreeSet(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of TreeSet.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
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
                return new global::Java.Util.IteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
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
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
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
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
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
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
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
                return new global::Java.Util.NavigableSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
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
                return new global::Java.Util.SortedSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
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
                return new global::Java.Util.SortedSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
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
                return new global::Java.Util.SortedSetAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
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
                return new global::Java.Util.ComparatorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
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

        public E Last()
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

        public E Lower(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
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

        public E Floor(E e)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                if (typeof(E) == typeof(global::System.String))
                {
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId12, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_);
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
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId13, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_);
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
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId14, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_);
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
                    return (E) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId15, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_);
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

        public global::Google.LibraryWrapper.Java.JavaObject Clone()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_));
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
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(TreeSet<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator TreeSet<E>(IntPtr rawObject)
        {
            return new TreeSet<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class TreeSet
} // end namespace Java.Util
