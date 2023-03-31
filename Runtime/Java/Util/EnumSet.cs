using System;

using UnityEngine;

namespace Java.Util
{
    public class EnumSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Io.Serializable where E : global::Java.Lang.Enum<E>
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedConstructorId0;
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

        static EnumSet()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/EnumSet");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
            _cachedMethodId7 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/util/EnumSet;");
        }

        public EnumSet() : base(IntPtr.Zero)
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

        public EnumSet(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of EnumSet.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> NoneOf<E2>(global::Java.Lang.Class<E2> elementType) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = elementType.GetRawObject() } };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> AllOf<E2>(global::Java.Lang.Class<E2> elementType) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = elementType.GetRawObject() } };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> CopyOf<E2>(global::Java.Util.EnumSet<E2> s) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> CopyOf<E2>(global::Java.Util.Collection<E2> c) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = c.GetRawObject() } };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> ComplementOf<E2>(global::Java.Util.EnumSet<E2> s) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> Of<E2>(E2 e) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { ToJvalue(e) };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> Of<E2>(E2 e1, E2 e2) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(e1),
                            ToJvalue(e2)
                        };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId6, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> Of<E2>(E2 e1, E2 e2, E2 e3) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(e1),
                            ToJvalue(e2),
                            ToJvalue(e3)
                        };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId7, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> Of<E2>(E2 e1, E2 e2, E2 e3, E2 e4) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(e1),
                            ToJvalue(e2),
                            ToJvalue(e3),
                            ToJvalue(e4)
                        };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId8, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> Of<E2>(E2 e1, E2 e2, E2 e3, E2 e4, E2 e5) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(e1),
                            ToJvalue(e2),
                            ToJvalue(e3),
                            ToJvalue(e4),
                            ToJvalue(e5)
                        };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId9, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.EnumSet<E2> Range<E2>(E2 from, E2 to) where E2 : global::Java.Lang.Enum<E2>
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            ToJvalue(from),
                            ToJvalue(to)
                        };
                return new global::Java.Util.EnumSet<E2>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId10, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.EnumSet<E> Clone()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.EnumSet<E>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(EnumSet<E> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator EnumSet<E>(IntPtr rawObject)
        {
            return new EnumSet<E>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class EnumSet
} // end namespace Java.Util
