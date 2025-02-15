
#region Apache Notice
/*****************************************************************************
 * $Revision: 383115 $
 * $LastChangedDate: 2006-03-04 15:21:51 +0100 (sam., 04 mars 2006) $
 * $LastChangedBy: gbayon $
 * 
 * iBATIS.NET Data Mapper
 * Copyright (C) 2006/2005 - The Apache Software Foundation
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

#region Using

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using log4net.Config;

using Mybatis.Common.Logging;
#endregion 

namespace Mybatis.Common.Logging.Impl.Log
{
	/// <summary>
	/// Concrete subclass of ILoggerFactoryAdapter specific to log4net.
	/// </summary>
	public class Log4NetLoggerFA : ILoggerFactoryAdapter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="properties"></param>
		public Log4NetLoggerFA(NameValueCollection properties)
		{
			string configType = string.Empty;
			
			if ( properties["configType"] != null )
			{
				configType = properties["configType"].ToUpper();	
			}

			string configFile = string.Empty;
			if ( properties["configFile"] != null )
			{
				configFile = properties["configFile"];			
			}

			if ( configType == "FILE" || configType == "FILE-WATCH" )
			{
                if (configFile == string.Empty)
                {
                    throw new ConfigurationErrorsException("Configration property 'configFile' must be set for log4Net configuration of type 'FILE'.");
                }

                if (!File.Exists(configFile))
                {
                    throw new ConfigurationErrorsException("log4net configuration file '" + configFile + "' does not exists");
                }
			}

			switch ( configType )
			{
				case "INLINE":
					XmlConfigurator.Configure();
					break;
				case "FILE":
					XmlConfigurator.Configure( new FileInfo( configFile ) );
					break;
				case "FILE-WATCH":
					XmlConfigurator.ConfigureAndWatch( new FileInfo( configFile ) );
					break;
				case "EXTERNAL":
					// Log4net will be configured outside of IBatisNet
					break;
				default:
					BasicConfigurator.Configure();
					break;
			}
		}

		#region ILoggerFactoryAdapter Members

		/// <summary>
		/// Get a ILog instance by type name 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ILog GetLogger(string name)
		{
			return new Log4NetLogger( log4net.LogManager.GetLogger( name ) );
		}

		/// <summary>
		/// Get a ILog instance by type 
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public ILog GetLogger(Type type)
		{
			return new Log4NetLogger( log4net.LogManager.GetLogger( type ) );
		}

		#endregion
	}
}
