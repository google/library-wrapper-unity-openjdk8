using System;

using UnityEngine;

namespace Java.Util
{
    public static class Map
    {
        public interface Entry<K, V> : global::Google.LibraryWrapper.Java.JavaInterface where K : class where V : class
        {

            K GetKey();

            V GetValue();

            V SetValue(V value);

            bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

            int HashCode();
        } // end class Entry

        public class EntryAnonymousImplementation<K, V> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Map.Entry<K, V> where K : class where V : class
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

            static EntryAnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Map$Entry");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getKey", "()Ljava/lang/Object;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getValue", "()Ljava/lang/Object;");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "setValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
                _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
                _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
                _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "comparingByKey", "()Ljava/util/Comparator;");
                _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "comparingByValue", "()Ljava/util/Comparator;");
                _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "comparingByKey", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
                _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "comparingByValue", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
            }

            public EntryAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of EntryAnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public K GetKey()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    if (typeof(K) == typeof(global::System.String))
                    {
                        return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId0, args_);
                    }
                    else
                    {
                        IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_);
                        return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<K>(result_);
                    }
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public V GetValue()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    if (typeof(V) == typeof(global::System.String))
                    {
                        return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId1, args_);
                    }
                    else
                    {
                        IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_);
                        return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                    }
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public V SetValue(V value)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { ToJvalue(value) };
                    if (typeof(V) == typeof(global::System.String))
                    {
                        return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId2, args_);
                    }
                    else
                    {
                        IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_);
                        return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                    }
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
                    return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId3, args_);
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
                    return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId4, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Comparator<global::Java.Util.Map.Entry<K2, V2>> ComparingByKey<K2, V2>() where K2 : class, global::Java.ExternalType.Java.Lang.Comparable<K2> where V2 : class
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.ComparatorAnonymousImplementation<global::Java.Util.Map.Entry<K2, V2>>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId5, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Comparator<global::Java.Util.Map.Entry<K2, V2>> ComparingByValue<K2, V2>() where K2 : class where V2 : class, global::Java.ExternalType.Java.Lang.Comparable<V2>
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.ComparatorAnonymousImplementation<global::Java.Util.Map.Entry<K2, V2>>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Comparator<global::Java.Util.Map.Entry<K2, V2>> ComparingByKey<K2, V2>(global::Java.Util.Comparator<K2> cmp) where K2 : class where V2 : class
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = cmp.GetRawObject() } };
                    return new global::Java.Util.ComparatorAnonymousImplementation<global::Java.Util.Map.Entry<K2, V2>>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId7, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Util.Comparator<global::Java.Util.Map.Entry<K2, V2>> ComparingByValue<K2, V2>(global::Java.Util.Comparator<V2> cmp) where K2 : class where V2 : class
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = cmp.GetRawObject() } };
                    return new global::Java.Util.ComparatorAnonymousImplementation<global::Java.Util.Map.Entry<K2, V2>>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId8, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(EntryAnonymousImplementation<K, V> wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator EntryAnonymousImplementation<K, V>(IntPtr rawObject)
            {
                return new EntryAnonymousImplementation<K, V>(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class EntryAnonymousImplementation

        public abstract class EntryCallbackHelper<K, V> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Map.Entry<K, V> where K : class where V : class
        {
            public EntryCallbackHelper() : base("java.util.Map$Entry") {}

            public abstract K GetKey();

            public abstract V GetValue();

            public abstract V SetValue(V value);

            public abstract bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

            public abstract int HashCode();

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            if (methodName == "getKey" && args.Length == 0)
            {
            return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(GetKey());
            }
            else if (methodName == "getValue" && args.Length == 0)
            {
            return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(GetValue());
            }
            else if (methodName == "setValue" && args.Length == 1)
            {
            return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(SetValue(args[0] is global::System.String ? (V) (global::System.Object) args[0] : Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(((AndroidJavaObject) args[0]).GetRawObject())));
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
        } // end class EntryCallbackHelper

    } // end class Map
    public interface Map<K, V> : global::Google.LibraryWrapper.Java.JavaInterface where K : class where V : class
    {

        int Size();

        bool IsEmpty();

        bool ContainsKey(global::Google.LibraryWrapper.Java.JavaObject key);

        bool ContainsValue(global::Google.LibraryWrapper.Java.JavaObject value);

        V Get(global::Google.LibraryWrapper.Java.JavaObject key);

        V Put(K key, V value);

        V Remove(global::Google.LibraryWrapper.Java.JavaObject key);

        void PutAll(global::Java.Util.Map<K, V> m);

        void Clear();

        global::Java.Util.Set<K> KeySet();

        global::Java.Util.Collection<V> Values();

        global::Java.Util.Set<global::Java.Util.Map.Entry<K, V>> EntrySet();

        bool Equals(global::Google.LibraryWrapper.Java.JavaObject o);

        int HashCode();
    } // end class Map

    public class MapAnonymousImplementation<K, V> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.Map<K, V> where K : class where V : class
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

        static MapAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Map");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "size", "()I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "containsKey", "(Ljava/lang/Object;)Z");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "containsValue", "(Ljava/lang/Object;)Z");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "putAll", "(Ljava/util/Map;)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "keySet", "()Ljava/util/Set;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "values", "()Ljava/util/Collection;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "entrySet", "()Ljava/util/Set;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "forEach", "(Ljava/util/function/BiConsumer;)V");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "replaceAll", "(Ljava/util/function/BiFunction;)V");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;");
        }

        public MapAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of MapAnonymousImplementation.");
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

        public bool ContainsValue(global::Google.LibraryWrapper.Java.JavaObject value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = value.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId3, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId4, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId5, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId6, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId8, args_);
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
                return new global::Java.Util.SetAnonymousImplementation<K>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
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
                return new global::Java.Util.CollectionAnonymousImplementation<V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
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
                return new global::Java.Util.SetAnonymousImplementation<global::Java.Util.Map.Entry<K, V>>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
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

        public void ForEach(global::Java.ExternalType.Java.Util.Function.BiConsumer<K, V> action)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = action.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId15, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId16, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId18, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId19, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId22, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId22, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId23, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId23, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId24, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId24, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<V>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(MapAnonymousImplementation<K, V> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator MapAnonymousImplementation<K, V>(IntPtr rawObject)
        {
            return new MapAnonymousImplementation<K, V>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class MapAnonymousImplementation

    public abstract class MapCallbackHelper<K, V> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.Map<K, V> where K : class where V : class
    {
        public MapCallbackHelper() : base("java.util.Map") {}

        public abstract int Size();

        public abstract bool IsEmpty();

        public abstract bool ContainsKey(global::Google.LibraryWrapper.Java.JavaObject key);

        public abstract bool ContainsValue(global::Google.LibraryWrapper.Java.JavaObject value);

        public abstract V Get(global::Google.LibraryWrapper.Java.JavaObject key);

        public abstract V Put(K key, V value);

        public abstract V Remove(global::Google.LibraryWrapper.Java.JavaObject key);

        public abstract void PutAll(global::Java.Util.Map<K, V> m);

        public abstract void Clear();

        public abstract global::Java.Util.Set<K> KeySet();

        public abstract global::Java.Util.Collection<V> Values();

        public abstract global::Java.Util.Set<global::Java.Util.Map.Entry<K, V>> EntrySet();

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
    } // end class MapCallbackHelper
} // end namespace Java.Util
