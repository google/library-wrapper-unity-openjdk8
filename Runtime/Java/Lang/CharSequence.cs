using System;

using UnityEngine;

namespace Java.Lang
{
    public interface CharSequence : global::Google.LibraryWrapper.Java.JavaInterface
    {

        int Length();

        char CharAt(int index);

        global::Java.Lang.CharSequence SubSequence(int start, int end);

        global::System.String ToString();
    } // end class CharSequence

    public class CharSequenceAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.CharSequence
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;

        static CharSequenceAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/CharSequence");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "length", "()I");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "charAt", "(I)C");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "subSequence", "(II)Ljava/lang/CharSequence;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "chars", "()Ljava/util/stream/IntStream;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "codePoints", "()Ljava/util/stream/IntStream;");
        }

        public CharSequenceAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of CharSequenceAnonymousImplementation.");
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

        public char CharAt(int index)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = index } };
                return AndroidJNI.CallCharMethod(_rawObject, _cachedMethodId1, args_);
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
                return new global::Java.Lang.CharSequenceAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.IntStream Chars()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.IntStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Util.Stream.IntStream CodePoints()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Util.Stream.IntStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(CharSequenceAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator CharSequenceAnonymousImplementation(IntPtr rawObject)
        {
            return new CharSequenceAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class CharSequenceAnonymousImplementation

    public abstract class CharSequenceCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.CharSequence
    {
        public CharSequenceCallbackHelper() : base("java.lang.CharSequence") {}

        public abstract int Length();

        public abstract char CharAt(int index);

        public abstract global::Java.Lang.CharSequence SubSequence(int start, int end);

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "length" && args.Length == 0)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Length());
        }
        else if (methodName == "charAt" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(CharAt((int) args[0]));
        }
        else if (methodName == "subSequence" && args.Length == 2)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(SubSequence((int) args[0], (int) args[1]));
        }
        return base.Invoke(methodName, args);
        }
    } // end class CharSequenceCallbackHelper
} // end namespace Java.Lang
