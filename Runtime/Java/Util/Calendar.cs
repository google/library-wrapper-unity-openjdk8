using System;

using UnityEngine;

namespace Java.Util
{
    public class Calendar : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable, global::Java.Lang.Cloneable, global::Java.ExternalType.Java.Lang.Comparable<global::Java.Util.Calendar>
    {
        public class Builder : global::Google.LibraryWrapper.Java.JavaObject
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
            private static readonly IntPtr _cachedMethodId12;

            static Builder()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Calendar$Builder");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "setInstant", "(J)Ljava/util/Calendar$Builder;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "setInstant", "(Ljava/util/Date;)Ljava/util/Calendar$Builder;");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "set", "(II)Ljava/util/Calendar$Builder;");
                _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "setDate", "(III)Ljava/util/Calendar$Builder;");
                _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "setTimeOfDay", "(III)Ljava/util/Calendar$Builder;");
                _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "setTimeOfDay", "(IIII)Ljava/util/Calendar$Builder;");
                _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "setWeekDate", "(III)Ljava/util/Calendar$Builder;");
                _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "setTimeZone", "(Ljava/util/TimeZone;)Ljava/util/Calendar$Builder;");
                _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "setLenient", "(Z)Ljava/util/Calendar$Builder;");
                _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "setCalendarType", "(Ljava/lang/String;)Ljava/util/Calendar$Builder;");
                _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "setLocale", "(Ljava/util/Locale;)Ljava/util/Calendar$Builder;");
                _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "setWeekDefinition", "(II)Ljava/util/Calendar$Builder;");
                _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "build", "()Ljava/util/Calendar;");
            }

            public Builder() : base(IntPtr.Zero)
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

            public Builder(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Builder.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetInstant(long instant)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { j = instant } };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetInstant(global::Java.Util.Date instant)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = instant.GetRawObject() } };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder Set(int field, int value)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { i = field },
                                new jvalue { i = value }
                            };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetDate(int year, int month, int dayOfMonth)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { i = year },
                                new jvalue { i = month },
                                new jvalue { i = dayOfMonth }
                            };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetTimeOfDay(int hourOfDay, int minute, int second)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { i = hourOfDay },
                                new jvalue { i = minute },
                                new jvalue { i = second }
                            };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetTimeOfDay(int hourOfDay, int minute, int second, int millis)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { i = hourOfDay },
                                new jvalue { i = minute },
                                new jvalue { i = second },
                                new jvalue { i = millis }
                            };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId5, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetWeekDate(int weekYear, int weekOfYear, int dayOfWeek)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { i = weekYear },
                                new jvalue { i = weekOfYear },
                                new jvalue { i = dayOfWeek }
                            };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId6, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetTimeZone(global::Java.Util.TimeZone zone)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = zone.GetRawObject() } };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId7, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetLenient(bool lenient)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { z = lenient } };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId8, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetCalendarType(global::System.String type)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(type) } };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId9, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetLocale(global::Java.Util.Locale locale)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = locale.GetRawObject() } };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId10, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar.Builder SetWeekDefinition(int firstDayOfWeek, int minimalDaysInFirstWeek)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { i = firstDayOfWeek },
                                new jvalue { i = minimalDaysInFirstWeek }
                            };
                    return new global::Java.Util.Calendar.Builder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Calendar Build()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.Calendar(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Builder wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Builder(IntPtr rawObject)
            {
                return new Builder(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Builder

        public static int ERA
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
        public static int YEAR
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
        public static int MONTH
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId2);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId2, value);
            }
        }
        public static int WEEK_OF_YEAR
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId3);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId3, value);
            }
        }
        public static int WEEK_OF_MONTH
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId4);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId4, value);
            }
        }
        public static int DATE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId5);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId5, value);
            }
        }
        public static int DAY_OF_MONTH
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId6);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId6, value);
            }
        }
        public static int DAY_OF_YEAR
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId7);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId7, value);
            }
        }
        public static int DAY_OF_WEEK
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId8);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId8, value);
            }
        }
        public static int DAY_OF_WEEK_IN_MONTH
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId9);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId9, value);
            }
        }
        public static int AM_PM
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId10);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId10, value);
            }
        }
        public static int HOUR
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId11);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId11, value);
            }
        }
        public static int HOUR_OF_DAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId12);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId12, value);
            }
        }
        public static int MINUTE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId13);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId13, value);
            }
        }
        public static int SECOND
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId14);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId14, value);
            }
        }
        public static int MILLISECOND
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId15);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId15, value);
            }
        }
        public static int ZONE_OFFSET
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId16);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId16, value);
            }
        }
        public static int DST_OFFSET
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId17);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId17, value);
            }
        }
        public static int FIELD_COUNT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId18);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId18, value);
            }
        }
        public static int SUNDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId19);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId19, value);
            }
        }
        public static int MONDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId20);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId20, value);
            }
        }
        public static int TUESDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId21);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId21, value);
            }
        }
        public static int WEDNESDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId22);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId22, value);
            }
        }
        public static int THURSDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId23);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId23, value);
            }
        }
        public static int FRIDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId24);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId24, value);
            }
        }
        public static int SATURDAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId25);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId25, value);
            }
        }
        public static int JANUARY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId26);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId26, value);
            }
        }
        public static int FEBRUARY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId27);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId27, value);
            }
        }
        public static int MARCH
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId28);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId28, value);
            }
        }
        public static int APRIL
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId29);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId29, value);
            }
        }
        public static int MAY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId30);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId30, value);
            }
        }
        public static int JUNE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId31);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId31, value);
            }
        }
        public static int JULY
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId32);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId32, value);
            }
        }
        public static int AUGUST
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId33);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId33, value);
            }
        }
        public static int SEPTEMBER
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId34);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId34, value);
            }
        }
        public static int OCTOBER
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId35);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId35, value);
            }
        }
        public static int NOVEMBER
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId36);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId36, value);
            }
        }
        public static int DECEMBER
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId37);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId37, value);
            }
        }
        public static int UNDECIMBER
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId38);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId38, value);
            }
        }
        public static int AM
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId39);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId39, value);
            }
        }
        public static int PM
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId40);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId40, value);
            }
        }
        public static int ALL_STYLES
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId41);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId41, value);
            }
        }
        public static int SHORT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId42);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId42, value);
            }
        }
        public static int LONG
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId43);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId43, value);
            }
        }
        public static int NARROW_FORMAT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId44);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId44, value);
            }
        }
        public static int NARROW_STANDALONE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId45);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId45, value);
            }
        }
        public static int SHORT_FORMAT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId46);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId46, value);
            }
        }
        public static int LONG_FORMAT
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId47);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId47, value);
            }
        }
        public static int SHORT_STANDALONE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId48);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId48, value);
            }
        }
        public static int LONG_STANDALONE
        {
            get
            {
                return AndroidJNI.GetStaticIntField(_classObject, _cachedFieldId49);
            }
            set
            {
                AndroidJNI.SetStaticIntField(_classObject, _cachedFieldId49, value);
            }
        }

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
        private static readonly IntPtr _cachedFieldId2;
        private static readonly IntPtr _cachedFieldId3;
        private static readonly IntPtr _cachedFieldId4;
        private static readonly IntPtr _cachedFieldId5;
        private static readonly IntPtr _cachedFieldId6;
        private static readonly IntPtr _cachedFieldId7;
        private static readonly IntPtr _cachedFieldId8;
        private static readonly IntPtr _cachedFieldId9;
        private static readonly IntPtr _cachedFieldId10;
        private static readonly IntPtr _cachedFieldId11;
        private static readonly IntPtr _cachedFieldId12;
        private static readonly IntPtr _cachedFieldId13;
        private static readonly IntPtr _cachedFieldId14;
        private static readonly IntPtr _cachedFieldId15;
        private static readonly IntPtr _cachedFieldId16;
        private static readonly IntPtr _cachedFieldId17;
        private static readonly IntPtr _cachedFieldId18;
        private static readonly IntPtr _cachedFieldId19;
        private static readonly IntPtr _cachedFieldId20;
        private static readonly IntPtr _cachedFieldId21;
        private static readonly IntPtr _cachedFieldId22;
        private static readonly IntPtr _cachedFieldId23;
        private static readonly IntPtr _cachedFieldId24;
        private static readonly IntPtr _cachedFieldId25;
        private static readonly IntPtr _cachedFieldId26;
        private static readonly IntPtr _cachedFieldId27;
        private static readonly IntPtr _cachedFieldId28;
        private static readonly IntPtr _cachedFieldId29;
        private static readonly IntPtr _cachedFieldId30;
        private static readonly IntPtr _cachedFieldId31;
        private static readonly IntPtr _cachedFieldId32;
        private static readonly IntPtr _cachedFieldId33;
        private static readonly IntPtr _cachedFieldId34;
        private static readonly IntPtr _cachedFieldId35;
        private static readonly IntPtr _cachedFieldId36;
        private static readonly IntPtr _cachedFieldId37;
        private static readonly IntPtr _cachedFieldId38;
        private static readonly IntPtr _cachedFieldId39;
        private static readonly IntPtr _cachedFieldId40;
        private static readonly IntPtr _cachedFieldId41;
        private static readonly IntPtr _cachedFieldId42;
        private static readonly IntPtr _cachedFieldId43;
        private static readonly IntPtr _cachedFieldId44;
        private static readonly IntPtr _cachedFieldId45;
        private static readonly IntPtr _cachedFieldId46;
        private static readonly IntPtr _cachedFieldId47;
        private static readonly IntPtr _cachedFieldId48;
        private static readonly IntPtr _cachedFieldId49;
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
        private static readonly IntPtr _cachedMethodId38;
        private static readonly IntPtr _cachedMethodId39;
        private static readonly IntPtr _cachedMethodId40;
        private static readonly IntPtr _cachedMethodId41;
        private static readonly IntPtr _cachedMethodId42;
        private static readonly IntPtr _cachedMethodId43;
        private static readonly IntPtr _cachedMethodId44;
        private static readonly IntPtr _cachedMethodId45;
        private static readonly IntPtr _cachedMethodId46;
        private static readonly IntPtr _cachedMethodId47;

        static Calendar()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Calendar");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "ERA", "I");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "YEAR", "I");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "MONTH", "I");
            _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "WEEK_OF_YEAR", "I");
            _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "WEEK_OF_MONTH", "I");
            _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "DATE", "I");
            _cachedFieldId6 = AndroidJNI.GetStaticFieldID(_classObject, "DAY_OF_MONTH", "I");
            _cachedFieldId7 = AndroidJNI.GetStaticFieldID(_classObject, "DAY_OF_YEAR", "I");
            _cachedFieldId8 = AndroidJNI.GetStaticFieldID(_classObject, "DAY_OF_WEEK", "I");
            _cachedFieldId9 = AndroidJNI.GetStaticFieldID(_classObject, "DAY_OF_WEEK_IN_MONTH", "I");
            _cachedFieldId10 = AndroidJNI.GetStaticFieldID(_classObject, "AM_PM", "I");
            _cachedFieldId11 = AndroidJNI.GetStaticFieldID(_classObject, "HOUR", "I");
            _cachedFieldId12 = AndroidJNI.GetStaticFieldID(_classObject, "HOUR_OF_DAY", "I");
            _cachedFieldId13 = AndroidJNI.GetStaticFieldID(_classObject, "MINUTE", "I");
            _cachedFieldId14 = AndroidJNI.GetStaticFieldID(_classObject, "SECOND", "I");
            _cachedFieldId15 = AndroidJNI.GetStaticFieldID(_classObject, "MILLISECOND", "I");
            _cachedFieldId16 = AndroidJNI.GetStaticFieldID(_classObject, "ZONE_OFFSET", "I");
            _cachedFieldId17 = AndroidJNI.GetStaticFieldID(_classObject, "DST_OFFSET", "I");
            _cachedFieldId18 = AndroidJNI.GetStaticFieldID(_classObject, "FIELD_COUNT", "I");
            _cachedFieldId19 = AndroidJNI.GetStaticFieldID(_classObject, "SUNDAY", "I");
            _cachedFieldId20 = AndroidJNI.GetStaticFieldID(_classObject, "MONDAY", "I");
            _cachedFieldId21 = AndroidJNI.GetStaticFieldID(_classObject, "TUESDAY", "I");
            _cachedFieldId22 = AndroidJNI.GetStaticFieldID(_classObject, "WEDNESDAY", "I");
            _cachedFieldId23 = AndroidJNI.GetStaticFieldID(_classObject, "THURSDAY", "I");
            _cachedFieldId24 = AndroidJNI.GetStaticFieldID(_classObject, "FRIDAY", "I");
            _cachedFieldId25 = AndroidJNI.GetStaticFieldID(_classObject, "SATURDAY", "I");
            _cachedFieldId26 = AndroidJNI.GetStaticFieldID(_classObject, "JANUARY", "I");
            _cachedFieldId27 = AndroidJNI.GetStaticFieldID(_classObject, "FEBRUARY", "I");
            _cachedFieldId28 = AndroidJNI.GetStaticFieldID(_classObject, "MARCH", "I");
            _cachedFieldId29 = AndroidJNI.GetStaticFieldID(_classObject, "APRIL", "I");
            _cachedFieldId30 = AndroidJNI.GetStaticFieldID(_classObject, "MAY", "I");
            _cachedFieldId31 = AndroidJNI.GetStaticFieldID(_classObject, "JUNE", "I");
            _cachedFieldId32 = AndroidJNI.GetStaticFieldID(_classObject, "JULY", "I");
            _cachedFieldId33 = AndroidJNI.GetStaticFieldID(_classObject, "AUGUST", "I");
            _cachedFieldId34 = AndroidJNI.GetStaticFieldID(_classObject, "SEPTEMBER", "I");
            _cachedFieldId35 = AndroidJNI.GetStaticFieldID(_classObject, "OCTOBER", "I");
            _cachedFieldId36 = AndroidJNI.GetStaticFieldID(_classObject, "NOVEMBER", "I");
            _cachedFieldId37 = AndroidJNI.GetStaticFieldID(_classObject, "DECEMBER", "I");
            _cachedFieldId38 = AndroidJNI.GetStaticFieldID(_classObject, "UNDECIMBER", "I");
            _cachedFieldId39 = AndroidJNI.GetStaticFieldID(_classObject, "AM", "I");
            _cachedFieldId40 = AndroidJNI.GetStaticFieldID(_classObject, "PM", "I");
            _cachedFieldId41 = AndroidJNI.GetStaticFieldID(_classObject, "ALL_STYLES", "I");
            _cachedFieldId42 = AndroidJNI.GetStaticFieldID(_classObject, "SHORT", "I");
            _cachedFieldId43 = AndroidJNI.GetStaticFieldID(_classObject, "LONG", "I");
            _cachedFieldId44 = AndroidJNI.GetStaticFieldID(_classObject, "NARROW_FORMAT", "I");
            _cachedFieldId45 = AndroidJNI.GetStaticFieldID(_classObject, "NARROW_STANDALONE", "I");
            _cachedFieldId46 = AndroidJNI.GetStaticFieldID(_classObject, "SHORT_FORMAT", "I");
            _cachedFieldId47 = AndroidJNI.GetStaticFieldID(_classObject, "LONG_FORMAT", "I");
            _cachedFieldId48 = AndroidJNI.GetStaticFieldID(_classObject, "SHORT_STANDALONE", "I");
            _cachedFieldId49 = AndroidJNI.GetStaticFieldID(_classObject, "LONG_STANDALONE", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "getInstance", "()Ljava/util/Calendar;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "getTime", "()Ljava/util/Date;");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "setTime", "(Ljava/util/Date;)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "getTimeInMillis", "()J");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "setTimeInMillis", "(J)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "get", "(I)I");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "set", "(II)V");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "set", "(III)V");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "set", "(IIIII)V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "set", "(IIIIII)V");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "clear", "()V");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "clear", "(I)V");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "isSet", "(I)Z");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;");
            _cachedMethodId18 = AndroidJNI.GetStaticMethodID(_classObject, "getAvailableCalendarTypes", "()Ljava/util/Set;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "getCalendarType", "()Ljava/lang/String;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "before", "(Ljava/lang/Object;)Z");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "after", "(Ljava/lang/Object;)Z");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "compareTo", "(Ljava/util/Calendar;)I");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "add", "(II)V");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "roll", "(IZ)V");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "roll", "(II)V");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "setTimeZone", "(Ljava/util/TimeZone;)V");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "getTimeZone", "()Ljava/util/TimeZone;");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "setLenient", "(Z)V");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "isLenient", "()Z");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "setFirstDayOfWeek", "(I)V");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "getFirstDayOfWeek", "()I");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "setMinimalDaysInFirstWeek", "(I)V");
            _cachedMethodId35 = AndroidJNI.GetMethodID(_classObject, "getMinimalDaysInFirstWeek", "()I");
            _cachedMethodId36 = AndroidJNI.GetMethodID(_classObject, "isWeekDateSupported", "()Z");
            _cachedMethodId37 = AndroidJNI.GetMethodID(_classObject, "getWeekYear", "()I");
            _cachedMethodId38 = AndroidJNI.GetMethodID(_classObject, "setWeekDate", "(III)V");
            _cachedMethodId39 = AndroidJNI.GetMethodID(_classObject, "getWeeksInWeekYear", "()I");
            _cachedMethodId40 = AndroidJNI.GetMethodID(_classObject, "getMinimum", "(I)I");
            _cachedMethodId41 = AndroidJNI.GetMethodID(_classObject, "getMaximum", "(I)I");
            _cachedMethodId42 = AndroidJNI.GetMethodID(_classObject, "getGreatestMinimum", "(I)I");
            _cachedMethodId43 = AndroidJNI.GetMethodID(_classObject, "getLeastMaximum", "(I)I");
            _cachedMethodId44 = AndroidJNI.GetMethodID(_classObject, "getActualMinimum", "(I)I");
            _cachedMethodId45 = AndroidJNI.GetMethodID(_classObject, "getActualMaximum", "(I)I");
            _cachedMethodId46 = AndroidJNI.GetMethodID(_classObject, "clone", "()Ljava/lang/Object;");
            _cachedMethodId47 = AndroidJNI.GetMethodID(_classObject, "toInstant", "()Ljava/time/Instant;");
        }

        public Calendar() : base(IntPtr.Zero)
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

        public Calendar(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Calendar.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Calendar GetInstance()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Calendar(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Calendar GetInstance(global::Java.Util.TimeZone zone)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = zone.GetRawObject() } };
                return new global::Java.Util.Calendar(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Calendar GetInstance(global::Java.Util.Locale aLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = aLocale.GetRawObject() } };
                return new global::Java.Util.Calendar(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Calendar GetInstance(global::Java.Util.TimeZone zone, global::Java.Util.Locale aLocale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = zone.GetRawObject() },
                            new jvalue { l = aLocale.GetRawObject() }
                        };
                return new global::Java.Util.Calendar(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Date GetTime()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Date(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetTime(global::Java.Util.Date date)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = date.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long GetTimeInMillis()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetTimeInMillis(long millis)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = millis } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Get(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Set(int field, int value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = field },
                            new jvalue { i = value }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Set(int year, int month, int date)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = year },
                            new jvalue { i = month },
                            new jvalue { i = date }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Set(int year, int month, int date, int hourOfDay, int minute)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = year },
                            new jvalue { i = month },
                            new jvalue { i = date },
                            new jvalue { i = hourOfDay },
                            new jvalue { i = minute }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Set(int year, int month, int date, int hourOfDay, int minute, int second)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = year },
                            new jvalue { i = month },
                            new jvalue { i = date },
                            new jvalue { i = hourOfDay },
                            new jvalue { i = minute },
                            new jvalue { i = second }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId12, args_);
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
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Clear(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsSet(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetDisplayName(int field, int style, global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = field },
                            new jvalue { i = style },
                            new jvalue { l = locale.GetRawObject() }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.Map<global::System.String, global::Java.Lang.Integer> GetDisplayNames(int field, int style, global::Java.Util.Locale locale)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = field },
                            new jvalue { i = style },
                            new jvalue { l = locale.GetRawObject() }
                        };
                return new global::Java.Util.MapAnonymousImplementation<global::System.String, global::Java.Lang.Integer>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Set<global::System.String> GetAvailableCalendarTypes()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.SetAnonymousImplementation<global::System.String>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetCalendarType()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId19, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId20, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool Before(global::Google.LibraryWrapper.Java.JavaObject when)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = when.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool After(global::Google.LibraryWrapper.Java.JavaObject when)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = when.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CompareTo(global::Java.Util.Calendar anotherCalendar)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = anotherCalendar.GetRawObject() } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Add(int field, int amount)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = field },
                            new jvalue { i = amount }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Roll(int field, bool up)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = field },
                            new jvalue { z = up }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Roll(int field, int amount)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = field },
                            new jvalue { i = amount }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetTimeZone(global::Java.Util.TimeZone value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = value.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Util.TimeZone GetTimeZone()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.TimeZone(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId29, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetLenient(bool lenient)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = lenient } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsLenient()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetFirstDayOfWeek(int value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = value } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId32, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetFirstDayOfWeek()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetMinimalDaysInFirstWeek(int value)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = value } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetMinimalDaysInFirstWeek()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsWeekDateSupported()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId36, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetWeekYear()
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

        public void SetWeekDate(int weekYear, int weekOfYear, int dayOfWeek)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = weekYear },
                            new jvalue { i = weekOfYear },
                            new jvalue { i = dayOfWeek }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetWeeksInWeekYear()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId39, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetMinimum(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId40, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetMaximum(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId41, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetGreatestMinimum(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId42, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetLeastMaximum(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId43, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetActualMinimum(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId44, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetActualMaximum(int field)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = field } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId45, args_);
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
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId46, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Time.Instant ToInstant()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Time.Instant(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId47, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Calendar wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Calendar(IntPtr rawObject)
        {
            return new Calendar(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Calendar
} // end namespace Java.Util
