using System;

using UnityEngine;

namespace Java.Lang
{
    public class Boolean : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Lang.Boolean>
    {
        public static global::Java.Lang.Boolean TRUE
        {
            get
            {
                return new global::Java.Lang.Boolean(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Lang.Boolean FALSE
        {
            get
            {
                return new global::Java.Lang.Boolean(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }
        public static global::Java.Lang.Class<global::Java.Lang.Boolean> TYPE
        {
            get
            {
                return new global::Java.Lang.Class<global::Java.Lang.Boolean>(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
            }
            set
            {
                IntPtr valueRef = value.GetRawObject();
                AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                AndroidJNI.DeleteLocalRef(valueRef);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
        private static readonly IntPtr _cachedFieldId2;
        private static readonly IntPtr _cachedConstructorId0;
        private static readonly IntPtr _cachedConstructorId1;
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

        static Boolean()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Boolean");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "TRUE", "Ljava/lang/Boolean;");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "FALSE", "Ljava/lang/Boolean;");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "TYPE", "Ljava/lang/Class;");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Z)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "parseBoolean", "(Ljava/lang/String;)Z");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "booleanValue", "()Z");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Z)Ljava/lang/Boolean;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "toString", "(Z)Ljava/lang/String;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId6 = AndroidJNI.GetStaticMethodID(_classObject, "hashCode", "(Z)I");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId8 = AndroidJNI.GetStaticMethodID(_classObject, "getBoolean", "(Ljava/lang/String;)Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/lang/Boolean;)I");
            _cachedMethodId10 = AndroidJNI.GetStaticMethodID(_classObject, "compare", "(ZZ)I");
            _cachedMethodId11 = AndroidJNI.GetStaticMethodID(_classObject, "logicalAnd", "(ZZ)Z");
            _cachedMethodId12 = AndroidJNI.GetStaticMethodID(_classObject, "logicalOr", "(ZZ)Z");
            _cachedMethodId13 = AndroidJNI.GetStaticMethodID(_classObject, "logicalXor", "(ZZ)Z");
        }

        public Boolean(bool value) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = value } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Boolean(global::System.String s) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Boolean(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Boolean.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool ParseBoolean(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool BooleanValue()
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

        public static global::Java.Lang.Boolean ValueOf(bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = b } };
                return new global::Java.Lang.Boolean(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Boolean ValueOf(global::System.String s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(s) } };
                return new global::Java.Lang.Boolean(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::System.String ToString(bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = b } };
                return AndroidJNI.CallStaticStringMethod(_classObject, _cachedMethodId4, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int HashCode(bool value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = value } };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Equals(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool GetBoolean(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Lang.Boolean b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = b.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int Compare(bool x, bool y)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = x },
                            new jvalue { z = y }
                        };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool LogicalAnd(bool a, bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = a },
                            new jvalue { z = b }
                        };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool LogicalOr(bool a, bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = a },
                            new jvalue { z = b }
                        };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool LogicalXor(bool a, bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = a },
                            new jvalue { z = b }
                        };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Boolean wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Boolean(IntPtr rawObject)
        {
            return new Boolean(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Boolean
} // end namespace Java.Lang
