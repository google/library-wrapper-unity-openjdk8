using System;

using UnityEngine;

namespace Java.Lang
{
    public class Class<T> : global::Google.LibraryWrapper.Java.JavaObject, global::Java.ExternalType.Java.Io.Serializable, global::Java.ExternalType.Java.Lang.Reflect.GenericDeclaration, global::Java.ExternalType.Java.Lang.Reflect.Type, global::Java.ExternalType.Java.Lang.Reflect.AnnotatedElement where T : class
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

        static Class()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/Class");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "toGenericString", "()Ljava/lang/String;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "newInstance", "()Ljava/lang/Object;");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "isInstance", "(Ljava/lang/Object;)Z");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "isAssignableFrom", "(Ljava/lang/Class;)Z");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "isInterface", "()Z");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "isArray", "()Z");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "isPrimitive", "()Z");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "isAnnotation", "()Z");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "isSynthetic", "()Z");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "getName", "()Ljava/lang/String;");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "getClassLoader", "()Ljava/lang/ClassLoader;");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "getSuperclass", "()Ljava/lang/Class;");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "getGenericSuperclass", "()Ljava/lang/reflect/Type;");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "getPackage", "()Ljava/lang/Package;");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "getComponentType", "()Ljava/lang/Class;");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "getModifiers", "()I");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "getEnclosingMethod", "()Ljava/lang/reflect/Method;");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "getDeclaringClass", "()Ljava/lang/Class;");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "getEnclosingClass", "()Ljava/lang/Class;");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "getSimpleName", "()Ljava/lang/String;");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "getTypeName", "()Ljava/lang/String;");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "getCanonicalName", "()Ljava/lang/String;");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "isAnonymousClass", "()Z");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "isLocalClass", "()Z");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "isMemberClass", "()Z");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "getProtectionDomain", "()Ljava/security/ProtectionDomain;");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "desiredAssertionStatus", "()Z");
            _cachedMethodId34 = AndroidJNI.GetMethodID(_classObject, "isEnum", "()Z");
            _cachedMethodId35 = AndroidJNI.GetMethodID(_classObject, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;");
            _cachedMethodId36 = AndroidJNI.GetMethodID(_classObject, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;");
            _cachedMethodId37 = AndroidJNI.GetMethodID(_classObject, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
            _cachedMethodId38 = AndroidJNI.GetMethodID(_classObject, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
            _cachedMethodId39 = AndroidJNI.GetMethodID(_classObject, "getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
            _cachedMethodId40 = AndroidJNI.GetMethodID(_classObject, "getAnnotatedSuperclass", "()Ljava/lang/reflect/AnnotatedType;");
        }

        public Class() : base(IntPtr.Zero)
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

        public Class(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Class.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String ToGenericString()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> ForName(global::System.String className)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(className) } };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> ForName(global::System.String name, bool initialize, global::Java.Lang.ClassLoader loader)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) },
                            new jvalue { z = initialize },
                            new jvalue { l = loader.GetRawObject() }
                        };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T NewInstance()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId3, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId3, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsInstance(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId4, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsAssignableFrom(global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> cls)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = cls.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsInterface()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsArray()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsPrimitive()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsAnnotation()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsSynthetic()
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

        public global::System.String GetName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.ClassLoader GetClassLoader()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.ClassLoader(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId12, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<T> GetSuperclass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Class<T>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId13, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Lang.Reflect.Type GetGenericSuperclass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Lang.Reflect.TypeAnonymousImplementation(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId14, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Package GetPackage()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Package(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId15, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> GetComponentType()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId16, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public int GetModifiers()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallIntMethod(_rawObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Lang.Reflect.Method GetEnclosingMethod()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Lang.Reflect.Method(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId18, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Lang.Reflect.Constructor<global::Google.LibraryWrapper.Java.JavaObject> GetEnclosingConstructor()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Lang.Reflect.Constructor<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId19, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> GetDeclaringClass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId20, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> GetEnclosingClass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId21, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetSimpleName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetTypeName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::System.String GetCanonicalName()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsAnonymousClass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsLocalClass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsMemberClass()
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

        public global::Java.ExternalType.Java.Lang.Reflect.Field GetField(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Lang.Reflect.Field(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId28, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Lang.Reflect.Field GetDeclaredField(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Lang.Reflect.Field(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId29, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Io.InputStream GetResourceAsStream(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId30, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Net.URL GetResource(global::System.String name)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(name) } };
                return new global::Java.ExternalType.Java.Net.URL(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId31, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Security.ProtectionDomain GetProtectionDomain()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Security.ProtectionDomain(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId32, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool DesiredAssertionStatus()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId33, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsEnum()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId34, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public T Cast(global::Google.LibraryWrapper.Java.JavaObject obj)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = obj.GetRawObject() } };
                if (typeof(T) == typeof(global::System.String))
                {
                    return (T) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId35, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId35, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<T>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.Lang.Class<U> AsSubclass<U>(global::Java.Lang.Class<U> clazz) where U : class
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = clazz.GetRawObject() } };
                return new global::Java.Lang.Class<U>(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId36, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public A GetAnnotation<A>(global::Java.Lang.Class<A> annotationClass) where A : class, global::Java.ExternalType.Java.Lang.Annotation.Annotation
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = annotationClass.GetRawObject() } };
                if (typeof(A) == typeof(global::System.String))
                {
                    return (A) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId37, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId37, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<A>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool IsAnnotationPresent(global::Java.Lang.Class<global::Java.ExternalType.Java.Lang.Annotation.Annotation> annotationClass)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = annotationClass.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId38, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public A GetDeclaredAnnotation<A>(global::Java.Lang.Class<A> annotationClass) where A : class, global::Java.ExternalType.Java.Lang.Annotation.Annotation
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = annotationClass.GetRawObject() } };
                if (typeof(A) == typeof(global::System.String))
                {
                    return (A) (global::System.Object) AndroidJNI.CallStringMethod(_rawObject, _cachedMethodId39, args_);
                }
                else
                {
                    IntPtr result_ = AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId39, args_);
                    return Google.LibraryWrapper.Java.Utils.CreateGenericInstance<A>(result_);
                }
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Java.ExternalType.Java.Lang.Reflect.AnnotatedType GetAnnotatedSuperclass()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.ExternalType.Java.Lang.Reflect.AnnotatedType(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId40, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Class<T> wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Class<T>(IntPtr rawObject)
        {
            return new Class<T>(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Class
} // end namespace Java.Lang
