using System;

using UnityEngine;

namespace Java.Lang
{
    public class StringBuffer : global::Java.ExternalType.Java.Lang.AbstractStringBuilder, global::Java.ExternalType.Java.Io.Serializable, global::Java.Lang.CharSequence
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

        static StringBuffer()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/StringBuffer");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(I)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/CharSequence;)V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "length", "()I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "capacity", "()I");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "ensureCapacity", "(I)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "trimToSize", "()V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "setLength", "(I)V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "charAt", "(I)C");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "codePointAt", "(I)I");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "codePointBefore", "(I)I");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "codePointCount", "(II)I");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "offsetByCodePoints", "(II)I");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "setCharAt", "(IC)V");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "append", "(Z)Ljava/lang/StringBuffer;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "append", "(C)Ljava/lang/StringBuffer;");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "append", "(I)Ljava/lang/StringBuffer;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "appendCodePoint", "(I)Ljava/lang/StringBuffer;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "append", "(J)Ljava/lang/StringBuffer;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "append", "(F)Ljava/lang/StringBuffer;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "append", "(D)Ljava/lang/StringBuffer;");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "delete", "(II)Ljava/lang/StringBuffer;");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "deleteCharAt", "(I)Ljava/lang/StringBuffer;");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "substring", "(I)Ljava/lang/String;");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "subSequence", "(II)Ljava/lang/CharSequence;");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "substring", "(II)Ljava/lang/String;");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "insert", "(IZ)Ljava/lang/StringBuffer;");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "insert", "(IC)Ljava/lang/StringBuffer;");
            _cachedMethodId35 = AndroidJNI.GetMethodID(_classObject, "insert", "(II)Ljava/lang/StringBuffer;");
            _cachedMethodId36 = AndroidJNI.GetMethodID(_classObject, "insert", "(IJ)Ljava/lang/StringBuffer;");
            _cachedMethodId37 = AndroidJNI.GetMethodID(_classObject, "insert", "(IF)Ljava/lang/StringBuffer;");
            _cachedMethodId38 = AndroidJNI.GetMethodID(_classObject, "insert", "(ID)Ljava/lang/StringBuffer;");
            _cachedMethodId39 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(Ljava/lang/String;)I");
            _cachedMethodId40 = AndroidJNI.GetMethodID(_classObject, "indexOf", "(Ljava/lang/String;I)I");
            _cachedMethodId41 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(Ljava/lang/String;)I");
            _cachedMethodId42 = AndroidJNI.GetMethodID(_classObject, "lastIndexOf", "(Ljava/lang/String;I)I");
            _cachedMethodId43 = AndroidJNI.GetMethodID(_classObject, "reverse", "()Ljava/lang/StringBuffer;");
        }

        public StringBuffer() : base(IntPtr.Zero)
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

        public StringBuffer(int capacity) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = capacity } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public StringBuffer(global::System.String str) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public StringBuffer(global::Java.Lang.CharSequence seq) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = seq.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public StringBuffer(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of StringBuffer.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int Length()
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

        public int Capacity()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void EnsureCapacity(int minimumCapacity)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = minimumCapacity } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void TrimToSize()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetLength(int newLength)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = newLength } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public char CharAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallCharMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CodePointAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CodePointBefore(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CodePointCount(int beginIndex, int endIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = beginIndex },
                            new jvalue { i = endIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int OffsetByCodePoints(int index, int codePointOffset)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = index },
                            new jvalue { i = codePointOffset }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetCharAt(int index, char ch)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = index },
                            new jvalue { c = ch }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId11, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(global::Java.Lang.StringBuffer sb)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = sb.GetRawObject() } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(global::Java.Lang.CharSequence s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = s.GetRawObject() } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(global::Java.Lang.CharSequence s, int start, int end)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = s.GetRawObject() },
                            new jvalue { i = start },
                            new jvalue { i = end }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = b } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(char c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = c } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId17, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = i } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer AppendCodePoint(int codePoint)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = codePoint } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(long lng)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = lng } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId20, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { f = f } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Append(double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { d = d } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId22, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Delete(int start, int end)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = start },
                            new jvalue { i = end }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId23, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer DeleteCharAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId24, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Replace(int start, int end, global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = start },
                            new jvalue { i = end },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId25, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Substring(int start)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = start } };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.CharSequence SubSequence(int start, int end)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = start },
                            new jvalue { i = end }
                        };
                return new global::Java.Lang.CharSequenceAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId27, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String Substring(int start, int end)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = start },
                            new jvalue { i = end }
                        };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { l = obj.GetRawObject() }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId29, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId30, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int dstOffset, global::Java.Lang.CharSequence s)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = dstOffset },
                            new jvalue { l = s.GetRawObject() }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId31, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int dstOffset, global::Java.Lang.CharSequence s, int start, int end)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = dstOffset },
                            new jvalue { l = s.GetRawObject() },
                            new jvalue { i = start },
                            new jvalue { i = end }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId32, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, bool b)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { z = b }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId33, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, char c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { c = c }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId34, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, int i)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { i = i }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId35, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, long l)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { j = l }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId36, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, float f)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { f = f }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId37, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Insert(int offset, double d)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { i = offset },
                            new jvalue { d = d }
                        };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId38, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId39, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int IndexOf(global::System.String str, int fromIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) },
                            new jvalue { i = fromIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId40, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(global::System.String str)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) } };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId41, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int LastIndexOf(global::System.String str, int fromIndex)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(str) },
                            new jvalue { i = fromIndex }
                        };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId42, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.StringBuffer Reverse()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.StringBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId43, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(StringBuffer wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator StringBuffer(IntPtr rawObject)
        {
            return new StringBuffer(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class StringBuffer
} // end namespace Java.Lang
