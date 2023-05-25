using System;

using UnityEngine;

namespace Java.Lang
{
    public interface Appendable : global::Google.LibraryWrapper.Java.JavaInterface
    {

        global::Java.Lang.Appendable Append(global::Java.Lang.CharSequence csq);

        global::Java.Lang.Appendable Append(global::Java.Lang.CharSequence csq, int start, int end);

        global::Java.Lang.Appendable Append(char c);
    } // end class Appendable

    public class AppendableAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Appendable
    {
        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;

        static AppendableAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Appendable");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "append", "(C)Ljava/lang/Appendable;");
        }

        public AppendableAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of AppendableAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Appendable Append(global::Java.Lang.CharSequence csq)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = csq.GetRawObject() } };
                return new global::Java.Lang.AppendableAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Appendable Append(global::Java.Lang.CharSequence csq, int start, int end)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = csq.GetRawObject() },
                            new jvalue { i = start },
                            new jvalue { i = end }
                        };
                return new global::Java.Lang.AppendableAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Appendable Append(char c)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { c = c } };
                return new global::Java.Lang.AppendableAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(AppendableAnonymousImplementation wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator AppendableAnonymousImplementation(IntPtr rawObject)
        {
            return new AppendableAnonymousImplementation(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class AppendableAnonymousImplementation

    public abstract class AppendableCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Appendable
    {
        public AppendableCallbackHelper() : base("java.lang.Appendable") {}

        public abstract global::Java.Lang.Appendable Append(global::Java.Lang.CharSequence csq);

        public abstract global::Java.Lang.Appendable Append(global::Java.Lang.CharSequence csq, int start, int end);

        public abstract global::Java.Lang.Appendable Append(char c);

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        if (methodName == "append" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Append(new global::Java.Lang.CharSequenceAnonymousImplementation(((AndroidJavaObject) args[0]).GetRawObject())));
        }
        else if (methodName == "append" && args.Length == 3)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Append(new global::Java.Lang.CharSequenceAnonymousImplementation(((AndroidJavaObject) args[0]).GetRawObject()), (int) args[1], (int) args[2]));
        }
        else if (methodName == "append" && args.Length == 1)
        {
        return Google.LibraryWrapper.Java.Utils.ToAndroidJavaObject(Append((char) args[0]));
        }
        return base.Invoke(methodName, args);
        }
    } // end class AppendableCallbackHelper
} // end namespace Java.Lang
