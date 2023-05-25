using System;

using UnityEngine;

namespace Java.Util
{
    public interface SortedMap<K, V> : global::Google.LibraryWrapper.Java.JavaInterface, global::Java.Util.Map<K, V> where K : class where V : class
    {

        global::Java.Util.Comparator<K> Comparator();

        global::Java.Util.SortedMap<K, V> SubMap(K fromKey, K toKey);

        global::Java.Util.SortedMap<K, V> HeadMap(K toKey);

        global::Java.Util.SortedMap<K, V> TailMap(K fromKey);

        K FirstKey();

        K LastKey();
    } // end class SortedMap

    public class SortedMapAnonymousImplementation<K, V> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Util.SortedMap<K, V> where K : class where V : class
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

        static SortedMapAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/SortedMap");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "comparator", "()Ljava/util/Comparator;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "firstKey", "()Ljava/lang/Object;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "lastKey", "()Ljava/lang/Object;");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "keySet", "()Ljava/util/Set;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "values", "()Ljava/util/Collection;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "entrySet", "()Ljava/util/Set;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "size", "()I");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "isEmpty", "()Z");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "containsKey", "(Ljava/lang/Object;)Z");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "containsValue", "(Ljava/lang/Object;)Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "putAll", "(Ljava/util/Map;)V");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
        }

        public SortedMapAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of SortedMapAnonymousImplementation.");
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
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
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
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
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
                return new global::Java.Util.SortedMapAnonymousImplementation<K, V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
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
                    return (K) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId4, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_);
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

        public global::Java.Util.Collection<V> Values()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.CollectionAnonymousImplementation<V>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
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
                return new global::Java.Util.SetAnonymousImplementation<global::Java.Util.Map.Entry<K, V>>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId9, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId10, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId11, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId12, args_);
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
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId13, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_);
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

        public V Remove(global::Google.LibraryWrapper.Java.JavaObject key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = key.GetRawObject() } };
                if (typeof(V) == typeof(global::System.String))
                {
                    return (V) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId15, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId16, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId17, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId18, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(SortedMapAnonymousImplementation<K, V> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator SortedMapAnonymousImplementation<K, V>(IntPtr rawObject)
        {
            return new SortedMapAnonymousImplementation<K, V>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class SortedMapAnonymousImplementation

    public abstract class SortedMapCallbackHelper<K, V> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Util.SortedMap<K, V> where K : class where V : class
    {
        public SortedMapCallbackHelper() : base("java.util.SortedMap") {}

        public abstract global::Java.Util.Comparator<K> Comparator();

        public abstract global::Java.Util.SortedMap<K, V> SubMap(K fromKey, K toKey);

        public abstract global::Java.Util.SortedMap<K, V> HeadMap(K toKey);

        public abstract global::Java.Util.SortedMap<K, V> TailMap(K fromKey);

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
        if (methodName == "comparator" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Comparator());
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
    } // end class SortedMapCallbackHelper
} // end namespace Java.Util
