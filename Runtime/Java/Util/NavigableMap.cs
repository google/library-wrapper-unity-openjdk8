using System;

using UnityEngine;

namespace Java.Util
{
    public interface NavigableMap<K, V> : global::Google.LibraryWrapper.Java.JavaInterface, global::Java.Util.SortedMap<K, V> where K : class where V : class
    {

        global::Java.Util.Map.Entry<K, V> LowerEntry(K key);

        K LowerKey(K key);

        global::Java.Util.Map.Entry<K, V> FloorEntry(K key);

        K FloorKey(K key);

        global::Java.Util.Map.Entry<K, V> CeilingEntry(K key);

        K CeilingKey(K key);

        global::Java.Util.Map.Entry<K, V> HigherEntry(K key);

        K HigherKey(K key);

        global::Java.Util.Map.Entry<K, V> FirstEntry();

        global::Java.Util.Map.Entry<K, V> LastEntry();

        global::Java.Util.Map.Entry<K, V> PollFirstEntry();

        global::Java.Util.Map.Entry<K, V> PollLastEntry();

        global::Java.Util.NavigableMap<K, V> DescendingMap();

        global::Java.Util.NavigableSet<K> NavigableKeySet();

        global::Java.Util.NavigableSet<K> DescendingKeySet();

        global::Java.Util.NavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive);

        global::Java.Util.NavigableMap<K, V> HeadMap(K toKey, bool inclusive);

        global::Java.Util.NavigableMap<K, V> TailMap(K fromKey, bool inclusive);
    } // end class NavigableMap

    public class NavigableMapAnonymousImplementation<K, V> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.NavigableMap<K, V> where K : class where V : class
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
        private static readonly IntPtr _cachedMethodId35;
        private static readonly IntPtr _cachedMethodId36;
        private static readonly IntPtr _cachedMethodId37;

        static NavigableMapAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/NavigableMap");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "firstEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "lastEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "pollFirstEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "pollLastEntry", "()Ljava/util/Map$Entry;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "descendingMap", "()Ljava/util/NavigableMap;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "navigableKeySet", "()Ljava/util/NavigableSet;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "descendingKeySet", "()Ljava/util/NavigableSet;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "comparator", "()Ljava/util/Comparator;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "firstKey", "()Ljava/lang/Object;");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "lastKey", "()Ljava/lang/Object;");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "keySet", "()Ljava/util/Set;");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "values", "()Ljava/util/Collection;");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "entrySet", "()Ljava/util/Set;");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "size", "()I");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "containsKey", "(Ljava/lang/Object;)Z");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "containsValue", "(Ljava/lang/Object;)Z");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "putAll", "(Ljava/util/Map;)V");
            _cachedMethodId35 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId36 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId37 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
        }

        public NavigableMapAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of NavigableMapAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
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

        public global::Java.Util.Map.Entry<K, V> FloorEntry(K key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(key) };
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
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
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId3, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_);
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
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
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId5, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_);
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
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
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId7, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
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
                return new global::Java.Util.Map.EntryAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
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
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
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
                return new global::Java.Util.NavigableSetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_));
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
                return new global::Java.Util.NavigableSetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
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
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_));
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
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
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
                return new global::Java.Util.NavigableMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_));
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
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_));
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
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_));
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
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId20, args_));
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
                return new global::Java.Util.ComparatorAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_));
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
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId22, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId22, args_);
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
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId23, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId23, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<K> KeySet()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.SetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId24, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Collection<V> Values()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.CollectionAnonymousImplementation<V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId25, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Set<global::Java.Util.Map.Entry<K, V>> EntrySet()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.SetAnonymousImplementation<global::Java.Util.Map.Entry<K, V>>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId26, args_));
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId27, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ContainsKey(global::Google.LibraryWrapper.Java.JavaObject key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = key.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ContainsValue(global::Google.LibraryWrapper.Java.JavaObject value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = value.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V Get(global::Google.LibraryWrapper.Java.JavaObject key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = key.GetRawObject() } };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId31, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId31, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V Put(K key, V value)
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId32, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId32, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V Remove(global::Google.LibraryWrapper.Java.JavaObject key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = key.GetRawObject() } };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId33, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId33, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void PutAll(global::Java.Util.Map<K, V> m)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = m.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId34, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId35, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId36, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId37, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(NavigableMapAnonymousImplementation<K, V> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator NavigableMapAnonymousImplementation<K, V>(IntPtr rawObject)
        {
            return new NavigableMapAnonymousImplementation<K, V>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class NavigableMapAnonymousImplementation

    public abstract class NavigableMapCallbackHelper<K, V> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.NavigableMap<K, V> where K : class where V : class
    {
        public NavigableMapCallbackHelper() : base("java.util.NavigableMap") {}

        public abstract global::Java.Util.Map.Entry<K, V> LowerEntry(K key);

        public abstract K LowerKey(K key);

        public abstract global::Java.Util.Map.Entry<K, V> FloorEntry(K key);

        public abstract K FloorKey(K key);

        public abstract global::Java.Util.Map.Entry<K, V> CeilingEntry(K key);

        public abstract K CeilingKey(K key);

        public abstract global::Java.Util.Map.Entry<K, V> HigherEntry(K key);

        public abstract K HigherKey(K key);

        public abstract global::Java.Util.Map.Entry<K, V> FirstEntry();

        public abstract global::Java.Util.Map.Entry<K, V> LastEntry();

        public abstract global::Java.Util.Map.Entry<K, V> PollFirstEntry();

        public abstract global::Java.Util.Map.Entry<K, V> PollLastEntry();

        public abstract global::Java.Util.NavigableMap<K, V> DescendingMap();

        public abstract global::Java.Util.NavigableSet<K> NavigableKeySet();

        public abstract global::Java.Util.NavigableSet<K> DescendingKeySet();

        public abstract global::Java.Util.NavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive);

        public abstract global::Java.Util.NavigableMap<K, V> HeadMap(K toKey, bool inclusive);

        public abstract global::Java.Util.NavigableMap<K, V> TailMap(K fromKey, bool inclusive);

        public abstract global::Java.Util.SortedMap<K, V> SubMap(K fromKey, K toKey);

        public abstract global::Java.Util.SortedMap<K, V> HeadMap(K toKey);

        public abstract global::Java.Util.SortedMap<K, V> TailMap(K fromKey);

        public abstract global::Java.Util.Comparator<K> Comparator();

        public abstract K FirstKey();

        public abstract K LastKey();

        public abstract global::Java.Util.Set<K> KeySet();

        public abstract global::Java.Util.Collection<V> Values();

        public abstract global::Java.Util.Set<global::Java.Util.Map.Entry<K, V>> EntrySet();

        public abstract int Size();

        public abstract bool IsEmpty();

        public abstract bool ContainsKey(global::Google.LibraryWrapper.Java.JavaObject key);

        public abstract bool ContainsValue(global::Google.LibraryWrapper.Java.JavaObject value);

        public abstract V Get(global::Google.LibraryWrapper.Java.JavaObject key);

        public abstract V Put(K key, V value);

        public abstract V Remove(global::Google.LibraryWrapper.Java.JavaObject key);

        public abstract void PutAll(global::Java.Util.Map<K, V> m);

        public abstract void Clear();

        public abstract bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

        public abstract int HashCode();

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "lowerEntry" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(LowerEntry(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "lowerKey" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(LowerKey(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "floorEntry" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(FloorEntry(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "floorKey" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(FloorKey(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "ceilingEntry" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(CeilingEntry(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "ceilingKey" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(CeilingKey(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "higherEntry" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HigherEntry(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "higherKey" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HigherKey(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "firstEntry" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(FirstEntry());
        }
        else if (methodName == "lastEntry" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(LastEntry());
        }
        else if (methodName == "pollFirstEntry" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PollFirstEntry());
        }
        else if (methodName == "pollLastEntry" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(PollLastEntry());
        }
        else if (methodName == "descendingMap" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(DescendingMap());
        }
        else if (methodName == "navigableKeySet" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(NavigableKeySet());
        }
        else if (methodName == "descendingKeySet" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(DescendingKeySet());
        }
        else if (methodName == "subMap" && args.Length == 4)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(SubMap(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject()), (bool) args[1], args[2] is global::System.String ? (K) (global::System.Object) args[2] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[2]).GetRawObject()), (bool) args[3]));
        }
        else if (methodName == "headMap" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HeadMap(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject()), (bool) args[1]));
        }
        else if (methodName == "tailMap" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(TailMap(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject()), (bool) args[1]));
        }
        else if (methodName == "subMap" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(SubMap(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject()), args[1] is global::System.String ? (K) (global::System.Object) args[1] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[1]).GetRawObject())));
        }
        else if (methodName == "headMap" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(HeadMap(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "tailMap" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(TailMap(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "comparator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Comparator());
        }
        else if (methodName == "firstKey" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(FirstKey());
        }
        else if (methodName == "lastKey" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(LastKey());
        }
        else if (methodName == "keySet" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(KeySet());
        }
        else if (methodName == "values" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Values());
        }
        else if (methodName == "entrySet" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(EntrySet());
        }
        else if (methodName == "size" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Size());
        }
        else if (methodName == "isEmpty" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(IsEmpty());
        }
        else if (methodName == "containsKey" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(ContainsKey(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "containsValue" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(ContainsValue(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "get" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Get(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "put" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Put(args[0] is global::System.String ? (K) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(((AndroidJavaObject) args[0]).GetRawObject()), args[1] is global::System.String ? (V) (global::System.Object) args[1] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(((AndroidJavaObject) args[1]).GetRawObject())));
        }
        else if (methodName == "remove" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Remove(new global::Google.LibraryWrapper.Java.JavaObject(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "putAll" && args.Length == 1)
        {
        PutAll(new global::Java.Util.MapAnonymousImplementation<K, V>(((AndroidJavaObject) args[0]).GetRawObject()));
        return null;
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
    } // end class NavigableMapCallbackHelper
} // end namespace Java.Util
