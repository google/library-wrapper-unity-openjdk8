using System;

using UnityEngine;

namespace Java.Util
{
    public class SimpleTimeZone : global::Java.Util.TimeZone
    {
        public static int WALL_TIME
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
        public static int STANDARD_TIME
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
        public static int UTC_TIME
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

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedFieldId0;
        private static readonly IntPtr _cachedFieldId1;
        private static readonly IntPtr _cachedFieldId2;
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

        static SimpleTimeZone()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/SimpleTimeZone");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "WALL_TIME", "I");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "STANDARD_TIME", "I");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "UTC_TIME", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "(ILjava/lang/String;)V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(ILjava/lang/String;IIIIIIII)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(ILjava/lang/String;IIIIIIIII)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(ILjava/lang/String;IIIIIIIIIII)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "setStartYear", "(I)V");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "setStartRule", "(IIII)V");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "setStartRule", "(III)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "setStartRule", "(IIIIZ)V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "setEndRule", "(IIII)V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "setEndRule", "(III)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "setEndRule", "(IIIIZ)V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "setDSTSavings", "(I)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "hashCode", "()I");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "equals", "(Ljava/lang/Object;)Z");
        }

        public SimpleTimeZone(int rawOffset, global::System.String ID) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = rawOffset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ID) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId0, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public SimpleTimeZone(int rawOffset, global::System.String ID, int startMonth, int startDay, int startDayOfWeek, int startTime, int endMonth, int endDay, int endDayOfWeek, int endTime) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = rawOffset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ID) },
                            new jvalue { i = startMonth },
                            new jvalue { i = startDay },
                            new jvalue { i = startDayOfWeek },
                            new jvalue { i = startTime },
                            new jvalue { i = endMonth },
                            new jvalue { i = endDay },
                            new jvalue { i = endDayOfWeek },
                            new jvalue { i = endTime }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public SimpleTimeZone(int rawOffset, global::System.String ID, int startMonth, int startDay, int startDayOfWeek, int startTime, int endMonth, int endDay, int endDayOfWeek, int endTime, int dstSavings) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = rawOffset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ID) },
                            new jvalue { i = startMonth },
                            new jvalue { i = startDay },
                            new jvalue { i = startDayOfWeek },
                            new jvalue { i = startTime },
                            new jvalue { i = endMonth },
                            new jvalue { i = endDay },
                            new jvalue { i = endDayOfWeek },
                            new jvalue { i = endTime },
                            new jvalue { i = dstSavings }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public SimpleTimeZone(int rawOffset, global::System.String ID, int startMonth, int startDay, int startDayOfWeek, int startTime, int startTimeMode, int endMonth, int endDay, int endDayOfWeek, int endTime, int endTimeMode, int dstSavings) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = rawOffset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(ID) },
                            new jvalue { i = startMonth },
                            new jvalue { i = startDay },
                            new jvalue { i = startDayOfWeek },
                            new jvalue { i = startTime },
                            new jvalue { i = startTimeMode },
                            new jvalue { i = endMonth },
                            new jvalue { i = endDay },
                            new jvalue { i = endDayOfWeek },
                            new jvalue { i = endTime },
                            new jvalue { i = endTimeMode },
                            new jvalue { i = dstSavings }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public SimpleTimeZone(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of SimpleTimeZone.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetStartYear(int year)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = year } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetStartRule(int startMonth, int startDay, int startDayOfWeek, int startTime)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = startMonth },
                            new jvalue { i = startDay },
                            new jvalue { i = startDayOfWeek },
                            new jvalue { i = startTime }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetStartRule(int startMonth, int startDay, int startTime)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = startMonth },
                            new jvalue { i = startDay },
                            new jvalue { i = startTime }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetStartRule(int startMonth, int startDay, int startDayOfWeek, int startTime, bool after)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = startMonth },
                            new jvalue { i = startDay },
                            new jvalue { i = startDayOfWeek },
                            new jvalue { i = startTime },
                            new jvalue { z = after }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetEndRule(int endMonth, int endDay, int endDayOfWeek, int endTime)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = endMonth },
                            new jvalue { i = endDay },
                            new jvalue { i = endDayOfWeek },
                            new jvalue { i = endTime }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetEndRule(int endMonth, int endDay, int endTime)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = endMonth },
                            new jvalue { i = endDay },
                            new jvalue { i = endTime }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetEndRule(int endMonth, int endDay, int endDayOfWeek, int endTime, bool after)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = endMonth },
                            new jvalue { i = endDay },
                            new jvalue { i = endDayOfWeek },
                            new jvalue { i = endTime },
                            new jvalue { z = after }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetDSTSavings(int millisSavedDuringDST)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = millisSavedDuringDST } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
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
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId8, args_);
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
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(SimpleTimeZone wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator SimpleTimeZone(IntPtr rawObject)
        {
            return new SimpleTimeZone(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class SimpleTimeZone
} // end namespace Java.Util
