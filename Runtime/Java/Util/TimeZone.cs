using System;

using UnityEngine;

namespace Java.Util
{
    public class TimeZone : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable, global::Java.Lang.Cloneable
    {
        public static int SHORT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId0);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId0, value);
            }
        }
        public static int LONG
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId1);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId1, value);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
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
        private static readonly IntPtr _cachedMethodId12;
        private static readonly IntPtr _cachedMethodId13;
        private static readonly IntPtr _cachedMethodId14;
        private static readonly IntPtr _cachedMethodId15;
        private static readonly IntPtr _cachedMethodId16;
        private static readonly IntPtr _cachedMethodId17;
        private static readonly IntPtr _cachedMethodId18;
        private static readonly IntPtr _cachedMethodId19;
        private static readonly IntPtr _cachedMethodId20;

        static TimeZone()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/TimeZone");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "SHORT", "I");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "LONG", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getOffset", "(IIIIII)I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getOffset", "(J)I");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "setRawOffset", "(I)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "getRawOffset", "()I");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "getID", "()Ljava/lang/String;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "setID", "(Ljava/lang/String;)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "()Ljava/lang/String;");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "(ZI)Ljava/lang/String;");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "getDSTSavings", "()I");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "useDaylightTime", "()Z");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "observesDaylightTime", "()Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "inDaylightTime", "(Ljava/util/Date;)Z");
            _cachedMethodId14 = AndroidJNI.GetStaticMethodID(_classObject, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
            _cachedMethodId15 = AndroidJNI.GetStaticMethodID(_classObject, "getTimeZone", "(Ljava/time/ZoneId;)Ljava/util/TimeZone;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "toZoneId", "()Ljava/time/ZoneId;");
            _cachedMethodId17 = AndroidJNI.GetStaticMethodID(_classObject, "getDefault", "()Ljava/util/TimeZone;");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "setDefault", "(Ljava/util/TimeZone;)V");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "hasSameRules", "(Ljava/util/TimeZone;)Z");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
        }

        public TimeZone() : base(IntPtr.Zero)
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

        public TimeZone(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of TimeZone.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetOffset(int era, int year, int month, int day, int dayOfWeek, int milliseconds)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = era },
                            new jvalue { i = year },
                            new jvalue { i = month },
                            new jvalue { i = day },
                            new jvalue { i = dayOfWeek },
                            new jvalue { i = milliseconds }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetOffset(long date)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = date } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetRawOffset(int offsetMillis)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = offsetMillis } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetRawOffset()
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

        public global::System.String GetID()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetID(global::System.String ID)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ID) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName(global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = locale.GetRawObject() } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName(bool daylight, int style)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = daylight },
                            new jvalue { i = style }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName(bool daylight, int style, global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { z = daylight },
                            new jvalue { i = style },
                            new jvalue { l = locale.GetRawObject() }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetDSTSavings()
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

        public bool UseDaylightTime()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool ObservesDaylightTime()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool InDaylightTime(global::Java.Util.Date date)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = date.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.TimeZone GetTimeZone(global::System.String ID)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ID) } };
                return new global::Java.Util.TimeZone(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.TimeZone GetTimeZone(global::Java.ExternalType.Java.Time.ZoneId zoneId)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = zoneId.GetRawObject() } };
                return new global::Java.Util.TimeZone(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Time.ZoneId ToZoneId()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Time.ZoneId(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.TimeZone GetDefault()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.TimeZone(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetDefault(global::Java.Util.TimeZone zone)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = zone.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool HasSameRules(global::Java.Util.TimeZone other)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = other.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId19, args_);
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
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId20, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(TimeZone wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator TimeZone(IntPtr rawObject)
        {
            return new TimeZone(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class TimeZone
} // end namespace Java.Util
