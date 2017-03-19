﻿/*
Copyright 2015 CloudShare Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Security.Cryptography;
using System.Text;

namespace cssdk
{
    public interface ISha1StringHasher
    {
        string Hash(string input);
    }

    public class Sha1StringHasher : ISha1StringHasher
    {
        public string Hash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hbytes = new SHA1CryptoServiceProvider().ComputeHash(bytes);
            return BitConverter.ToString(hbytes).Replace("-", "").ToLower();
        }
    }
}