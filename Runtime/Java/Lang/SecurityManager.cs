using System;

using UnityEngine;

namespace Java.Lang
{
    public class SecurityManager : global::Google.LibraryWrapper.Java.JavaObject
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

        static SecurityManager()
        {
            AndroidJNI.AttachCurrentThread();
            IntPtr classObject = AndroidJNI.FindClass("java/lang/SecurityManager");
            _classObject = AndroidJNI.NewGlobalRef(classObject);
            AndroidJNI.DeleteLocalRef(classObject);
            _cachedConstructorId0 = AndroidJNI.GetMethodID(_classObject, "<init>", "()V");
            _cachedMethodId0 = AndroidJNI.GetMethodID(_classObject, "getInCheck", "()Z");
            _cachedMethodId1 = AndroidJNI.GetMethodID(_classObject, "getSecurityContext", "()Ljava/lang/Object;");
            _cachedMethodId2 = AndroidJNI.GetMethodID(_classObject, "checkPermission", "(Ljava/security/Permission;)V");
            _cachedMethodId3 = AndroidJNI.GetMethodID(_classObject, "checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V");
            _cachedMethodId4 = AndroidJNI.GetMethodID(_classObject, "checkCreateClassLoader", "()V");
            _cachedMethodId5 = AndroidJNI.GetMethodID(_classObject, "checkAccess", "(Ljava/lang/Thread;)V");
            _cachedMethodId6 = AndroidJNI.GetMethodID(_classObject, "checkAccess", "(Ljava/lang/ThreadGroup;)V");
            _cachedMethodId7 = AndroidJNI.GetMethodID(_classObject, "checkExit", "(I)V");
            _cachedMethodId8 = AndroidJNI.GetMethodID(_classObject, "checkExec", "(Ljava/lang/String;)V");
            _cachedMethodId9 = AndroidJNI.GetMethodID(_classObject, "checkLink", "(Ljava/lang/String;)V");
            _cachedMethodId10 = AndroidJNI.GetMethodID(_classObject, "checkRead", "(Ljava/io/FileDescriptor;)V");
            _cachedMethodId11 = AndroidJNI.GetMethodID(_classObject, "checkRead", "(Ljava/lang/String;)V");
            _cachedMethodId12 = AndroidJNI.GetMethodID(_classObject, "checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V");
            _cachedMethodId13 = AndroidJNI.GetMethodID(_classObject, "checkWrite", "(Ljava/io/FileDescriptor;)V");
            _cachedMethodId14 = AndroidJNI.GetMethodID(_classObject, "checkWrite", "(Ljava/lang/String;)V");
            _cachedMethodId15 = AndroidJNI.GetMethodID(_classObject, "checkDelete", "(Ljava/lang/String;)V");
            _cachedMethodId16 = AndroidJNI.GetMethodID(_classObject, "checkConnect", "(Ljava/lang/String;I)V");
            _cachedMethodId17 = AndroidJNI.GetMethodID(_classObject, "checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V");
            _cachedMethodId18 = AndroidJNI.GetMethodID(_classObject, "checkListen", "(I)V");
            _cachedMethodId19 = AndroidJNI.GetMethodID(_classObject, "checkAccept", "(Ljava/lang/String;I)V");
            _cachedMethodId20 = AndroidJNI.GetMethodID(_classObject, "checkMulticast", "(Ljava/net/InetAddress;)V");
            _cachedMethodId21 = AndroidJNI.GetMethodID(_classObject, "checkMulticast", "(Ljava/net/InetAddress;B)V");
            _cachedMethodId22 = AndroidJNI.GetMethodID(_classObject, "checkPropertiesAccess", "()V");
            _cachedMethodId23 = AndroidJNI.GetMethodID(_classObject, "checkPropertyAccess", "(Ljava/lang/String;)V");
            _cachedMethodId24 = AndroidJNI.GetMethodID(_classObject, "checkTopLevelWindow", "(Ljava/lang/Object;)Z");
            _cachedMethodId25 = AndroidJNI.GetMethodID(_classObject, "checkPrintJobAccess", "()V");
            _cachedMethodId26 = AndroidJNI.GetMethodID(_classObject, "checkSystemClipboardAccess", "()V");
            _cachedMethodId27 = AndroidJNI.GetMethodID(_classObject, "checkAwtEventQueueAccess", "()V");
            _cachedMethodId28 = AndroidJNI.GetMethodID(_classObject, "checkPackageAccess", "(Ljava/lang/String;)V");
            _cachedMethodId29 = AndroidJNI.GetMethodID(_classObject, "checkPackageDefinition", "(Ljava/lang/String;)V");
            _cachedMethodId30 = AndroidJNI.GetMethodID(_classObject, "checkSetFactory", "()V");
            _cachedMethodId31 = AndroidJNI.GetMethodID(_classObject, "checkMemberAccess", "(Ljava/lang/Class;I)V");
            _cachedMethodId32 = AndroidJNI.GetMethodID(_classObject, "checkSecurityAccess", "(Ljava/lang/String;)V");
            _cachedMethodId33 = AndroidJNI.GetMethodID(_classObject, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
        }

        public SecurityManager() : base(IntPtr.Zero)
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

        public SecurityManager(IntPtr rawObject) : base(IntPtr.Zero)
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
                    throw new ArgumentException("The provided reference is not an instance of SecurityManager.");
                }
                _rawObject = AndroidJNI.NewGlobalRef(rawObject);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool GetInCheck()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId0, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public global::Google.LibraryWrapper.Java.JavaObject GetSecurityContext()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                return new global::Google.LibraryWrapper.Java.JavaObject(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId1, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPermission(global::Java.ExternalType.Java.Security.Permission perm)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = perm.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId2, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPermission(global::Java.ExternalType.Java.Security.Permission perm, global::Google.LibraryWrapper.Java.JavaObject context)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = perm.GetRawObject() },
                            new jvalue { l = context.GetRawObject() }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId3, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckCreateClassLoader()
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

        public void CheckAccess(global::Java.Lang.Thread t)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = t.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId5, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckAccess(global::Java.Lang.ThreadGroup g)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = g.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId6, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckExit(int status)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = status } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId7, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckExec(global::System.String cmd)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(cmd) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId8, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckLink(global::System.String lib)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(lib) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId9, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckRead(global::Java.ExternalType.Java.Io.FileDescriptor fd)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = fd.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId10, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckRead(global::System.String file)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(file) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId11, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckRead(global::System.String file, global::Google.LibraryWrapper.Java.JavaObject context)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(file) },
                            new jvalue { l = context.GetRawObject() }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId12, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckWrite(global::Java.ExternalType.Java.Io.FileDescriptor fd)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = fd.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId13, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckWrite(global::System.String file)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(file) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId14, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckDelete(global::System.String file)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(file) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId15, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckConnect(global::System.String host, int port)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(host) },
                            new jvalue { i = port }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId16, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckConnect(global::System.String host, int port, global::Google.LibraryWrapper.Java.JavaObject context)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(host) },
                            new jvalue { i = port },
                            new jvalue { l = context.GetRawObject() }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId17, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckListen(int port)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { i = port } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId18, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckAccept(global::System.String host, int port)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(host) },
                            new jvalue { i = port }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId19, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckMulticast(global::Java.ExternalType.Java.Net.InetAddress maddr)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = maddr.GetRawObject() } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId20, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckMulticast(global::Java.ExternalType.Java.Net.InetAddress maddr, sbyte ttl)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = maddr.GetRawObject() },
                            new jvalue
                            {
                                #if UNITY_2019_1_OR_NEWER
                                b = ttl
                                #else
                                b = (byte)ttl
                                #endif
                            }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId21, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPropertiesAccess()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId22, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPropertyAccess(global::System.String key)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(key) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId23, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public bool CheckTopLevelWindow(global::Google.LibraryWrapper.Java.JavaObject window)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = window.GetRawObject() } };
                return AndroidJNI.CallBooleanMethod(_rawObject, _cachedMethodId24, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPrintJobAccess()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId25, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckSystemClipboardAccess()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId26, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckAwtEventQueueAccess()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId27, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPackageAccess(global::System.String pkg)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(pkg) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId28, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckPackageDefinition(global::System.String pkg)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(pkg) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId29, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckSetFactory()
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] {  };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId30, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckMemberAccess(global::Java.Lang.Class<global::Google.LibraryWrapper.Java.JavaObject> clazz, int which)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ =
                        new jvalue[]
                        {
                            new jvalue { l = clazz.GetRawObject() },
                            new jvalue { i = which }
                        };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId31, args_);
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public void CheckSecurityAccess(global::System.String target)
        {
            try
            {
                AndroidJNI.PushLocalFrame(0);
                jvalue[] args_ = new jvalue[] { new jvalue { l = global::Google.LibraryWrapper.Java.Utils.NewString(target) } };
                AndroidJNI.CallVoidMethod(_rawObject, _cachedMethodId32, args_);
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
                return new global::Java.Lang.ThreadGroup(AndroidJNI.CallObjectMethod(_rawObject, _cachedMethodId33, args_));
            }
            finally
            {
                AndroidJNI.PopLocalFrame(IntPtr.Zero);
            }
        }

        public static explicit operator IntPtr(SecurityManager wrapper)
        {
            return wrapper.GetRawObject();
        }

        public static explicit operator SecurityManager(IntPtr rawObject)
        {
            return new SecurityManager(rawObject);
        }

        public new static IntPtr GetRawClass()
        {
            return AndroidJNI.NewLocalRef(_classObject);
        }
    } // end class SecurityManager
} // end namespace Java.Lang
