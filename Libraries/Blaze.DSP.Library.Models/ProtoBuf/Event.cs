﻿// The MIT License (MIT)
// 
// Copyright (c) 2015 Daniel Franklin. http://blazedsp.com/
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Blaze.DSP.Library.Models.ProtoBuf
{
    using Enumerators;

    using global::ProtoBuf;

    [ProtoContract]
    public class Event
    {
        [ProtoMember(1)]
        public EventType Type { get; set; }

        [ProtoMember(2)]
        public ulong Time { get; set; }

        [ProtoMember(3)]
        public string UserId { get; set; }

        [ProtoMember(4)]
        public string UserAgent { get; set; }

        [ProtoMember(5)]
        public string UserLanguage { get; set; }

        [ProtoMember(6)]
        public string UserHostAddress { get; set; }

        [ProtoMember(7)]
        public string UserProxyAddress { get; set; }

        [ProtoMember(8)]
        public string Referer { get; set; }

        [ProtoMember(9)]
        public string Flight { get; set; }

        [ProtoMember(10)]
        public string Destination { get; set; }
    }
}