using System;

using UnityEngine;

namespace Java.Util
{
    public class TreeMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.NavigableMap<K, V>, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Io.Serializable where K : class where V : class
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
        private static readonly IntPtr _cachedMethodId22;
        private static readonly IntPtr _cachedMethodId23;
        private static readonly IntPtr _cachedMethodId24;
        private static readonly IntPtr _cachedMethodId25;
        private static readonly IntPtr _cachedMethodId26;
        private static readonly IntPtr _cachedMethodId27;
        private static readonly IntPtr _cachedMethodId28;

        static TreeMap()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/TreeMap");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Comparator;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Map;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/SortedMap;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "comparator", "()Ljava/util/Comparator;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "firstKey", "()Ljava/lang/Object;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "lastKey", "()Ljava/lang/Object;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "firstEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "lastEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "pollFirstEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "pollLastEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "navigableKeySet", "()Ljava/util/NavigableSet;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "descendingKeySet", "()Ljava/util/NavigableSet;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "descendingMap", "()Ljava/util/NavigableMap;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "forEach", "(Ljava/util/function/BiConsumer;)V");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "replaceAll", "(Ljava/util/function/BiFunction;)V");
        }

        public TreeMap() : base(IntPtr.Zero)
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

        public TreeMap(global::Java.Util.Comparator<K> comparator) : base(IntPtr.Zero)
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

        public TreeMap(global::Java.Util.Map<K, V> m) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = m.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public TreeMap(global::Java.Util.SortedMap<K, V> m) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = m.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public TreeMap(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of TreeMap.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Comparator<K> Comparator()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.ComparatorAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public K FirstKey()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(K) == typeof(global::System.String))
                {
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId1, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public K LastKey()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(K) == typeof(global::System.String))
                {
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId2, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
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
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> FirstEntry()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> LastEntry()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> PollFirstEntry()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> PollLastEntry()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> LowerEntry(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public K LowerKey(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                if (typeof(K) == typeof(global::System.String))
                {
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId9, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> FloorEntry(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public K FloorKey(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                if (typeof(K) == typeof(global::System.String))
                {
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId11, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> CeilingEntry(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public K CeilingKey(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                if (typeof(K) == typeof(global::System.String))
                {
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId13, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map.Entry<K, V> HigherEntry(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public K HigherKey(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                if (typeof(K) == typeof(global::System.String))
                {
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId15, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableSet<K> NavigableKeySet()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.NavigableSetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableSet<K> DescendingKeySet()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.NavigableSetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableMap<K, V> DescendingMap()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(fromKey),
                            new jvalue { z = fromInclusive },
                            ToJvalue(toKey),
                            new jvalue { z = toInclusive }
                        };
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableMap<K, V> HeadMap(K toKey, bool inclusive)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(toKey),
                            new jvalue { z = inclusive }
                        };
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId20, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.NavigableMap<K, V> TailMap(K fromKey, bool inclusive)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(fromKey),
                            new jvalue { z = inclusive }
                        };
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.SortedMap<K, V> SubMap(K fromKey, K toKey)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(fromKey),
                            ToJvalue(toKey)
                        };
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId22, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.SortedMap<K, V> HeadMap(K toKey)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(toKey) };
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId23, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.SortedMap<K, V> TailMap(K fromKey)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(fromKey) };
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId24, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Replace(K key, V oldValue, V newValue)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(key),
                            ToJvalue(oldValue),
                            ToJvalue(newValue)
                        };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V Replace(K key, V value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(key),
                            ToJvalue(value)
                        };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId26, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId26, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void ForEach(global::Java.ExternalType.Java.Util.Function.BiConsumer<K, V> action)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = action.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void ReplaceAll(global::Java.ExternalType.Java.Util.Function.BiFunction<K, V, V> function)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = function.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(TreeMap<K, V> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator TreeMap<K, V>(IntPtr rawObject)
        {
            return new TreeMap<K, V>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class TreeMap
} // end namespace Java.Util
