﻿//----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//----------------------------------------------------------------------------------

#region

using System;

#endregion

namespace GraphConsoleAppV31
{
    internal class Helper
    {
        /// <summary>
        ///     Returns a random string of upto 32 characters.
        /// </summary>
        /// <returns>String of upto 32 characters.</returns>
        public static string GetRandomString(int length = 32)
        {
            //because GUID can't be longer than 32
            return Guid.NewGuid().ToString("N").Substring(0, length > 32 ? 32 : length);
        }
    }
}
