using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util
{
    public static class Spliterator
    {
        public interface OfDouble : global::Google.LibraryWrapper.Java.JavaInterface
        {
        } // end class OfDouble

        public class OfDoubleAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfDouble
        {
            private static readonly IntPtr _classObject;

            static OfDoubleAnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator$OfDouble");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
            }

            public OfDoubleAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of OfDoubleAnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(OfDoubleAnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator OfDoubleAnonymousImplementation(IntPtr rawObject)
            {
                return new OfDoubleAnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class OfDoubleAnonymousImplementation

        public abstract class OfDoubleCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator.OfDouble
        {
            public OfDoubleCallbackHelper() : base("java.util.Spliterator$OfDouble") {}

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            return base.Invoke(methodName, args);
            }
        } // end class OfDoubleCallbackHelper

        public interface OfInt : global::Google.LibraryWrapper.Java.JavaInterface
        {
        } // end class OfInt

        public class OfIntAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfInt
        {
            private static readonly IntPtr _classObject;

            static OfIntAnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator$OfInt");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
            }

            public OfIntAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of OfIntAnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(OfIntAnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator OfIntAnonymousImplementation(IntPtr rawObject)
            {
                return new OfIntAnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class OfIntAnonymousImplementation

        public abstract class OfIntCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator.OfInt
        {
            public OfIntCallbackHelper() : base("java.util.Spliterator$OfInt") {}

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            return base.Invoke(methodName, args);
            }
        } // end class OfIntCallbackHelper

        public interface OfLong : global::Google.LibraryWrapper.Java.JavaInterface
        {
        } // end class OfLong

        public class OfLongAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfLong
        {
            private static readonly IntPtr _classObject;

            static OfLongAnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator$OfLong");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
            }

            public OfLongAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of OfLongAnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(OfLongAnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator OfLongAnonymousImplementation(IntPtr rawObject)
            {
                return new OfLongAnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class OfLongAnonymousImplementation

        public abstract class OfLongCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator.OfLong
        {
            public OfLongCallbackHelper() : base("java.util.Spliterator$OfLong") {}

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            return base.Invoke(methodName, args);
            }
        } // end class OfLongCallbackHelper

    } // end class Spliterator
    public interface Spliterator<T0> : global::Google.LibraryWrapper.Java.JavaInterface where T0 : class
    {
    } // end class Spliterator

    public class SpliteratorAnonymousImplementation<T0> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator<T0> where T0 : class
    {
        private static readonly IntPtr _classObject;

        static SpliteratorAnonymousImplementation()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
        }

        public SpliteratorAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of SpliteratorAnonymousImplementation.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(SpliteratorAnonymousImplementation<T0> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator SpliteratorAnonymousImplementation<T0>(IntPtr rawObject)
        {
            return new SpliteratorAnonymousImplementation<T0>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class SpliteratorAnonymousImplementation

    public abstract class SpliteratorCallbackHelper<T0> : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator<T0> where T0 : class
    {
        public SpliteratorCallbackHelper() : base("java.util.Spliterator") {}

        public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
        {
        return base.Invoke(methodName, args);
        }
    } // end class SpliteratorCallbackHelper
} // end namespace Java.ExternalType.Java.Util
