using System;

using UnityEngine;

namespace Java.Lang
{
    public class Thread : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Runnable
    {
        public class State : global::Java.Lang.Enum<global::Java.Lang.Thread.State>
        {
            public static global::Java.Lang.Thread.State NEW
            {
                get
                {
                    return new global::Java.Lang.Thread.State(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId0));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId0, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Thread.State RUNNABLE
            {
                get
                {
                    return new global::Java.Lang.Thread.State(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId1));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId1, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Thread.State BLOCKED
            {
                get
                {
                    return new global::Java.Lang.Thread.State(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId2));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId2, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Thread.State WAITING
            {
                get
                {
                    return new global::Java.Lang.Thread.State(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId3));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId3, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Thread.State TIMED_WAITING
            {
                get
                {
                    return new global::Java.Lang.Thread.State(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId4));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId4, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }
            public static global::Java.Lang.Thread.State TERMINATED
            {
                get
                {
                    return new global::Java.Lang.Thread.State(AndroidJNI.GetStaticObjectField(_classObject, _cachedFieldId5));
                }
                set
                {
                    IntPtr valueRef = value.GetRawObject();
                    AndroidJNI.SetStaticObjectField(_classObject, _cachedFieldId5, valueRef);
                    AndroidJNI.DeleteLocalRef(valueRef);
                }
            }

            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedFieldId0;
            private static readonly IntPtr _cachedFieldId1;
            private static readonly IntPtr _cachedFieldId2;
            private static readonly IntPtr _cachedFieldId3;
            private static readonly IntPtr _cachedFieldId4;
            private static readonly IntPtr _cachedFieldId5;
            private static readonly IntPtr _cachedMethodId0;

            static State()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/Thread$State");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "NEW", "Ljava/lang/Thread$State;");
                _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "RUNNABLE", "Ljava/lang/Thread$State;");
                _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "BLOCKED", "Ljava/lang/Thread$State;");
                _cachedFieldId3 = AndroidJNI.GetStaticFieldID(_classObject, "WAITING", "Ljava/lang/Thread$State;");
                _cachedFieldId4 = AndroidJNI.GetStaticFieldID(_classObject, "TIMED_WAITING", "Ljava/lang/Thread$State;");
                _cachedFieldId5 = AndroidJNI.GetStaticFieldID(_classObject, "TERMINATED", "Ljava/lang/Thread$State;");
                _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
            }

            public State(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of State.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static global::Java.Lang.Thread.State ValueOf(global::System.String name)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                    return new global::Java.Lang.Thread.State(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(State wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator State(IntPtr rawObject)
            {
                return new State(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class State

        public interface UncaughtExceptionHandler : global::Google.LibraryWrapper.Java.JavaInterface
        {

            void UncaughtException(global::Java.Lang.Thread t, global::Java.Lang.Throwable e);
        } // end class UncaughtExceptionHandler

        public class UncaughtExceptionHandlerAnonymousImplementation : global::Google.LibraryWrapper.Java.JavaObject, global::Java.Lang.Thread.UncaughtExceptionHandler
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedMethodId0;

            static UncaughtExceptionHandlerAnonymousImplementation()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/lang/Thread$UncaughtExceptionHandler");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
            }

            public UncaughtExceptionHandlerAnonymousImplementation(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of UncaughtExceptionHandlerAnonymousImplementation.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public void UncaughtException(global::Java.Lang.Thread t, global::Java.Lang.Throwable e)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ =
                            new jvalue[]
                            {
                                new jvalue { l = t.GetRawObject() },
                                new jvalue { l = e.GetRawObject() }
                            };
                    AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId0, args_);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(UncaughtExceptionHandlerAnonymousImplementation wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator UncaughtExceptionHandlerAnonymousImplementation(IntPtr rawObject)
            {
                return new UncaughtExceptionHandlerAnonymousImplementation(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class UncaughtExceptionHandlerAnonymousImplementation

        public abstract class UncaughtExceptionHandlerCallbackHelper : global::Google.LibraryWrapper.Java.JavaProxy, global::Java.Lang.Thread.UncaughtExceptionHandler
        {
            public UncaughtExceptionHandlerCallbackHelper() : base("java.lang.Thread$UncaughtExceptionHandler") {}

            public abstract void UncaughtException(global::Java.Lang.Thread t, global::Java.Lang.Throwable e);

            public override sealed AndroidJavaObject Invoke(global::System.String methodName, global::System.Object[] args)
            {
            if (methodName == "uncaughtException" && args.Length == 2)
            {
            UncaughtException(new global::Java.Lang.Thread(((AndroidJavaObject) args[0]).GetRawObject()), new global::Java.Lang.Throwable(((AndroidJavaObject) args[1]).GetRawObject()));
            return null;
            }
            return base.Invoke(methodName, args);
            }
        } // end class UncaughtExceptionHandlerCallbackHelper

        public static int MIN_PRIORITY
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
        public static int NORM_PRIORITY
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
        public static int MAX_PRIORITY
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
        private static readonly IntPtr _cachedConstructorId4;
        private static readonly IntPtr _cachedConstructorId5;
        private static readonly IntPtr _cachedConstructorId6;
        private static readonly IntPtr _cachedConstructorId7;
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

        static Thread()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Thread");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedFieldId0 = AndroidJNI.GetStaticFieldID(_classObject, "MIN_PRIORITY", "I");
            _cachedFieldId1 = AndroidJNI.GetStaticFieldID(_classObject, "NORM_PRIORITY", "I");
            _cachedFieldId2 = AndroidJNI.GetStaticFieldID(_classObject, "MAX_PRIORITY", "I");
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedConstructorId1 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Runnable;)V");
            _cachedConstructorId2 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
            _cachedConstructorId3 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/String;)V");
            _cachedConstructorId4 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
            _cachedConstructorId5 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
            _cachedConstructorId6 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
            _cachedConstructorId7 = AndroidJNI.GetMethodID(_classObject, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "currentThread", "()Ljava/lang/Thread;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "yield", "()V");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "sleep", "(J)V");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "sleep", "(JI)V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "start", "()V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "run", "()V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "stop", "()V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "stop", "(Ljava/lang/Throwable;)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "interrupt", "()V");
            _cachedMethodId9 = AndroidJNI.GetStaticMethodID(_classObject, "interrupted", "()Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "isInterrupted", "()Z");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "destroy", "()V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "isAlive", "()Z");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "suspend", "()V");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "resume", "()V");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "setPriority", "(I)V");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "getPriority", "()I");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "setName", "(Ljava/lang/String;)V");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "getName", "()Ljava/lang/String;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
            _cachedMethodId20 = AndroidJNI.GetStaticMethodID(_classObject, "activeCount", "()I");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "countStackFrames", "()I");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "join", "(J)V");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "join", "(JI)V");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "join", "()V");
            _cachedMethodId25 = AndroidJNI.GetStaticMethodID(_classObject, "dumpStack", "()V");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "setDaemon", "(Z)V");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "isDaemon", "()Z");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "checkAccess", "()V");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
            _cachedMethodId31 = AndroidJNI.GetStaticMethodID(_classObject, "holdsLock", "(Ljava/lang/Object;)Z");
            _cachedMethodId32 = AndroidJNI.GetStaticMethodID(_classObject, "getAllStackTraces", "()Ljava/util/Map;");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "getId", "()J");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "getState", "()Ljava/lang/Thread$State;");
            _cachedMethodId35 = AndroidJNI.GetStaticMethodID(_classObject, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
            _cachedMethodId36 = AndroidJNI.GetStaticMethodID(_classObject, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
            _cachedMethodId37 = AndroidJNI.GetMethodID(_classObject, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
            _cachedMethodId38 = AndroidJNI.GetMethodID(_classObject, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
        }

        public Thread() : base(IntPtr.Zero)
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

        public Thread(global::Java.Lang.Runnable target) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = target.GetRawObject() } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId1, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(global::Java.Lang.ThreadGroup group, global::Java.Lang.Runnable target) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = group.GetRawObject() },
                            new jvalue { l = target.GetRawObject() }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId2, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(global::System.String name) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId3, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(global::Java.Lang.ThreadGroup group, global::System.String name) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = group.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId4, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(global::Java.Lang.Runnable target, global::System.String name) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = target.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId5, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(global::Java.Lang.ThreadGroup group, global::Java.Lang.Runnable target, global::System.String name) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = group.GetRawObject() },
                            new jvalue { l = target.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId6, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(global::Java.Lang.ThreadGroup group, global::Java.Lang.Runnable target, global::System.String name, long stackSize) : base(IntPtr.Zero)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = group.GetRawObject() },
                            new jvalue { l = target.GetRawObject() },
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) },
                            new jvalue { j = stackSize }
                        };
                IntPtr rawObject_ = AndroidJNI.NewObject(_classObject, _cachedConstructorId7, args_);
                _rawObject = AndroidJNI.NewGlobalRef(rawObject_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public Thread(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Thread.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Thread CurrentThread()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Thread(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Yield()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId1, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Sleep(long millis)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = millis } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void Sleep(long millis, int nanos)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = millis },
                            new jvalue { i = nanos }
                        };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Start()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Run()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Stop()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Stop(global::Java.Lang.Throwable obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Interrupt()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool Interrupted()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsInterrupted()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Destroy()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsAlive()
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

        public void Suspend()
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

        public void Resume()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetPriority(int newPriority)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = newPriority } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetPriority()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetName(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.ThreadGroup GetThreadGroup()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.ThreadGroup(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static int ActiveCount()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStaticIntMethod(_classObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int CountStackFrames()
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

        public void Join(long millis)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { j = millis } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Join(long millis, int nanos)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { j = millis },
                            new jvalue { i = nanos }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void Join()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void DumpStack()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetDaemon(bool on)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { z = on } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsDaemon()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckAccess()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.ClassLoader GetContextClassLoader()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.ClassLoader(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId29, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetContextClassLoader(global::Java.Lang.ClassLoader cl)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = cl.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static bool HoldsLock(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallStaticBooleanMethod(_classObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Map<global::Java.Lang.Thread, global::Java.Lang.StackTraceElement> GetAllStackTraces()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.MapAnonymousImplementation<global::Java.Lang.Thread, global::Java.Lang.StackTraceElement>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId32, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public long GetId()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallLongMethod(_rawObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Thread.State GetState()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Thread.State(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId34, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static void SetDefaultUncaughtExceptionHandler(global::Java.Lang.Thread.UncaughtExceptionHandler eh)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = eh.GetRawObject() } };
                AndroidJNI.CallStaticVoidMethod(_classObject, _cachedMethodId35, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Thread.UncaughtExceptionHandler GetDefaultUncaughtExceptionHandler()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Thread.UncaughtExceptionHandlerAnonymousImplementation(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId36, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Thread.UncaughtExceptionHandler GetUncaughtExceptionHandler()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Thread.UncaughtExceptionHandlerAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId37, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void SetUncaughtExceptionHandler(global::Java.Lang.Thread.UncaughtExceptionHandler eh)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = eh.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Thread wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Thread(IntPtr rawObject)
        {
            return new Thread(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Thread
} // end namespace Java.Lang
