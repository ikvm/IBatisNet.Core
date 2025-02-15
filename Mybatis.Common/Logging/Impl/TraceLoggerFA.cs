#region Apache Notice

/*****************************************************************************
 * $Header: $
 * $Revision: 383115 $
 * $Date: 2006-03-04 15:21:51 +0100 (sam., 04 mars 2006) $
 * 
 * iBATIS.NET Data Mapper
 * Copyright (C) 2004 - Gilles Bayon
 *  
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 ********************************************************************************/

#endregion

using System;
using System.Collections;
using System.Collections.Specialized;

namespace Mybatis.Common.Logging.Impl
{
    /// <summary>
    ///     Summary description for  TraceLoggerFA.
    /// </summary>
    public class TraceLoggerFA : ILoggerFactoryAdapter
    {
        private readonly string _dateTimeFormat = string.Empty;
        private readonly LogLevel _Level = LogLevel.All;
        private readonly Hashtable _logs = Hashtable.Synchronized(new Hashtable());
        private readonly bool _showDateTime = true;
        private readonly bool _showLogName = true;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="properties"></param>
        public TraceLoggerFA(NameValueCollection properties)
        {
            try
            {
                _Level = (LogLevel) Enum.Parse(typeof(LogLevel), properties["level"], true);
            }
            catch (Exception)
            {
                _Level = LogLevel.All;
            }

            try
            {
                _showDateTime = bool.Parse(properties["showDateTime"]);
            }
            catch (Exception)
            {
                _showDateTime = true;
            }

            try
            {
                _showLogName = bool.Parse(properties["showLogName"]);
            }
            catch (Exception)
            {
                _showLogName = true;
            }

            _dateTimeFormat = properties["dateTimeFormat"];
        }

        #region ILoggerFactoryAdapter Members

        /// <summary>
        ///     Get a ILog instance by type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ILog GetLogger(Type type)
        {
            return GetLogger(type.FullName);
        }

        /// <summary>
        ///     Get a ILog instance by type name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ILog GetLogger(string name)
        {
            ILog log = _logs[name] as ILog;
            if (log == null)
            {
                log = new TraceLogger(name, _Level, _showDateTime, _showLogName, _dateTimeFormat);
                _logs.Add(name, log);
            }

            return log;
        }

        #endregion
    }
}