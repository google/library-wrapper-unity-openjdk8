using System;

using UnityEngine;

namespace Java.Util
{
    public class Vector<E> : global::Java.Util.AbstractList<E>, global::Java.Util.List<E>, global::Java.Util.RandomAccess, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Io.Serializable where E : class
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
        private static readonly IntPtr _cachedMethodId19;
        private static readonly IntPtr _cachedMethodId20;
        private static readonly IntPtr _cachedMethodId21;

        static Vector()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Vector");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(II)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(I)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Collection;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "trimToSize", "()V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "ensureCapacity", "(I)V");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "setSize", "(I)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "capacity", "()I");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "elements", "()Ljava/util/Enumeration;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(Ljava/lang/Object;I)I");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(Ljava/lang/Object;I)I");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "elementAt", "(I)Ljava/lang/Object;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "firstElement", "()Ljava/lang/Object;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "lastElement", "()Ljava/lang/Object;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "setElementAt", "(Ljava/lang/Object;I)V");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "removeElementAt", "(I)V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "insertElementAt", "(Ljava/lang/Object;I)V");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "addElement", "(Ljava/lang/Object;)V");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "removeElement", "(Ljava/lang/Object;)Z");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "removeAllElements", "()V");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "forEach", "(Ljava/util/function/Consumer;)V");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "removeIf", "(Ljava/util/function/Predicate;)Z");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "replaceAll", "(Ljava/util/function/UnaryOperator;)V");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "sort", "(Ljava/util/Comparator;)V");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "spliterator", "()Ljava/util/Spliterator;");
        }

        public Vector(int initialCapacity, int capacityIncrement) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = initialCapacity },
                            new jvalue { i = capacityIncrement }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Vector(int initialCapacity) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = initialCapacity } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Vector() : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Vector(global::Java.Util.Collection<E> c) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Vector(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Vector.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void TrimToSize()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void EnsureCapacity(int minCapacity)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = minCapacity } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetSize(int newSize)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = newSize } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Capacity()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Enumeration<E> Elements()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.EnumerationAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(global::Google.LibraryWrapper.Java.JavaObject o, int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = o.GetRawObject() },
                            new jvalue { i = index }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(global::Google.LibraryWrapper.Java.JavaObject o, int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = o.GetRawObject() },
                            new jvalue { i = index }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public E ElementAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
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

        public E FirstElement()
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

        public E LastElement()
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

        public void SetElementAt(E obj, int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(obj),
                            new jvalue { i = index }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void RemoveElementAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void InsertElementAt(E obj, int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(obj),
                            new jvalue { i = index }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void AddElement(E obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(obj) };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool RemoveElement(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void RemoveAllElements()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId15, args_);
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
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void ForEach(global::Java.ExternalType.Java.Util.Function.Consumer<E> action)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = action.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId17, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void ReplaceAll(global::Java.ExternalType.Java.Util.Function.UnaryOperator<E> @operator)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = @operator.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Sort(global::Java.Util.Comparator<E> c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId20, args_);
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
                return new global::Java.ExternalType.Java.Util.SpliteratorAnonymousImplementation<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Vector<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Vector<E>(IntPtr rawObject)
        {
            return new Vector<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Vector
} // end namespace Java.Util
