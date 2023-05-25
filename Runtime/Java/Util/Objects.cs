using System;

using UnityEngine;

namespace Java.Util
{
    public class Objects : global::Google.LibraryWrapper.Java.JavaObject
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

        static Objects()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Objects");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "deepEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(Ljava/lang/Object;)I");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(Ljava/lang/Object;)Ljava/lang/String;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "requireNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "isNull", "(Ljava/lang/Object;)Z");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "nonNull", "(Ljava/lang/Object;)Z");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "requireNonNull", "(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;");
        }

        public Objects(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Objects.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool Equals(global::Google.LibraryWrapper.Java.JavaObject a, global::Google.LibraryWrapper.Java.JavaObject b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = a.GetRawObject() },
                            new jvalue { l = b.GetRawObject() }
                        };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool DeepEquals(global::Google.LibraryWrapper.Java.JavaObject a, global::Google.LibraryWrapper.Java.JavaObject b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = a.GetRawObject() },
                            new jvalue { l = b.GetRawObject() }
                        };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(global::Google.LibraryWrapper.Java.JavaObject o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = o.GetRawObject() } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(global::Google.LibraryWrapper.Java.JavaObject o)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = o.GetRawObject() } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(global::Google.LibraryWrapper.Java.JavaObject o, global::System.String nullDefault)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = o.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(nullDefault) }
                        };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare<T>(T a, T b, global::Java.Util.Comparator<T> c) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(a),
                            ToJvalue(b),
                            new jvalue { l = c.GetRawObject() }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static T RequireNonNull<T>(T obj) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(obj) };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId6, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static T RequireNonNull<T>(T obj, global::System.String message) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(obj),
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(message) }
                        };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId7, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId7, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool IsNull(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool NonNull(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static T RequireNonNull<T>(T obj, global::Java.ExternalType.Java.Util.Function.Supplier<global::System.String> messageSupplier) where T : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(obj),
                            new jvalue { l = messageSupplier.GetRawObject() }
                        };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId10, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId10, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Objects wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Objects(IntPtr rawObject)
        {
            return new Objects(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Objects
} // end namespace Java.Util
