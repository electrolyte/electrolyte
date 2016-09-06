using System;
using System.Diagnostics;
using System.Reflection;

namespace Electrolyte.Core.Logging
{
    /// <summary>
    /// A basic shared Logging system for use by internal features
    /// as well as plugin modules.
    /// </summary>
    public class Log : ILog
    {
        private readonly NLog.Logger _logger;

        public bool IsDebugEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return _logger.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return _logger.IsWarnEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return _logger.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return _logger.IsFatalEnabled; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Log()
        {
            _logger = NLog.LogManager.GetLogger(GetCallingClassFullName());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Log(string name)
        {
            _logger = NLog.LogManager.GetLogger(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string GetCallingClassFullName()
        {
            string className;
            Type declaringType;
            int framesToSkip = 2;

            do
            {
                StackFrame frame = new StackFrame(framesToSkip, false);
                MethodBase method = frame.GetMethod();
                declaringType = method.DeclaringType;
                if (declaringType == null)
                {
                    className = method.Name;
                    break;
                }

                framesToSkip++;
                className = declaringType.FullName;
            } while (declaringType.Module.Name.Equals("mscorlib.dll", StringComparison.OrdinalIgnoreCase));

            return className;
        }

        #region " Simple Logging "

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Info(string message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        #endregion

        #region " Formated Logging "

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public void Debug(string format, params object[] args)
        {
            _logger.Debug(format, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public void Info(string format, params object[] args)
        {
            _logger.Info(format, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public void Warn(string format, params object[] args)
        {
            _logger.Warn(format, args);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public void Error(string format, params object[] args)
        {
            _logger.Error(format, args);
        }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="format"></param>
    /// <param name="args"></param>
        public void Fatal(string format, params object[] args)
        {
            _logger.Fatal(format, args);
        }

    #endregion
    }
}