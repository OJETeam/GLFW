using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OJE.GLFW
{
    public static unsafe class Glfw
    {
        public enum Key
        {
            Unknown,
            Space,
            Apostrophe,
            Comma,
            Minus,
            Period,
        }
        public const int KEY_UNKNOWN = -1;
        public const int KEY_SPACE = 32;
        public const int KEY_APOSTROPHE = 39;
        public const int KEY_COMMA = 44;
        public const int KEY_MINUS = 45; /* - */
        public const int KEY_PERIOD = 46; /* . */
        public const int KEY_SLASH = 47; /* / */
        public const int KEY_0 = 48;
        public const int KEY_1 = 49;
        public const int KEY_2 = 50;
        public const int KEY_3 = 51;
        public const int KEY_4 = 52;
        public const int KEY_5 = 53;
        public const int KEY_6 = 54;
        public const int KEY_7 = 55;
        public const int KEY_8 = 56;
        public const int KEY_9 = 57;
        public const int KEY_SEMICOLON = 59;/* ; */
        public const int KEY_EQUAL = 61;/* = */
        public const int KEY_A = 65;
        public const int KEY_B = 66;
        public const int KEY_C = 67;
        public const int KEY_D = 68;
        public const int KEY_E = 69;
        public const int KEY_F = 70;
        public const int KEY_G = 71;
        public const int KEY_H = 72;
        public const int KEY_I = 73;
        public const int KEY_J = 74;
        public const int KEY_K = 75;
        public const int KEY_L = 76;
        public const int KEY_M = 77;
        public const int KEY_N = 78;
        public const int KEY_O = 79;
        public const int KEY_P = 80;
        public const int KEY_Q = 81;
        public const int KEY_R = 82;
        public const int KEY_S = 83;
        public const int KEY_T = 84;
        public const int KEY_U = 85;
        public const int KEY_V = 86;
        public const int KEY_W = 87;
        public const int KEY_X = 88;
        public const int KEY_Y = 89;
        public const int KEY_Z = 90;
        public const int KEY_LEFT_BRACKET = 91; /* [ */
        public const int KEY_BACKSLASH = 92; /* \ */
        public const int KEY_RIGHT_BRACKET = 93;/* ] */
        public const int KEY_GRAVE_ACCENT = 96; /* ` */
        public const int KEY_WORLD_1 = 161; /* non-US #1 */
        public const int KEY_WORLD_2 = 162; /* non-US #2 */
        public const int KEY_ESCAPE = 256;
        public const int KEY_ENTER = 257;
        public const int KEY_TAB = 258;
        public const int KEY_BACKSPACE = 259;
        public const int KEY_INSERT = 260;
        public const int KEY_DELETE = 261;
        public const int KEY_RIGHT = 262;
        public const int KEY_LEFT = 263;
        public const int KEY_DOWN = 264;
        public const int KEY_UP = 265;
        public const int KEY_PAGE_UP = 266;
        public const int KEY_PAGE_DOWN = 267;
        public const int KEY_HOME = 268;
        public const int KEY_END = 269;
        public const int KEY_CAPS_LOCK = 280;
        public const int KEY_SCROLL_LOCK = 281;
        public const int KEY_NUM_LOCK = 282;
        public const int KEY_PRINT_SCREEN = 283;
        public const int KEY_PAUSE = 284;
        public const int KEY_F1 = 290;
        public const int KEY_F2 = 291;
        public const int KEY_F3 = 292;
        public const int KEY_F4 = 293;
        public const int KEY_F5 = 294;
        public const int KEY_F6 = 295;
        public const int KEY_F7 = 296;
        public const int KEY_F8 = 297;
        public const int KEY_F9 = 298;
        public const int KEY_F10 = 299;
        public const int KEY_F11 = 300;
        public const int KEY_F12 = 301;
        public const int KEY_F13 = 302;
        public const int KEY_F14 = 303;
        public const int KEY_F15 = 304;
        public const int KEY_F16 = 305;
        public const int KEY_F17 = 306;
        public const int KEY_F18 = 307;
        public const int KEY_F19 = 308;
        public const int KEY_F20 = 309;
        public const int KEY_F21 = 310;
        public const int KEY_F22 = 311;
        public const int KEY_F23 = 312;
        public const int KEY_F24 = 313;
        public const int KEY_F25 = 314;
        public const int KEY_KP_0 = 320;
        public const int KEY_KP_1 = 321;
        public const int KEY_KP_2 = 322;
        public const int KEY_KP_3 = 323;
        public const int KEY_KP_4 = 324;
        public const int KEY_KP_5 = 325;
        public const int KEY_KP_6 = 326;
        public const int KEY_KP_7 = 327;
        public const int KEY_KP_8 = 328;
        public const int KEY_KP_9 = 329;
        public const int KEY_KP_DECIMAL = 330;
        public const int KEY_KP_DIVIDE = 331;
        public const int KEY_KP_MULTIPLY = 332;
        public const int KEY_KP_SUBTRACT = 333;
        public const int KEY_KP_ADD = 334;
        public const int KEY_KP_ENTER = 335;
        public const int KEY_KP_EQUAL = 336;
        public const int KEY_LEFT_SHIFT = 340;
        public const int KEY_LEFT_CONTROL = 341;
        public const int KEY_LEFT_ALT = 342;
        public const int KEY_LEFT_SUPER = 343;
        public const int KEY_RIGHT_SHIFT = 344;
        public const int KEY_RIGHT_CONTROL = 345;
        public const int KEY_RIGHT_ALT = 346;
        public const int KEY_RIGHT_SUPER = 347;
        public const int KEY_MENU = 348;
        public const int KEY_LAST = KEY_MENU;
        public const int MOD_SHIFT = 0x0001;
        public const int MOD_CONTROL = 0x0002;
        public const int MOD_ALT = 0x0004;
        public const int MOD_SUPER = 0x0008;
        public const int MOUSE_BUTTON_1 = 0;
        public const int MOUSE_BUTTON_2 = 1;
        public const int MOUSE_BUTTON_3 = 2;
        public const int MOUSE_BUTTON_4 = 3;
        public const int MOUSE_BUTTON_5 = 4;
        public const int MOUSE_BUTTON_6 = 5;
        public const int MOUSE_BUTTON_7 = 6;
        public const int MOUSE_BUTTON_8 = 7;
        public const int MOUSE_BUTTON_LAST = MOUSE_BUTTON_8;
        public const int MOUSE_BUTTON_LEFT = MOUSE_BUTTON_1;
        public const int MOUSE_BUTTON_RIGHT = MOUSE_BUTTON_2;
        public const int MOUSE_BUTTON_MIDDLE = MOUSE_BUTTON_3;
        public const int JOYSTICK_1 = 0;
        public const int JOYSTICK_2 = 1;
        public const int JOYSTICK_3 = 2;
        public const int JOYSTICK_4 = 3;
        public const int JOYSTICK_5 = 4;
        public const int JOYSTICK_6 = 5;
        public const int JOYSTICK_7 = 6;
        public const int JOYSTICK_8 = 7;
        public const int JOYSTICK_9 = 8;
        public const int JOYSTICK_10 = 9;
        public const int JOYSTICK_11 = 10;
        public const int JOYSTICK_12 = 11;
        public const int JOYSTICK_13 = 12;
        public const int JOYSTICK_14 = 13;
        public const int JOYSTICK_15 = 14;
        public const int JOYSTICK_16 = 15;
        public const int JOYSTICK_LAST = JOYSTICK_16;
        public const int NOT_INITIALIZED = 0x00010001;
        public const int NO_CURRENT_CONTEXT = 0x00010002;
        public const int INVALID_ENUM = 0x00010003;
        public const int INVALID_VALUE = 0x00010004;
        public const int OUT_OF_MEMORY = 0x00010005;
        public const int API_UNAVAILABLE = 0x00010006;
        public const int VERSION_UNAVAILABLE = 0x00010007;
        public const int PLATFORM_ERROR = 0x00010008;
        public const int FORMAT_UNAVAILABLE = 0x00010009;
        public const int FOCUSED = 0x00020001;
        public const int ICONIFIED = 0x00020002;
        public const int RESIZABLE = 0x00020003;
        public const int VISIBLE = 0x00020004;
        public const int DECORATED = 0x00020005;
        public const int RED_BITS = 0x00021001;
        public const int GREEN_BITS = 0x00021002;
        public const int BLUE_BITS = 0x00021003;
        public const int ALPHA_BITS = 0x00021004;
        public const int DEPTH_BITS = 0x00021005;
        public const int STENCIL_BITS = 0x00021006;
        public const int ACCUM_RED_BITS = 0x00021007;
        public const int ACCUM_GREEN_BITS = 0x00021008;
        public const int ACCUM_BLUE_BITS = 0x00021009;
        public const int ACCUM_ALPHA_BITS = 0x0002100A;
        public const int AUX_BUFFERS = 0x0002100B;
        public const int STEREO = 0x0002100C;
        public const int SAMPLES = 0x0002100D;
        public const int SRGB_CAPABLE = 0x0002100E;
        public const int REFRESH_RATE = 0x0002100F;
        public const int CLIENT_API = 0x00022001;
        public const int CONTEXT_VERSION_MAJOR = 0x00022002;
        public const int CONTEXT_VERSION_MINOR = 0x00022003;
        public const int CONTEXT_REVISION = 0x00022004;
        public const int CONTEXT_ROBUSTNESS = 0x00022005;
        public const int OPENGL_FORWARD_COMPAT = 0x00022006;
        public const int OPENGL_DEBUG_CONTEXT = 0x00022007;
        public const int OPENGL_PROFILE = 0x00022008;
        public const int OPENGL_API = 0x00030001;
        public const int OPENGL_ES_API = 0x00030002;
        public const int NO_ROBUSTNESS = 0;
        public const int NO_RESET_NOTIFICATION = 0x00031001;
        public const int LOSE_CONTEXT_ON_RESET = 0x00031002;
        public const int OPENGL_ANY_PROFILE = 0;
        public const int OPENGL_CORE_PROFILE = 0x00032001;
        public const int OPENGL_COMPAT_PROFILE = 0x00032002;
        public const int CURSOR = 0x00033001;
        public const int STICKY_KEYS = 0x00033002;
        public const int STICKY_MOUSE_BUTTONS = 0x00033003;
        public const int CURSOR_NORMAL = 0x00034001;
        public const int CURSOR_HIDDEN = 0x00034002;
        public const int CURSOR_DISABLED = 0x00034003;
        public const int CONNECTED = 0x00040001;
        public const int DISCONNECTED = 0x00040002;
        public const int VERSION_MAJOR = 3;
        public const int VERSION_MINOR = 0;
        public const int VERSION_REVISION = 4;
        public const int RELEASE = 0;
        public const int PRESS = 1;

        [StructLayout(LayoutKind.Explicit)]
        public struct Window
        {
            private Window(IntPtr ptr)
            {
                inner_ptr = ptr;
            }

            [FieldOffsetAttribute(0)]
            private IntPtr
                inner_ptr;

            public readonly static Window NULL = new Window(IntPtr.Zero);
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Monitor
        {
            private Monitor(IntPtr ptr)
            {
                inner_ptr = ptr;
            }

            [FieldOffsetAttribute(0)]
            private IntPtr
                inner_ptr;

            public readonly static Monitor NULL = new Monitor(IntPtr.Zero);
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct GammaRampInternal
        {
            public uint* Red;
            public uint* Green;
            public uint* Blue;
            public uint Length;
        }

        [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 6)]
        public struct Vidmode
        {
            [FieldOffset(sizeof(int) * 0)]
            public int Width;
            [FieldOffset(sizeof(int) * 1)]
            public int Height;
            [FieldOffset(sizeof(int) * 2)]
            public int RedBits;
            [FieldOffset(sizeof(int) * 3)]
            public int BlueBits;
            [FieldOffset(sizeof(int) * 4)]
            public int GreenBits;
            [FieldOffset(sizeof(int) * 5)]
            public int RefreshRate;
        }

        public struct GammaRamp
        {
            [MarshalAs(UnmanagedType.LPArray)]
            public uint[] Red;
            [MarshalAs(UnmanagedType.LPArray)]
            public uint[] Green;
            [MarshalAs(UnmanagedType.LPArray)]
            public uint[] Blue;
            internal uint Length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Init()
        {
            return Imports.glfwInit();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Terminate()
        {
            Imports.glfwTerminate();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetVersion(out int major, out int minor, out int rev)
        {
            Imports.glfwGetVersion(out major, out minor, out rev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetVersionString()
        {
            return Imports.glfwGetVersionString();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetErrorCallbackDelegate(int error, int description);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetErrorCallback(SetErrorCallbackDelegate cbfun)
        {
            Imports.glfwSetErrorCallback(cbfun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Monitor[] GetMonitors(out int count)
        {
            int lenght;
            Monitor* monitors = Imports.glfwGetMonitors(out lenght);
            Monitor[] result = new Monitor[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result[i] = monitors[i];
            }
            count = lenght;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Monitor GetPrimaryMonitor()
        {
            return Imports.glfwGetPrimaryMonitor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetMonitorPos(Monitor monitor, out int x, out int y)
        {
            Imports.glfwGetMonitorPos(monitor, out x, out y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetMonitorPhysicalSize(Monitor monitor, out int width, out int height)
        {
            Imports.glfwGetMonitorPhysicalSize(monitor, out width, out height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetMonitorName(Monitor monitor)
        {
            return Imports.glfwGetMonitorName(monitor);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetMonitorCallbackDelegate(Monitor monitor, int @event);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMonitorCallback(SetMonitorCallbackDelegate cbfun)
        {
            Imports.glfwSetMonitorCallback(cbfun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vidmode[] GetVideoModes(Monitor monitor, out int count)
        {
            int lenght;
            Vidmode* monitors = Imports.glfwGetVideoModes(monitor, out lenght);
            Vidmode[] result = new Vidmode[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result[i] = monitors[i];
            }
            count = lenght;
            return result;
        }

        //         [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //         public static GLFWvidmode GetVideoMode(GLFWmonitor monitor)
        //         {
        //             return Imports.glfwGetVideoMode(monitor);
        //         }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vidmode GetVideoMode(Monitor monitor)
        {
            Vidmode* vidMode = Imports.glfwGetVideoMode(monitor);
            Vidmode returnMode = new Vidmode
            {
                RedBits = vidMode->RedBits,
                GreenBits = vidMode->GreenBits,
                BlueBits = vidMode->BlueBits,
                RefreshRate = vidMode->RefreshRate,
                Width = vidMode->Width,
                Height = vidMode->Height
            };
            return returnMode;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GammaRamp GetGammaRamp(Monitor monitor)
        {
            GammaRamp ramp;
            GammaRampInternal rampI = Imports.glfwGetGammaRamp(monitor);
            uint length = rampI.Length;
            ramp = new GammaRamp();
            ramp.Red = new uint[length];
            ramp.Green = new uint[length];
            ramp.Blue = new uint[length];
            for (int i = 0; i < ramp.Red.Length; ++i)
            {
                ramp.Red[i] = rampI.Red[i];
            }
            for (int i = 0; i < ramp.Green.Length; ++i)
            {
                ramp.Green[i] = rampI.Green[i];
            }
            for (int i = 0; i < ramp.Blue.Length; ++i)
            {
                ramp.Blue[i] = rampI.Blue[i];
            }
            return ramp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetGammaRamp(Monitor monitor, GammaRamp ramp)
        {
            Imports.glfwSetGammaRamp(monitor, ramp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DefaultWindowHints()
        {
            Imports.glfwDefaultWindowHints();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WindowHint(int target, int hint)
        {
            Imports.glfwWindowHint(target, hint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Window CreateWindow(int width, int height, string title)
        {
            return Imports.glfwCreateWindow(width, height, title, Monitor.NULL, Window.NULL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Window CreateWindow(int width, int height, string title, Window share)
        {
            return Imports.glfwCreateWindow(width, height, title, Monitor.NULL, share);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Window CreateWindow(int width, int height, string title, Monitor monitor)
        {
            return Imports.glfwCreateWindow(width, height, title, monitor, Window.NULL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Window CreateWindow(int width, int height, string title, Monitor monitor, Window share)
        {
            return Imports.glfwCreateWindow(width, height, title, monitor, share);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DestroyWindow(Window window)
        {
            Imports.glfwDestroyWindow(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WindowShouldClose(Window window)
        {
            return Imports.glfwWindowShouldClose(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowShouldClose(Window window, int value)
        {
            Imports.glfwSetWindowShouldClose(window, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowTitle(Window window, string title)
        {
            Imports.glfwSetWindowTitle(window, title);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetWindowPos(Monitor monitor, out int x, out int y)
        {
            Imports.glfwGetWindowPos(monitor, out x, out y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowPos(Window window, int x, int y)
        {
            Imports.glfwSetWindowPos(window, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetWindowSize(Window window, out int width, out int height)
        {
            Imports.glfwGetWindowSize(window, out width, out height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowSize(Window window, int width, int height)
        {
            Imports.glfwSetWindowSize(window, width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetFramebufferSize(Window window, out int width, out int height)
        {
            Imports.glfwGetFramebufferSize(window, out width, out height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IconifyWindow(Window window)
        {
            Imports.glfwIconifyWindow(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RestoreWindow(Window window)
        {
            Imports.glfwRestoreWindow(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ShowWindow(Window window)
        {
            Imports.glfwShowWindow(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HideWindow(Window window)
        {
            Imports.glfwHideWindow(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Monitor GetWindowMonitor(Window window)
        {
            return Imports.glfwGetWindowMonitor(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetWindowAttribute(Window window, int attrib)
        {
            return Imports.glfwGetWindowAttrib(window, attrib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowUserPointer(Window window, IntPtr pointer)
        {
            Imports.glfwSetWindowUserPointer(window, pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr GetWindowUserPointer(Window window)
        {
            return Imports.glfwGetWindowUserPointer(window);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetWindowPosCallbackDelegate(Window window, int x, int y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowPosCallback(Window window, SetWindowPosCallbackDelegate cbfun)
        {
            Imports.glfwSetWindowPosCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetWindowSizeCallbackDelegate(Window window, int width, int height);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowSizeCallback(Window window, SetWindowSizeCallbackDelegate cbfun)
        {
            Imports.glfwSetWindowSizeCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetWindowCloseCallbackDelegate(Window window);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowCloseCallback(Window window, SetWindowCloseCallbackDelegate cbfun)
        {
            Imports.glfwSetWindowCloseCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetWindowRefreshCallbackDelegate(Window window);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowRefreshCallback(Window window, SetWindowRefreshCallbackDelegate cbfun)
        {
            Imports.glfwSetWindowRefreshCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetWindowFocusCallbackDelegate(Window window, bool focused);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowFocusCallback(Window window, SetWindowFocusCallbackDelegate cbfun)
        {
            Imports.glfwSetWindowFocusCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetWindowIconifyCallbackDelegate(Window window, bool iconified);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWindowIconifyCallback(Window window, SetWindowIconifyCallbackDelegate cbfun)
        {
            Imports.glfwSetWindowIconifyCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetFramebufferSizeCallbackDelegate(Window window, int width, int height);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFramebufferSizeCallback(Window window, SetFramebufferSizeCallbackDelegate cbfun)
        {
            Imports.glfwSetFramebufferSizeCallback(window, cbfun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void PollEvents()
        {
            Imports.glfwPollEvents();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WaitEvents()
        {
            Imports.glfwWaitEvents();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetInputMode(Window window, int mode)
        {
            return Imports.glfwGetInputMode(window, mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetInputMode(Window window, int mode, int value)
        {
            Imports.glfwSetInputMode(window, mode, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetKey(Window window, int key)
        {
            return Imports.glfwGetKey(window, key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetMouseButton(Window window, int button)
        {
            return Imports.glfwGetMouseButton(window, button);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetCursorPos(Window window, out double x, out double y)
        {
            Imports.glfwGetCursorPos(window, out x, out y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCursorPos(Window window, double x, double y)
        {
            Imports.glfwSetCursorPos(window, x, y);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetKeyCallbackDelegate(Window window, int key, int scancode, int action, int mods);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetKeyCallback(Window window, SetKeyCallbackDelegate cbfun)
        {
            Imports.glfwSetKeyCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetCharCallbackDelegate(Window window, uint codepoint);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCharCallback(Window window, SetCharCallbackDelegate cbfun)
        {
            Imports.glfwSetCharCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetMouseButtonCallbackDelegate(Window window, int button, int action, int mods);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMouseButtonCallback(Window window, SetMouseButtonCallbackDelegate cbfun)
        {
            Imports.glfwSetMouseButtonCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetCursorPosCallbackDelegate(Window window, double xPos, double yPos);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCursorPosCallback(Window window, SetCursorPosCallbackDelegate cbfun)
        {
            Imports.glfwSetCursorPosCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetCursorEnterCallbackDelegate(Window window, bool entered);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCursorEnterCallback(Window window, SetCursorEnterCallbackDelegate cbfun)
        {
            Imports.glfwSetCursorEnterCallback(window, cbfun);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public delegate void SetScrollCallbackDelegate(Window window, double xOffset, double yOffset);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetScrollCallback(Window window, SetScrollCallbackDelegate cbfun)
        {
            Imports.glfwSetScrollCallback(window, cbfun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int JoystickPresent(int joystick)
        {
            //             if (Imports.glfwJoystickPresent(joystick) == 1)
            //                 return true;
            //             return false;
            return Imports.glfwJoystickPresent(joystick);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float[] GetJoystickAxes(int joystick, out int count)
        {
            int lenght;
            float* monitors = Imports.glfwGetJoystickAxes(joystick, out lenght);
            float[] result = new float[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result[i] = monitors[i];
            }
            count = lenght;
            return result;
        }

        //TODO const unsigned char * 	glfwGetJoystickButtons (int joy, int *count)


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetJoystickName(int joystick)
        {
            return Imports.glfwGetJoystickName(joystick);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetClipboardString(Window window, string str)
        {
            Imports.glfwSetClipboardString(window, str);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double GetTime()
        {
            return Imports.glfwGetTime();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTime(double time)
        {
            Imports.glfwSetTime(time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MakeContextCurrent(Window window)
        {
            Imports.glfwMakeContextCurrent(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Window GetCurrentContext()
        {
            return Imports.glfwGetCurrentContext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SwapBuffers(Window window)
        {
            Imports.glfwSwapBuffers(window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SwapInterval(int interval)
        {
            Imports.glfwSwapInterval(interval);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ExtensionSupported(string extension)
        {
            return Imports.glfwExtensionSupported(extension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetProcAddress(string procname)
        {
            Imports.glfwGetProcAddress(procname);
        }
    }
}