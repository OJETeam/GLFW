using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OJE.GLFW
{
    internal static unsafe class Imports
    {
        public const string DllName = "glfw.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwInit();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwTerminate();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern string glfwGetVersionString();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetErrorCallback(Glfw.SetErrorCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Monitor* glfwGetMonitors(out int count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Monitor glfwGetPrimaryMonitor();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetMonitorPos(Glfw.Monitor monitor, out int xpos, out int ypos);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetMonitorPhysicalSize(Glfw.Monitor monitor, out int width, out int height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern string glfwGetMonitorName(Glfw.Monitor monitor);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetMonitorCallback(Glfw.SetMonitorCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Vidmode* glfwGetVideoModes(Glfw.Monitor monitor, out int count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Vidmode* glfwGetVideoMode(Glfw.Monitor monitor);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetGamma(Glfw.Monitor monitor, float gamma);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.GammaRampInternal glfwGetGammaRamp(Glfw.Monitor monitor);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetGammaRamp(Glfw.Monitor monitor, Glfw.GammaRamp ramp);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwDefaultWindowHints();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwWindowHint(int target, int hint);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Window glfwCreateWindow(int width, int height, string title, Glfw.Monitor monitor, Glfw.Window share);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwDestroyWindow(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwWindowShouldClose(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowShouldClose(Glfw.Window window, int value);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowTitle(Glfw.Window window, string title);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetWindowPos(Glfw.Monitor monitor, out int xpos, out int ypos);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowPos(Glfw.Window window, int xpos, int ypos);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetWindowSize(Glfw.Window window, out int width, out int height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowSize(Glfw.Window window, int width, int height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetFramebufferSize(Glfw.Window window, out int width, out int height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwIconifyWindow(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwRestoreWindow(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwShowWindow(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwHideWindow(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Monitor glfwGetWindowMonitor(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetWindowAttrib(Glfw.Window window, int attrib);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowUserPointer(Glfw.Window window, IntPtr pointer);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern IntPtr glfwGetWindowUserPointer(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowPosCallback(Glfw.Window window, Glfw.SetWindowPosCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowSizeCallback(Glfw.Window window, Glfw.SetWindowSizeCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowCloseCallback(Glfw.Window window, Glfw.SetWindowCloseCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowRefreshCallback(Glfw.Window window, Glfw.SetWindowRefreshCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowFocusCallback(Glfw.Window window, Glfw.SetWindowFocusCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowIconifyCallback(Glfw.Window window, Glfw.SetWindowIconifyCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetFramebufferSizeCallback(Glfw.Window window, Glfw.SetFramebufferSizeCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwPollEvents();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwWaitEvents();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetInputMode(Glfw.Window window, int mode);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetInputMode(Glfw.Window window, int mode, int value);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetKey(Glfw.Window window, int key);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetMouseButton(Glfw.Window window, int button);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetCursorPos(Glfw.Window window, out double xpos, out double ypos);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetCursorPos(Glfw.Window window, double xpos, double ypos);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetKeyCallback(Glfw.Window window, Glfw.SetKeyCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetCharCallback(Glfw.Window window, Glfw.SetCharCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetMouseButtonCallback(Glfw.Window window, Glfw.SetMouseButtonCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetCursorPosCallback(Glfw.Window window, Glfw.SetCursorPosCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetCursorEnterCallback(Glfw.Window window, Glfw.SetCursorEnterCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetScrollCallback(Glfw.Window window, Glfw.SetScrollCallbackDelegate cbfun);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwJoystickPresent(int joy);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern float* glfwGetJoystickAxes(int joy, out int count);

        //TODO const unsigned char * 	glfwGetJoystickButtons (int joy, int *count)

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern string glfwGetJoystickName(int joy);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetClipboardString(Glfw.Window window, string str);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern double glfwGetTime();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetTime(double time);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwMakeContextCurrent(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern Glfw.Window glfwGetCurrentContext();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSwapBuffers(Glfw.Window window);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSwapInterval(int interval);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwExtensionSupported(string extension);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetProcAddress(string procname);
    }
}
