// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit;

namespace NuGet.Protocol.Plugins.Tests
{
    public class TaskLogMessageTests : LogMessageTests
    {
        [Fact]
        public void ToString_ReturnsJson()
        {
            const string requestId = "a";
            const MessageMethod method = MessageMethod.GetOperationClaims;
            const MessageType type = MessageType.Request;
            const TaskState state = TaskState.Executing;

            var logMessage = new TaskLogMessage(requestId, method, type, state);

            var message = VerifyOuterMessageAndReturnInnerMessage(logMessage, "task");

            Assert.Equal(4, message.Count);

            var actualRequestId = message.Value<string>("request ID");
            var actualMethod = Enum.Parse(typeof(MessageMethod), message.Value<string>("method"));
            var actualType = Enum.Parse(typeof(MessageType), message.Value<string>("type"));
            var actualState = Enum.Parse(typeof(TaskState), message.Value<string>("state"));

            Assert.Equal(requestId, actualRequestId);
            Assert.Equal(method, actualMethod);
            Assert.Equal(type, actualType);
            Assert.Equal(state, actualState);
        }
    }
}