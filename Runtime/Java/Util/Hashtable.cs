using System;

using UnityEngine;

namespace Java.Util
{
    public class Hashtable<K, V> : global::Java.Util.Dictionary<K, V>, global::Java.Util.Map<K, V>, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Io.Serializable where K : class where V : class
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

        static Hashtable()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Hashtable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(IF)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(I)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/util/Map;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "contains", "(Ljava/lang/Object;)Z");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "containsValue", "(Ljava/lang/Object;)Z");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "containsKey", "(Ljava/lang/Object;)Z");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "putAll", "(Ljava/util/Map;)V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "keySet", "()Ljava/util/Set;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "entrySet", "()Ljava/util/Set;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "values", "()Ljava/util/Collection;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "forEach", "(Ljava/util/function/BiConsumer;)V");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "replaceAll", "(Ljava/util/function/BiFunction;)V");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
        }

        public Hashtable(int initialCapacity, float loadFactor) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = initialCapacity },
                            new jvalue { f = loadFactor }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Hashtable(int initialCapacity) : base(IntPtr.Zero)
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

        public Hashtable() : base(IntPtr.Zero)
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

        public Hashtable(global::Java.Util.Map<K, V> t) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = t.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Hashtable(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Hashtable.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Contains(global::Google.LibraryWrapper.Java.JavaObject value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = value.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId0, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId1, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void PutAll(global::Java.Util.Map<K, V> t)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = t.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
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
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
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
                return new global::Java.Util.SetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
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
                return new global::Java.Util.SetAnonymousImplementation<global::Java.Util.Map.Entry<K, V>>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
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
                return new global::Java.Util.CollectionAnonymousImplementation<V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V GetOrDefault(global::Google.LibraryWrapper.Java.JavaObject key, V defaultValue)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = key.GetRawObject() },
                            ToJvalue(defaultValue)
                        };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId11, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId12, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V PutIfAbsent(K key, V value)
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId14, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Remove(global::Google.LibraryWrapper.Java.JavaObject key, global::Google.LibraryWrapper.Java.JavaObject value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = key.GetRawObject() },
                            new jvalue { l = value.GetRawObject() }
                        };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId15, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId16, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId17, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V ComputeIfAbsent(K key, global::Java.ExternalType.Java.Util.Function.Function<K, V> mappingFunction)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(key),
                            new jvalue { l = mappingFunction.GetRawObject() }
                        };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId18, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V ComputeIfPresent(K key, global::Java.ExternalType.Java.Util.Function.BiFunction<K, V, V> remappingFunction)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(key),
                            new jvalue { l = remappingFunction.GetRawObject() }
                        };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId19, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V Compute(K key, global::Java.ExternalType.Java.Util.Function.BiFunction<K, V, V> remappingFunction)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(key),
                            new jvalue { l = remappingFunction.GetRawObject() }
                        };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId20, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId20, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public V Merge(K key, V value, global::Java.ExternalType.Java.Util.Function.BiFunction<V, V, V> remappingFunction)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(key),
                            ToJvalue(value),
                            new jvalue { l = remappingFunction.GetRawObject() }
                        };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId21, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Hashtable<K, V> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Hashtable<K, V>(IntPtr rawObject)
        {
            return new Hashtable<K, V>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Hashtable
} // end namespace Java.Util
