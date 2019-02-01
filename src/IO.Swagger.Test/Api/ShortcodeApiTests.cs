/* 
 * WINSMS
 *
 * WinSMS RESTful API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@winsms.co.za
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ShortcodeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ShortcodeApiTests
    {
        private ShortcodeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ShortcodeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShortcodeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ShortcodeApi
            //Assert.IsInstanceOfType(typeof(ShortcodeApi), instance, "instance is a ShortcodeApi");
        }

        
        /// <summary>
        /// Test GetShortCodeMessages
        /// </summary>
        [Test]
        public void GetShortCodeMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetShortCodeMessages(offset, limit);
            //Assert.IsInstanceOf<ShortcodeMessageResponse> (response, "response is ShortcodeMessageResponse");
        }
        
    }

}