//#region Apache Notice
///*****************************************************************************
// * $Header: $
// * $Revision: 378715 $
// * $Date: 2006-10-10 12:57:36 -0600 (Tue, 10 Oct 2006) $
// * 
// * iBATIS.NET Data Mapper
// * Copyright (C) 2006 - Apache Fondation
// *  
// * 
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *      http://www.apache.org/licenses/LICENSE-2.0
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// * 
// ********************************************************************************/
//#endregion

//using System.Web;
//using IBatisNet.Common;
//using IBatisNet.Common.Exceptions;

//namespace IBatisNet.DataAccess.SessionStore
//{

//	/// <summary>
//	/// Provides an implementation of <see cref="ISessionStore"/>
//	/// which relies on <c>HttpContext</c>. Suitable for web projects.
//	/// </summary>
//	public class WebSessionStore : AbstractSessionStore
//	{
//        /// <summary>
//        /// Initializes a new instance of the <see cref="WebSessionStore"/> class.
//        /// </summary>
//        /// <param name="daoManagerId">The DaoManager name.</param>
//        public WebSessionStore(string daoManagerId) : base(daoManagerId)
//		{}

//		/// <summary>
//		/// Get the local session
//		/// </summary>
//		public override IDalSession LocalSession
//		{
//			get
//			{
//				HttpContext currentContext = ObtainSessionContext();
//				return currentContext.Items[sessionName] as IDalSession;
//			}
//		}

//		/// <summary>
//		/// Store the specified session.
//		/// </summary>
//		/// <param name="session">The session to store</param>

//		public override void Store(IDalSession session)
//		{
//			HttpContext currentContext = ObtainSessionContext();
//			currentContext.Items[sessionName] = session;
//		}

//		/// <summary>
//		/// Remove the local session.
//		/// </summary>
//		public override void Dispose()
//		{
//			HttpContext currentContext = ObtainSessionContext();
//			currentContext.Items[sessionName] = null;
//		}

		
//		private static HttpContext ObtainSessionContext()
//		{
//			HttpContext currentContext = HttpContext.Current;
	
//			if (currentContext == null)
//			{
//				throw new IBatisNetException("WebSessionStore: Could not obtain reference to HttpContext");
//			}
//			return currentContext;
//		}
//	}
//}
