using System;

using UnityEngine;

namespace Java.Util
{
    public class Base64 : global::Google.LibraryWrapper.Java.JavaObject
    {
        public class Decoder : global::Google.LibraryWrapper.Java.JavaObject
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;

            static Decoder()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Base64$Decoder");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "wrap", "(Ljava/io/InputStream;)Ljava/io/InputStream;");
            }

            public Decoder() : base(IntPtr.Zero)
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

            public Decoder(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Decoder.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Nio.ByteBuffer Decode(global::Java.ExternalType.Java.Nio.ByteBuffer buffer)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = buffer.GetRawObject() } };
                    return new global::Java.ExternalType.Java.Nio.ByteBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Io.InputStream Wrap(global::Java.ExternalType.Java.Io.InputStream @is)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = @is.GetRawObject() } };
                    return new global::Java.ExternalType.Java.Io.InputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Decoder wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Decoder(IntPtr rawObject)
            {
                return new Decoder(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Decoder

        public class Encoder : global::Google.LibraryWrapper.Java.JavaObject
        {
            private static readonly IntPtr _classObject;
            private static readonly IntPtr _cachedConstructorId0;
            private static readonly IntPtr _cachedMethodId0;
            private static readonly IntPtr _cachedMethodId1;
            private static readonly IntPtr _cachedMethodId2;

            static Encoder()
            {
                AndroidJNI.AttachCurrentThread();
                IntPtr classObject = AndroidJNI.FindClass("java/util/Base64$Encoder");
                _classObject = AndroidJNI.NewGlobalRef(classObject);
                AndroidJNI.DeleteLocalRef(classObject);
                _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
                _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "encode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
                _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "wrap", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;");
                _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "withoutPadding", "()Ljava/util/Base64$Encoder;");
            }

            public Encoder() : base(IntPtr.Zero)
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

            public Encoder(IntPtr rawObject) : base(IntPtr.Zero)
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
                        throw new ArgumentException("The provided reference is not an instance of Encoder.");
                    }
                    _rawObject = AndroidJNI.NewGlobalRef(rawObject);
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Nio.ByteBuffer Encode(global::Java.ExternalType.Java.Nio.ByteBuffer buffer)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = buffer.GetRawObject() } };
                    return new global::Java.ExternalType.Java.Nio.ByteBuffer(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId0, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.ExternalType.Java.Io.OutputStream Wrap(global::Java.ExternalType.Java.Io.OutputStream os)
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] { new jvalue { l = os.GetRawObject() } };
                    return new global::Java.ExternalType.Java.Io.OutputStream(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public global::Java.Util.Base64.Encoder WithoutPadding()
            {
                try
                {
                    AndroidJNI.PushLocalFrame(0);
                    jvalue[] args_ = new jvalue[] {  };
                    return new global::Java.Util.Base64.Encoder(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId2, args_));
                }
                finally
                {
                    AndroidJNI.PopLocalFrame(IntPtr.Zero);
                }
            }

            public static explicit operator IntPtr(Encoder wrapper)
            {
                return wrapper.GetRawObject();
            }

            public static explicit operator Encoder(IntPtr rawObject)
            {
                return new Encoder(rawObject);
            }

            public new static IntPtr GetRawClass()
            {
                return AndroidJNI.NewLocalRef(_classObject);
            }
        } // end class Encoder

        private static readonly IntPtr _classObject;
        private static readonly IntPtr _cachedMethodId0;
        private static readonly IntPtr _cachedMethodId1;
        private static readonly IntPtr _cachedMethodId2;
        private static readonly IntPtr _cachedMethodId3;
        private static readonly IntPtr _cachedMethodId4;
        private static readonly IntPtr _cachedMethodId5;

        static Base64()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/util/Base64");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedMethodId0 = AndroidJNI.GetStaticMethodID(_classObject, "getEncoder", "()Ljava/util/Base64$Encoder;");
            _cachedMethodId1 = AndroidJNI.GetStaticMethodID(_classObject, "getUrlEncoder", "()Ljava/util/Base64$Encoder;");
            _cachedMethodId2 = AndroidJNI.GetStaticMethodID(_classObject, "getMimeEncoder", "()Ljava/util/Base64$Encoder;");
            _cachedMethodId3 = AndroidJNI.GetStaticMethodID(_classObject, "getDecoder", "()Ljava/util/Base64$Decoder;");
            _cachedMethodId4 = AndroidJNI.GetStaticMethodID(_classObject, "getUrlDecoder", "()Ljava/util/Base64$Decoder;");
            _cachedMethodId5 = AndroidJNI.GetStaticMethodID(_classObject, "getMimeDecoder", "()Ljava/util/Base64$Decoder;");
        }

        public Base64(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of Base64.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Base64.Encoder GetEncoder()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Base64.Encoder(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId0, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Base64.Encoder GetUrlEncoder()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Base64.Encoder(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Base64.Encoder GetMimeEncoder()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Base64.Encoder(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId2, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Base64.Decoder GetDecoder()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Base64.Decoder(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId3, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Base64.Decoder GetUrlDecoder()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Base64.Decoder(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId4, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static global::Java.Util.Base64.Decoder GetMimeDecoder()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Java.Util.Base64.Decoder(AndroidJNI.CallStaticObjectMethod(_classObject, _cachedMethodId5, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(Base64 wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator Base64(IntPtr rawObject)
        {
            return new Base64(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class Base64
} // end namespace Java.Util
