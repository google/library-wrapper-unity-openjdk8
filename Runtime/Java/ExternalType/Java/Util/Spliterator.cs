using System;

using UnityEngine;

namespace Java.ExternalType.Java.Util
{
    public static class Spliterator
    {
        public interface OfDouble : global::Google.LibraryWrapper.Java.JavaInterface
        {
            public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfDouble
            {
                private static readonly IntPtr _classObject;

                static AnonymousImplementation()
                {
                    AndroidJNI.AttachCurrentThread();
                    IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator$OfDouble");
                    _classObject = AndroidJNI.NewGlobalRef(classObject);
                    AndroidJNI.DeleteLocalRef(classObject);
                }

                public AnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                            throw new ArgumentException("The provided reference is not an instance of AnonymousImplementation.");
                        }
                        _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                    }
                    finally
                    {
                        AndroidJNI.PopLocalFrame(IntPtr.Zero);
                    }
                }

                public static explicit operator IntPtr(AnonymousImplementation wrapper)
                {
                    return wrapper.GetRawObject();
                }

                public static explicit operator AnonymousImplementation(IntPtr rawObject)
                {
                    return new AnonymousImplementation(rawObject);
                }

                public new static IntPtr GetRawClass()
                {
                    return AndroidJNI.NewLocalRef(_classObject);
                }
            } // end class AnonymousImplementation

            public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator.OfDouble
            {
                public CallbackHelper() : base("java.util.Spliterator$OfDouble") {}

                public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
                {
                return base.Invoke(methodName, args);
                }
            } // end class CallbackHelper
        } // end class OfDouble

        public interface OfInt : global::Google.LibraryWrapper.Java.JavaInterface
        {
            public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfInt
            {
                private static readonly IntPtr _classObject;

                static AnonymousImplementation()
                {
                    AndroidJNI.AttachCurrentThread();
                    IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator$OfInt");
                    _classObject = AndroidJNI.NewGlobalRef(classObject);
                    AndroidJNI.DeleteLocalRef(classObject);
                }

                public AnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                            throw new ArgumentException("The provided reference is not an instance of AnonymousImplementation.");
                        }
                        _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                    }
                    finally
                    {
                        AndroidJNI.PopLocalFrame(IntPtr.Zero);
                    }
                }

                public static explicit operator IntPtr(AnonymousImplementation wrapper)
                {
                    return wrapper.GetRawObject();
                }

                public static explicit operator AnonymousImplementation(IntPtr rawObject)
                {
                    return new AnonymousImplementation(rawObject);
                }

                public new static IntPtr GetRawClass()
                {
                    return AndroidJNI.NewLocalRef(_classObject);
                }
            } // end class AnonymousImplementation

            public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator.OfInt
            {
                public CallbackHelper() : base("java.util.Spliterator$OfInt") {}

                public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
                {
                return base.Invoke(methodName, args);
                }
            } // end class CallbackHelper
        } // end class OfInt

        public interface OfLong : global::Google.LibraryWrapper.Java.JavaInterface
        {
            public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator.OfLong
            {
                private static readonly IntPtr _classObject;

                static AnonymousImplementation()
                {
                    AndroidJNI.AttachCurrentThread();
                    IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator$OfLong");
                    _classObject = AndroidJNI.NewGlobalRef(classObject);
                    AndroidJNI.DeleteLocalRef(classObject);
                }

                public AnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                            throw new ArgumentException("The provided reference is not an instance of AnonymousImplementation.");
                        }
                        _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                    }
                    finally
                    {
                        AndroidJNI.PopLocalFrame(IntPtr.Zero);
                    }
                }

                public static explicit operator IntPtr(AnonymousImplementation wrapper)
                {
                    return wrapper.GetRawObject();
                }

                public static explicit operator AnonymousImplementation(IntPtr rawObject)
                {
                    return new AnonymousImplementation(rawObject);
                }

                public new static IntPtr GetRawClass()
                {
                    return AndroidJNI.NewLocalRef(_classObject);
                }
            } // end class AnonymousImplementation

            public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator.OfLong
            {
                public CallbackHelper() : base("java.util.Spliterator$OfLong") {}

                public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
                {
                return base.Invoke(methodName, args);
                }
            } // end class CallbackHelper
        } // end class OfLong

    } // end class Spliterator
    public interface Spliterator<T0> : global::Google.LibraryWrapper.Java.JavaInterface where T0 : class
    {
        public new class AnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Util.Spliterator<T0>
        {
            private static readonly IntPtr _classObject;

            static AnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Spliterator");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
            }

            public AnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of AnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(AnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator AnonymousImplementation(IntPtr rawObject)
            {
                return new AnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class AnonymousImplementation

        public new abstract class CallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.ExternalType.Java.Util.Spliterator<T0>
        {
            public CallbackHelper() : base("java.util.Spliterator") {}

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            return base.Invoke(methodName, args);
            }
        } // end class CallbackHelper
    } // end class Spliterator
} // end namespace Java.ExternalType.Java.Util
